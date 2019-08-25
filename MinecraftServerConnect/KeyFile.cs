using System;
using System.IO;

namespace MinecraftServerConnect {
  public enum KEY_FILE_TYPES {
    PEM,
    PPK,
    UNKNOWN
  }

  public struct KeyFile {
    public static KEY_FILE_TYPES Type(string value) {
      switch (value) {
        case "PEM":
          return KEY_FILE_TYPES.PEM;
        case "PPK":
          return KEY_FILE_TYPES.PPK;
        default:
          return KEY_FILE_TYPES.UNKNOWN;
      }
    }

    public static string ParsePrivateKey(string filePath, KEY_FILE_TYPES type) {
      switch (type) {
        case KEY_FILE_TYPES.PEM:
          string privateKey = File.ReadAllText(filePath);
          return privateKey;
        default:
          throw new NotSupportedException("Attempted to parse unsupported key file type");
      }
    }
  }
}
