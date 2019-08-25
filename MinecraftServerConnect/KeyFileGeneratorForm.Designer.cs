namespace MinecraftServerConnect
{
    partial class KeyFileGeneratorForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KeyFileGeneratorForm));
      this.rsaKeyFilePathTextBox = new System.Windows.Forms.TextBox();
      this.rsaKeyFilePathBrowseButton = new System.Windows.Forms.Button();
      this.serverIpDomainNameTextBox = new System.Windows.Forms.TextBox();
      this.rsaKeyGroupBox = new System.Windows.Forms.GroupBox();
      this.rsaKeyFileTypeComboBox = new System.Windows.Forms.ComboBox();
      this.serverGroupBox = new System.Windows.Forms.GroupBox();
      this.serverUserLabel = new System.Windows.Forms.Label();
      this.serverPortLabel = new System.Windows.Forms.Label();
      this.serverUserTextBox = new System.Windows.Forms.TextBox();
      this.serverPortTextBox = new System.Windows.Forms.TextBox();
      this.serverIpDomainNameLabel = new System.Windows.Forms.Label();
      this.exportGenerateButton = new System.Windows.Forms.Button();
      this.exportSaveFilePathTextBox = new System.Windows.Forms.TextBox();
      this.exportGroupBox = new System.Windows.Forms.GroupBox();
      this.exportSaltTextBox = new System.Windows.Forms.TextBox();
      this.exportPasswordTextBox = new System.Windows.Forms.TextBox();
      this.exportSaltLabel = new System.Windows.Forms.Label();
      this.exportPasswordLabel = new System.Windows.Forms.Label();
      this.exportSaveFilePathBrowseButton = new System.Windows.Forms.Button();
      this.rsaKeyFileBrowserDialog = new System.Windows.Forms.OpenFileDialog();
      this.exportSaveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.serverPortOverrideCheckBox = new System.Windows.Forms.CheckBox();
      this.rsaKeyGroupBox.SuspendLayout();
      this.serverGroupBox.SuspendLayout();
      this.exportGroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // rsaKeyFilePathTextBox
      // 
      this.rsaKeyFilePathTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rsaKeyFilePathTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
      this.rsaKeyFilePathTextBox.Location = new System.Drawing.Point(6, 22);
      this.rsaKeyFilePathTextBox.Name = "rsaKeyFilePathTextBox";
      this.rsaKeyFilePathTextBox.ReadOnly = true;
      this.rsaKeyFilePathTextBox.Size = new System.Drawing.Size(275, 20);
      this.rsaKeyFilePathTextBox.TabIndex = 0;
      this.rsaKeyFilePathTextBox.Text = " Choose File Path";
      // 
      // rsaKeyFilePathBrowseButton
      // 
      this.rsaKeyFilePathBrowseButton.Location = new System.Drawing.Point(287, 20);
      this.rsaKeyFilePathBrowseButton.Name = "rsaKeyFilePathBrowseButton";
      this.rsaKeyFilePathBrowseButton.Size = new System.Drawing.Size(68, 23);
      this.rsaKeyFilePathBrowseButton.TabIndex = 1;
      this.rsaKeyFilePathBrowseButton.Text = "Browse";
      this.rsaKeyFilePathBrowseButton.UseVisualStyleBackColor = true;
      this.rsaKeyFilePathBrowseButton.Click += new System.EventHandler(this.rsaKeyFilePathBrowseButton_Click);
      // 
      // serverIpDomainNameTextBox
      // 
      this.serverIpDomainNameTextBox.Location = new System.Drawing.Point(99, 19);
      this.serverIpDomainNameTextBox.Name = "serverIpDomainNameTextBox";
      this.serverIpDomainNameTextBox.Size = new System.Drawing.Size(255, 20);
      this.serverIpDomainNameTextBox.TabIndex = 2;
      // 
      // rsaKeyGroupBox
      // 
      this.rsaKeyGroupBox.Controls.Add(this.rsaKeyFileTypeComboBox);
      this.rsaKeyGroupBox.Controls.Add(this.rsaKeyFilePathTextBox);
      this.rsaKeyGroupBox.Controls.Add(this.rsaKeyFilePathBrowseButton);
      this.rsaKeyGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.rsaKeyGroupBox.Location = new System.Drawing.Point(11, 10);
      this.rsaKeyGroupBox.Name = "rsaKeyGroupBox";
      this.rsaKeyGroupBox.Size = new System.Drawing.Size(361, 88);
      this.rsaKeyGroupBox.TabIndex = 3;
      this.rsaKeyGroupBox.TabStop = false;
      this.rsaKeyGroupBox.Text = "RSA Key File";
      // 
      // rsaKeyFileTypeComboBox
      // 
      this.rsaKeyFileTypeComboBox.FormattingEnabled = true;
      this.rsaKeyFileTypeComboBox.Items.AddRange(new object[] {
            "PEM"});
      this.rsaKeyFileTypeComboBox.Location = new System.Drawing.Point(7, 53);
      this.rsaKeyFileTypeComboBox.Name = "rsaKeyFileTypeComboBox";
      this.rsaKeyFileTypeComboBox.Size = new System.Drawing.Size(87, 21);
      this.rsaKeyFileTypeComboBox.TabIndex = 2;
      this.rsaKeyFileTypeComboBox.Text = "Key File Type";
      // 
      // serverGroupBox
      // 
      this.serverGroupBox.Controls.Add(this.serverPortOverrideCheckBox);
      this.serverGroupBox.Controls.Add(this.serverUserLabel);
      this.serverGroupBox.Controls.Add(this.serverPortLabel);
      this.serverGroupBox.Controls.Add(this.serverUserTextBox);
      this.serverGroupBox.Controls.Add(this.serverPortTextBox);
      this.serverGroupBox.Controls.Add(this.serverIpDomainNameLabel);
      this.serverGroupBox.Controls.Add(this.serverIpDomainNameTextBox);
      this.serverGroupBox.Location = new System.Drawing.Point(12, 104);
      this.serverGroupBox.Name = "serverGroupBox";
      this.serverGroupBox.Size = new System.Drawing.Size(360, 104);
      this.serverGroupBox.TabIndex = 4;
      this.serverGroupBox.TabStop = false;
      this.serverGroupBox.Text = "Server";
      // 
      // serverUserLabel
      // 
      this.serverUserLabel.AutoSize = true;
      this.serverUserLabel.Location = new System.Drawing.Point(6, 76);
      this.serverUserLabel.Name = "serverUserLabel";
      this.serverUserLabel.Size = new System.Drawing.Size(29, 13);
      this.serverUserLabel.TabIndex = 7;
      this.serverUserLabel.Text = "User";
      // 
      // serverPortLabel
      // 
      this.serverPortLabel.AutoSize = true;
      this.serverPortLabel.Location = new System.Drawing.Point(6, 49);
      this.serverPortLabel.Name = "serverPortLabel";
      this.serverPortLabel.Size = new System.Drawing.Size(26, 13);
      this.serverPortLabel.TabIndex = 6;
      this.serverPortLabel.Text = "Port";
      // 
      // serverUserTextBox
      // 
      this.serverUserTextBox.Location = new System.Drawing.Point(99, 73);
      this.serverUserTextBox.Name = "serverUserTextBox";
      this.serverUserTextBox.Size = new System.Drawing.Size(100, 20);
      this.serverUserTextBox.TabIndex = 5;
      // 
      // serverPortTextBox
      // 
      this.serverPortTextBox.Location = new System.Drawing.Point(99, 46);
      this.serverPortTextBox.Name = "serverPortTextBox";
      this.serverPortTextBox.ReadOnly = true;
      this.serverPortTextBox.Size = new System.Drawing.Size(100, 20);
      this.serverPortTextBox.TabIndex = 4;
      this.serverPortTextBox.Text = "25565";
      // 
      // serverIpDomainNameLabel
      // 
      this.serverIpDomainNameLabel.AutoSize = true;
      this.serverIpDomainNameLabel.Location = new System.Drawing.Point(6, 22);
      this.serverIpDomainNameLabel.Name = "serverIpDomainNameLabel";
      this.serverIpDomainNameLabel.Size = new System.Drawing.Size(87, 13);
      this.serverIpDomainNameLabel.TabIndex = 3;
      this.serverIpDomainNameLabel.Text = "IP/Domain name";
      // 
      // exportGenerateButton
      // 
      this.exportGenerateButton.Location = new System.Drawing.Point(279, 82);
      this.exportGenerateButton.Name = "exportGenerateButton";
      this.exportGenerateButton.Size = new System.Drawing.Size(75, 23);
      this.exportGenerateButton.TabIndex = 5;
      this.exportGenerateButton.Text = "Generate";
      this.exportGenerateButton.UseVisualStyleBackColor = true;
      this.exportGenerateButton.Click += new System.EventHandler(this.exportGenerateButton_Click);
      // 
      // exportSaveFilePathTextBox
      // 
      this.exportSaveFilePathTextBox.ForeColor = System.Drawing.SystemColors.GrayText;
      this.exportSaveFilePathTextBox.Location = new System.Drawing.Point(6, 84);
      this.exportSaveFilePathTextBox.Name = "exportSaveFilePathTextBox";
      this.exportSaveFilePathTextBox.ReadOnly = true;
      this.exportSaveFilePathTextBox.Size = new System.Drawing.Size(194, 20);
      this.exportSaveFilePathTextBox.TabIndex = 6;
      this.exportSaveFilePathTextBox.Text = " Choose Save File Path";
      // 
      // exportGroupBox
      // 
      this.exportGroupBox.Controls.Add(this.exportSaltTextBox);
      this.exportGroupBox.Controls.Add(this.exportPasswordTextBox);
      this.exportGroupBox.Controls.Add(this.exportSaltLabel);
      this.exportGroupBox.Controls.Add(this.exportPasswordLabel);
      this.exportGroupBox.Controls.Add(this.exportSaveFilePathBrowseButton);
      this.exportGroupBox.Controls.Add(this.exportSaveFilePathTextBox);
      this.exportGroupBox.Controls.Add(this.exportGenerateButton);
      this.exportGroupBox.Location = new System.Drawing.Point(12, 214);
      this.exportGroupBox.Name = "exportGroupBox";
      this.exportGroupBox.Size = new System.Drawing.Size(360, 110);
      this.exportGroupBox.TabIndex = 7;
      this.exportGroupBox.TabStop = false;
      this.exportGroupBox.Text = "Export";
      // 
      // exportSaltTextBox
      // 
      this.exportSaltTextBox.Location = new System.Drawing.Point(99, 48);
      this.exportSaltTextBox.Name = "exportSaltTextBox";
      this.exportSaltTextBox.Size = new System.Drawing.Size(100, 20);
      this.exportSaltTextBox.TabIndex = 11;
      // 
      // exportPasswordTextBox
      // 
      this.exportPasswordTextBox.Location = new System.Drawing.Point(99, 19);
      this.exportPasswordTextBox.Name = "exportPasswordTextBox";
      this.exportPasswordTextBox.Size = new System.Drawing.Size(255, 20);
      this.exportPasswordTextBox.TabIndex = 10;
      // 
      // exportSaltLabel
      // 
      this.exportSaltLabel.AutoSize = true;
      this.exportSaltLabel.Location = new System.Drawing.Point(6, 51);
      this.exportSaltLabel.Name = "exportSaltLabel";
      this.exportSaltLabel.Size = new System.Drawing.Size(71, 13);
      this.exportSaltLabel.TabIndex = 9;
      this.exportSaltLabel.Text = "Salt (optional)";
      // 
      // exportPasswordLabel
      // 
      this.exportPasswordLabel.AutoSize = true;
      this.exportPasswordLabel.Location = new System.Drawing.Point(6, 22);
      this.exportPasswordLabel.Name = "exportPasswordLabel";
      this.exportPasswordLabel.Size = new System.Drawing.Size(62, 13);
      this.exportPasswordLabel.TabIndex = 8;
      this.exportPasswordLabel.Text = "Passphrase";
      // 
      // exportSaveFilePathBrowseButton
      // 
      this.exportSaveFilePathBrowseButton.Location = new System.Drawing.Point(205, 82);
      this.exportSaveFilePathBrowseButton.Name = "exportSaveFilePathBrowseButton";
      this.exportSaveFilePathBrowseButton.Size = new System.Drawing.Size(68, 23);
      this.exportSaveFilePathBrowseButton.TabIndex = 7;
      this.exportSaveFilePathBrowseButton.Text = "Browse";
      this.exportSaveFilePathBrowseButton.UseVisualStyleBackColor = true;
      this.exportSaveFilePathBrowseButton.Click += new System.EventHandler(this.exportSaveFilePathBrowseButton_Click);
      // 
      // rsaKeyFileBrowserDialog
      // 
      this.rsaKeyFileBrowserDialog.FileName = "openFileDialog1";
      this.rsaKeyFileBrowserDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.rsaKeyFileBrowserDialog_FileOk);
      // 
      // exportSaveFileDialog
      // 
      this.exportSaveFileDialog.FileName = "minecraft.key.mskf";
      this.exportSaveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.exportSaveFileDialog_FileOk);
      // 
      // serverPortOverrideCheckBox
      // 
      this.serverPortOverrideCheckBox.AutoSize = true;
      this.serverPortOverrideCheckBox.Location = new System.Drawing.Point(205, 48);
      this.serverPortOverrideCheckBox.Name = "serverPortOverrideCheckBox";
      this.serverPortOverrideCheckBox.Size = new System.Drawing.Size(66, 17);
      this.serverPortOverrideCheckBox.TabIndex = 8;
      this.serverPortOverrideCheckBox.Text = "Override";
      this.serverPortOverrideCheckBox.UseVisualStyleBackColor = true;
      this.serverPortOverrideCheckBox.CheckedChanged += new System.EventHandler(this.serverPortOverrideCheckBox_CheckedChanged);
      // 
      // KeyFileGeneratorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(384, 336);
      this.Controls.Add(this.exportGroupBox);
      this.Controls.Add(this.serverGroupBox);
      this.Controls.Add(this.rsaKeyGroupBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MaximizeBox = false;
      this.Name = "KeyFileGeneratorForm";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Generate Minecraft Key File";
      this.rsaKeyGroupBox.ResumeLayout(false);
      this.rsaKeyGroupBox.PerformLayout();
      this.serverGroupBox.ResumeLayout(false);
      this.serverGroupBox.PerformLayout();
      this.exportGroupBox.ResumeLayout(false);
      this.exportGroupBox.PerformLayout();
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox rsaKeyFilePathTextBox;
        private System.Windows.Forms.Button rsaKeyFilePathBrowseButton;
        private System.Windows.Forms.TextBox serverIpDomainNameTextBox;
        private System.Windows.Forms.GroupBox rsaKeyGroupBox;
        private System.Windows.Forms.ComboBox rsaKeyFileTypeComboBox;
        private System.Windows.Forms.GroupBox serverGroupBox;
        private System.Windows.Forms.Label serverUserLabel;
        private System.Windows.Forms.Label serverPortLabel;
        private System.Windows.Forms.TextBox serverUserTextBox;
        private System.Windows.Forms.TextBox serverPortTextBox;
        private System.Windows.Forms.Label serverIpDomainNameLabel;
        private System.Windows.Forms.Button exportGenerateButton;
        private System.Windows.Forms.TextBox exportSaveFilePathTextBox;
        private System.Windows.Forms.GroupBox exportGroupBox;
        private System.Windows.Forms.Button exportSaveFilePathBrowseButton;
        private System.Windows.Forms.OpenFileDialog rsaKeyFileBrowserDialog;
        private System.Windows.Forms.SaveFileDialog exportSaveFileDialog;
        private System.Windows.Forms.TextBox exportSaltTextBox;
        private System.Windows.Forms.TextBox exportPasswordTextBox;
        private System.Windows.Forms.Label exportSaltLabel;
        private System.Windows.Forms.Label exportPasswordLabel;
    private System.Windows.Forms.CheckBox serverPortOverrideCheckBox;
  }
}