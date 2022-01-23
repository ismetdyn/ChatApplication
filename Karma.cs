using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace chat
{
    public static class Karma
    {
        public static string MesajKarma(string metin)
        {
            SHA256 karmaOlusturucu = new SHA256CryptoServiceProvider();
            return Convert.ToBase64String(
                karmaOlusturucu.ComputeHash(Encoding.UTF8.GetBytes(metin)));
        }

        public static string DosyaKarma(string filePath)
        {
            using (SHA256 SHA256 = SHA256Managed.Create())
            {
                using (FileStream fileStream = File.OpenRead(filePath))
                    return Convert.ToBase64String(SHA256.ComputeHash(fileStream));
            }
        }
    }
}
