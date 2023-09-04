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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle26 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle27 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle28 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle25 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridViewPing = new System.Windows.Forms.DataGridView();
            this.MinPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvgPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaxPing = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.LOGOCF)).BeginInit();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPing)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxInterval
            // 
            this.textBoxInterval.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxInterval.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxInterval.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxInterval.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxInterval.ForeColor = System.Drawing.SystemColors.MenuHighlight;
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
            this.LOGOCF.Location = new System.Drawing.Point(662, 662);
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
            this.textBoxPacketLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxPacketLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxPacketLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPacketLoss.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxPacketLoss.Location = new System.Drawing.Point(122, 9);
            this.textBoxPacketLoss.Name = "textBoxPacketLoss";
            this.textBoxPacketLoss.ReadOnly = true;
            this.textBoxPacketLoss.Size = new System.Drawing.Size(54, 16);
            this.textBoxPacketLoss.TabIndex = 33;
            this.textBoxPacketLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxJitter
            // 
            this.textBoxJitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBoxJitter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxJitter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxJitter.Location = new System.Drawing.Point(122, 42);
            this.textBoxJitter.Name = "textBoxJitter";
            this.textBoxJitter.ReadOnly = true;
            this.textBoxJitter.Size = new System.Drawing.Size(54, 16);
            this.textBoxJitter.TabIndex = 34;
            this.textBoxJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxJitter.TextChanged += new System.EventHandler(this.TextBoxJitter_TextChanged);
            // 
            // labelPacketLoss
            // 
            this.labelPacketLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPacketLoss.AutoSize = true;
            this.labelPacketLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPacketLoss.Location = new System.Drawing.Point(5, 8);
            this.labelPacketLoss.Name = "labelPacketLoss";
            this.labelPacketLoss.Size = new System.Drawing.Size(109, 18);
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
            this.labelJitter.Location = new System.Drawing.Point(5, 41);
            this.labelJitter.Name = "labelJitter";
            this.labelJitter.Size = new System.Drawing.Size(109, 18);
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
            this.ipAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ipAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ipAddress.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ipAddress.ForeColor = System.Drawing.SystemColors.Highlight;
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
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
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
            this.ButtonNetworkAdapters.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonNetworkAdapters.AutoSize = true;
            this.ButtonNetworkAdapters.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ButtonNetworkAdapters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonNetworkAdapters.FlatAppearance.BorderSize = 0;
            this.ButtonNetworkAdapters.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
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
            this.buttonCleanTemp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCleanTemp.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCleanTemp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.buttonCleanTemp.FlatAppearance.BorderSize = 0;
            this.buttonCleanTemp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCleanTemp.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCleanTemp.ForeColor = System.Drawing.SystemColors.HotTrack;
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
            this.tableLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.Controls.Add(this.ipAddress, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxInterval, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(9, 34);
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
            this.ButtonMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonMenu.FlatAppearance.BorderSize = 0;
            this.ButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMenu.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonMenu.ForeColor = System.Drawing.SystemColors.HotTrack;
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
            this.ButtonCleanNetwork.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ButtonCleanNetwork.FlatAppearance.BorderSize = 0;
            this.ButtonCleanNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonCleanNetwork.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCleanNetwork.ForeColor = System.Drawing.SystemColors.HotTrack;
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
            this.TextBoxMaxLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxMaxLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMaxLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMaxLoss.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxMaxLoss.Location = new System.Drawing.Point(308, 9);
            this.TextBoxMaxLoss.Name = "TextBoxMaxLoss";
            this.TextBoxMaxLoss.Size = new System.Drawing.Size(56, 16);
            this.TextBoxMaxLoss.TabIndex = 52;
            this.TextBoxMaxLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMaxJitter
            // 
            this.TextBoxMaxJitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMaxJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxMaxJitter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMaxJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMaxJitter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxMaxJitter.Location = new System.Drawing.Point(308, 42);
            this.TextBoxMaxJitter.Name = "TextBoxMaxJitter";
            this.TextBoxMaxJitter.Size = new System.Drawing.Size(56, 16);
            this.TextBoxMaxJitter.TabIndex = 52;
            this.TextBoxMaxJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAvgJitter
            // 
            this.TextBoxAvgJitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAvgJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxAvgJitter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAvgJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAvgJitter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxAvgJitter.Location = new System.Drawing.Point(246, 42);
            this.TextBoxAvgJitter.Name = "TextBoxAvgJitter";
            this.TextBoxAvgJitter.Size = new System.Drawing.Size(54, 16);
            this.TextBoxAvgJitter.TabIndex = 51;
            this.TextBoxAvgJitter.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxAvgLoss
            // 
            this.TextBoxAvgLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxAvgLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxAvgLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxAvgLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxAvgLoss.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxAvgLoss.Location = new System.Drawing.Point(246, 9);
            this.TextBoxAvgLoss.Name = "TextBoxAvgLoss";
            this.TextBoxAvgLoss.Size = new System.Drawing.Size(54, 16);
            this.TextBoxAvgLoss.TabIndex = 51;
            this.TextBoxAvgLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMinLoss
            // 
            this.TextBoxMinLoss.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMinLoss.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxMinLoss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMinLoss.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMinLoss.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxMinLoss.Location = new System.Drawing.Point(184, 9);
            this.TextBoxMinLoss.Name = "TextBoxMinLoss";
            this.TextBoxMinLoss.Size = new System.Drawing.Size(54, 16);
            this.TextBoxMinLoss.TabIndex = 50;
            this.TextBoxMinLoss.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TextBoxMinJitter
            // 
            this.TextBoxMinJitter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TextBoxMinJitter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBoxMinJitter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TextBoxMinJitter.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxMinJitter.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TextBoxMinJitter.Location = new System.Drawing.Point(184, 42);
            this.TextBoxMinJitter.Name = "TextBoxMinJitter";
            this.TextBoxMinJitter.Size = new System.Drawing.Size(54, 16);
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
            this.tableLayoutPanel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.buttonCleanTemp, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonCleanNetwork, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.ButtonNetworkAdapters, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.ButtonMenu, 1, 1);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(377, 34);
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
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle15;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle16.NullValue = null;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Time,
            this.Status,
            this.RTT});
            dataGridViewCellStyle20.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle20.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle20.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle20.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(9, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle21;
            this.dataGridView1.RowHeadersVisible = false;
            dataGridViewCellStyle22.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle22.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dataGridView1.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridView1.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridView1.Size = new System.Drawing.Size(679, 487);
            this.dataGridView1.TabIndex = 59;
            this.dataGridView1.TabStop = false;
            // 
            // Time
            // 
            this.Time.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Time.DefaultCellStyle = dataGridViewCellStyle17;
            this.Time.HeaderText = "Time";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 71;
            // 
            // Status
            // 
            this.Status.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status.DefaultCellStyle = dataGridViewCellStyle18;
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // RTT
            // 
            this.RTT.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.RTT.DefaultCellStyle = dataGridViewCellStyle19;
            this.RTT.HeaderText = "RTT";
            this.RTT.Name = "RTT";
            this.RTT.ReadOnly = true;
            this.RTT.Width = 62;
            // 
            // dataGridViewPing
            // 
            this.dataGridViewPing.AllowUserToAddRows = false;
            this.dataGridViewPing.AllowUserToDeleteRows = false;
            this.dataGridViewPing.AllowUserToResizeColumns = false;
            this.dataGridViewPing.AllowUserToResizeRows = false;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle23.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPing.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle23;
            this.dataGridViewPing.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridViewPing.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle24.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle24.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle24.NullValue = null;
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPing.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle24;
            this.dataGridViewPing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MinPing,
            this.AvgPing,
            this.MaxPing});
            dataGridViewCellStyle26.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle26.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            dataGridViewCellStyle26.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle26.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle26.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle26.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle26.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPing.DefaultCellStyle = dataGridViewCellStyle26;
            this.dataGridViewPing.EnableHeadersVisualStyles = false;
            this.dataGridViewPing.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPing.Location = new System.Drawing.Point(473, 605);
            this.dataGridViewPing.Name = "dataGridViewPing";
            this.dataGridViewPing.ReadOnly = true;
            dataGridViewCellStyle27.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle27.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle27.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle27.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            dataGridViewCellStyle27.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle27.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle27.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPing.RowHeadersDefaultCellStyle = dataGridViewCellStyle27;
            this.dataGridViewPing.RowHeadersVisible = false;
            dataGridViewCellStyle28.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle28.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle28.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle28.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridViewPing.RowsDefaultCellStyle = dataGridViewCellStyle28;
            this.dataGridViewPing.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dataGridViewPing.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.Black;
            this.dataGridViewPing.Size = new System.Drawing.Size(216, 51);
            this.dataGridViewPing.TabIndex = 60;
            this.dataGridViewPing.TabStop = false;
            // 
            // MinPing
            // 
            dataGridViewCellStyle25.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.MinPing.DefaultCellStyle = dataGridViewCellStyle25;
            this.MinPing.HeaderText = "Min.";
            this.MinPing.Name = "MinPing";
            this.MinPing.ReadOnly = true;
            this.MinPing.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.MinPing.Width = 71;
            // 
            // AvgPing
            // 
            this.AvgPing.HeaderText = "Avg.";
            this.AvgPing.Name = "AvgPing";
            this.AvgPing.ReadOnly = true;
            this.AvgPing.Width = 71;
            // 
            // MaxPing
            // 
            this.MaxPing.HeaderText = "Max.";
            this.MaxPing.Name = "MaxPing";
            this.MaxPing.ReadOnly = true;
            this.MaxPing.Width = 71;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tableLayoutPanel5.ColumnCount = 5;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel5.Controls.Add(this.labelJitter, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.labelPacketLoss, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxPacketLoss, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.textBoxJitter, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxAvgLoss, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxMaxLoss, 4, 0);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxMaxJitter, 4, 1);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxAvgJitter, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxMinJitter, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.TextBoxMinLoss, 2, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(12, 608);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 2;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(369, 68);
            this.tableLayoutPanel5.TabIndex = 61;
            // 
            // FormPinger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(700, 700);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.dataGridViewPing);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LOGOCF);
            this.Controls.Add(this.COPYRIGHT);
            this.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormPinger";
            this.Text = "   ";
            this.Load += new System.EventHandler(this.FormPinger_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LOGOCF)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPing)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn RTT;
        private System.Windows.Forms.DataGridView dataGridViewPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn MinPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn AvgPing;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaxPing;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}
