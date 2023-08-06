using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Networker;
using System.Timers;

namespace Pingerino
{
    public partial class FormPinger : Form
    {
        #region Fields

        private double memoryUsage;
        private double cpuUsage;
        private readonly System.Timers.Timer cpuTimer;
        private readonly System.Timers.Timer ramTimer;
        private readonly System.Threading.Timer pingTimer;
        private string currentIpAddress = "8.8.8.8";
        private TextBox textBoxOutput; // Add the TextBox control

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        #endregion

        #region Constructor

        public FormPinger()
        {
            InitializeComponent();
            // Add event handlers for the TextChanged events of the TextBox controls
            textBoxInterval.KeyDown += TextBoxInterval_KeyDown;
            this.DoubleBuffered = true;
            ipAddress.Text = currentIpAddress;
            textBoxInterval.Text = "300";
            ipAddress.Select();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.FormClosing += FormPinger_FormClosing;

            // Create and initialize the TextBox control
            InitializeTextBox();

            UpdatePerformanceStatistics(null);

            // Initialize the CPU and RAM timers
            cpuTimer = new System.Timers.Timer(500);
            cpuTimer.Elapsed += UpdateCpuUsage;

            ramTimer = new System.Timers.Timer(500);
            ramTimer.Elapsed += UpdateMemoryUsage;

            cpuTimer.Start();
            ramTimer.Start();

            // Start the timer to ping the default IP address
            pingTimer = new System.Threading.Timer(PingCurrentIpAddress, null, 0, 300);
            // Start the automatic update
            StartAutoUpdate();

            // Start the timer to update Memory Usage and CPU Usage every 500 milliseconds
            var performanceTimer = new System.Threading.Timer(UpdatePerformanceStatistics, null, 0, 500);
            // Start the automatic update
            StartAutoUpdate();

            // Update network statistics when the app is opened
            UpdateNetworkStatistics();
        }

        #endregion

        #region Initialization Methods

