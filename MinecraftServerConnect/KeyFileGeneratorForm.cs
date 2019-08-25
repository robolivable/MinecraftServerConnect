using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MinecraftServerConnect {
  public partial class KeyFileGeneratorForm : Form {
    private string rsaKeyFilePath;
    private string minecraftKeyFilePath;
    public KeyFileGeneratorForm() {
      InitializeComponent();
      this.rsaKeyFileTypeComboBox.SelectedIndex = 0;
    }

    private void exportGenerateButton_Click(object sender, EventArgs e) {
      if (this.rsaKeyFilePath == null) {
        MessageBox.Show(
          ClientConfig.MessageBoxDefaults.KeyFileGeneratorFormDefaults.RSAKeyFileEmptyMessageBox.Message,
          ClientConfig.MessageBoxDefaults.KeyFileGeneratorFormDefaults.RSAKeyFileEmptyMessageBox.Caption, 
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation
        );
        return;
      }
      if (this.minecraftKeyFilePath == null) {
        MessageBox.Show(
          ClientConfig.MessageBoxDefaults.KeyFileGeneratorFormDefaults.ExportKeyFileEmptyMessageBox.Message, 
          ClientConfig.MessageBoxDefaults.KeyFileGeneratorFormDefaults.ExportKeyFileEmptyMessageBox.Caption, 
          MessageBoxButtons.OK, MessageBoxIcon.Exclamation
        );
        return;
      }
      string keyFileType = rsaKeyFileTypeComboBox.SelectedItem.ToString();
      string domainValue = serverIpDomainNameTextBox.Text;
      string port = serverPortTextBox.Text;
      string user = serverUserTextBox.Text;
      string privateKey = KeyFile.ParsePrivateKey(this.rsaKeyFilePath, KeyFile.Type(keyFileType));
      string passphrase = exportPasswordTextBox.Text;
      string salt = exportSaltTextBox.Text;
      string values = String.Join("|", new string[] { keyFileType, domainValue, port, user, privateKey });
      byte[] encrypted = Crypto.encrypt(values, passphrase, salt);
      File.WriteAllBytes(this.minecraftKeyFilePath, encrypted);
      MessageBox.Show(
        ClientConfig.MessageBoxDefaults.KeyFileGeneratorFormDefaults.KeyFileExportedMessageBox.Message,
        ClientConfig.MessageBoxDefaults.KeyFileGeneratorFormDefaults.KeyFileExportedMessageBox.Caption,
        MessageBoxButtons.OK, MessageBoxIcon.Asterisk
      );
    }

    private void rsaKeyFilePathBrowseButton_Click(object sender, EventArgs e) {
      rsaKeyFileBrowserDialog.ShowDialog();
    }

    private void rsaKeyFileBrowserDialog_FileOk(object sender, CancelEventArgs e) {
      this.rsaKeyFilePath = rsaKeyFileBrowserDialog.FileName;
      rsaKeyFilePathTextBox.Text = this.rsaKeyFilePath;

    }

    private void exportSaveFilePathBrowseButton_Click(object sender, EventArgs e) {
      exportSaveFileDialog.ShowDialog();
    }

    private void exportSaveFileDialog_FileOk(object sender, CancelEventArgs e) {
      this.minecraftKeyFilePath = exportSaveFileDialog.FileName;
      exportSaveFilePathTextBox.Text = this.minecraftKeyFilePath;
    }

    private void serverPortOverrideCheckBox_CheckedChanged(object sender, EventArgs e) {
      serverPortTextBox.ReadOnly = !serverPortOverrideCheckBox.Checked;
    }
  }
}
