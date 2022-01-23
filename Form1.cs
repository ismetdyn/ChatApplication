using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Threading;

namespace chat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sifreleme.SifrelemeilklAyar();
        }

        OpenFileDialog OD = new OpenFileDialog();
        FolderBrowserDialog FD = new FolderBrowserDialog();
        private string IP = "127.0.0.1";
        TcpListener dinleyici;
        TcpClient istemci;
        Socket soket_istemci;
        private Thread serverThread;
        private Thread pcBul;
        int flag = 0;
        string dosyaAdi = "";
        private bool serverCalisiyorMu = false;
        private bool bagli_mi = false;
        int x = 361;
        int y = 99;
        string kayitYolu;
        string gondericiIP;
        string gondericiMakineAdi;
        string hedefIP;
        string hedefCihaz;
        string gidenDosyaKarma = "";
        string gelenDosyaKarma = "";
        string gidenMesajKarma = "";
        
        

        private void Form1_Load(object sender, EventArgs e)
        {
            lblUygulamaDurum.ForeColor = Color.Red;
            lblUygulamaDurum.Text = "Uygulama Offline";
            tbMesaj.Text = "";
            FD.SelectedPath = Application.StartupPath;
        }

        void StartServer()
        {
            try
            {
                serverCalisiyorMu = true;
                dinleyici = new TcpListener(IPAddress.Parse(IP), 11000);
                dinleyici.Start();
                serverThread = new Thread(new ThreadStart(ServerTasks));
                serverThread.Start();
                while (!serverThread.IsAlive) ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        void ServerTasks()
        {
            try
            {
                while (true)
                {
                    istemci = dinleyici.AcceptTcpClient();
                    bagli_mi = true;
                    NetworkStream stream = istemci.GetStream();
                    if (flag == 1 && bagli_mi)
                    {
                        Invoke((MethodInvoker)delegate
                        {
                            rtbCikti.Text += "Dosya alınıyor..." +
                            dosyaAdi + "\n" +
                            "Kimden: " + gondericiIP + gondericiMakineAdi + "\n";
                        });
                        kayitYolu = FD.SelectedPath + "\\" +
                            dosyaAdi;
                        using (var cikti = File.Create(kayitYolu))
                        {
                            var buffer = new byte[1024];
                            int bytesRead;
                            while ((bytesRead = stream.Read(buffer, 0, buffer.Length)) > 0)
                            {
                                cikti.Write(buffer, 0, bytesRead);
                            }
                            flag = 0;
                            istemci.Close();
                            bagli_mi = false;
                            dosyaAdi = "";

                            Invoke((MethodInvoker)delegate
                            {
                                rtbCikti.Text += "Dosya alındı." + "\n";
                                lblDosyaGonderimBilgisi.Text = "";
                            });
                        }
                        string zipliDosya = kayitYolu;
                        Arsivleme.ZipAc(zipliDosya);
                        int index = zipliDosya.LastIndexOf(".");
                        string ziptenCikmisDosya = zipliDosya.Substring(0, index);
                        Sifreleme.DosyaSifreCoz(ziptenCikmisDosya);
                        string karmaKontrol = Karma.DosyaKarma(ziptenCikmisDosya);

                        if(karmaKontrol != gelenDosyaKarma)
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                rtbCikti.SelectionColor = Color.Red;
                                rtbCikti.Text += "HASH(KARMA) HATASI! Dosya bozuk veya eksik!" + "\n" +
                                "Dosyayla birlikte gelen karma --> " + gelenDosyaKarma + "\n" +
                                "Dosya karma kontrol" + karmaKontrol + "\n";
                            });
                        }
                        else
                        {
                            Invoke((MethodInvoker)delegate
                            {
                                rtbCikti.Text += "HASH(KARMA) Kontrolü Başarıyla tamamlandı." + "\n" +
                                "Dosyayla birlikte gelen karma --> " + gelenDosyaKarma + "\n" +
                                "Dosya karma kontrol" + karmaKontrol + "\n";
                                int satirSayisi = rtbCikti.Lines.Length;
                                for (int i = 1; i <= 3; i++)
                                {
                                    string line = rtbCikti.Lines[satirSayisi - i];
                                    rtbCikti.Select(rtbCikti.GetFirstCharIndexFromLine(satirSayisi - i), line.Length);
                                    rtbCikti.SelectionColor = Color.Yellow;
                                }
                            });
                        }
                    }
                    else if (flag == 0 && bagli_mi)
                    {
                        string gelenSifreliMesaj = "";
                        string gelenMesaj = "";
                        string gelenMesajKarma = "";
                        Byte[] bytes = new Byte[256];
                        String data = null;
                        int i;
                        while ((i = stream.Read(bytes, 0, bytes.Length)) != 0)
                        {
                            data = Encoding.ASCII.GetString(bytes, 0, i);
                        }
                        string[] msg = data.Split('@');

                        if(msg[0] == "Message" && msg[1] == "File")
                        {
                            gelenSifreliMesaj = msg[2];
                            gelenMesajKarma = msg[3];
                            dosyaAdi = msg[4];
                            gelenDosyaKarma = msg[5];
                            gondericiIP = msg[6];
                            gondericiMakineAdi = msg[7];
                            bagli_mi = false;
                            flag = 1;
                        }
                        else if(msg[0] == "Message" && msg[1] != "File")
                        {
                            gelenSifreliMesaj = msg[1];
                            gelenMesajKarma = msg[2];
                            bagli_mi = false;
                            flag = 0;
                        }
                        else if(msg[0] == "File")
                        {
                            dosyaAdi = msg[1];
                            gelenDosyaKarma = msg[2];
                            gondericiIP = msg[3];
                            gondericiMakineAdi = msg[4];
                            bagli_mi = false;
                            flag = 1;
                        }
                        Invoke((MethodInvoker)delegate
                        {
                            gelenMesaj = Sifreleme.MesajSifreCoz(gelenSifreliMesaj);
                            rtbCikti.Text += gelenMesaj + "\n";
                        });
                    }
                }
            }
            catch (Exception)
            {
                flag = 0;
                bagli_mi = false;
                if (istemci != null)
                    istemci.Close();
            }
        }

        private void btnBulBaslat_Click(object sender, EventArgs e)
        {
            tbAliciIP.Text = "";
            onlinePCList.Items.Clear();
            lblUygulamaDurum.ForeColor = Color.Green;
            lblUygulamaDurum.Text = "Finding...";

            try
            {
                pcBul = new Thread(new ThreadStart(LANAyar));
                pcBul.Start();
                while (!pcBul.IsAlive) ;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        void LANAyar()
        {
            bool isNetworkUp = NetworkInterface.GetIsNetworkAvailable();
            if (isNetworkUp)
            {
                var host = Dns.GetHostEntry(Dns.GetHostName());
                foreach (var ip in host.AddressList)
                {
                    if (ip.AddressFamily == AddressFamily.InterNetwork)
                    {
                        this.IP = ip.ToString();
                    }
                }
                Invoke((MethodInvoker)delegate
                {
                    labelMyIp.Text = "Bu Bilgisayar: " + this.IP;
                });

                PC_Ara();

                Invoke((MethodInvoker)delegate
                {
                    lblUygulamaDurum.ForeColor = Color.Green;
                    lblUygulamaDurum.Text = "Uygulama Online";
                });

                if (!serverCalisiyorMu)
                    StartServer();
            }
            else
            {
                Invoke((MethodInvoker)delegate
                {
                    lblUygulamaDurum.ForeColor = Color.Red;
                    lblUygulamaDurum.Text = "Uygulama Offline";
                });
                MessageBox.Show("LAN'a bağlı değil.");
            }
        }

        private void PC_Ara()
        {
            string[] ipRange = IP.Split('.');
            for (int i = 1; i < 255; i++)
            {
                Ping ping = new Ping();
                string testIP = ipRange[0] + '.' + ipRange[1] + '.' + ipRange[2] + '.' + i.ToString();
                if (testIP != this.IP)
                {
                    ping.PingCompleted += new PingCompletedEventHandler(PingCompletedEvent);
                    ping.SendAsync(testIP, 100, testIP);
                }
            }
        }

        void PingCompletedEvent(object sender, PingCompletedEventArgs e)
        {
            string ip = (string)e.UserState;
            if (e.Reply.Status == IPStatus.Success)
            {
                string name;
                try
                {
                    IPHostEntry hostEntry = Dns.GetHostEntry(ip);
                    name = hostEntry.HostName;
                }
                catch (SocketException ex)
                {
                    name = ex.Message;
                }
                Invoke((MethodInvoker)delegate
                {
                    ListViewItem item = new ListViewItem();
                    item.Text = ip;
                    item.SubItems.Add(name);
                    onlinePCList.Items.Add(item);
                });
            }
        }

        private void btnDosyaEkle_Click(object sender, EventArgs e)
        {
            OD = new OpenFileDialog();
            OD.Filter = "All Files|*.*";
            OD.Title = "Dosya Seç";
            OD.FileName = "";
            if (OD.ShowDialog() == DialogResult.OK)
            {
                btnDosyaEkle.Text = OD.SafeFileName;
                lblDosyaYolu.Text = OD.FileName;  // dosya yolu
            }
            timer1.Start();
        }

        private void btnDosyaGonder_Click(object sender, EventArgs e)
        {
            hedefIP = null;
            hedefCihaz = null;
            if ((onlinePCList.SelectedIndices.Count > 0 ||
                tbAliciIP.Text != "") &&
                serverCalisiyorMu)
            {
                if (tbAliciIP.Text != "")
                {
                    hedefIP = tbAliciIP.Text;
                    hedefCihaz = "";
                }
                else
                {
                    hedefIP = onlinePCList.SelectedItems[0].Text;
                    hedefCihaz = onlinePCList.SelectedItems[0].
                        SubItems[1].Text;
                }

                try
                {
                    Ping p = new Ping();
                    PingReply r;
                    r = p.Send(hedefIP);
                    if (!(r.Status == IPStatus.Success))
                    {
                        MessageBox.Show("Hedef bilgisayar mevcut değil.",
                            "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dinleyici.Stop();
                        serverThread.Abort();
                        serverThread.Join();
                        serverCalisiyorMu = false;

                        if (tbMesaj.Text != "")
                        {
                            gidenMesajKarma = Karma.MesajKarma(tbMesaj.Text);
                            string sifreliMesaj = Sifreleme.MesajSifrele(tbMesaj.Text);

                            if (OD.FileName == "")
                            {
                                string mesaj = "Message@" +
                                sifreliMesaj + "@" + gidenMesajKarma;
                                MesajGonder(mesaj);
                                rtbCikti.Text += sifreliMesaj + "\n";
                            }

                            else if(OD.FileName != "")
                            {
                                gidenDosyaKarma = Karma.DosyaKarma(OD.FileName);
                                gidenMesajKarma = Karma.MesajKarma(tbMesaj.Text);
                                Sifreleme.DosyaSifrele(OD.FileName);
                                Arsivleme.Ziple(OD.FileName);
                                GC.Collect();
                                string zipliDosyaYolu = OD.FileName.ToString() + ".zip";
                                string mesaj = "Message@" + "File@" +
                                sifreliMesaj + "@" + gidenMesajKarma + "@" + OD.SafeFileName.ToString() + ".zip".ToString() + "@" +
                                gidenDosyaKarma + "@" + this.IP + "@" +
                                Environment.MachineName;
                                MesajGonder(mesaj);
                                DosyaGonder(zipliDosyaYolu);
                                Sifreleme.DosyaSifreCoz(OD.FileName);
                                OD.FileName = "";
                                btnDosyaEkle.Text = "Dosya Ekle...";
                            }
                            
                        }
                        else if (tbMesaj.Text == "" && OD.FileName != "")
                        {
                            gidenDosyaKarma = Karma.DosyaKarma(OD.FileName);
                            Sifreleme.DosyaSifrele(OD.FileName);
                            Arsivleme.Ziple(OD.FileName);
                            GC.Collect();
                            string zipliDosyaYolu = OD.FileName.ToString() + ".zip";
                            string dosyaBilgisi = "File@" +
                            OD.SafeFileName.ToString() + ".zip" + "@" + gidenDosyaKarma + "@" + this.IP + "@" +
                            Environment.MachineName;
                            MesajGonder(dosyaBilgisi);
                            DosyaGonder(zipliDosyaYolu);
                            OD.FileName = "";
                            btnDosyaEkle.Text = "Dosya Ekle...";
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    if (soket_istemci != null)
                    {
                        dinleyici.Stop();
                        serverThread.Abort();
                        serverThread.Join();
                        soket_istemci.Shutdown(SocketShutdown.Both);
                        soket_istemci.Close();
                    }
                }
                finally
                {
                    lblDosyaGonderimBilgisi.Text = ".";
                    tbMesaj.Text = "";
                    StartServer();
                }
            }
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serverCalisiyorMu)
            {
                dinleyici.Stop();
                if (serverThread != null)
                {
                    serverThread.Abort();
                    serverThread.Join();
                }
            }
        }

        private void btnUygulamaDurdur_Click(object sender, EventArgs e)
        {
            if (serverCalisiyorMu)
            {
                serverCalisiyorMu = false;
                onlinePCList.Items.Clear();
                if (dinleyici != null)
                    dinleyici.Stop();
                if (serverThread != null)
                {
                    serverThread.Abort();
                    serverThread.Join();
                }

                lblUygulamaDurum.ForeColor = Color.Red;
                lblUygulamaDurum.Text = "Uygulama Offline";
                labelMyIp.Text = "";
                lblDosyaYolu.Text = ".";
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            x = x - 5;
            lblDosyaYolu.Location = new Point(x, y);
            if (x < (lblDosyaYolu.Text.Length * (-1)))
                x = 700;
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            lblDosyaYolu.Text = ".";
            timer1.Stop();
        }

        private void btnKaydetmeKonumu_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog FD = new FolderBrowserDialog();
            if (FD.ShowDialog() == DialogResult.OK)
            {
                string kayitKonumu = FD.SelectedPath;
                labelKayitKonumu.Text = kayitKonumu;
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            if (serverCalisiyorMu)
            {
                if (dinleyici != null)
                    dinleyici.Stop();
                if (serverThread != null)
                {
                    serverThread.Abort();
                    serverThread.Join();
                }

            }
            Application.Exit();
        }
       

        private void btnMesajGecmisi_Click(object sender, EventArgs e)
        {

        }

        private void MesajGonder(string mesaj)
        {
            byte[] byteDizi = Encoding.Default.GetBytes(mesaj);
            soket_istemci = new Socket(AddressFamily.InterNetwork,
                            SocketType.Stream, ProtocolType.Tcp);
            soket_istemci.Connect(new IPEndPoint(
                IPAddress.Parse(hedefIP), 11000));
            soket_istemci.Send(byteDizi);
            soket_istemci.Shutdown(SocketShutdown.Both);
            soket_istemci.Close();
        }

        private void DosyaGonder(string yol)
        {

            soket_istemci = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            soket_istemci.Connect(new IPEndPoint(IPAddress.Parse(hedefIP), 11000));
            soket_istemci.SendFile(yol);
            soket_istemci.Shutdown(SocketShutdown.Both);
            soket_istemci.Close();
        }
    }
}
