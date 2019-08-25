namespace MinecraftServerConnect {
  public struct ClientConfig {
    public struct UIDefaults {
      public struct StatusStrip {
        public struct Status {
          public static string UiText(bool value) {
            return value ? "Connected" : "Not Connected";
          }
        }
      }
      public struct PassphraseTextBox {
        public static string Placeholder = "Enter Passphrase";
      }
      public struct SaltTextBox {
        public static string Placeholder = "Salt (optional)";
      }
    }
    public struct MessageBoxDefaults {
      public struct KeyFileGeneratorFormDefaults {
        public struct RSAKeyFileEmptyMessageBox {
          public static string Message = "You must select a valid RSA Private Key file to generate a Minecraft Key File.";
          public static string Caption = "RSA Key File";
        }
        public struct ExportKeyFileEmptyMessageBox {
          public static string Message = "Please choose a file path to save the Minecraft Key File!";
          public static string Caption = "Export";
        }
        public struct KeyFileExportedMessageBox {
          public static string Message = "Minecraft Key File exported!";
          public static string Caption = "Export";
        }
      }
    }
  }
}
