using System;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

using Renci.SshNet;
using System.Threading;
using System.IO;

namespace MinecraftServerConnect {
  public partial class MainForm : Form {
    private delegate void SafeCallDelegate(bool value);
    private bool isConnected = false;
    private bool isConnectionRequested = false;
    private bool isConnectionAsServerRequested = false;
    private PrivateKeyFile privateKeyFile;
    private string domainName;
    private string user;
    private string port;
    private string passphrase = "";
    private string salt = "";

    public MainForm() {
      InitializeComponent();
    }

    private void setDisconnectButtonEnabledSafe(bool value) {
      if (disconnectButton.InvokeRequired) {
        disconnectButton.Invoke(
            new SafeCallDelegate(setDisconnectButtonEnabledSafe),
            new object[] { value }
        );
        return;
      }
      disconnectButton.Enabled = value;
    }

    private void setConnectButtonEnabledSafe(bool value) {
      if (connectButton.InvokeRequired) {
        connectButton.Invoke(
            new SafeCallDelegate(setConnectButtonEnabledSafe),
            new object[] { value }
        );
        return;
      }
      connectButton.Enabled = value;
    }

    private void setConnectedStatusStripTextSafe(bool value) {
      if (statusStrip.InvokeRequired) {
        statusStrip.Invoke(
            new SafeCallDelegate(setConnectedStatusStripTextSafe),
            new object[] { value }
        );
        return;
      }
      statusStrip.Items[0].Text = ClientConfig.UIDefaults.StatusStrip.Status.UiText(value);
    }

    private void setPassphraseTextBoxEnabledSafe(bool value) {
      if (passphraseTextBox.InvokeRequired) {
        passphraseTextBox.Invoke(
            new SafeCallDelegate(setPassphraseTextBoxEnabledSafe),
            new object[] { value }
        );
        return;
      }
      passphraseTextBox.Enabled = value;
    }

    private void setSaltTextBoxEnabledSafe(bool value) {
      if (saltTextBox.InvokeRequired) {
        saltTextBox.Invoke(
            new SafeCallDelegate(setSaltTextBoxEnabledSafe),
            new object[] { value }
        );
        return;
      }
      saltTextBox.Enabled = value;
    }

    private void setIsConnected(bool value) {
      this.isConnected = value;
      this.setDisconnectButtonEnabledSafe(this.isConnected);
      this.setConnectButtonEnabledSafe(!this.isConnected);
      this.setConnectedStatusStripTextSafe(this.isConnected);
      this.setPassphraseTextBoxEnabledSafe(!this.isConnected);
      this.setSaltTextBoxEnabledSafe(!this.isConnected);
    }

    private void connectButton_Click(object sender, EventArgs e) {
      if (this.isConnected) {
        return;
      }
      openKeyFileDialog.ShowDialog();
    }

    private void openKeyFileDialog_FileOk(object sender, CancelEventArgs e) {
      try {
        string values = Crypto.decrypt(File.ReadAllBytes(openKeyFileDialog.FileName), this.passphrase, this.salt);
        string[] split = values.Split(new char[] { '|' });
        string keyFileType = split[0];
        this.domainName = split[1];
        this.port = split[2];
        this.user = split[3];
        this.privateKeyFile = new PrivateKeyFile(new MemoryStream(Encoding.UTF8.GetBytes(split[4])));
      } catch (Exception exception) {
        Console.Write(exception.ToString());
        MessageBox.Show($"Unable to load Minecraft Key File! (Error: {exception.Message})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }
      this.isConnectionRequested = true;
      connectionDelegate.RunWorkerAsync();
    }

    private void disconnectButton_Click(object sender, EventArgs e) {
      this.isConnectionRequested = false;
      this.isConnectionAsServerRequested = false;
    }

    private void connectionDelegate_DoWork(object sender, DoWorkEventArgs e) {
      if (!this.isConnectionRequested) {
        return;
      }
      try {
        using (SshClient client = new SshClient(this.domainName, this.user, this.privateKeyFile)) {
          client.Connect();
          this.setIsConnected(true);
          if (this.isConnectionAsServerRequested) {
            ForwardedPortRemote port = new ForwardedPortRemote(
              ServerConfig.ClientHost, uint.Parse(this.port),
              ServerConfig.ServerHost, uint.Parse(this.port)
            );
            client.AddForwardedPort(port);
            port.Start();
          } else {
            ForwardedPortLocal port = new ForwardedPortLocal(
              ServerConfig.ClientHost, uint.Parse(this.port),
              ServerConfig.ServerHost, uint.Parse(this.port)
            );
            client.AddForwardedPort(port);
            port.Start();
          }
          while (this.isConnectionRequested) {
            Thread.Sleep(1000);
          }
          client.Disconnect();
          this.setIsConnected(false);
        }
      } catch (Exception exception) {
        this.setIsConnected(false);
        MessageBox.Show(
            $"Connection severed due to error: {exception.Message}", "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error
        );
      }
    }

    private void generateKeyFileToolStripMenuItem_Click(object sender, EventArgs e) {
      KeyFileGeneratorForm keyFileGeneratorForm = new KeyFileGeneratorForm();
      keyFileGeneratorForm.Show();
    }

    private void passphraseTextBox_Enter(object sender, EventArgs e) {
      if (passphraseTextBox.Text == ClientConfig.UIDefaults.PassphraseTextBox.Placeholder) {
        passphraseTextBox.Text = "";
      }
    }

    private void passphraseTextBox_Leave(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(passphraseTextBox.Text)) {
        passphraseTextBox.Text = ClientConfig.UIDefaults.PassphraseTextBox.Placeholder;
      }
    }

    private void saltTextBox_Enter(object sender, EventArgs e) {
      if (saltTextBox.Text == ClientConfig.UIDefaults.SaltTextBox.Placeholder) {
        saltTextBox.Text = "";
      }
    }

    private void saltTextBox_Leave(object sender, EventArgs e) {
      if (string.IsNullOrWhiteSpace(saltTextBox.Text)) {
        saltTextBox.Text = ClientConfig.UIDefaults.SaltTextBox.Placeholder;
      }
    }

    private void connectAsServerToolStripMenuItem_Click(object sender, EventArgs e) {
      if (this.isConnected) {
        return;
      }
      this.isConnectionAsServerRequested = true;
      openKeyFileDialog.ShowDialog();
    }

    private void passphraseTextBox_TextChanged(object sender, EventArgs e) {
      this.passphrase = passphraseTextBox.Text;
      if (this.passphrase == ClientConfig.UIDefaults.PassphraseTextBox.Placeholder) {
        this.passphrase = "";
      }
    }

    private void saltTextBox_TextChanged(object sender, EventArgs e) {
      this.salt = saltTextBox.Text;
      if (this.salt == ClientConfig.UIDefaults.SaltTextBox.Placeholder) {
        this.salt = "";
      }
    }
  }
}
