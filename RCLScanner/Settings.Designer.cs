
namespace RCLScanner
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.Menu = new System.Windows.Forms.MenuStrip();
            this.MenuFile = new System.Windows.Forms.ToolStripMenuItem();
            this.newScanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.lblWorkstationID = new System.Windows.Forms.Label();
            this.txtBoxWorkstationID = new System.Windows.Forms.TextBox();
            this.txtBoxScanDirectory = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxUploadDirectory = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxHistoryDirectory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // Menu
            // 
            this.Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuFile,
            this.MenuAbout});
            this.Menu.Location = new System.Drawing.Point(0, 0);
            this.Menu.Name = "Menu";
            this.Menu.Size = new System.Drawing.Size(344, 24);
            this.Menu.TabIndex = 4;
            this.Menu.Text = "menuStrip1";
            // 
            // MenuFile
            // 
            this.MenuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newScanToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.MenuFile.Name = "MenuFile";
            this.MenuFile.Size = new System.Drawing.Size(37, 20);
            this.MenuFile.Text = "File";
            // 
            // newScanToolStripMenuItem
            // 
            this.newScanToolStripMenuItem.Name = "newScanToolStripMenuItem";
            this.newScanToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.newScanToolStripMenuItem.Text = "New Scan";
            this.newScanToolStripMenuItem.Click += new System.EventHandler(this.newScanToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // MenuAbout
            // 
            this.MenuAbout.Name = "MenuAbout";
            this.MenuAbout.Size = new System.Drawing.Size(52, 20);
            this.MenuAbout.Text = "About";
            // 
            // lblWorkstationID
            // 
            this.lblWorkstationID.AutoSize = true;
            this.lblWorkstationID.Location = new System.Drawing.Point(38, 58);
            this.lblWorkstationID.Name = "lblWorkstationID";
            this.lblWorkstationID.Size = new System.Drawing.Size(78, 13);
            this.lblWorkstationID.TabIndex = 5;
            this.lblWorkstationID.Text = "Workstation ID";
            // 
            // txtBoxWorkstationID
            // 
            this.txtBoxWorkstationID.Location = new System.Drawing.Point(128, 55);
            this.txtBoxWorkstationID.Name = "txtBoxWorkstationID";
            this.txtBoxWorkstationID.Size = new System.Drawing.Size(195, 20);
            this.txtBoxWorkstationID.TabIndex = 6;
            // 
            // txtBoxScanDirectory
            // 
            this.txtBoxScanDirectory.Location = new System.Drawing.Point(128, 81);
            this.txtBoxScanDirectory.Name = "txtBoxScanDirectory";
            this.txtBoxScanDirectory.Size = new System.Drawing.Size(195, 20);
            this.txtBoxScanDirectory.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Scan Directory";
            // 
            // txtBoxUploadDirectory
            // 
            this.txtBoxUploadDirectory.Location = new System.Drawing.Point(128, 107);
            this.txtBoxUploadDirectory.Name = "txtBoxUploadDirectory";
            this.txtBoxUploadDirectory.Size = new System.Drawing.Size(195, 20);
            this.txtBoxUploadDirectory.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Upload Directory";
            // 
            // txtBoxHistoryDirectory
            // 
            this.txtBoxHistoryDirectory.Location = new System.Drawing.Point(128, 133);
            this.txtBoxHistoryDirectory.Name = "txtBoxHistoryDirectory";
            this.txtBoxHistoryDirectory.Size = new System.Drawing.Size(195, 20);
            this.txtBoxHistoryDirectory.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "History Directory";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(207, 159);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 45);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 219);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtBoxHistoryDirectory);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxUploadDirectory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxScanDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxWorkstationID);
            this.Controls.Add(this.lblWorkstationID);
            this.Controls.Add(this.Menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "RCL Scanner - Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.Menu.ResumeLayout(false);
            this.Menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip Menu;
        private System.Windows.Forms.ToolStripMenuItem MenuFile;
        private System.Windows.Forms.ToolStripMenuItem MenuAbout;
        private System.Windows.Forms.ToolStripMenuItem newScanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label lblWorkstationID;
        private System.Windows.Forms.TextBox txtBoxWorkstationID;
        private System.Windows.Forms.TextBox txtBoxScanDirectory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxUploadDirectory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxHistoryDirectory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
    }
}