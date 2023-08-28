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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPinger));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.ButtonMenu = new System.Windows.Forms.Button();
            this.ButtonCleanNetwork = new System.Windows.Forms.Button();
            this.TextBoxAvgPing = new System.Windows.Forms.TextBox();
            this.TextBoxMaxPing = new System.Windows.Forms.TextBox();
            this.TextBoxMinPing = new System.Windows.Forms.TextBox();
            this.TextBoxMaxLoss = new System.Windows.Forms.TextBox();
            this.TextBoxMaxJitter = new System.Windows.Forms.TextBox();
            this.TextBoxAvgJitter = new System.Windows.Forms.TextBox();
            this.TextBoxAvgLoss = new System.Windows.Forms.TextBox();
            this.TextBoxMinLoss = new System.Windows.Forms.TextBox();
            this.TextBoxMinJitter = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.LOGOCF)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInterval.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInterval.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.textBoxInterval.Location = new System.Drawing.Point(136, 41);
            this.textBoxInterval.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxInterval.MaxLength = 4;
            this.textBoxInterval.Name = "textBoxInterval";
            this.textBoxInterval.Size = new System.Drawing.Size(172, 16);
            this.textBoxInterval.TabIndex = 2;
            this.textBoxInterval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxInterval.TextChanged += new System.EventHandler(this.TextBoxInterval_TextChanged);
            this.textBoxInterval.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxInterval_KeyDown);
            // 
            // COPYRIGHT
            // 
            this.COPYRIGHT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.COPYRIGHT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.COPYRIGHT.Cursor = System.Windows.Forms.Cursors.Default;
            this.COPYRIGHT.Enabled = false;
            this.COPYRIGHT.ForeColor = System.Drawing.SystemColors.Info;
            this.COPYRIGHT.Location = new System.Drawing.Point(481, 677);
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
            this.close.Location = new System.Drawing.Point(669, 0);
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
            this.LOGOCF.Location = new System.Drawing.Point(663, 663);
            this.LOGOCF.Name = "LOGOCF";
            this.LOGOCF.Size = new System.Drawing.Size(38, 38);
            this.LOGOCF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LOGOCF.TabIndex = 32;
            this.LOGOCF.TabStop = false;
            this.LOGOCF.Click += new System.EventHandler(this.LOGOCF_Click);
            // 
            // textBoxPacketLoss
            // 
            this.textBoxPacketLoss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPacketLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxPacketLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPacketLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPacketLoss.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPacketLoss.Location = new System.Drawing.Point(111, 6);
            this.textBoxPacketLoss.Name = "textBoxPacketLoss";
            this.textBoxPacketLoss.ReadOnly = true;
            this.textBoxPacketLoss.Size = new System.Drawing.Size(114, 16);
            this.textBoxPacketLoss.TabIndex = 33;
            this.textBoxPacketLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxJitter
            // 
            this.textBoxJitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxJitter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJitter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxJitter.Location = new System.Drawing.Point(111, 6);
            this.textBoxJitter.Name = "textBoxJitter";
            this.textBoxJitter.ReadOnly = true;
            this.textBoxJitter.Size = new System.Drawing.Size(114, 16);
            this.textBoxJitter.TabIndex = 34;
            this.textBoxJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxJitter.TextChanged += new System.EventHandler(this.TextBoxJitter_TextChanged);
            // 
            // labelPacketLoss
            // 
            this.labelPacketLoss.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.labelJitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelJitter.AutoSize = true;
            this.labelJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelJitter.Location = new System.Drawing.Point(22, 5);
            this.labelJitter.Name = "labelJitter";
            this.labelJitter.Size = new System.Drawing.Size(64, 18);
            this.labelJitter.TabIndex = 36;
            this.labelJitter.Text = "Jitter:";
            this.labelJitter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelJitter.Click += new System.EventHandler(this.LabelJitter_Click);
            // 
            // ipAddress
            // 
            this.ipAddress.AllowInternalTab = false;
            this.ipAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ipAddress.AutoHeight = true;
            this.ipAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ipAddress.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ipAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddress.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddress.ForeColor = System.Drawing.SystemColors.Highlight;
            this.ipAddress.Location = new System.Drawing.Point(135, 6);
            this.ipAddress.MinimumSize = new System.Drawing.Size(126, 23);
            this.ipAddress.Name = "ipAddress";
            this.ipAddress.ReadOnly = false;
            this.ipAddress.Size = new System.Drawing.Size(174, 23);
            this.ipAddress.TabIndex = 37;
            this.ipAddress.Text = "...";
            this.ipAddress.Click += new System.EventHandler(this.IpAddress_Click);
            this.ipAddress.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxIpAddress_KeyDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(18, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 18);
            this.label1.TabIndex = 38;
            this.label1.Text = "IP Address:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 40);
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
            this.TextBoxRAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxRAM.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxRAM.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxRAM.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TextBoxRAM.Location = new System.Drawing.Point(525, 6);
            this.TextBoxRAM.Name = "TextBoxRAM";
            this.TextBoxRAM.ReadOnly = true;
            this.TextBoxRAM.Size = new System.Drawing.Size(95, 16);
            this.TextBoxRAM.TabIndex = 44;
            this.TextBoxRAM.TabStop = false;
            this.TextBoxRAM.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxRAM.TextChanged += new System.EventHandler(this.TextBoxRAM_TextChanged);
            // 
            // TextBoxCPU
            // 
            this.TextBoxCPU.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxCPU.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxCPU.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxCPU.Font = new System.Drawing.Font("Cascadia Mono Light", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxCPU.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.TextBoxCPU.Location = new System.Drawing.Point(424, 6);
            this.TextBoxCPU.Name = "TextBoxCPU";
            this.TextBoxCPU.ReadOnly = true;
            this.TextBoxCPU.Size = new System.Drawing.Size(95, 16);
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
            this.Bt_mini.Location = new System.Drawing.Point(629, 0);
            this.Bt_mini.Name = "Bt_mini";
            this.Bt_mini.Size = new System.Drawing.Size(34, 28);
            this.Bt_mini.TabIndex = 41;
            this.Bt_mini.Text = "__";
            this.Bt_mini.UseVisualStyleBackColor = false;
            this.Bt_mini.Click += new System.EventHandler(this.Bt_mini_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
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
            this.ButtonNetworkAdapters.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonNetworkAdapters.AutoSize = true;
            this.ButtonNetworkAdapters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonNetworkAdapters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonNetworkAdapters.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonNetworkAdapters.ForeColor = System.Drawing.SystemColors.HotTrack;
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
            this.buttonCleanTemp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonCleanTemp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCleanTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonCleanTemp.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCleanTemp.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.buttonCleanTemp.Location = new System.Drawing.Point(160, 5);
            this.buttonCleanTemp.Name = "buttonCleanTemp";
            this.buttonCleanTemp.Size = new System.Drawing.Size(145, 27);
            this.buttonCleanTemp.TabIndex = 43;
            this.buttonCleanTemp.Text = "Kill N Clean";
            this.buttonCleanTemp.UseVisualStyleBackColor = false;
            this.buttonCleanTemp.Click += new System.EventHandler(this.ButtonCleanTemp_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.labelPacketLoss, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxPacketLoss, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(457, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(231, 29);
            this.tableLayoutPanel1.TabIndex = 44;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ipAddress, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxInterval, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(12, 47);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(315, 67);
            this.tableLayoutPanel2.TabIndex = 45;
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonMenu.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonMenu.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonMenu.Location = new System.Drawing.Point(160, 42);
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.Size = new System.Drawing.Size(145, 27);
            this.ButtonMenu.TabIndex = 43;
            this.ButtonMenu.Text = "Stuff";
            this.ButtonMenu.UseVisualStyleBackColor = false;
            this.ButtonMenu.Click += new System.EventHandler(this.ButtonMenu_Click);
            // 
            // ButtonCleanNetwork
            // 
            this.ButtonCleanNetwork.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ButtonCleanNetwork.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonCleanNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonCleanNetwork.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCleanNetwork.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.ButtonCleanNetwork.Location = new System.Drawing.Point(5, 42);
            this.ButtonCleanNetwork.Name = "ButtonCleanNetwork";
            this.ButtonCleanNetwork.Size = new System.Drawing.Size(145, 27);
            this.ButtonCleanNetwork.TabIndex = 42;
            this.ButtonCleanNetwork.Text = "Reset Network";
            this.ButtonCleanNetwork.UseVisualStyleBackColor = false;
            this.ButtonCleanNetwork.Click += new System.EventHandler(this.ButtonCleanNetwork_Click);
            // 
            // TextBoxAvgPing
            // 
            this.TextBoxAvgPing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxAvgPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxAvgPing.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAvgPing.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxAvgPing.Location = new System.Drawing.Point(78, 146);
            this.TextBoxAvgPing.Name = "TextBoxAvgPing";
            this.TextBoxAvgPing.Size = new System.Drawing.Size(60, 23);
            this.TextBoxAvgPing.TabIndex = 48;
            this.TextBoxAvgPing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMaxPing
            // 
            this.TextBoxMaxPing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxMaxPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxMaxPing.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMaxPing.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxMaxPing.Location = new System.Drawing.Point(144, 146);
            this.TextBoxMaxPing.Name = "TextBoxMaxPing";
            this.TextBoxMaxPing.Size = new System.Drawing.Size(60, 23);
            this.TextBoxMaxPing.TabIndex = 49;
            this.TextBoxMaxPing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMinPing
            // 
            this.TextBoxMinPing.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxMinPing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxMinPing.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMinPing.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxMinPing.Location = new System.Drawing.Point(12, 146);
            this.TextBoxMinPing.Name = "TextBoxMinPing";
            this.TextBoxMinPing.Size = new System.Drawing.Size(60, 23);
            this.TextBoxMinPing.TabIndex = 47;
            this.TextBoxMinPing.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMaxLoss
            // 
            this.TextBoxMaxLoss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxMaxLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxMaxLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMaxLoss.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxMaxLoss.Location = new System.Drawing.Point(613, 82);
            this.TextBoxMaxLoss.Name = "TextBoxMaxLoss";
            this.TextBoxMaxLoss.Size = new System.Drawing.Size(60, 23);
            this.TextBoxMaxLoss.TabIndex = 52;
            this.TextBoxMaxLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMaxJitter
            // 
            this.TextBoxMaxJitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxMaxJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxMaxJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMaxJitter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxMaxJitter.Location = new System.Drawing.Point(613, 146);
            this.TextBoxMaxJitter.Name = "TextBoxMaxJitter";
            this.TextBoxMaxJitter.Size = new System.Drawing.Size(60, 23);
            this.TextBoxMaxJitter.TabIndex = 52;
            this.TextBoxMaxJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAvgJitter
            // 
            this.TextBoxAvgJitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxAvgJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxAvgJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAvgJitter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxAvgJitter.Location = new System.Drawing.Point(547, 146);
            this.TextBoxAvgJitter.Name = "TextBoxAvgJitter";
            this.TextBoxAvgJitter.Size = new System.Drawing.Size(60, 23);
            this.TextBoxAvgJitter.TabIndex = 51;
            this.TextBoxAvgJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAvgLoss
            // 
            this.TextBoxAvgLoss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxAvgLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxAvgLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAvgLoss.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxAvgLoss.Location = new System.Drawing.Point(547, 82);
            this.TextBoxAvgLoss.Name = "TextBoxAvgLoss";
            this.TextBoxAvgLoss.Size = new System.Drawing.Size(60, 23);
            this.TextBoxAvgLoss.TabIndex = 51;
            this.TextBoxAvgLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMinLoss
            // 
            this.TextBoxMinLoss.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxMinLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxMinLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMinLoss.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxMinLoss.Location = new System.Drawing.Point(481, 82);
            this.TextBoxMinLoss.Name = "TextBoxMinLoss";
            this.TextBoxMinLoss.Size = new System.Drawing.Size(60, 23);
            this.TextBoxMinLoss.TabIndex = 50;
            this.TextBoxMinLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMinJitter
            // 
            this.TextBoxMinJitter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBoxMinJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxMinJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMinJitter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxMinJitter.Location = new System.Drawing.Point(481, 146);
            this.TextBoxMinJitter.Name = "TextBoxMinJitter";
            this.TextBoxMinJitter.Size = new System.Drawing.Size(60, 23);
            this.TextBoxMinJitter.TabIndex = 50;
            this.TextBoxMinJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxMinJitter.TextChanged += new System.EventHandler(this.TextBoxMinJitter_TextChanged);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel4.AutoSize = true;
            this.tableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel4.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.05263F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.94737F));
            this.tableLayoutPanel4.Controls.Add(this.labelJitter, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.textBoxJitter, 1, 0);
            this.tableLayoutPanel4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel4.Location = new System.Drawing.Point(457, 111);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(231, 29);
            this.tableLayoutPanel4.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(155, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 18);
            this.label4.TabIndex = 55;
            this.label4.Text = "Max.";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(89, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 18);
            this.label5.TabIndex = 56;
            this.label5.Text = "Avg.";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(23, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 18);
            this.label6.TabIndex = 57;
            this.label6.Text = "Min.";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonCleanTemp, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonCleanNetwork, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ButtonNetworkAdapters, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonMenu, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(12, 608);
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
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle2.NullValue = null;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
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
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(9, 175);
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
            this.dataGridView1.Size = new System.Drawing.Size(679, 427);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.TabStop = false;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Time.DefaultCellStyle = dataGridViewCellStyle3;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 71;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.DefaultCellStyle = dataGridViewCellStyle4;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // RTT
            // 
            this.RTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RTT.DefaultCellStyle = dataGridViewCellStyle5;
            this.RTT.HeaderText = "RTT";
            this.RTT.Name = "RTT";
            this.RTT.ReadOnly = true;
            this.RTT.Width = 62;
            // 
            // FormPinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TextBoxAvgJitter);
            this.Controls.Add(this.TextBoxMaxJitter);
            this.Controls.Add(this.TextBoxAvgLoss);
            this.Controls.Add(this.TextBoxMinJitter);
            this.Controls.Add(this.TextBoxMaxLoss);
            this.Controls.Add(this.TextBoxMinLoss);
            this.Controls.Add(this.TextBoxAvgPing);
            this.Controls.Add(this.TextBoxMaxPing);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TextBoxMinPing);
            this.Controls.Add(this.LOGOCF);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.COPYRIGHT);
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
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBoxInterval;
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
        private System.Windows.Forms.TextBox TextBoxAvgPing;
        private System.Windows.Forms.TextBox TextBoxMaxPing;
        private System.Windows.Forms.TextBox TextBoxMinPing;
        private System.Windows.Forms.TextBox TextBoxMaxLoss;
        private System.Windows.Forms.TextBox TextBoxMaxJitter;
        private System.Windows.Forms.TextBox TextBoxAvgJitter;
        private System.Windows.Forms.TextBox TextBoxAvgLoss;
        private System.Windows.Forms.TextBox TextBoxMinLoss;
        private System.Windows.Forms.TextBox TextBoxMinJitter;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ButtonMenu;
        private System.Windows.Forms.Button ButtonCleanNetwork;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RTT;
    }
}
