using Microsoft.Win32.TaskScheduler;
using Networker;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using WinForms = System.Windows.Forms;

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
        private readonly List<long> pingRoundTripTimes = new List<long>();
        private readonly List<double> packetLossValues = new List<double>();
        private readonly List<double> jitterValues = new List<double>();
        private readonly WinForms.ProgressBar progressBar;
        private readonly BackgroundWorker worker = new BackgroundWorker();
        private readonly WinForms.Button ButtonCleanTemp;
        private readonly BackgroundWorker networkWorker;
        private readonly WinForms.ProgressBar progressBarNetwork;
        private const int MaxLines = 999;
        private readonly CircularBuffer<string> outputLines = new CircularBuffer<string>(MaxLines);


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

            System.Threading.Tasks.Task.Run(() => InitializeNetworkOperationsAsync());
        }


        #endregion

        #region Initialization Methods

        private void InitializeContextMenu()
        {
            contextMenuStrip1 = new ContextMenuStrip(); // Change this line
            contextMenuStrip1.Items.Add("[1] Run with Windows");
            contextMenuStrip1.Items.Add("[2] Auto Ping");

            ButtonMenu.Click += (sender, e) =>
            {
                contextMenuStrip1.Show(ButtonMenu, 0, ButtonMenu.Height);
            };

            // Attach event handlers to the menu items
            contextMenuStrip1.Items[0].Click += Option1_Click;
            contextMenuStrip1.Items[1].Click += Option2_Click;
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
      //      UpdateNetworkStatistics();

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
                contextMenuStrip1.Items[1].Text = "[2] Auto Ping ✔";
            }

            {
                UpdateOption1Text("Pingerino");
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
                        AddLineToOutput(timestamp, $"Pinging {ipAddress} - Success", $"{reply.RoundtripTime}ms");
                        UpdatePingRoundTripTimes(reply.RoundtripTime);
                        UpdatePingStatistics();

                    }
                    else
                    {
                        AddLineToOutput(timestamp, $"Ping to {ipAddress} - Failed", reply.Status.ToString());
                    }
                }
            }
            catch (PingException pEx)
            {
                AddLineToOutput(timestamp, "Ping exception:", pEx.Message);
            }
            catch (InvalidOperationException opEx)
            {
                AddLineToOutput(timestamp, "Operation invalid:", opEx.Message);
            }
            catch (Exception ex)
            {
                AddLineToOutput(timestamp, "Unexpected error:", ex.Message);
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
                    outputLines.Add($"{Time} - {Status} - {RTT}"); // Store to CircularBuffer
                    dataGridView1.FirstDisplayedScrollingRowIndex = dataGridView1.RowCount - 1;
                }
            }
        }


        public class CircularBuffer<T>
        {
            private readonly T[] buffer;
            private int head;
            private int tail;

            public int MaxSize { get; private set; }

            public CircularBuffer(int size)
            {
                buffer = new T[size];
                MaxSize = size;
            }

            public void Add(T item)
            {
                buffer[head] = item;
                head = (head + 1) % MaxSize;
                if (head == tail)
                {
                    tail = (tail + 1) % MaxSize;  // remove oldest item
                }
            }

            public T[] ToArray()
            {
                if (head < tail)
                {
                    return buffer.Skip(tail).Concat(buffer.Take(head)).ToArray();
                }
                else
                {
                    return buffer.Skip(tail).Take(head - tail).ToArray();
                }
            }
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
            UpdateTextBoxValue(TextBoxCPU, $"{cpuUsage:F2} %");
        }

        private void UpdateTextBoxValue(System.Windows.Forms.TextBox textBox, string value)
        {
            if (textBox.InvokeRequired)
            {
                textBox.Invoke(new Action<System.Windows.Forms.TextBox, string>(UpdateTextBoxValue), textBox, value);
            }
            else
            {
                textBox.Text = value;
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

                // Update the respective Text Boxes with max, avg, and min ping values
                if (TextBoxMaxPing.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        TextBoxMaxPing.Text = $"{maxPing} ms";
                    });
                }
                else
                {
                    TextBoxMaxPing.Text = $"{maxPing} ms";
                }

                if (TextBoxMinPing.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        TextBoxMinPing.Text = $"{minPing} ms";
                    });
                }
                else
                {
                    TextBoxMinPing.Text = $"{minPing} ms";
                }

                if (TextBoxAvgPing.InvokeRequired)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        TextBoxAvgPing.Text = $"{avgPing:F0} ms";
                    });
                }
                else
                {
                    TextBoxAvgPing.Text = $"{avgPing:F0} ms";
                }

            }
        }

        private void UpdateOption1Text(string Pingerino)
        {
            bool isTaskInScheduler = IsTaskInScheduler(Pingerino);
            contextMenuStrip1.Items[0].Text = isTaskInScheduler ? "[1] Run with Windows ✔" : "[1] Run with Windows";
        }


        private bool IsTaskInScheduler(string Pingerino)
        {
            using (Microsoft.Win32.TaskScheduler.TaskService ts = new Microsoft.Win32.TaskScheduler.TaskService())
            {
                Microsoft.Win32.TaskScheduler.Task existingTask = ts.GetTask(Pingerino);
                return existingTask != null;
            }
        }

        private void Option1_Click(object sender, EventArgs e)
        {
            using (TaskService ts = new TaskService())
            {
                string taskName = "Pingerino";

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

                    td.Actions.Add(new ExecAction(Application.ExecutablePath));

                    string currentUserName = WindowsIdentity.GetCurrent().Name;

                    // Set the task to run only when the user is logged on
                    td.Principal.LogonType = TaskLogonType.InteractiveToken;

                    ts.RootFolder.RegisterTaskDefinition(taskName, td, TaskCreation.CreateOrUpdate, currentUserName, null, TaskLogonType.InteractiveToken);
                }

                UpdateOption1Text(taskName);
            }
        }

        private bool autoPingEnabled = false;

        private void Option2_Click(object sender, EventArgs e)
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




        #endregion

        #region Jitter and Packet Loss Statistics Methods

        // Method to update the jitter values list
        private void UpdateJitterValues(double jitter)
        {
            jitterValues.Add(jitter);
        }

        // Method to update the packet loss values list
        private void UpdatePacketLossValues(double packetLoss)
        {
            packetLossValues.Add(packetLoss);
        }

        // Method to calculate and update Max, Average, and Minimum jitter values
        private void UpdateJitterStatistics()
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


        // Method to calculate and update Max, Average, and Minimum packet loss values
        private void UpdatePacketLossStatistics()
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
            UpdateTextBoxValue(TextBoxRAM, $"{memoryUsage:F0} MB");
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
    }
}
