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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPinger));
            this.textBoxInterval = new System.Windows.Forms.TextBox();
            this.COPYRIGHT = new System.Windows.Forms.TextBox();
            this.close = new System.Windows.Forms.Button();
            this.LOGOCF = new System.Windows.Forms.PictureBox();
            this.textBoxPacketLoss = new System.Windows.Forms.TextBox();
            this.textBoxJitter = new System.Windows.Forms.TextBox();
            this.labelPacketLoss = new System.Windows.Forms.Label();
            this.labelJitter = new System.Windows.Forms.Label();
            this.ipAddress = new IPAddressControlLib.IPAddressControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TextBoxRAM = new System.Windows.Forms.TextBox();
            this.TextBoxCPU = new System.Windows.Forms.TextBox();
            this.Bt_mini = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ButtonNetworkAdapters = new System.Windows.Forms.Button();
            this.buttonCleanTemp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.ButtonCleanNetwork = new System.Windows.Forms.Button();
            this.SmootherPanel1 = new SmootherPanel();
            ((System.ComponentModel.ISupportInitialize)(this.LOGOCF)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInterval.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBoxInterval.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxInterval.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInterval.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxInterval.Location = new System.Drawing.Point(136, 40);
            this.textBoxInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxInterval.MaxLength = 4;
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(170, 23);
            this.textBoxInterval.TabIndex = 2;
            this.textBoxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInterval.TextChanged += new System.EventHandler(this.TextBoxInterval_TextChanged);
            this.textBoxInterval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxInterval_KeyDown);
            // 
            // COPYRIGHT
            // 
            this.COPYRIGHT.BackColor = System.Drawing.SystemColors.InfoText;
            this.COPYRIGHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.COPYRIGHT.Cursor = System.Windows.Forms.Cursors.Default;
            this.COPYRIGHT.Enabled = false;
            this.COPYRIGHT.ForeColor = System.Drawing.SystemColors.Info;
            this.COPYRIGHT.Location = new System.Drawing.Point(381, 667);
            this.COPYRIGHT.Name = "COPYRIGHT";
            this.COPYRIGHT.Size = new System.Drawing.Size(172, 19);
            this.COPYRIGHT.TabIndex = 31;
            this.COPYRIGHT.Text = "By Silicon Squire";
            this.COPYRIGHT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.COPYRIGHT.TextChanged += new System.EventHandler(this.COPYRIGHT_TextChanged);
            // 
            // close
            // 
            this.close.BackColor = System.Drawing.Color.Transparent;
            this.close.FlatAppearance.BorderSize = 0;
            this.close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.close.ForeColor = System.Drawing.Color.White;
            this.close.Location = new System.Drawing.Point(560, 0);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(34, 28);
            this.close.TabIndex = 30;
            this.close.Text = "X";
            this.close.UseVisualStyleBackColor = false;
            this.close.Click += new System.EventHandler(this.Close_Click);
            this.close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // LOGOCF
            // 
            this.LOGOCF.ErrorImage = ((System.Drawing.Image)(resources.GetObject("LOGOCF.ErrorImage")));
            this.LOGOCF.Image = ((System.Drawing.Image)(resources.GetObject("LOGOCF.Image")));
            this.LOGOCF.InitialImage = ((System.Drawing.Image)(resources.GetObject("LOGOCF.InitialImage")));
            this.LOGOCF.Location = new System.Drawing.Point(556, 648);
            this.LOGOCF.Name = "LOGOCF";
            this.LOGOCF.Size = new System.Drawing.Size(38, 38);
            this.LOGOCF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LOGOCF.TabIndex = 32;
            this.LOGOCF.TabStop = false;
            this.LOGOCF.Click += new System.EventHandler(this.LOGOCF_Click);
            // 
            // textBoxPacketLoss
            // 
            this.textBoxPacketLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPacketLoss.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBoxPacketLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPacketLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPacketLoss.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxPacketLoss.Location = new System.Drawing.Point(111, 6);
            this.textBoxPacketLoss.Name = "textBoxPacketLoss";
            this.textBoxPacketLoss.ReadOnly = true;
            this.textBoxPacketLoss.Size = new System.Drawing.Size(114, 16);
            this.textBoxPacketLoss.TabIndex = 33;
            this.textBoxPacketLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxJitter
            // 
            this.textBoxJitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJitter.BackColor = System.Drawing.SystemColors.ControlText;
            this.textBoxJitter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJitter.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.textBoxJitter.Location = new System.Drawing.Point(111, 31);
            this.textBoxJitter.Name = "textBoxJitter";
            this.textBoxJitter.ReadOnly = true;
            this.textBoxJitter.Size = new System.Drawing.Size(114, 16);
            this.textBoxJitter.TabIndex = 34;
            this.textBoxJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxJitter.TextChanged += new System.EventHandler(this.TextBoxJitter_TextChanged);
            // 
            // labelPacketLoss
            // 
            this.labelPacketLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPacketLoss.AutoSize = true;
            this.labelPacketLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacketLoss.Location = new System.Drawing.Point(6, 5);
            this.labelPacketLoss.Name = "labelPacketLoss";
            this.labelPacketLoss.Size = new System.Drawing.Size(96, 18);
            this.labelPacketLoss.TabIndex = 35;
            this.labelPacketLoss.Text = "PacketLoss:";
            this.labelPacketLoss.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelPacketLoss.Click += new System.EventHandler(this.Label1_Click);
            // 
            // labelJitter
            // 
            this.labelJitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelJitter.AutoSize = true;
            this.labelJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJitter.Location = new System.Drawing.Point(6, 30);
            this.labelJitter.Name = "labelJitter";
            this.labelJitter.Size = new System.Drawing.Size(96, 18);
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
            this.ipAddress.BackColor = System.Drawing.Color.Black;
            this.ipAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddress.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ipAddress.Location = new System.Drawing.Point(135, 6);
            this.ipAddress.MinimumSize = new System.Drawing.Size(126, 23);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.ReadOnly = false;
            this.ipAddress.Size = new System.Drawing.Size(172, 23);
            this.ipAddress.TabIndex = 37;
            this.ipAddress.Text = "...";
            this.ipAddress.Click += new System.EventHandler(this.IpAddress_Click);
            this.ipAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxIpAddress_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "IP Address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 18);
            this.label2.TabIndex = 39;
            this.label2.Text = "Interval (MS):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Controls.Add(this.TextBoxRAM);
            this.panel1.Controls.Add(this.TextBoxCPU);
            this.panel1.Controls.Add(this.Bt_mini);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.close);
            this.panel1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(-4, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1071, 27);
            this.panel1.TabIndex = 40;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel1_MouseDown);
            // 
            // TextBoxRAM
            // 
            this.TextBoxRAM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxRAM.BackColor = System.Drawing.SystemColors.Highlight;
            this.TextBoxRAM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxRAM.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxRAM.Location = new System.Drawing.Point(385, 5);
            this.TextBoxRAM.Name = "TextBoxRAM";
            this.TextBoxRAM.ReadOnly = true;
            this.TextBoxRAM.Size = new System.Drawing.Size(78, 19);
            this.TextBoxRAM.TabIndex = 44;
            this.TextBoxRAM.TabStop = false;
            this.TextBoxRAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxRAM.TextChanged += new System.EventHandler(this.TextBoxRAM_TextChanged);
            // 
            // TextBoxCPU
            // 
            this.TextBoxCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCPU.BackColor = System.Drawing.SystemColors.Highlight;
            this.TextBoxCPU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxCPU.ForeColor = System.Drawing.SystemColors.ControlText;
            this.TextBoxCPU.Location = new System.Drawing.Point(300, 5);
            this.TextBoxCPU.Name = "TextBoxCPU";
            this.TextBoxCPU.ReadOnly = true;
            this.TextBoxCPU.Size = new System.Drawing.Size(78, 19);
            this.TextBoxCPU.TabIndex = 45;
            this.TextBoxCPU.TabStop = false;
            this.TextBoxCPU.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxCPU.TextChanged += new System.EventHandler(this.TextBoxCPU_TextChanged);
            // 
            // Bt_mini
            // 
            this.Bt_mini.BackColor = System.Drawing.Color.Transparent;
            this.Bt_mini.FlatAppearance.BorderSize = 0;
            this.Bt_mini.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Bt_mini.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bt_mini.Font = new System.Drawing.Font("Showcard Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bt_mini.ForeColor = System.Drawing.Color.White;
            this.Bt_mini.Location = new System.Drawing.Point(520, -1);
            this.Bt_mini.Name = "Bt_mini";
            this.Bt_mini.Size = new System.Drawing.Size(34, 28);
            this.Bt_mini.TabIndex = 41;
            this.Bt_mini.Text = "__";
            this.Bt_mini.UseVisualStyleBackColor = false;
            this.Bt_mini.Click += new System.EventHandler(this.Bt_mini_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(9, 3);
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
            this.ButtonNetworkAdapters.BackColor = System.Drawing.SystemColors.Desktop;
            this.ButtonNetworkAdapters.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNetworkAdapters.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonNetworkAdapters.Location = new System.Drawing.Point(6, 6);
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
            this.buttonCleanTemp.AutoSize = true;
            this.buttonCleanTemp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCleanTemp.BackColor = System.Drawing.SystemColors.Desktop;
            this.buttonCleanTemp.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCleanTemp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCleanTemp.Location = new System.Drawing.Point(161, 6);
            this.buttonCleanTemp.Name = "buttonCleanTemp";
            this.buttonCleanTemp.Size = new System.Drawing.Size(139, 28);
            this.buttonCleanTemp.TabIndex = 43;
            this.buttonCleanTemp.Text = "Kill N Clean";
            this.buttonCleanTemp.UseVisualStyleBackColor = false;
            this.buttonCleanTemp.Click += new System.EventHandler(this.ButtonCleanTemp_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelPacketLoss, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPacketLoss, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxJitter, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelJitter, 0, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(357, 59);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(231, 53);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ipAddress, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxInterval, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 42);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(313, 70);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.ButtonCleanNetwork, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ButtonNetworkAdapters, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonCleanTemp, 1, 0);
            this.tableLayoutPanel3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 603);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel3.Size = new System.Drawing.Size(306, 77);
            this.tableLayoutPanel3.TabIndex = 46;
            // 
            // ButtonCleanNetwork
            // 
            this.ButtonCleanNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonCleanNetwork.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonCleanNetwork.BackColor = System.Drawing.SystemColors.Desktop;
            this.ButtonCleanNetwork.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCleanNetwork.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonCleanNetwork.Location = new System.Drawing.Point(6, 43);
            this.ButtonCleanNetwork.Name = "ButtonCleanNetwork";
            this.ButtonCleanNetwork.Size = new System.Drawing.Size(146, 28);
            this.ButtonCleanNetwork.TabIndex = 42;
            this.ButtonCleanNetwork.Text = "Reset Network";
            this.ButtonCleanNetwork.UseVisualStyleBackColor = false;
            this.ButtonCleanNetwork.Click += new System.EventHandler(this.ButtonCleanNetwork_Click);
            // 
            // SmootherPanel1
            // 
            this.SmootherPanel1.ForeColor = System.Drawing.Color.Lime;
            this.SmootherPanel1.Location = new System.Drawing.Point(10, 120);
            this.SmootherPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SmootherPanel1.Name = "SmootherPanel1";
            this.SmootherPanel1.Size = new System.Drawing.Size(580, 475);
            this.SmootherPanel1.TabIndex = 3;
            // 
            // FormPinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 690);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LOGOCF);
            this.Controls.Add(this.SmootherPanel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.COPYRIGHT);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPinger";
            this.Text = "Pingerino";
            this.Load += new System.EventHandler(this.FormPinger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LOGOCF)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInterval;
        private SmootherPanel SmootherPanel1;
        private System.Windows.Forms.TextBox COPYRIGHT;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.PictureBox LOGOCF;
        private System.Windows.Forms.TextBox textBoxPacketLoss;
        private System.Windows.Forms.TextBox textBoxJitter;
        private System.Windows.Forms.Label labelPacketLoss;
        private System.Windows.Forms.Label labelJitter;
        private IPAddressControlLib.IPAddressControl ipAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Bt_mini;
        private System.Windows.Forms.Button ButtonNetworkAdapters;
        private System.Windows.Forms.Button buttonCleanTemp;
        private System.Windows.Forms.TextBox TextBoxRAM;
        private System.Windows.Forms.TextBox TextBoxCPU;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button ButtonCleanNetwork;
    }
}
