using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace chat
{
    public static class Sifreleme
    {
        private static TripleDESCryptoServiceProvider des = 
            new TripleDESCryptoServiceProvider();
        public static void SifrelemeilklAyar()
        {
            des.Key = UTF8Encoding.UTF8.GetBytes(DefaultKey);
            des.Mode = CipherMode.ECB;
            des.Padding = PaddingMode.PKCS7;
        }

        public static void DosyaSifrele(string dosyaYolu)
        {
            byte[] Bytes = File.ReadAllBytes(dosyaYolu);
            byte[] eBytes = des.CreateEncryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            File.WriteAllBytes(dosyaYolu, eBytes);
        }

        public static void DosyaSifreCoz(string dosyaYolu)
        {
            byte[] Bytes = File.ReadAllBytes(dosyaYolu);
            byte[] dBytes = des.CreateDecryptor().TransformFinalBlock(Bytes, 0, Bytes.Length);
            File.WriteAllBytes(dosyaYolu, dBytes);
        }

        public static string MesajSifrele(string mesaj)
        {
            string key = DefaultKey;
            byte[] inputArray = Encoding.UTF8.GetBytes(mesaj);
            MemoryStream ms = new MemoryStream();
            CryptoStream cs = new CryptoStream(ms, GetCryptoTransform(EncryptionMode.Encrypt, key), CryptoStreamMode.Write);
            cs.Write(inputArray, 0, inputArray.Length);
            cs.FlushFinalBlock();
            byte[] outArray = ms.ToArray();
            ms.Close();
            // send it back
            return Convert.ToBase64String(outArray);
        }

        public static string MesajSifreCoz(string sifreliMesaj)
        {
            string key = DefaultKey;
            if (sifreliMesaj == null ||
                sifreliMesaj.Length == 0 ||
                (sifreliMesaj.Length % 4) != 0)
            {
                return "";
            }

            System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex(@"[^-A-Za-z0-9+/=]|=[^=]|={3,}$");
            if (regex.Match(sifreliMesaj).Success)
            {
                return "";
            }

            byte[] inputArray = new byte[sifreliMesaj.Length];
            MemoryStream ms = new MemoryStream();
            inputArray = Convert.FromBase64String(sifreliMesaj);

            CryptoStream cs = new CryptoStream(ms, GetCryptoTransform(EncryptionMode.Decrypt, key), CryptoStreamMode.Write);
            cs.Write(inputArray, 0, inputArray.Length);
            cs.FlushFinalBlock();
            byte[] outArray = ms.ToArray();
            ms.Close();

            return Encoding.UTF8.GetString(outArray);
        }
        
        #region Diğer Gerekli Kodlar
        public enum EncryptionMode { Encrypt, Decrypt }
        enum EncryptionProviders { DES, TripleDES }

        private const string DefaultKey = "yusufyusufyusufy"; //Burası şifrelemede ve şifre çözmede kullanılan anahtar kelime.
        private static readonly byte[] _IV3Des = { 21, 3, 61, 12, 99, 66, 71, 12 };
        private static TripleDESCryptoServiceProvider _3Des = new TripleDESCryptoServiceProvider();
        private static EncryptionProviders CryptoServiceProvider = EncryptionProviders.TripleDES;

        private static string GetPassPhrase(string passPhrase)
        {
            if (!String.IsNullOrEmpty(passPhrase))
                return passPhrase;
            return DefaultKey;
        }

        private static ICryptoTransform GetCryptoTransform(EncryptionMode mode, string encryptionKey)
        {
            EncryptionProviders provider = CryptoServiceProvider;
            string passPhrase = GetPassPhrase(encryptionKey);
            MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
            byte[] key = MD5.ComputeHash(ASCIIEncoding.ASCII.GetBytes(passPhrase));
            return (mode == EncryptionMode.Encrypt) ? _3Des.CreateEncryptor(key, _IV3Des) : _3Des.CreateDecryptor(key, _IV3Des);
        }
        #endregion
    }
}
