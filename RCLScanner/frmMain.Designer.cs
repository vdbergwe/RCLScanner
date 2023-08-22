namespace RCLScanner
{
    partial class frmMain
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
            this.btnScan = new System.Windows.Forms.Button();
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnExit = new System.Windows.Forms.Button();
            this.grpBoxPageSize = new System.Windows.Forms.GroupBox();
            this.rbtnA3 = new System.Windows.Forms.RadioButton();
            this.rbtnA4 = new System.Windows.Forms.RadioButton();
            this.grpBoxResolution = new System.Windows.Forms.GroupBox();
            this.rbtn300 = new System.Windows.Forms.RadioButton();
            this.rbtn150 = new System.Windows.Forms.RadioButton();
            this.lblDocNumber = new System.Windows.Forms.Label();
            this.txtDocNumber = new System.Windows.Forms.TextBox();
            this.lblDocType = new System.Windows.Forms.Label();
            this.cmbDocType = new System.Windows.Forms.ComboBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.btnProcess = new System.Windows.Forms.Button();
            this.grpBoxDocInfo = new System.Windows.Forms.GroupBox();
            this.txtBoxGRNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ButtonContainer = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.chkBoxUseADF = new System.Windows.Forms.CheckBox();
            this.cmbBoxScanners = new System.Windows.Forms.ComboBox();
            this.lblSelectedScanner = new System.Windows.Forms.Label();
            this.picBoxRCLLogo = new System.Windows.Forms.PictureBox();
            this.picBoxEnlarged = new System.Windows.Forms.PictureBox();
            this.cmbBoxScannerID = new System.Windows.Forms.ComboBox();
            this.btnImport = new System.Windows.Forms.Button();
            this.MainTimer = new System.Windows.Forms.Timer(this.components);
            this.MainStatusStrip = new System.Windows.Forms.StatusStrip();
            this.DateLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.OnlineTimer = new System.Windows.Forms.Timer(this.components);
            this.Preview = new System.Windows.Forms.GroupBox();
            this.rbtnBottom = new System.Windows.Forms.RadioButton();
            this.rbtnTop = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rbtnRight = new System.Windows.Forms.RadioButton();
            this.rbtnLeft = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rbtnLandscape = new System.Windows.Forms.RadioButton();
            this.rbtnPortrait = new System.Windows.Forms.RadioButton();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnRotateAnti = new System.Windows.Forms.Button();
            this.btnAddPage = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.grpBoxPageSize.SuspendLayout();
            this.grpBoxResolution.SuspendLayout();
            this.grpBoxDocInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRCLLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnlarged)).BeginInit();
            this.MainStatusStrip.SuspendLayout();
            this.Preview.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Location = new System.Drawing.Point(819, 302);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(139, 39);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseVisualStyleBackColor = false;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuSettings,
            this.MenuAbout});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(971, 24);
            this.Menu.TabIndex = 3;
            this.Menu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MenuSettings
            // 
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(61, 20);
            this.MenuSettings.Text = "Settings";
            this.MenuSettings.Visible = false;
            this.MenuSettings.Click += new System.EventHandler(this.MenuSettings_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(52, 20);
            this.MenuAbout.Text = "About";
            this.MenuAbout.Visible = false;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Tomato;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(820, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBoxPageSize
            // 
            this.grpBoxPageSize.Controls.Add(this.rbtnA3);
            this.grpBoxPageSize.Controls.Add(this.rbtnA4);
            this.grpBoxPageSize.Location = new System.Drawing.Point(9, 81);
            this.grpBoxPageSize.Name = "grpBoxPageSize";
            this.grpBoxPageSize.Size = new System.Drawing.Size(77, 86);
            this.grpBoxPageSize.TabIndex = 5;
            this.grpBoxPageSize.TabStop = false;
            this.grpBoxPageSize.Text = "Page Size";
            // 
            // rbtnA3
            // 
            this.rbtnA3.AutoSize = true;
            this.rbtnA3.Location = new System.Drawing.Point(16, 59);
            this.rbtnA3.Name = "rbtnA3";
            this.rbtnA3.Size = new System.Drawing.Size(38, 17);
            this.rbtnA3.TabIndex = 1;
            this.rbtnA3.Text = "A3";
            this.rbtnA3.UseVisualStyleBackColor = true;
            this.rbtnA3.CheckedChanged += new System.EventHandler(this.rbtnA3_CheckedChanged);
            // 
            // rbtnA4
            // 
            this.rbtnA4.AutoSize = true;
            this.rbtnA4.Checked = true;
            this.rbtnA4.Location = new System.Drawing.Point(16, 36);
            this.rbtnA4.Name = "rbtnA4";
            this.rbtnA4.Size = new System.Drawing.Size(38, 17);
            this.rbtnA4.TabIndex = 0;
            this.rbtnA4.TabStop = true;
            this.rbtnA4.Text = "A4";
            this.rbtnA4.UseVisualStyleBackColor = true;
            // 
            // grpBoxResolution
            // 
            this.grpBoxResolution.Controls.Add(this.rbtn300);
            this.grpBoxResolution.Controls.Add(this.rbtn150);
            this.grpBoxResolution.Location = new System.Drawing.Point(92, 81);
            this.grpBoxResolution.Name = "grpBoxResolution";
            this.grpBoxResolution.Size = new System.Drawing.Size(77, 86);
            this.grpBoxResolution.TabIndex = 6;
            this.grpBoxResolution.TabStop = false;
            this.grpBoxResolution.Text = "Resolution";
            // 
            // rbtn300
            // 
            this.rbtn300.AutoSize = true;
            this.rbtn300.Location = new System.Drawing.Point(16, 59);
            this.rbtn300.Name = "rbtn300";
            this.rbtn300.Size = new System.Drawing.Size(43, 17);
            this.rbtn300.TabIndex = 1;
            this.rbtn300.Text = "300";
            this.rbtn300.UseVisualStyleBackColor = true;
            // 
            // rbtn150
            // 
            this.rbtn150.AutoSize = true;
            this.rbtn150.Checked = true;
            this.rbtn150.Location = new System.Drawing.Point(16, 36);
            this.rbtn150.Name = "rbtn150";
            this.rbtn150.Size = new System.Drawing.Size(43, 17);
            this.rbtn150.TabIndex = 0;
            this.rbtn150.TabStop = true;
            this.rbtn150.Text = "150";
            this.rbtn150.UseVisualStyleBackColor = true;
            // 
            // lblDocNumber
            // 
            this.lblDocNumber.AutoSize = true;
            this.lblDocNumber.Location = new System.Drawing.Point(10, 16);
            this.lblDocNumber.Name = "lblDocNumber";
            this.lblDocNumber.Size = new System.Drawing.Size(96, 13);
            this.lblDocNumber.TabIndex = 8;
            this.lblDocNumber.Text = "Document Number";
            // 
            // txtDocNumber
            // 
            this.txtDocNumber.Location = new System.Drawing.Point(112, 13);
            this.txtDocNumber.Name = "txtDocNumber";
            this.txtDocNumber.Size = new System.Drawing.Size(200, 20);
            this.txtDocNumber.TabIndex = 9;
            // 
            // lblDocType
            // 
            this.lblDocType.AutoSize = true;
            this.lblDocType.Location = new System.Drawing.Point(10, 39);
            this.lblDocType.Name = "lblDocType";
            this.lblDocType.Size = new System.Drawing.Size(83, 13);
            this.lblDocType.TabIndex = 10;
            this.lblDocType.Text = "Document Type";
            // 
            // cmbDocType
            // 
            this.cmbDocType.FormattingEnabled = true;
            this.cmbDocType.Items.AddRange(new object[] {
            "POD",
            "INV",
            "REPL_POD"});
            this.cmbDocType.Location = new System.Drawing.Point(112, 36);
            this.cmbDocType.Name = "cmbDocType";
            this.cmbDocType.Size = new System.Drawing.Size(121, 21);
            this.cmbDocType.TabIndex = 11;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(112, 84);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 13;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(49, 13);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "GR Date";
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.Color.PaleGreen;
            this.btnProcess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProcess.Location = new System.Drawing.Point(820, 413);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(139, 39);
            this.btnProcess.TabIndex = 15;
            this.btnProcess.Text = "PROCESS";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // grpBoxDocInfo
            // 
            this.grpBoxDocInfo.Controls.Add(this.txtBoxGRNumber);
            this.grpBoxDocInfo.Controls.Add(this.label1);
            this.grpBoxDocInfo.Controls.Add(this.txtDocNumber);
            this.grpBoxDocInfo.Controls.Add(this.lblDocNumber);
            this.grpBoxDocInfo.Controls.Add(this.lblDate);
            this.grpBoxDocInfo.Controls.Add(this.lblDocType);
            this.grpBoxDocInfo.Controls.Add(this.dtpDate);
            this.grpBoxDocInfo.Controls.Add(this.cmbDocType);
            this.grpBoxDocInfo.Location = new System.Drawing.Point(413, 342);
            this.grpBoxDocInfo.Name = "grpBoxDocInfo";
            this.grpBoxDocInfo.Size = new System.Drawing.Size(400, 110);
            this.grpBoxDocInfo.TabIndex = 16;
            this.grpBoxDocInfo.TabStop = false;
            this.grpBoxDocInfo.Text = "Document Information";
            this.grpBoxDocInfo.Enter += new System.EventHandler(this.grpBoxDocInfo_Enter);
            // 
            // txtBoxGRNumber
            // 
            this.txtBoxGRNumber.Location = new System.Drawing.Point(112, 61);
            this.txtBoxGRNumber.Name = "txtBoxGRNumber";
            this.txtBoxGRNumber.Size = new System.Drawing.Size(200, 20);
            this.txtBoxGRNumber.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "GR Number";
            // 
            // ButtonContainer
            // 
            this.ButtonContainer.Location = new System.Drawing.Point(175, 36);
            this.ButtonContainer.Name = "ButtonContainer";
            this.ButtonContainer.Size = new System.Drawing.Size(230, 420);
            this.ButtonContainer.TabIndex = 17;
            this.ButtonContainer.TabStop = false;
            this.ButtonContainer.Text = "Pending Files";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefresh.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Location = new System.Drawing.Point(820, 185);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 40);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // chkBoxUseADF
            // 
            this.chkBoxUseADF.AutoSize = true;
            this.chkBoxUseADF.Checked = true;
            this.chkBoxUseADF.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBoxUseADF.FlatAppearance.BorderColor = System.Drawing.SystemColors.HighlightText;
            this.chkBoxUseADF.FlatAppearance.CheckedBackColor = System.Drawing.Color.Lime;
            this.chkBoxUseADF.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chkBoxUseADF.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkBoxUseADF.Location = new System.Drawing.Point(820, 276);
            this.chkBoxUseADF.Name = "chkBoxUseADF";
            this.chkBoxUseADF.Size = new System.Drawing.Size(146, 20);
            this.chkBoxUseADF.TabIndex = 18;
            this.chkBoxUseADF.Text = "Document Feeder";
            this.chkBoxUseADF.UseVisualStyleBackColor = true;
            // 
            // cmbBoxScanners
            // 
            this.cmbBoxScanners.FormattingEnabled = true;
            this.cmbBoxScanners.Location = new System.Drawing.Point(9, 54);
            this.cmbBoxScanners.Name = "cmbBoxScanners";
            this.cmbBoxScanners.Size = new System.Drawing.Size(160, 21);
            this.cmbBoxScanners.TabIndex = 19;
            // 
            // lblSelectedScanner
            // 
            this.lblSelectedScanner.AutoSize = true;
            this.lblSelectedScanner.Location = new System.Drawing.Point(9, 36);
            this.lblSelectedScanner.Name = "lblSelectedScanner";
            this.lblSelectedScanner.Size = new System.Drawing.Size(92, 13);
            this.lblSelectedScanner.TabIndex = 20;
            this.lblSelectedScanner.Text = "Selected Scanner";
            // 
            // picBoxRCLLogo
            // 
            this.picBoxRCLLogo.ErrorImage = null;
            this.picBoxRCLLogo.Image = global::RCLScanner.Properties.Resources.RCL_Logo_0420232;
            this.picBoxRCLLogo.InitialImage = null;
            this.picBoxRCLLogo.Location = new System.Drawing.Point(12, 215);
            this.picBoxRCLLogo.Name = "picBoxRCLLogo";
            this.picBoxRCLLogo.Size = new System.Drawing.Size(157, 254);
            this.picBoxRCLLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxRCLLogo.TabIndex = 7;
            this.picBoxRCLLogo.TabStop = false;
            // 
            // picBoxEnlarged
            // 
            this.picBoxEnlarged.Location = new System.Drawing.Point(413, 36);
            this.picBoxEnlarged.Name = "picBoxEnlarged";
            this.picBoxEnlarged.Size = new System.Drawing.Size(400, 300);
            this.picBoxEnlarged.TabIndex = 2;
            this.picBoxEnlarged.TabStop = false;
            // 
            // cmbBoxScannerID
            // 
            this.cmbBoxScannerID.FormattingEnabled = true;
            this.cmbBoxScannerID.Location = new System.Drawing.Point(814, 158);
            this.cmbBoxScannerID.Name = "cmbBoxScannerID";
            this.cmbBoxScannerID.Size = new System.Drawing.Size(157, 21);
            this.cmbBoxScannerID.TabIndex = 21;
            // 
            // btnImport
            // 
            this.btnImport.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnImport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnImport.Location = new System.Drawing.Point(820, 231);
            this.btnImport.Name = "btnImport";
            this.btnImport.Size = new System.Drawing.Size(140, 39);
            this.btnImport.TabIndex = 22;
            this.btnImport.Text = "IMPORT";
            this.btnImport.UseVisualStyleBackColor = false;
            this.btnImport.Click += new System.EventHandler(this.btnImport_Click);
            // 
            // MainTimer
            // 
            this.MainTimer.Enabled = true;
            this.MainTimer.Interval = 1000;
            this.MainTimer.Tick += new System.EventHandler(this.MainTimer_Tick);
            // 
            // MainStatusStrip
            // 
            this.MainStatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateLabel,
            this.StatusLabel});
            this.MainStatusStrip.Location = new System.Drawing.Point(0, 464);
            this.MainStatusStrip.Name = "MainStatusStrip";
            this.MainStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.MainStatusStrip.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MainStatusStrip.Size = new System.Drawing.Size(971, 22);
            this.MainStatusStrip.TabIndex = 23;
            this.MainStatusStrip.Text = "statusStrip1";
            // 
            // DateLabel
            // 
            this.DateLabel.Margin = new System.Windows.Forms.Padding(0, 3, 300, 2);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateLabel.Size = new System.Drawing.Size(118, 17);
            this.DateLabel.Text = "toolStripStatusLabel2";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StatusLabel.Size = new System.Drawing.Size(0, 17);
            // 
            // OnlineTimer
            // 
            this.OnlineTimer.Enabled = true;
            this.OnlineTimer.Interval = 5000;
            this.OnlineTimer.Tick += new System.EventHandler(this.OnlineTimer_Tick);
            // 
            // Preview
            // 
            this.Preview.Controls.Add(this.rbtnBottom);
            this.Preview.Controls.Add(this.rbtnTop);
            this.Preview.Location = new System.Drawing.Point(820, 65);
            this.Preview.Name = "Preview";
            this.Preview.Size = new System.Drawing.Size(68, 69);
            this.Preview.TabIndex = 24;
            this.Preview.TabStop = false;
            this.Preview.Text = "Preview";
            // 
            // rbtnBottom
            // 
            this.rbtnBottom.AutoSize = true;
            this.rbtnBottom.Location = new System.Drawing.Point(6, 39);
            this.rbtnBottom.Name = "rbtnBottom";
            this.rbtnBottom.Size = new System.Drawing.Size(58, 17);
            this.rbtnBottom.TabIndex = 1;
            this.rbtnBottom.Text = "Bottom";
            this.rbtnBottom.UseVisualStyleBackColor = true;
            this.rbtnBottom.CheckedChanged += new System.EventHandler(this.rbtnTop_CheckedChanged);
            // 
            // rbtnTop
            // 
            this.rbtnTop.AutoSize = true;
            this.rbtnTop.Checked = true;
            this.rbtnTop.Location = new System.Drawing.Point(6, 16);
            this.rbtnTop.Name = "rbtnTop";
            this.rbtnTop.Size = new System.Drawing.Size(44, 17);
            this.rbtnTop.TabIndex = 0;
            this.rbtnTop.TabStop = true;
            this.rbtnTop.Text = "Top";
            this.rbtnTop.UseVisualStyleBackColor = true;
            this.rbtnTop.CheckedChanged += new System.EventHandler(this.rbtnTop_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnRight);
            this.groupBox2.Controls.Add(this.rbtnLeft);
            this.groupBox2.Location = new System.Drawing.Point(894, 65);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(66, 69);
            this.groupBox2.TabIndex = 25;
            this.groupBox2.TabStop = false;
            // 
            // rbtnRight
            // 
            this.rbtnRight.AutoSize = true;
            this.rbtnRight.Checked = true;
            this.rbtnRight.Location = new System.Drawing.Point(6, 39);
            this.rbtnRight.Name = "rbtnRight";
            this.rbtnRight.Size = new System.Drawing.Size(50, 17);
            this.rbtnRight.TabIndex = 2;
            this.rbtnRight.TabStop = true;
            this.rbtnRight.Text = "Right";
            this.rbtnRight.UseVisualStyleBackColor = true;
            this.rbtnRight.CheckedChanged += new System.EventHandler(this.rbtnTop_CheckedChanged);
            // 
            // rbtnLeft
            // 
            this.rbtnLeft.AutoSize = true;
            this.rbtnLeft.Location = new System.Drawing.Point(6, 16);
            this.rbtnLeft.Name = "rbtnLeft";
            this.rbtnLeft.Size = new System.Drawing.Size(43, 17);
            this.rbtnLeft.TabIndex = 1;
            this.rbtnLeft.Text = "Left";
            this.rbtnLeft.UseVisualStyleBackColor = true;
            this.rbtnLeft.CheckedChanged += new System.EventHandler(this.rbtnTop_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnLandscape);
            this.groupBox3.Controls.Add(this.rbtnPortrait);
            this.groupBox3.Location = new System.Drawing.Point(12, 173);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(157, 36);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Orientation";
            // 
            // rbtnLandscape
            // 
            this.rbtnLandscape.AutoSize = true;
            this.rbtnLandscape.Checked = true;
            this.rbtnLandscape.Location = new System.Drawing.Point(73, 13);
            this.rbtnLandscape.Name = "rbtnLandscape";
            this.rbtnLandscape.Size = new System.Drawing.Size(78, 17);
            this.rbtnLandscape.TabIndex = 2;
            this.rbtnLandscape.TabStop = true;
            this.rbtnLandscape.Text = "Landscape";
            this.rbtnLandscape.UseVisualStyleBackColor = true;
            // 
            // rbtnPortrait
            // 
            this.rbtnPortrait.AutoSize = true;
            this.rbtnPortrait.Location = new System.Drawing.Point(6, 13);
            this.rbtnPortrait.Name = "rbtnPortrait";
            this.rbtnPortrait.Size = new System.Drawing.Size(58, 17);
            this.rbtnPortrait.TabIndex = 1;
            this.rbtnPortrait.Text = "Portrait";
            this.rbtnPortrait.UseVisualStyleBackColor = true;
            // 
            // btnRotate
            // 
            this.btnRotate.Location = new System.Drawing.Point(820, 141);
            this.btnRotate.Name = "btnRotate";
            this.btnRotate.Size = new System.Drawing.Size(139, 26);
            this.btnRotate.TabIndex = 27;
            this.btnRotate.Text = "90° Clockwise";
            this.btnRotate.UseVisualStyleBackColor = true;
            this.btnRotate.Click += new System.EventHandler(this.btnRotate_Click);
            // 
            // btnRotateAnti
            // 
            this.btnRotateAnti.Location = new System.Drawing.Point(820, 171);
            this.btnRotateAnti.Name = "btnRotateAnti";
            this.btnRotateAnti.Size = new System.Drawing.Size(139, 25);
            this.btnRotateAnti.TabIndex = 28;
            this.btnRotateAnti.Text = "90° Anti-Clockwise";
            this.btnRotateAnti.UseVisualStyleBackColor = true;
            this.btnRotateAnti.Click += new System.EventHandler(this.btnRotateAnti_Click);
            // 
            // btnAddPage
            // 
            this.btnAddPage.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAddPage.Enabled = false;
            this.btnAddPage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddPage.Location = new System.Drawing.Point(819, 368);
            this.btnAddPage.Name = "btnAddPage";
            this.btnAddPage.Size = new System.Drawing.Size(139, 39);
            this.btnAddPage.TabIndex = 29;
            this.btnAddPage.Text = "ADD PAGE";
            this.btnAddPage.UseVisualStyleBackColor = false;
            this.btnAddPage.Visible = false;
            this.btnAddPage.Click += new System.EventHandler(this.btnAddPage_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 486);
            this.Controls.Add(this.btnAddPage);
            this.Controls.Add(this.btnRotateAnti);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Preview);
            this.Controls.Add(this.MainStatusStrip);
            this.Controls.Add(this.btnImport);
            this.Controls.Add(this.cmbBoxScannerID);
            this.Controls.Add(this.lblSelectedScanner);
            this.Controls.Add(this.cmbBoxScanners);
            this.Controls.Add(this.chkBoxUseADF);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.ButtonContainer);
            this.Controls.Add(this.grpBoxDocInfo);
            this.Controls.Add(this.btnProcess);
            this.Controls.Add(this.picBoxRCLLogo);
            this.Controls.Add(this.grpBoxResolution);
            this.Controls.Add(this.grpBoxPageSize);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.picBoxEnlarged);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.Menu);
            this.Location = new System.Drawing.Point(100, 150);
            this.MainMenuStrip = this.Menu;
            this.MaximumSize = new System.Drawing.Size(987, 525);
            this.MinimumSize = new System.Drawing.Size(987, 525);
            this.Name = "frmMain";
            this.Text = "RCL Scanner";
            this.Load += new System.EventHandler(this.frmMain_LoadAsync);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.grpBoxPageSize.ResumeLayout(false);
            this.grpBoxPageSize.PerformLayout();
            this.grpBoxResolution.ResumeLayout(false);
            this.grpBoxResolution.PerformLayout();
            this.grpBoxDocInfo.ResumeLayout(false);
            this.grpBoxDocInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRCLLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnlarged)).EndInit();
            this.MainStatusStrip.ResumeLayout(false);
            this.MainStatusStrip.PerformLayout();
            this.Preview.ResumeLayout(false);
            this.Preview.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.PictureBox picBoxEnlarged;
        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox grpBoxPageSize;
        private System.Windows.Forms.RadioButton rbtnA3;
        private System.Windows.Forms.RadioButton rbtnA4;
        private System.Windows.Forms.GroupBox grpBoxResolution;
        private System.Windows.Forms.RadioButton rbtn300;
        private System.Windows.Forms.RadioButton rbtn150;
        private System.Windows.Forms.PictureBox picBoxRCLLogo;
        private System.Windows.Forms.Label lblDocNumber;
        private System.Windows.Forms.TextBox txtDocNumber;
        private System.Windows.Forms.Label lblDocType;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.GroupBox grpBoxDocInfo;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.GroupBox ButtonContainer;
        private System.Windows.Forms.Button btnRefresh;
        public System.Windows.Forms.ComboBox cmbDocType;
        private System.Windows.Forms.CheckBox chkBoxUseADF;
        private System.Windows.Forms.ComboBox cmbBoxScanners;
        private System.Windows.Forms.Label lblSelectedScanner;
        private System.Windows.Forms.ComboBox cmbBoxScannerID;
        private System.Windows.Forms.Button btnImport;
        private System.Windows.Forms.Timer MainTimer;
        private System.Windows.Forms.StatusStrip MainStatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel DateLabel;
        private System.Windows.Forms.Timer OnlineTimer;
        private System.Windows.Forms.GroupBox Preview;
        private System.Windows.Forms.RadioButton rbtnBottom;
        private System.Windows.Forms.RadioButton rbtnTop;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbtnRight;
        private System.Windows.Forms.RadioButton rbtnLeft;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtnLandscape;
        private System.Windows.Forms.RadioButton rbtnPortrait;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnRotateAnti;
        private System.Windows.Forms.Button btnAddPage;
        private System.Windows.Forms.TextBox txtBoxGRNumber;
        private System.Windows.Forms.Label label1;
    }
}

