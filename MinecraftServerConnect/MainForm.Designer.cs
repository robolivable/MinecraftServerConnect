using System;
namespace MinecraftServerConnect
{
    partial class MainForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
      this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.generateKeyFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.configToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.connectButton = new System.Windows.Forms.Button();
      this.openKeyFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.disconnectButton = new System.Windows.Forms.Button();
      this.connectionDelegate = new System.ComponentModel.BackgroundWorker();
      this.statusStrip = new System.Windows.Forms.StatusStrip();
      this.connectedStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
      this.passphraseTextBox = new System.Windows.Forms.TextBox();
      this.saltTextBox = new System.Windows.Forms.TextBox();
      this.connectAsServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mainMenuStrip.SuspendLayout();
      this.statusStrip.SuspendLayout();
      this.SuspendLayout();
      // 
      // mainMenuStrip
      // 
      this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem,
            this.configToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
      this.mainMenuStrip.Name = "mainMenuStrip";
      this.mainMenuStrip.Size = new System.Drawing.Size(784, 24);
      this.mainMenuStrip.TabIndex = 0;
      this.mainMenuStrip.Text = "mainMenuStrip";
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateKeyFileToolStripMenuItem,
            this.connectAsServerToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
      this.toolsToolStripMenuItem.Text = "Tools";
      // 
      // generateKeyFileToolStripMenuItem
      // 
      this.generateKeyFileToolStripMenuItem.Name = "generateKeyFileToolStripMenuItem";
      this.generateKeyFileToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.generateKeyFileToolStripMenuItem.Text = "Generate Minecraft Key File";
      this.generateKeyFileToolStripMenuItem.Click += new System.EventHandler(this.generateKeyFileToolStripMenuItem_Click);
      // 
      // configToolStripMenuItem
      // 
      this.configToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.advancedToolStripMenuItem});
      this.configToolStripMenuItem.Name = "configToolStripMenuItem";
      this.configToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
      this.configToolStripMenuItem.Text = "Config";
      this.configToolStripMenuItem.Visible = false;
      // 
      // advancedToolStripMenuItem
      // 
      this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
      this.advancedToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
      this.advancedToolStripMenuItem.Text = "Advanced";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      this.helpToolStripMenuItem.Visible = false;
      // 
      // connectButton
      // 
      this.connectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.connectButton.Location = new System.Drawing.Point(12, 301);
      this.connectButton.Name = "connectButton";
      this.connectButton.Size = new System.Drawing.Size(760, 37);
      this.connectButton.TabIndex = 1;
      this.connectButton.Text = "Connect Using Minecraft Key File";
      this.connectButton.UseVisualStyleBackColor = true;
      this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
      // 
      // openKeyFileDialog
      // 
      this.openKeyFileDialog.FileName = "minecraft.key.file";
      this.openKeyFileDialog.InitialDirectory = "C:\\Users\\rldeo\\Desktop";
      this.openKeyFileDialog.Title = "Open Minecraft Key File";
      this.openKeyFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openKeyFileDialog_FileOk);
      // 
      // disconnectButton
      // 
      this.disconnectButton.Enabled = false;
      this.disconnectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.disconnectButton.Location = new System.Drawing.Point(12, 344);
      this.disconnectButton.Name = "disconnectButton";
      this.disconnectButton.Size = new System.Drawing.Size(760, 33);
      this.disconnectButton.TabIndex = 2;
      this.disconnectButton.Text = "Disconnect";
      this.disconnectButton.UseVisualStyleBackColor = true;
      this.disconnectButton.Click += new System.EventHandler(this.disconnectButton_Click);
      // 
      // connectionDelegate
      // 
      this.connectionDelegate.DoWork += new System.ComponentModel.DoWorkEventHandler(this.connectionDelegate_DoWork);
      // 
      // statusStrip
      // 
      this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectedStripStatusLabel});
      this.statusStrip.Location = new System.Drawing.Point(0, 389);
      this.statusStrip.Name = "statusStrip";
      this.statusStrip.Size = new System.Drawing.Size(784, 22);
      this.statusStrip.SizingGrip = false;
      this.statusStrip.TabIndex = 3;
      this.statusStrip.Text = "statusStrip";
      // 
      // connectedStripStatusLabel
      // 
      this.connectedStripStatusLabel.Name = "connectedStripStatusLabel";
      this.connectedStripStatusLabel.Size = new System.Drawing.Size(88, 17);
      this.connectedStripStatusLabel.Text = "Not Connected";
      // 
      // passphraseTextBox
      // 
      this.passphraseTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.passphraseTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
      this.passphraseTextBox.Location = new System.Drawing.Point(195, 269);
      this.passphraseTextBox.Name = "passphraseTextBox";
      this.passphraseTextBox.Size = new System.Drawing.Size(265, 26);
      this.passphraseTextBox.TabIndex = 4;
      this.passphraseTextBox.Text = "Enter Passphrase";
      this.passphraseTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.passphraseTextBox.TextChanged += new System.EventHandler(this.passphraseTextBox_TextChanged);
      this.passphraseTextBox.Enter += new System.EventHandler(this.passphraseTextBox_Enter);
      this.passphraseTextBox.Leave += new System.EventHandler(this.passphraseTextBox_Leave);
      // 
      // saltTextBox
      // 
      this.saltTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.saltTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
      this.saltTextBox.Location = new System.Drawing.Point(466, 269);
      this.saltTextBox.Name = "saltTextBox";
      this.saltTextBox.Size = new System.Drawing.Size(130, 26);
      this.saltTextBox.TabIndex = 5;
      this.saltTextBox.Text = "Salt (optional)";
      this.saltTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.saltTextBox.TextChanged += new System.EventHandler(this.saltTextBox_TextChanged);
      this.saltTextBox.Enter += new System.EventHandler(this.saltTextBox_Enter);
      this.saltTextBox.Leave += new System.EventHandler(this.saltTextBox_Leave);
      // 
      // connectAsServerToolStripMenuItem
      // 
      this.connectAsServerToolStripMenuItem.Name = "connectAsServerToolStripMenuItem";
      this.connectAsServerToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
      this.connectAsServerToolStripMenuItem.Text = "Connect As Server";
      this.connectAsServerToolStripMenuItem.Click += new System.EventHandler(this.connectAsServerToolStripMenuItem_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
      this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.ClientSize = new System.Drawing.Size(784, 411);
      this.Controls.Add(this.saltTextBox);
      this.Controls.Add(this.passphraseTextBox);
      this.Controls.Add(this.statusStrip);
      this.Controls.Add(this.disconnectButton);
      this.Controls.Add(this.connectButton);
      this.Controls.Add(this.mainMenuStrip);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.mainMenuStrip;
      this.MaximizeBox = false;
      this.Name = "MainForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Minecraft Server Secure Connect";
      this.mainMenuStrip.ResumeLayout(false);
      this.mainMenuStrip.PerformLayout();
      this.statusStrip.ResumeLayout(false);
      this.statusStrip.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateKeyFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.OpenFileDialog openKeyFileDialog;
        private System.Windows.Forms.Button disconnectButton;
        private System.ComponentModel.BackgroundWorker connectionDelegate;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel connectedStripStatusLabel;
        private System.Windows.Forms.TextBox passphraseTextBox;
        private System.Windows.Forms.TextBox saltTextBox;
    private System.Windows.Forms.ToolStripMenuItem connectAsServerToolStripMenuItem;
  }
}

