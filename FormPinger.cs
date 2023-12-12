using Microsoft.Win32.TaskScheduler;
using Networker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Net.Http;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace Pingerino
{

    public partial class FormPinger : Form
    {
        #region Fields
        private readonly System.Threading.Timer pingTimer;
        private string currentIpAddress = Properties.Settings.Default.LastUsedIpAddress;
        private readonly List<long> pingRoundTripTimes = new List<long>();
        private readonly List<double> packetLossValues = new List<double>();
        private readonly List<double> jitterValues = new List<double>();
        private readonly object lockObject = new object();
        private readonly WinForms.ProgressBar progressBar;
        private readonly BackgroundWorker worker = new BackgroundWorker();
        private readonly WinForms.Button ButtonCleanTemp;
        private readonly BackgroundWorker networkWorker;
        private readonly WinForms.ProgressBar progressBarNetwork;
        private readonly List<string> outputLines = new List<string>();
        private readonly HttpClient client = new HttpClient();
        private readonly System.Windows.Forms.Timer timer2;

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

        private async System.Threading.Tasks.Task InitializeNetworkOperationsAsync()
        {
            await System.Threading.Tasks.Task.Run(() => UpdateNetworkStatistics());
            await System.Threading.Tasks.Task.Run(() => PingCurrentIpAddress(null));
        }

        #region Constructor

        public FormPinger()
        {
            InitializeComponent();
            timer2 = new System.Windows.Forms.Timer
            {
                Interval = 3600000 // 1 hour in milliseconds
            };
            timer2.Tick += new EventHandler(Timer2_Tick);
            timer2.Start();

            // Initial IP fetch
            FetchPublicIP();
            ButtonCleanTemp = buttonCleanTemp;

            worker.DoWork += Worker_DoWork;
            worker.ProgressChanged += Worker_ProgressChanged;
            worker.RunWorkerCompleted += Worker_RunWorkerCompleted; // Subscribe to the completion event
            worker.WorkerReportsProgress = true;
            worker.WorkerSupportsCancellation = true;


            networkWorker = new BackgroundWorker { WorkerReportsProgress = true };
            networkWorker.DoWork += NetworkWorker_DoWork;
            networkWorker.ProgressChanged += NetworkWorker_ProgressChanged;
            networkWorker.RunWorkerCompleted += NetworkWorker_RunWorkerCompleted;

            // Initialize the progressBarNetwork
            progressBarNetwork = new WinForms.ProgressBar
            {
                Maximum = 100,
                Value = 0,
                Dock = DockStyle.Fill,
                Visible = false
            };
            tableLayoutPanel3.Controls.Add(progressBarNetwork, 0, 1);

            // Initialize the progressBar field
            this.progressBar = new WinForms.ProgressBar
            {
                Maximum = 100,
                Value = 0,
                Dock = DockStyle.Fill,
                Visible = false
            };

            // Add the ProgressBar control to the layout panel
            tableLayoutPanel3.Controls.Add(this.progressBar, 1, 0);


            #region ContextMenu
            InitializeContextMenu();
            // Add event handlers for the TextChanged events of the TextBox controls
            textBoxInterval.KeyDown += TextBoxInterval_KeyDown;
            this.DoubleBuffered = true;
            ipAddress.Text = currentIpAddress;
            textBoxInterval.Text = "300";
            ipAddress.Select();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            this.FormClosing += FormPinger_FormClosing;
            this.Load += new System.EventHandler(this.FormPinger_Load);



            #endregion





            // Start the timer to ping the default IP address
            pingTimer = new System.Threading.Timer(PingCurrentIpAddress, null, 0, 300);
            // Start the automatic update
            StartAutoUpdate();

            

            // Update network statistics when the app is opened

            System.Threading.Tasks.Task.Run(() => InitializeNetworkOperationsAsync());
        }


        #endregion

        #region Initialization Methods
        private async void FetchPublicIP()
        {
            try
            {
                // Fetching the public IP
                string publicIP = await client.GetStringAsync("http://ipinfo.io/ip");
                label4.Text = "Public IP: " + publicIP.Trim();
            }
            catch (Exception ex)
            {
                label4.Text = "Error fetching IP: " + ex.Message;

                // Wait for 30 seconds before retrying
                await System.Threading.Tasks.Task.Delay(30000);

                // Retry fetching the IP address
                FetchPublicIP();
            }
        }


        private void Timer2_Tick(object sender, EventArgs e)
        {
            FetchPublicIP();
        }
        private void InitializeContextMenu()
        {
            contextMenuStrip1 = new ContextMenuStrip();
            contextMenuStrip1.Items.Add("[1] Show Network Details");
            contextMenuStrip1.Items.Add("[2] Auto Ping ✔");
            contextMenuStrip1.Items.Add("[3] Run with Windows");
            contextMenuStrip1.Items.Add("[4] Proxy");


            ButtonMenu.Click += (sender, e) =>
            {
                contextMenuStrip1.Show(ButtonMenu, 0, ButtonMenu.Height);
            };

            // Attach event handlers to the menu items
            contextMenuStrip1.Items[0].Click += ShowNetworkDetails_Click;
            contextMenuStrip1.Items[1].Click += Option1_Click;
            contextMenuStrip1.Items[2].Click += Option2_Click;
            contextMenuStrip1.Items[3].Click += ProxyMenuItem_Click;
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


        private void ShowNetworkDetails_Click(object sender, EventArgs e)
        {
            string details = "";

            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType != NetworkInterfaceType.Loopback && nic.OperationalStatus == OperationalStatus.Up)
                {
                    IPInterfaceProperties properties = nic.GetIPProperties();

                    details += $"Description: {nic.Description}\n";
                    details += $"Physical Address: {nic.GetPhysicalAddress()}\n";
                    details += $"DHCP Enabled: {(properties.GetIPv4Properties().IsDhcpEnabled ? "Yes" : "No")}\n";

                    foreach (UnicastIPAddressInformation ip in properties.UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) // IPv4 addresses only
                        {
                            details += $"IPv4 Address: {ip.Address}\n";
                            details += $"IPv4 Subnet Mask: {ip.IPv4Mask}\n";
                        }
                    }

                    foreach (GatewayIPAddressInformation gateway in properties.GatewayAddresses)
                    {
                        details += $"IPv4 Default Gateway: {gateway.Address}\n";
                    }

                    details += $"IPv4 DHCP Server: {properties.DhcpServerAddresses.FirstOrDefault()}\n";
                    details += $"IPv4 DNS Servers: {string.Join(", ", properties.DnsAddresses)}\n";
                }
            }

            MessageBox.Show(details);
        }

        private void FormPinger_Load(object sender, EventArgs e)
        {

            // Load the form's position
            if (Properties.Settings.Default.FormPosition != null)
            {
                this.Location = Properties.Settings.Default.FormPosition;
            }

            // Load the values entered by the user
            ipAddress.Text = Properties.Settings.Default.IpAddressValue;
            textBoxInterval.Text = Properties.Settings.Default.TextBoxIntervalValue;
            // ...


            autoPingEnabled = Properties.Settings.Default.AutoPingEnabled;
            if (autoPingEnabled)
            {
                StartAutoUpdate(); // Start auto-pinging if it's enabled
                contextMenuStrip1.Items[2].Text = "[2] Auto Ping ✔";
            }

            {
                UpdateOption2Text("Pingerino");
            }

        }


        private void StartAutoUpdate()
        {
            // Start the timer to automatically update
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
            UpdateJitterAndPacketLossStatistics(statistics.Jitter, statistics.PacketLoss); // Update jitter and packet loss values
        }



        private void PingCurrentIpAddress(object state)
        {
            PingIpAddress();
            UpdateNetworkStatistics();
        }

        private void PingIpAddress()
        {
            string ipAddress = currentIpAddress;
            string timestamp = DateTime.Now.ToString("HH:mm:ss.ff");
            try
            {
                if (!NetworkInterface.GetIsNetworkAvailable())
                {
                    AddLineToOutput(timestamp, "No network connection available.", "");
                    return;
                }

                using (Ping ping = new Ping())
                {
                    PingReply reply = ping.Send(ipAddress);

                    if (reply.Status == IPStatus.Success)
                    {
                        AddLineToOutput(timestamp, $"Pinging {ipAddress} - Success", $"{reply.RoundtripTime} ms");
                        UpdatePingRoundTripTimes(reply.RoundtripTime);
                        UpdatePingStatistics();
                    }
                    else
                    {
                        AddLineToOutput(timestamp, $"Ping to {ipAddress} - Failed: {reply.Status}", "");
                    }
                }

            }
            catch (PingException pEx)
            {
                AddLineToOutput(timestamp, $"Ping exception: {pEx.Message}", "");
            }
            catch (InvalidOperationException opEx)
            {
                AddLineToOutput(timestamp, $"Operation invalid: {opEx.Message}", "");
            }
            catch (Exception ex)
            {
                AddLineToOutput(timestamp, $"Unexpected error: {ex.Message}", "");
            }
        }

        private void AddLineToOutput(string Time, string Status, string RTT = "")
        {
            if (this.IsHandleCreated)
            {
                if (dataGridView1.InvokeRequired)
                {
                    this.Invoke(new Action<string, string, string>(AddLineToOutput), Time, Status, RTT);
                }
                else
                {
                    dataGridView1.Rows.Add(new object[] { Time, Status, RTT });
                    outputLines.Add($"{Time} - {Status} - {RTT}");
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                }
            }
        }



        private void UpdateSmootherTextOutput(string message)
        {
            if (dataGridView1.InvokeRequired)
            {
                this.Invoke(new Action<string>(UpdateSmootherTextOutput), message);
            }
            else
            {
                var Time = DateTime.Now.ToString("HH:mm:ss.fff");
                var rttStartIndex = message.IndexOf("RTT:");

                if (rttStartIndex != -1)
                {
                    var Status = message.Substring(0, rttStartIndex).Trim(); // Get everything before "RTT:"
                    var RTT = message.Substring(rttStartIndex + 4).Trim();  // Get the value after "RTT:"

                    int rowIndex = dataGridView1.Rows.Add();
                    DataGridViewRow row = dataGridView1.Rows[rowIndex];
                    row.Cells["Time"].Value = Time;
                    row.Cells["Status"].Value = Status;
                    row.Cells["RTT"].Value = RTT;

                }
                else
                {
                    dataGridView1.Rows.Add(new object[] { Time, message, string.Empty });
                }

            }
        }



        private void TextBoxInterval_KeyDown(object sender, KeyEventArgs e)
        {
            // Check if the user pressed the Enter key
            if (e.KeyCode == Keys.Enter)
            {
                // Clear collections 
                pingRoundTripTimes.Clear();
                jitterValues.Clear();
                packetLossValues.Clear();
                dataGridView1.Rows.Clear();
                dataGridView2.Rows.Clear();
                // Reset statistics display  
                if (dataGridView2.Rows.Count > 0)
                {
                    dataGridView2.Rows[0].Cells["MaxPing"].Value = "0 ms";
                    dataGridView2.Rows[0].Cells["MinPing"].Value = "0 ms";
                    dataGridView2.Rows[0].Cells["AvgPing"].Value = "0 ms";
                }

                TextBoxMaxJitter.Text = "0 ms";
                TextBoxMinJitter.Text = "0 ms";
                TextBoxAvgJitter.Text = "0 ms";

                TextBoxMaxLoss.Text = "0%";
                TextBoxMinLoss.Text = "0%";
                TextBoxAvgLoss.Text = "0%";

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
                // Clear collections 
                pingRoundTripTimes.Clear();
                jitterValues.Clear();
                packetLossValues.Clear();

                // Reset statistics display
                if (dataGridView2.Rows.Count > 0)
                {
                    dataGridView2.Rows[0].Cells["MaxPing"].Value = "0 ms";
                    dataGridView2.Rows[0].Cells["MinPing"].Value = "0 ms";
                    dataGridView2.Rows[0].Cells["AvgPing"].Value = "0 ms";
                }

                TextBoxMaxJitter.Text = "0 ms";
                TextBoxMinJitter.Text = "0 ms";
                TextBoxAvgJitter.Text = "0 ms";

                TextBoxMaxLoss.Text = "0%";
                TextBoxMinLoss.Text = "0%";
                TextBoxAvgLoss.Text = "0%";

                // Change the IP address to ping
                currentIpAddress = ipAddress.Text;
                // Save the updated IP address to settings
                Properties.Settings.Default.LastUsedIpAddress = currentIpAddress;
                Properties.Settings.Default.Save();
            }
        }

      



        private void UpdatePingRoundTripTimes(long roundtripTime)
        {
            pingRoundTripTimes.Add(roundtripTime);
        }

        private void UpdatePingStatistics()
        {
            if (pingRoundTripTimes.Count > 0)
            {
                long maxPing = pingRoundTripTimes.Max();
                long minPing = pingRoundTripTimes.Min();
                double avgPing = pingRoundTripTimes.Average();

                if (!dataGridView2.InvokeRequired)
                {
                    // Update the row with stats
                    if (dataGridView2.Rows.Count == 0)
                    {
                        dataGridView2.Rows.Add();
                    }
                    dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells["MaxPing"].Value = $"{maxPing} ms";
                    dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells["MinPing"].Value = $"{minPing} ms";
                    dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells["AvgPing"].Value = $"{avgPing:F0} ms";

                    // Resize the row
                    dataGridView2.AutoResizeRow(dataGridView2.Rows.Count - 1);
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        // Update the row with stats
                        if (dataGridView2.Rows.Count == 0)
                        {
                            dataGridView2.Rows.Add();
                        }
                        dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells["MaxPing"].Value = $"{maxPing} ms";
                        dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells["MinPing"].Value = $"{minPing} ms";
                        dataGridView2.Rows[dataGridView2.Rows.Count - 1].Cells["AvgPing"].Value = $"{avgPing:F0} ms";

                        // Resize the row
                        dataGridView2.AutoResizeRow(dataGridView2.Rows.Count - 1);

                    });
                }
            }
        }





        private void UpdateOption2Text(string Pingerino)
        {
            bool isTaskInScheduler = IsTaskInScheduler(Pingerino);
            contextMenuStrip1.Items[2].Text = isTaskInScheduler ? "[3] Run with Windows ✔" : "[3] Run with Windows";
        }


        private bool IsTaskInScheduler(string Pingerino)
        {
            using (Microsoft.Win32.TaskScheduler.TaskService ts = new Microsoft.Win32.TaskScheduler.TaskService())
            {
                Microsoft.Win32.TaskScheduler.Task existingTask = ts.GetTask(Pingerino);
                return existingTask != null;
            }
        }

        private void Option2_Click(object sender, EventArgs e)
        {
            using (TaskService ts = new TaskService())
            {
                string taskName = "Pingerino";
                string executablePath = Application.ExecutablePath;
                string executableDirectory = Path.GetDirectoryName(executablePath);

                if (IsTaskInScheduler(taskName))
                {
                    // Task is already scheduled, so remove it
                    ts.RootFolder.DeleteTask(taskName, false);
                }
                else
                {
                    // Task is not scheduled, so add it
                    TaskDefinition td = ts.NewTask();
                    td.RegistrationInfo.Description = "Pingerino";
                    td.Principal.RunLevel = TaskRunLevel.Highest;
                    td.Triggers.Add(new LogonTrigger());

                    ExecAction execAction = new ExecAction(executablePath)
                    {
                        WorkingDirectory = executableDirectory // Set the working directory here
                    };
                    td.Actions.Add(execAction);

                    string currentUserName = WindowsIdentity.GetCurrent().Name;

                    // Set the task to run only when the user is logged on
                    td.Principal.LogonType = TaskLogonType.InteractiveToken;

                    ts.RootFolder.RegisterTaskDefinition(taskName, td, TaskCreation.CreateOrUpdate, currentUserName, null, TaskLogonType.InteractiveToken);
                }

                UpdateOption2Text(taskName);
            }
        }


        private bool autoPingEnabled = false;

        private void Option1_Click(object sender, EventArgs e)
        {
            if (!autoPingEnabled)
            {
                autoPingEnabled = true;
                StartAutoUpdate(); // Start the auto-update timer
                contextMenuStrip1.Items[1].Text = "[2] Auto Ping ✔";
            }
            else
            {
                autoPingEnabled = false;
                pingTimer.Change(Timeout.Infinite, Timeout.Infinite); // Stop the auto-update timer
                contextMenuStrip1.Items[1].Text = "[2] Auto Ping";
            }
        }

        private void ProxyMenuItem_Click(object sender, EventArgs e)
        {
            RunExternalProxyScript();
        }

        private void RunExternalProxyScript()
        {
            string executableDirectory = Path.GetDirectoryName(Application.ExecutablePath);
            string scriptPath = Path.Combine(executableDirectory, "runPS1.bat");

            if (File.Exists(scriptPath))
            {
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = scriptPath,
                    UseShellExecute = true
                };
                Process.Start(processStartInfo);
            }
            else
            {
                MessageBox.Show("Proxy script not found.");
            }
        }



        #endregion

        #region Jitter and Packet Loss Statistics Methods

        // Method to update the jitter values list
        private void UpdateJitterValues(double jitter)
        {
            lock (lockObject)
            {
                jitterValues.Add(jitter);
            }
        }

        // Method to update the packet loss values list
        private void UpdatePacketLossValues(double packetLoss)
        {
            lock (lockObject)
            {
                packetLossValues.Add(packetLoss);
            }
        }

        // Method to calculate and update Max, Average, and Minimum jitter values
        private void UpdateJitterStatistics()
        {
            lock (lockObject)
            {
                List<double> jitterCopy = new List<double>(jitterValues);

                if (jitterCopy.Count > 0)
                {
                    double maxJitter = jitterCopy.Max();
                    double minJitter = jitterCopy.Min();
                    double avgJitter = jitterCopy.Average();

                    if (TextBoxMaxJitter.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            TextBoxMaxJitter.Text = $"{maxJitter:F0} ms";
                        });
                    }
                    else
                    {
                        TextBoxMaxJitter.Text = $"{maxJitter:F0} ms";
                    }

                    if (TextBoxMinJitter.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            TextBoxMinJitter.Text = $"{minJitter:F0} ms";
                        });
                    }
                    else
                    {
                        TextBoxMinJitter.Text = $"{minJitter:F0} ms";
                    }

                    if (TextBoxAvgJitter.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            TextBoxAvgJitter.Text = $"{avgJitter:F0} ms";
                        });
                    }
                    else
                    {
                        TextBoxAvgJitter.Text = $"{avgJitter:F0} ms";
                    }

                }
            }

        }

        // Method to calculate and update Max, Average, and Minimum packet loss values
        private void UpdatePacketLossStatistics()
        {
            lock (lockObject)
            {
                if (packetLossValues.Count > 0)
                {
                    double maxPacketLoss = packetLossValues.Max();
                    double minPacketLoss = packetLossValues.Min();
                    double avgPacketLoss = packetLossValues.Average();

                    // Update the respective Text Boxes with max, avg, and min packet loss values
                    if (TextBoxMaxLoss.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            TextBoxMaxLoss.Text = $"{maxPacketLoss:F0}%";
                        });
                    }
                    else
                    {
                        TextBoxMaxLoss.Text = $"{maxPacketLoss:F0}%";
                    }

                    if (TextBoxMinLoss.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            TextBoxMinLoss.Text = $"{minPacketLoss:F0}%";
                        });
                    }
                    else
                    {
                        TextBoxMinLoss.Text = $"{minPacketLoss:F0}%";
                    }

                    if (TextBoxAvgLoss.InvokeRequired)
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            TextBoxAvgLoss.Text = $"{avgPacketLoss:F0}%";
                        });
                    }
                    else
                    {
                        TextBoxAvgLoss.Text = $"{avgPacketLoss:F0}%";
                    }
                }
            }
        }

        // Method to update jitter and packet loss statistics together
        private void UpdateJitterAndPacketLossStatistics(double jitter, double packetLoss)
        {
            UpdateJitterValues(jitter);
            UpdatePacketLossValues(packetLoss);
            UpdateJitterStatistics();
            UpdatePacketLossStatistics();
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

        private void Label1_Click(object sender, EventArgs e)
        {
            // Placeholder
        }

        private void LabelJitter_Click(object sender, EventArgs e)
        {
            // Placeholder
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


        private async void ButtonCleanNetwork_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This action will release and renew network settings. Are you sure you want to continue?", "Confirm Action", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                ButtonCleanNetwork.Visible = false; // Disable the button during the operation

                // Show the progress bar and bring it to the front
                progressBarNetwork.Visible = true;
                progressBarNetwork.Value = 0;

                await System.Threading.Tasks.Task.Run(() =>
                {
                    string ethName = FindEthernetAdapterName(); // Detect Ethernet adapter name 
                    Process cmd = new Process();
                    cmd.StartInfo.FileName = "cmd.exe";
                    cmd.StartInfo.RedirectStandardInput = true;
                    cmd.StartInfo.RedirectStandardOutput = true;
                    cmd.StartInfo.CreateNoWindow = true;
                    cmd.StartInfo.UseShellExecute = false;
                    cmd.StartInfo.Verb = "runas";
                    cmd.Start();
                    cmd.StandardInput.WriteLine($"ipconfig /release \"{ethName}\"");
                    cmd.StandardInput.Flush();
                    cmd.StandardInput.WriteLine($"ipconfig /renew \"{ethName}\"");
                    // Add your other commands here

                    // Simulate a delay for the command execution
                    Thread.Sleep(3000);

                    cmd.StandardInput.Flush();
                    cmd.StandardInput.WriteLine("exit");
                    cmd.WaitForExit();
                });

                // Update progress bar and message
                progressBarNetwork.Value = 100;
                UpdateSmootherTextOutput("Network reset completed.");

                // Re-enable the button and hide the progress bar
                ButtonCleanNetwork.Visible = true;
                progressBarNetwork.Visible = false;
            }
        }

        private void NetworkWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            // Simulate network reset logic
            for (int i = 0; i <= 10; i++)
            {
                // Simulate a step of the network reset process
                Thread.Sleep(500); // Simulate processing time
                networkWorker.ReportProgress(i * 10); // Report progress
            }
        }

        private void UpdateProgressBar(WinForms.ProgressBar progressBar, int progress)
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action<WinForms.ProgressBar, int>(UpdateProgressBar), progressBar, progress);
            }
            else
            {
                progressBar.Value = progress;
            }
        }

        private void NetworkWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            UpdateProgressBar(progressBarNetwork, e.ProgressPercentage); // Use UpdateProgressBar here
        }



        private void NetworkWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ButtonCleanNetwork.Visible = true; // Re-enable the button
            progressBarNetwork.Visible = false; // Hide the progress bar
        }




        private string FindEthernetAdapterName()
        {
            foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (nic.NetworkInterfaceType == NetworkInterfaceType.Ethernet && nic.OperationalStatus == OperationalStatus.Up)
                {
                    return nic.Name; // Return the name of the first active Ethernet adapter
                }
            }
            return "Ethernet"; // Default if no active Ethernet adapter is found
        }




        private void ButtonCleanTemp_Click(object sender, EventArgs e)
        {
            // Show the progress bar and bring it to the front
            progressBar.Visible = true;
            progressBar.Value = 0;
            ButtonCleanTemp.Visible = false; // Disable the button during cleanup

            // Perform cleanup steps asynchronously
            worker.RunWorkerAsync();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] folders = new string[]
            {
              @"%systemroot%\temp",
              @"%systemroot%\Prefetch",
              @"%userprofile%\LocalS~1\Temp",
              @"%userprofile%\AppData\Local\Temp"
            };

            for (int i = 0; i < folders.Length; i++)
            {
                folders[i] = Environment.ExpandEnvironmentVariables(folders[i]);
            }

            int totalSteps = folders.Length * 2; // Number of folders * number of steps per folder

            for (int i = 0; i < folders.Length; i++)
            {
                DirectoryInfo dirInfo = new DirectoryInfo(folders[i]);

                // Delete files
                foreach (FileInfo file in dirInfo.GetFiles())
                {
                    try
                    {
                        file.Delete();
                    }
                    catch
                    {
                        // Handle exceptions here
                    }

                    // Update progress after each step
                    worker.ReportProgress((i * 2 + 1) * 100 / totalSteps);
                }

                // Delete directories
                foreach (DirectoryInfo dir in dirInfo.GetDirectories())
                {
                    try
                    {
                        dir.Delete(true);
                    }
                    catch
                    {

                    }

                    // Update progress after each step
                    worker.ReportProgress((i * 2 + 2) * 100 / totalSteps);
                }
            }
        }


        private void UpdateProgressBar(int progress)
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new Action<int>(UpdateProgressBar), progress);
            }
            else
            {
                progressBar.Value = progress;
            }
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            ButtonCleanTemp.Visible = true; // Re-enable the button
            progressBar.Visible = false;    // Hide the progress bar
        }


        private void IpAddress_Click(object sender, EventArgs e)
        {
            // Placeholder
        }

  
        

        private void LOGOCF_Click(object sender, EventArgs e)
        {

        }

        private void TextBoxMinJitter_TextChanged(object sender, EventArgs e)
        {

        }



        private void ButtonMenu_Click(object sender, EventArgs e)
        {
            contextMenuStrip1.Show(ButtonMenu, 0, ButtonMenu.Height);
        }




        #endregion

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void ButtonClearAll_Click(object sender, EventArgs e)
        {
            // 1. Clear the underlying data lists
            pingRoundTripTimes.Clear();
            packetLossValues.Clear();
            jitterValues.Clear();
            outputLines.Clear();
            

            // 2. Clear UI elements
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            // 3. Optionally, clear statistics shown in UI:
            // Reset any displayed ping, jitter, or packet loss statistics (depending on your UI structure).
            if (dataGridView2.Rows.Count > 0)
            {
                dataGridView2.Rows[0].Cells["MaxPing"].Value = "0 ms";
                dataGridView2.Rows[0].Cells["MinPing"].Value = "0 ms";
                dataGridView2.Rows[0].Cells["AvgPing"].Value = "0 ms";
            }



            TextBoxMaxJitter.Text = "0 ms";
            TextBoxMinJitter.Text = "0 ms";
            TextBoxAvgJitter.Text = "0 ms";

            TextBoxMaxLoss.Text = "0%";
            TextBoxMinLoss.Text = "0%";
            TextBoxAvgLoss.Text = "0%";

            FetchPublicIP();
        }

    }
}
