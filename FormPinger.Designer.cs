namespace Pingerino
{
    partial class FormPinger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPinger));
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.COPYRIGHT = new System.Windows.Forms.TextBox();
            this.textBoxPacketLoss = new System.Windows.Forms.TextBox();
            this.textBoxJitter = new System.Windows.Forms.TextBox();
            this.labelPacketLoss = new System.Windows.Forms.Label();
            this.labelJitter = new System.Windows.Forms.Label();
            this.ipAddress = new IPAddressControlLib.IPAddressControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonExit = new System.Windows.Forms.Button();
            this.ButtonMinimize = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonNetworkAdapters = new System.Windows.Forms.Button();
            this.buttonCleanTemp = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonMenu = new System.Windows.Forms.Button();
            this.ButtonCleanNetwork = new System.Windows.Forms.Button();
            this.TextBoxMaxLoss = new System.Windows.Forms.TextBox();
            this.TextBoxMaxJitter = new System.Windows.Forms.TextBox();
            this.TextBoxAvgJitter = new System.Windows.Forms.TextBox();
            this.TextBoxAvgLoss = new System.Windows.Forms.TextBox();
            this.TextBoxMinLoss = new System.Windows.Forms.TextBox();
            this.TextBoxMinJitter = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonClearAll = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.MinPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.textBoxInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInterval.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInterval.ForeColor = System.Drawing.Color.Gold;
            this.textBoxInterval.Location = new System.Drawing.Point(134, 47);
            this.textBoxInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxInterval.MaxLength = 4;
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(178, 16);
            this.textBoxInterval.TabIndex = 2;
            this.textBoxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInterval.TextChanged += new System.EventHandler(this.TextBoxInterval_TextChanged);
            this.textBoxInterval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxInterval_KeyDown);
            // 
            // COPYRIGHT
            // 
            this.COPYRIGHT.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.COPYRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.COPYRIGHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.COPYRIGHT.Cursor = System.Windows.Forms.Cursors.Default;
            this.COPYRIGHT.Enabled = false;
            this.COPYRIGHT.ForeColor = System.Drawing.SystemColors.Info;
            this.COPYRIGHT.Location = new System.Drawing.Point(533, 508);
            this.COPYRIGHT.Margin = new System.Windows.Forms.Padding(0);
            this.COPYRIGHT.Name = "COPYRIGHT";
            this.COPYRIGHT.Size = new System.Drawing.Size(180, 19);
            this.COPYRIGHT.TabIndex = 31;
            this.COPYRIGHT.Text = "By Silicon Squire";
            this.COPYRIGHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.COPYRIGHT.TextChanged += new System.EventHandler(this.COPYRIGHT_TextChanged);
            // 
            // textBoxPacketLoss
            // 
            this.textBoxPacketLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPacketLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.textBoxPacketLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPacketLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPacketLoss.ForeColor = System.Drawing.Color.Gold;
            this.textBoxPacketLoss.Location = new System.Drawing.Point(93, 9);
            this.textBoxPacketLoss.Name = "textBoxPacketLoss";
            this.textBoxPacketLoss.ReadOnly = true;
            this.textBoxPacketLoss.Size = new System.Drawing.Size(58, 16);
            this.textBoxPacketLoss.TabIndex = 33;
            this.textBoxPacketLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxJitter
            // 
            this.textBoxJitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.textBoxJitter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJitter.ForeColor = System.Drawing.Color.Gold;
            this.textBoxJitter.Location = new System.Drawing.Point(93, 42);
            this.textBoxJitter.Name = "textBoxJitter";
            this.textBoxJitter.ReadOnly = true;
            this.textBoxJitter.Size = new System.Drawing.Size(58, 16);
            this.textBoxJitter.TabIndex = 34;
            this.textBoxJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxJitter.TextChanged += new System.EventHandler(this.TextBoxJitter_TextChanged);
            // 
            // labelPacketLoss
            // 
            this.labelPacketLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPacketLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacketLoss.ForeColor = System.Drawing.Color.Gold;
            this.labelPacketLoss.Location = new System.Drawing.Point(5, 8);
            this.labelPacketLoss.Name = "labelPacketLoss";
            this.labelPacketLoss.Size = new System.Drawing.Size(80, 18);
            this.labelPacketLoss.TabIndex = 35;
            this.labelPacketLoss.Text = "PacketLoss:";
            this.labelPacketLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPacketLoss.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelJitter
            // 
            this.labelJitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJitter.ForeColor = System.Drawing.Color.Gold;
            this.labelJitter.Location = new System.Drawing.Point(5, 41);
            this.labelJitter.Name = "labelJitter";
            this.labelJitter.Size = new System.Drawing.Size(80, 18);
            this.labelJitter.TabIndex = 36;
            this.labelJitter.Text = "Jitter:";
            this.labelJitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelJitter.Click += new System.EventHandler(this.LabelJitter_Click);
            // 
            // ipAddress
            // 
            this.ipAddress.AllowInternalTab = false;
            this.ipAddress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ipAddress.AutoHeight = true;
            this.ipAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ipAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddress.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddress.ForeColor = System.Drawing.Color.Gold;
            this.ipAddress.Location = new System.Drawing.Point(133, 10);
            this.ipAddress.MinimumSize = new System.Drawing.Size(120, 18);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.ReadOnly = false;
            this.ipAddress.Size = new System.Drawing.Size(180, 18);
            this.ipAddress.TabIndex = 37;
            this.ipAddress.Text = "...";
            this.ipAddress.Click += new System.EventHandler(this.IpAddress_Click);
            this.ipAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxIpAddress_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(5, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 34);
            this.label1.TabIndex = 38;
            this.label1.Text = "IP Address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(5, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.TabIndex = 39;
            this.label2.Text = "Interval (MS):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gold;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ButtonExit);
            this.panel1.Controls.Add(this.ButtonMinimize);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(715, 27);
            this.panel1.TabIndex = 40;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Location = new System.Drawing.Point(128, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 21);
            this.label4.TabIndex = 64;
            // 
            // ButtonExit
            // 
            this.ButtonExit.BackgroundImage = global::Pingerino.Properties.Resources.Untitled;
            this.ButtonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonExit.Location = new System.Drawing.Point(657, 1);
            this.ButtonExit.Name = "ButtonExit";
            this.ButtonExit.Size = new System.Drawing.Size(25, 25);
            this.ButtonExit.TabIndex = 33;
            this.ButtonExit.UseVisualStyleBackColor = true;
            this.ButtonExit.Click += new System.EventHandler(this.ButtonExit_Click);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.BackgroundImage = global::Pingerino.Properties.Resources.Untitlemd;
            this.ButtonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMinimize.Location = new System.Drawing.Point(629, 1);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(25, 25);
            this.ButtonMinimize.TabIndex = 32;
            this.ButtonMinimize.UseVisualStyleBackColor = true;
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.label3.Location = new System.Drawing.Point(15, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 31;
            this.label3.Text = "Pingerino";
            this.label3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Label3_MouseDown);
            // 
            // ButtonNetworkAdapters
            // 
            this.ButtonNetworkAdapters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNetworkAdapters.AutoSize = true;
            this.ButtonNetworkAdapters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonNetworkAdapters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonNetworkAdapters.FlatAppearance.BorderSize = 0;
            this.ButtonNetworkAdapters.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonNetworkAdapters.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonNetworkAdapters.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonNetworkAdapters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonNetworkAdapters.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNetworkAdapters.ForeColor = System.Drawing.Color.Gold;
            this.ButtonNetworkAdapters.Location = new System.Drawing.Point(5, 5);
            this.ButtonNetworkAdapters.Name = "ButtonNetworkAdapters";
            this.ButtonNetworkAdapters.Size = new System.Drawing.Size(146, 28);
            this.ButtonNetworkAdapters.TabIndex = 41;
            this.ButtonNetworkAdapters.Text = "Network Adapters";
            this.ButtonNetworkAdapters.UseVisualStyleBackColor = false;
            this.ButtonNetworkAdapters.Click += new System.EventHandler(this.ButtonNetworkAdapters_Click);
            // 
            // buttonCleanTemp
            // 
            this.buttonCleanTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCleanTemp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCleanTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.buttonCleanTemp.FlatAppearance.BorderSize = 0;
            this.buttonCleanTemp.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.buttonCleanTemp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.buttonCleanTemp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.buttonCleanTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleanTemp.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCleanTemp.ForeColor = System.Drawing.Color.Gold;
            this.buttonCleanTemp.Location = new System.Drawing.Point(159, 5);
            this.buttonCleanTemp.Name = "buttonCleanTemp";
            this.buttonCleanTemp.Size = new System.Drawing.Size(147, 27);
            this.buttonCleanTemp.TabIndex = 43;
            this.buttonCleanTemp.Text = "Kill N Clean";
            this.buttonCleanTemp.UseVisualStyleBackColor = false;
            this.buttonCleanTemp.Click += new System.EventHandler(this.ButtonCleanTemp_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ipAddress, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxInterval, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 31);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 75);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonMenu.FlatAppearance.BorderSize = 0;
            this.ButtonMenu.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMenu.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMenu.ForeColor = System.Drawing.Color.Gold;
            this.ButtonMenu.Location = new System.Drawing.Point(159, 42);
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.Size = new System.Drawing.Size(147, 27);
            this.ButtonMenu.TabIndex = 43;
            this.ButtonMenu.Text = "Stuff";
            this.ButtonMenu.UseVisualStyleBackColor = false;
            this.ButtonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // ButtonCleanNetwork
            // 
            this.ButtonCleanNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCleanNetwork.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonCleanNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonCleanNetwork.FlatAppearance.BorderSize = 0;
            this.ButtonCleanNetwork.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonCleanNetwork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonCleanNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonCleanNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCleanNetwork.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCleanNetwork.ForeColor = System.Drawing.Color.Red;
            this.ButtonCleanNetwork.Location = new System.Drawing.Point(5, 42);
            this.ButtonCleanNetwork.Name = "ButtonCleanNetwork";
            this.ButtonCleanNetwork.Size = new System.Drawing.Size(146, 27);
            this.ButtonCleanNetwork.TabIndex = 42;
            this.ButtonCleanNetwork.Text = "Reset Network";
            this.ButtonCleanNetwork.UseVisualStyleBackColor = false;
            this.ButtonCleanNetwork.Click += new System.EventHandler(this.ButtonCleanNetwork_Click);
            // 
            // TextBoxMaxLoss
            // 
            this.TextBoxMaxLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMaxLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.TextBoxMaxLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMaxLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMaxLoss.ForeColor = System.Drawing.Color.Gold;
            this.TextBoxMaxLoss.Location = new System.Drawing.Point(291, 9);
            this.TextBoxMaxLoss.Name = "TextBoxMaxLoss";
            this.TextBoxMaxLoss.Size = new System.Drawing.Size(82, 16);
            this.TextBoxMaxLoss.TabIndex = 52;
            this.TextBoxMaxLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMaxJitter
            // 
            this.TextBoxMaxJitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMaxJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.TextBoxMaxJitter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMaxJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMaxJitter.ForeColor = System.Drawing.Color.Gold;
            this.TextBoxMaxJitter.Location = new System.Drawing.Point(291, 42);
            this.TextBoxMaxJitter.Name = "TextBoxMaxJitter";
            this.TextBoxMaxJitter.Size = new System.Drawing.Size(82, 16);
            this.TextBoxMaxJitter.TabIndex = 52;
            this.TextBoxMaxJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAvgJitter
            // 
            this.TextBoxAvgJitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAvgJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.TextBoxAvgJitter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAvgJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAvgJitter.ForeColor = System.Drawing.Color.Gold;
            this.TextBoxAvgJitter.Location = new System.Drawing.Point(225, 42);
            this.TextBoxAvgJitter.Name = "TextBoxAvgJitter";
            this.TextBoxAvgJitter.Size = new System.Drawing.Size(58, 16);
            this.TextBoxAvgJitter.TabIndex = 51;
            this.TextBoxAvgJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAvgLoss
            // 
            this.TextBoxAvgLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAvgLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.TextBoxAvgLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAvgLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAvgLoss.ForeColor = System.Drawing.Color.Gold;
            this.TextBoxAvgLoss.Location = new System.Drawing.Point(225, 9);
            this.TextBoxAvgLoss.Name = "TextBoxAvgLoss";
            this.TextBoxAvgLoss.Size = new System.Drawing.Size(58, 16);
            this.TextBoxAvgLoss.TabIndex = 51;
            this.TextBoxAvgLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMinLoss
            // 
            this.TextBoxMinLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMinLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.TextBoxMinLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMinLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMinLoss.ForeColor = System.Drawing.Color.Gold;
            this.TextBoxMinLoss.Location = new System.Drawing.Point(159, 9);
            this.TextBoxMinLoss.Name = "TextBoxMinLoss";
            this.TextBoxMinLoss.Size = new System.Drawing.Size(58, 16);
            this.TextBoxMinLoss.TabIndex = 50;
            this.TextBoxMinLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMinJitter
            // 
            this.TextBoxMinJitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMinJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.TextBoxMinJitter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMinJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMinJitter.ForeColor = System.Drawing.Color.Gold;
            this.TextBoxMinJitter.Location = new System.Drawing.Point(159, 42);
            this.TextBoxMinJitter.Name = "TextBoxMinJitter";
            this.TextBoxMinJitter.Size = new System.Drawing.Size(58, 16);
            this.TextBoxMinJitter.TabIndex = 50;
            this.TextBoxMinJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxMinJitter.TextChanged += new System.EventHandler(this.TextBoxMinJitter_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.ButtonCleanNetwork, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ButtonNetworkAdapters, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonMenu, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonCleanTemp, 1, 0);
            this.tableLayoutPanel3.ForeColor = System.Drawing.Color.Gold;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(392, 31);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(311, 75);
            this.tableLayoutPanel3.TabIndex = 58;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Status,
            this.RTT});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.Gold;
            this.dataGridView1.Location = new System.Drawing.Point(12, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(691, 336);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.TabStop = false;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Time.DefaultCellStyle = dataGridViewCellStyle3;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 120;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Status.DefaultCellStyle = dataGridViewCellStyle4;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 468;
            // 
            // RTT
            // 
            this.RTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Gold;
            this.RTT.DefaultCellStyle = dataGridViewCellStyle5;
            this.RTT.HeaderText = "RTT";
            this.RTT.Name = "RTT";
            this.RTT.ReadOnly = true;
            this.RTT.Width = 70;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 88F));
            this.tableLayoutPanel5.Controls.Add(this.labelJitter, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.textBoxPacketLoss, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxJitter, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxAvgLoss, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxMaxLoss, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxMaxJitter, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxAvgJitter, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxMinJitter, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxMinLoss, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.labelPacketLoss, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 452);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(378, 68);
            this.tableLayoutPanel5.TabIndex = 61;
            // 
            // ButtonClearAll
            // 
            this.ButtonClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ButtonClearAll.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonClearAll.FlatAppearance.BorderSize = 0;
            this.ButtonClearAll.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonClearAll.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ButtonClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonClearAll.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World, ((byte)(0)));
            this.ButtonClearAll.ForeColor = System.Drawing.Color.Gold;
            this.ButtonClearAll.Location = new System.Drawing.Point(395, 454);
            this.ButtonClearAll.Name = "ButtonClearAll";
            this.ButtonClearAll.Size = new System.Drawing.Size(88, 24);
            this.ButtonClearAll.TabIndex = 64;
            this.ButtonClearAll.Text = "CLEAR VALUES";
            this.ButtonClearAll.UseVisualStyleBackColor = false;
            this.ButtonClearAll.Click += new System.EventHandler(this.ButtonClearAll_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToResizeColumns = false;
            this.dataGridView2.AllowUserToResizeRows = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView2.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle10.NullValue = null;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MinPing,
            this.AvgPing,
            this.MaxPing});
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView2.DefaultCellStyle = dataGridViewCellStyle14;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.GridColor = System.Drawing.Color.Gold;
            this.dataGridView2.Location = new System.Drawing.Point(488, 451);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView2.RowHeadersVisible = false;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Gold;
            this.dataGridView2.RowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView2.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView2.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dataGridView2.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Gold;
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.dataGridView2.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Gold;
            this.dataGridView2.Size = new System.Drawing.Size(215, 54);
            this.dataGridView2.TabIndex = 65;
            this.dataGridView2.TabStop = false;
            // 
            // MinPing
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Gold;
            this.MinPing.DefaultCellStyle = dataGridViewCellStyle11;
            this.MinPing.HeaderText = "Min.";
            this.MinPing.Name = "MinPing";
            this.MinPing.ReadOnly = true;
            this.MinPing.Width = 70;
            // 
            // AvgPing
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Gold;
            this.AvgPing.DefaultCellStyle = dataGridViewCellStyle12;
            this.AvgPing.HeaderText = "Avg.";
            this.AvgPing.Name = "AvgPing";
            this.AvgPing.ReadOnly = true;
            this.AvgPing.Width = 70;
            // 
            // MaxPing
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Gold;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.Color.Gold;
            this.MaxPing.DefaultCellStyle = dataGridViewCellStyle13;
            this.MaxPing.HeaderText = "Max.";
            this.MaxPing.Name = "MaxPing";
            this.MaxPing.ReadOnly = true;
            this.MaxPing.Width = 70;
            // 
            // FormPinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(17)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(715, 532);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.ButtonClearAll);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.COPYRIGHT);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPinger";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.FormPinger_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInterval;
        private System.Windows.Forms.TextBox COPYRIGHT;
        private System.Windows.Forms.TextBox textBoxPacketLoss;
        private System.Windows.Forms.TextBox textBoxJitter;
        private System.Windows.Forms.Label labelPacketLoss;
        private System.Windows.Forms.Label labelJitter;
        private IPAddressControlLib.IPAddressControl ipAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ButtonNetworkAdapters;
        private System.Windows.Forms.Button buttonCleanTemp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox TextBoxMaxLoss;
        private System.Windows.Forms.TextBox TextBoxMaxJitter;
        private System.Windows.Forms.TextBox TextBoxAvgJitter;
        private System.Windows.Forms.TextBox TextBoxAvgLoss;
        private System.Windows.Forms.TextBox TextBoxMinLoss;
        private System.Windows.Forms.TextBox TextBoxMinJitter;
        private System.Windows.Forms.Button ButtonMenu;
        private System.Windows.Forms.Button ButtonCleanNetwork;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Button ButtonExit;
        private System.Windows.Forms.Button ButtonMinimize;
        private System.Windows.Forms.Button ButtonClearAll;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPing;
        private System.Windows.Forms.Label label4;
        
    }
}
