using System;
using System.IO;
using System.Security.Cryptography;

namespace MinecraftServerConnect {
  public struct Crypto {
    public static byte[] encrypt(string values) {
      return encrypt(values, "", "");
    }
    public static byte[] encrypt(string values, string passphrase) {
      return encrypt(values, passphrase, "");
    }
    public static byte[] encrypt(string values, string passphrase, string salt) {
      byte[] encrypted;
      byte[] key = new byte[256];
      byte[] iv = new byte[16];

      using (SHA256 sha256 = SHA256.Create()) {
        key = sha256.ComputeHash((new System.Text.UTF8Encoding()).GetBytes(passphrase));
        byte[] tempIv = sha256.ComputeHash((new System.Text.UTF8Encoding()).GetBytes(salt));
        Array.Copy(tempIv, 0, iv, 0, 16);
      }

      using (RijndaelManaged rijndael = new RijndaelManaged()) {
        rijndael.GenerateIV();
        using (Rijndael rijAlg = Rijndael.Create()) {
          rijAlg.Key = key;
          rijAlg.IV = iv;
          ICryptoTransform encryptor = rijAlg.CreateEncryptor(rijAlg.Key, rijAlg.IV);
          using (MemoryStream msEncrypt = new MemoryStream()) {
            using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)) {
              using (StreamWriter swEncrypt = new StreamWriter(csEncrypt)) {
                swEncrypt.Write(values);
              }
              encrypted = msEncrypt.ToArray();
            }
          }
        }
      }
      return encrypted;
    }

    public static string decrypt(byte[] cipher) {
      return decrypt(cipher, "", "");
    }
    public static string decrypt(byte[] cipher, string passphrase) {
      return decrypt(cipher, passphrase, "");
    }
    public static string decrypt(byte[] cipher, string passphrase, string salt) {
      string message;
      byte[] key = new byte[256];
      byte[] iv = new byte[16];

      using (SHA256 sha256 = SHA256.Create()) {
        key = sha256.ComputeHash((new System.Text.UTF8Encoding()).GetBytes(passphrase));
        byte[] tempIv = sha256.ComputeHash((new System.Text.UTF8Encoding()).GetBytes(salt));
        Array.Copy(tempIv, 0, iv, 0, 16);
      }

      using (RijndaelManaged rijndael = new RijndaelManaged()) {
        rijndael.GenerateIV();
        using (Rijndael rijAlg = Rijndael.Create()) {
          rijAlg.Key = key;
          rijAlg.IV = iv;
          ICryptoTransform decryptor = rijAlg.CreateDecryptor(rijAlg.Key, rijAlg.IV);
          using (MemoryStream msDecrypt = new MemoryStream(cipher)) {
            using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read)) {
              using (StreamReader srDecrypt = new StreamReader(csDecrypt)) {
                message = srDecrypt.ReadToEnd();
              }
            }
          }
        }
      }
      return message;
    }
  }
}
