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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
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
            this.picBoxRCLLogo = new System.Windows.Forms.PictureBox();
            this.picBoxEnlarged = new System.Windows.Forms.PictureBox();
            this.ButtonContainer = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.grpBoxPageSize.SuspendLayout();
            this.grpBoxResolution.SuspendLayout();
            this.grpBoxDocInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxRCLLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxEnlarged)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(820, 297);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(139, 39);
            this.btnScan.TabIndex = 0;
            this.btnScan.Text = "SCAN";
            this.btnScan.UseVisualStyleBackColor = true;
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
            this.MenuSettings.Click += new System.EventHandler(this.MenuSettings_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(52, 20);
            this.MenuAbout.Text = "About";
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
            this.btnExit.Location = new System.Drawing.Point(820, 36);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(139, 39);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpBoxPageSize
            // 
            this.grpBoxPageSize.Controls.Add(this.rbtnA3);
            this.grpBoxPageSize.Controls.Add(this.rbtnA4);
            this.grpBoxPageSize.Location = new System.Drawing.Point(9, 36);
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
            this.grpBoxResolution.Location = new System.Drawing.Point(92, 36);
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
            this.lblDocNumber.Location = new System.Drawing.Point(10, 34);
            this.lblDocNumber.Name = "lblDocNumber";
            this.lblDocNumber.Size = new System.Drawing.Size(96, 13);
            this.lblDocNumber.TabIndex = 8;
            this.lblDocNumber.Text = "Document Number";
            // 
            // txtDocNumber
            // 
            this.txtDocNumber.Location = new System.Drawing.Point(112, 31);
            this.txtDocNumber.Name = "txtDocNumber";
            this.txtDocNumber.Size = new System.Drawing.Size(200, 20);
            this.txtDocNumber.TabIndex = 9;
            // 
            // lblDocType
            // 
            this.lblDocType.AutoSize = true;
            this.lblDocType.Location = new System.Drawing.Point(10, 60);
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
            "INV"});
            this.cmbDocType.Location = new System.Drawing.Point(112, 57);
            this.cmbDocType.Name = "cmbDocType";
            this.cmbDocType.Size = new System.Drawing.Size(121, 21);
            this.cmbDocType.TabIndex = 11;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(112, 84);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 12;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(10, 84);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(78, 13);
            this.lblDate.TabIndex = 13;
            this.lblDate.Text = "Date Delivered";
            // 
            // btnProcess
            // 
            this.btnProcess.Location = new System.Drawing.Point(820, 413);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(139, 39);
            this.btnProcess.TabIndex = 15;
            this.btnProcess.Text = "PROCESS";
            this.btnProcess.UseVisualStyleBackColor = true;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // grpBoxDocInfo
            // 
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
            // 
            // picBoxRCLLogo
            // 
            this.picBoxRCLLogo.Image = global::RCLScanner.Properties.Resources.RCL_Logo_04202321;
            this.picBoxRCLLogo.Location = new System.Drawing.Point(12, 201);
            this.picBoxRCLLogo.Name = "picBoxRCLLogo";
            this.picBoxRCLLogo.Size = new System.Drawing.Size(150, 268);
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
            this.btnRefresh.Location = new System.Drawing.Point(820, 233);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(140, 40);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "REFRESH";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Visible = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(971, 464);
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
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(100, 150);
            this.MainMenuStrip = this.Menu;
            this.MaximumSize = new System.Drawing.Size(987, 503);
            this.MinimumSize = new System.Drawing.Size(987, 503);
            this.Name = "frmMain";
            this.Text = "RCL Scanner";
            this.Load += new System.EventHandler(this.frmMain_Load);
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
    }
}

