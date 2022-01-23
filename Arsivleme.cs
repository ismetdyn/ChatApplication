using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.IO.Compression;
using System.Windows.Forms;

namespace chat
{
    public static class Arsivleme
    {
        public static void Ziple(string dosyaYolu)
        {
            string dosyaAdi = Path.GetFileName(dosyaYolu);
            string klasorYolu = Path.GetDirectoryName(dosyaYolu);
            using (FileStream inputStream = new FileStream(
                dosyaYolu,
                FileMode.OpenOrCreate, 
                FileAccess.ReadWrite))
            {
                using (FileStream outputStream = new FileStream(
                    klasorYolu + "\\"+ dosyaAdi + ".zip", 
                    FileMode.OpenOrCreate, 
                    FileAccess.ReadWrite))
                {
                    using (GZipStream gzip = new GZipStream(
                        outputStream, CompressionMode.Compress))
                    {
                        inputStream.CopyTo(gzip);
                    }
                }
            }

        }

        public static void ZipAc(string dosyaYolu)
        {
            string dosyaAdi = Path.GetFileName(dosyaYolu);
            int index = dosyaAdi.LastIndexOf(".");
            dosyaAdi = dosyaAdi.Substring(0, index);
            string klasorYolu = Path.GetDirectoryName(dosyaYolu);
            using (FileStream inputStream = new FileStream(
                dosyaYolu, 
                FileMode.OpenOrCreate,
                FileAccess.ReadWrite))
            {
                using (FileStream outputStream = new FileStream(
                    klasorYolu + "\\" + dosyaAdi, 
                    FileMode.OpenOrCreate, 
                    FileAccess.ReadWrite))
                {
                    using (GZipStream gzip = new GZipStream(
                        inputStream, CompressionMode.Decompress))
                    {
                        gzip.CopyTo(outputStream);
                    }
                }
            }

        }
    }
}