        // Method to initialize the TextBox control
        private void InitializeTextBox()
        {
            textBoxOutput = new TextBox
            {
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                Dock = DockStyle.Fill,
                Font = new System.Drawing.Font("Consolas", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0))),
                ForeColor = System.Drawing.Color.FromArgb(0, 255, 0),
                BackColor = System.Drawing.SystemColors.ActiveCaptionText
            };
            SmootherPanel1.Controls.Add(textBoxOutput); // Add the TextBox control to the NonFlickerPanel control
        }


        #endregion

        #region Event Handlers

        private void FormPinger_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Save the form's position
            Properties.Settings.Default.FormPosition = this.Location;

            // Save the values entered by the user
            Properties.Settings.Default.IpAddressValue = ipAddress.Text;
            Properties.Settings.Default.TextBoxIntervalValue = textBoxInterval.Text;
            // ...

            // Save all settings
            Properties.Settings.Default.Save();
        }




        private void FormPinger_Load(object sender, EventArgs e)
        {
            // Update network statistics when the app is opened
            UpdateNetworkStatistics();

            // Load the form's position
            if (Properties.Settings.Default.FormPosition != null)
            {
                this.Location = Properties.Settings.Default.FormPosition;
            }

            // Load the values entered by the user
            ipAddress.Text = Properties.Settings.Default.IpAddressValue;
            textBoxInterval.Text = Properties.Settings.Default.TextBoxIntervalValue;
            // ...
        }




        private void StartAutoUpdate()
        {
            // Start the timer to automatically update every 50ms
            pingTimer.Change(0, 300);
        }



        private void UpdateNetworkStatistics()
        {
            string ipAddress = currentIpAddress; // Use the IP address from the TextBox
            int count = 10; // Number of pings to send

            NetworkStatistics statistics = new NetworkStatistics();
            statistics.CalculatePacketLoss(ipAddress, count);
            statistics.CalculateJitter(ipAddress, count);

            // Update packet loss and jitter TextBoxes
            if (this.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { textBoxPacketLoss.Text = $"{statistics.PacketLoss:F2}%"; });
                this.Invoke((MethodInvoker)delegate { textBoxJitter.Text = $"{statistics.Jitter:F2}ms"; });
            }
            else
            {
                textBoxPacketLoss.Text = $"{statistics.PacketLoss:F2}%";
                textBoxJitter.Text = $"{statistics.Jitter}ms";
            }
        }

        private void PingCurrentIpAddress(object state)
        {
            // Update network statistics before pinging the IP address
            UpdateNetworkStatistics();
            PingIpAddress();
        }

        private void PingIpAddress()
        {
            string ipAddress = currentIpAddress;
            try
            {
                if (!NetworkInterface.GetIsNetworkAvailable())
                {
                    // Display an error message indicating no network connection
                    AddPingResult("No network connection available.");
                    return;
                }
                Ping ping = new Ping();
                PingReply reply = ping.Send(ipAddress);

                if (reply.Status == IPStatus.Success)
                {
                    AddPingResult($"Ping to {ipAddress} - Success - Roundtrip Time: {reply.RoundtripTime}ms");
                }
                else
                {
                    AddPingResult($"Ping to {ipAddress} - Failed - {reply.Status}");
                }
            }
            catch (Exception ex)
            {
                AddPingResult($"Ping to {ipAddress} - Failed - {ex.Message}");
            }
        }

        private void AddPingResult(string result)
        {
            textBoxOutput.Invoke(new Action(() => textBoxOutput.AppendText(result + Environment.NewLine)));
        }

        private void TextBoxInterval_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the user pressed the Enter key
            if (e.KeyCode == Keys.Enter)
            {
                // Parse the interval from the TextBox control
                if (int.TryParse(textBoxInterval.Text, out int interval))
                {
                    // Change the ping timer interval
                    pingTimer.Change(0, interval);
                }
            }
        }

        private void TextBoxIpAddress_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the user pressed the Enter key
            if (e.KeyCode == Keys.Enter)
            {
                // Change the IP address to ping
                currentIpAddress = ipAddress.Text;
            }
        }

        private void UpdatePerformanceStatistics(object state)
        {
            // Update Memory Usage
            double memoryUsage = GetMemoryUsage();
            UpdateTextBoxRAM(memoryUsage);

            // Update CPU Usage
            double cpuUsage = GetCpuUsage();
            UpdateTextBoxCPU(cpuUsage);
        }

        private void UpdateCpuUsage(object sender, ElapsedEventArgs e)
        {
            cpuUsage = GetCpuUsage();
            UpdateTextBoxCPU(cpuUsage);
        }

        private void UpdateMemoryUsage(object sender, ElapsedEventArgs e)
        {
            memoryUsage = GetMemoryUsage();
            UpdateTextBoxRAM(memoryUsage);
        }

        private void UpdateTextBoxRAM(double memoryUsage)
        {
            if (TextBoxRAM.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { TextBoxRAM.Text = $"{memoryUsage:F0} MB"; });
            }
            else
            {
                TextBoxRAM.Text = $"{memoryUsage:F0} MB";
            }
        }


        // Method to update the TextBoxCPU control with CPU usage
        private void UpdateTextBoxCPU(double cpuUsage)
        {
            if (TextBoxCPU.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { TextBoxCPU.Text = $"{cpuUsage:F2} %"; });
            }
            else
            {
                TextBoxCPU.Text = $"{cpuUsage:F2} %";
            }
        }



        #endregion

        #region Performance Counters

        private PerformanceCounter cpuPerformanceCounter;

        private double GetCpuUsage()
        {
            if (cpuPerformanceCounter == null)
            {
                cpuPerformanceCounter = new PerformanceCounter("Processor", "% Processor Time", "_Total");
                // Give some time for the counter to collect data
                cpuPerformanceCounter.NextValue();
                System.Threading.Thread.Sleep(100);
            }
            return cpuPerformanceCounter.NextValue();
        }

        private PerformanceCounter ramPerformanceCounter;

        private double GetMemoryUsage()
        {
            if (ramPerformanceCounter == null)
            {
                ramPerformanceCounter = new PerformanceCounter("Memory", "Available MBytes");
                // Give some time for the counter to collect data
                ramPerformanceCounter.NextValue();
                System.Threading.Thread.Sleep(100);
            }
            return ramPerformanceCounter.NextValue();
        }

        #endregion

        #region Miscellaneous

        private void COPYRIGHT_TextChanged(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void LabelJitter_Click(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void Close_MouseEnter(object sender, EventArgs e)
        {
            close.BackColor = Color.Red;
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = Color.Transparent;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Label3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
        }

        private void Bt_mini_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void TextBoxInterval_TextChanged(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void TextBoxJitter_TextChanged(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void ButtonNetworkAdapters_Click(object sender, EventArgs e)
        {
            Process.Start("control", "ncpa.cpl");
        }

        private void ButtonCleanNetwork_Click(object sender, EventArgs e)
        {
            string EthName = "Ethernet";
            ButtonCleanNetwork.Enabled = false;
            Process cmd = new Process();
            cmd.StartInfo.FileName = "cmd.exe";
            cmd.StartInfo.RedirectStandardInput = true;
            cmd.StartInfo.RedirectStandardOutput = true;
            cmd.StartInfo.CreateNoWindow = true;
            cmd.StartInfo.UseShellExecute = false;
            cmd.StartInfo.Verb = "runas";
            cmd.Start();
            cmd.StandardInput.WriteLine("ipconfig /release " + '"' + EthName + '"');
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine("ipconfig /renew " + '"' + EthName + '"');
            cmd.StandardInput.Flush();
            cmd.StandardInput.WriteLine("exit");
            cmd.WaitForExit();
            ButtonCleanNetwork.Enabled = true;
        }

        private void ButtonCleanTemp_Click(object sender, EventArgs e)
        {
            // Kill unresponsive applications
            foreach (Process process in Process.GetProcesses())
            {
                try
                {
                    if (process.Responding == false)
                    {
                        process.Kill();
                    }
                }
                catch (Exception)
                {
                    // Handle exceptions here, for example:
                    Console.WriteLine("Could not kill process: " + process.ProcessName);
                }
            }

            System.Threading.Thread.Sleep(3000);

            // Delete files
            string[] folders = new string[]
            {
                Environment.ExpandEnvironmentVariables(@"%systemroot%\temp"),
                Environment.ExpandEnvironmentVariables(@"%systemroot%\Prefetch"),
                Environment.ExpandEnvironmentVariables(@"%userprofile%\LocalS~1\Temp"),
                Environment.ExpandEnvironmentVariables(@"%userprofile%\AppData\Local\Temp")
            };

            foreach (string folder in folders)
            {
                try
                {
                    DirectoryInfo dirInfo = new DirectoryInfo(folder);
                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        try
                        {
                            file.Delete();
                        }
                        catch (Exception)
                        {
                            // Handle exceptions here, for example:
                            Console.WriteLine("Could not delete file: " + file.FullName);
                        }
                    }
                    foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                    {
                        try
                        {
                            dir.Delete(true);
                        }
                        catch (Exception)
                        {
                            // Handle exceptions here, for example:
                            Console.WriteLine("Could not delete directory: " + dir.FullName);
                        }
                    }
                }
                catch (Exception)
                {
                    // Handle exceptions here
                }
            }
        }

        private void IpAddress_Click(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void TextBoxCPU_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxCPU.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { TextBoxCPU.Text = $"{cpuUsage:F2} %"; });
            }
            else
            {
                TextBoxCPU.Text = $"{cpuUsage:F2} %";
            }
        }

        private void TextBoxRAM_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxRAM.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { TextBoxRAM.Text = $"{memoryUsage:F0} MB"; });
            }
            else
            {
                TextBoxRAM.Text = $"{memoryUsage:F0} MB";
            }
        }


        #endregion

        private void LOGOCF_Click(object sender, EventArgs e)
        {

        }
    }
}
