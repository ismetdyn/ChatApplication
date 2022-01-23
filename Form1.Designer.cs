namespace chat
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelGercekKisi = new System.Windows.Forms.Panel();
            this.lblUygulamaDurum = new System.Windows.Forms.Label();
            this.btnCikis = new System.Windows.Forms.Button();
            this.labelKayitKonumu = new System.Windows.Forms.Label();
            this.btnUygulamaDurdur = new System.Windows.Forms.Button();
            this.btnBulBaslat = new System.Windows.Forms.Button();
            this.labelMyIp = new System.Windows.Forms.Label();
            this.btnKaydetmeKonumu = new System.Windows.Forms.Button();
            this.tbCokluGorev = new System.Windows.Forms.TextBox();
            this.btnMesajGecmisi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAliciIP = new System.Windows.Forms.TextBox();
            this.panelAna = new System.Windows.Forms.Panel();
            this.labelAna = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelKisiler = new System.Windows.Forms.Panel();
            this.onlinePCList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panelMesajlasma = new System.Windows.Forms.Panel();
            this.lblDosyaGonderimBilgisi = new System.Windows.Forms.Label();
            this.btnDosyaGonder = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.btnCozCıkar = new System.Windows.Forms.Button();
            this.tbMesaj = new System.Windows.Forms.TextBox();
            this.btnDosyaEkle = new System.Windows.Forms.Button();
            this.panelCikti = new System.Windows.Forms.Panel();
            this.rtbCikti = new System.Windows.Forms.RichTextBox();
            this.panelGercekKisi.SuspendLayout();
            this.panelAna.SuspendLayout();
            this.panelKisiler.SuspendLayout();
            this.panelMesajlasma.SuspendLayout();
            this.panelCikti.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGercekKisi
            // 
            this.panelGercekKisi.Controls.Add(this.lblUygulamaDurum);
            this.panelGercekKisi.Controls.Add(this.btnCikis);
            this.panelGercekKisi.Controls.Add(this.labelKayitKonumu);
            this.panelGercekKisi.Controls.Add(this.btnUygulamaDurdur);
            this.panelGercekKisi.Controls.Add(this.btnBulBaslat);
            this.panelGercekKisi.Controls.Add(this.labelMyIp);
            this.panelGercekKisi.Controls.Add(this.btnKaydetmeKonumu);
            this.panelGercekKisi.Controls.Add(this.tbCokluGorev);
            this.panelGercekKisi.Controls.Add(this.btnMesajGecmisi);
            this.panelGercekKisi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGercekKisi.Location = new System.Drawing.Point(0, 0);
            this.panelGercekKisi.Name = "panelGercekKisi";
            this.panelGercekKisi.Size = new System.Drawing.Size(1327, 112);
            this.panelGercekKisi.TabIndex = 4;
            // 
            // lblUygulamaDurum
            // 
            this.lblUygulamaDurum.AutoSize = true;
            this.lblUygulamaDurum.Location = new System.Drawing.Point(13, 52);
            this.lblUygulamaDurum.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUygulamaDurum.Name = "lblUygulamaDurum";
            this.lblUygulamaDurum.Size = new System.Drawing.Size(10, 16);
            this.lblUygulamaDurum.TabIndex = 18;
            this.lblUygulamaDurum.Text = ".";
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCikis.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCikis.Location = new System.Drawing.Point(543, 4);
            this.btnCikis.Margin = new System.Windows.Forms.Padding(4);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(185, 44);
            this.btnCikis.TabIndex = 17;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // labelKayitKonumu
            // 
            this.labelKayitKonumu.AutoSize = true;
            this.labelKayitKonumu.Location = new System.Drawing.Point(387, 52);
            this.labelKayitKonumu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelKayitKonumu.Name = "labelKayitKonumu";
            this.labelKayitKonumu.Size = new System.Drawing.Size(172, 16);
            this.labelKayitKonumu.TabIndex = 16;
            this.labelKayitKonumu.Text = "C:\\Users\\Public\\Downloads";
            // 
            // btnUygulamaDurdur
            // 
            this.btnUygulamaDurdur.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnUygulamaDurdur.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUygulamaDurdur.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUygulamaDurdur.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnUygulamaDurdur.Location = new System.Drawing.Point(197, 4);
            this.btnUygulamaDurdur.Margin = new System.Windows.Forms.Padding(4);
            this.btnUygulamaDurdur.Name = "btnUygulamaDurdur";
            this.btnUygulamaDurdur.Size = new System.Drawing.Size(185, 44);
            this.btnUygulamaDurdur.TabIndex = 15;
            this.btnUygulamaDurdur.Text = "Uygulamayı Durdur";
            this.btnUygulamaDurdur.UseVisualStyleBackColor = false;
            this.btnUygulamaDurdur.Click += new System.EventHandler(this.btnUygulamaDurdur_Click);
            // 
            // btnBulBaslat
            // 
            this.btnBulBaslat.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnBulBaslat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBulBaslat.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBulBaslat.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnBulBaslat.Location = new System.Drawing.Point(4, 4);
            this.btnBulBaslat.Margin = new System.Windows.Forms.Padding(4);
            this.btnBulBaslat.Name = "btnBulBaslat";
            this.btnBulBaslat.Size = new System.Drawing.Size(185, 44);
            this.btnBulBaslat.TabIndex = 14;
            this.btnBulBaslat.Text = "Bul/Başlat";
            this.btnBulBaslat.UseVisualStyleBackColor = false;
            this.btnBulBaslat.Click += new System.EventHandler(this.btnBulBaslat_Click);
            // 
            // labelMyIp
            // 
            this.labelMyIp.AutoSize = true;
            this.labelMyIp.Location = new System.Drawing.Point(194, 52);
            this.labelMyIp.Name = "labelMyIp";
            this.labelMyIp.Size = new System.Drawing.Size(11, 16);
            this.labelMyIp.TabIndex = 5;
            this.labelMyIp.Text = "-";
            // 
            // btnKaydetmeKonumu
            // 
            this.btnKaydetmeKonumu.AutoSize = true;
            this.btnKaydetmeKonumu.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnKaydetmeKonumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydetmeKonumu.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKaydetmeKonumu.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnKaydetmeKonumu.Location = new System.Drawing.Point(390, 4);
            this.btnKaydetmeKonumu.Margin = new System.Windows.Forms.Padding(4);
            this.btnKaydetmeKonumu.Name = "btnKaydetmeKonumu";
            this.btnKaydetmeKonumu.Size = new System.Drawing.Size(145, 44);
            this.btnKaydetmeKonumu.TabIndex = 11;
            this.btnKaydetmeKonumu.Text = "Kaydetme Konumu";
            this.btnKaydetmeKonumu.UseVisualStyleBackColor = false;
            this.btnKaydetmeKonumu.Click += new System.EventHandler(this.btnKaydetmeKonumu_Click);
            // 
            // tbCokluGorev
            // 
            this.tbCokluGorev.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbCokluGorev.Location = new System.Drawing.Point(315, 79);
            this.tbCokluGorev.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.tbCokluGorev.Name = "tbCokluGorev";
            this.tbCokluGorev.Size = new System.Drawing.Size(444, 30);
            this.tbCokluGorev.TabIndex = 4;
            // 
            // btnMesajGecmisi
            // 
            this.btnMesajGecmisi.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMesajGecmisi.Location = new System.Drawing.Point(1161, 0);
            this.btnMesajGecmisi.Name = "btnMesajGecmisi";
            this.btnMesajGecmisi.Size = new System.Drawing.Size(166, 112);
            this.btnMesajGecmisi.TabIndex = 0;
            this.btnMesajGecmisi.Text = "Mesaj Geçmişi";
            this.btnMesajGecmisi.UseVisualStyleBackColor = true;
            this.btnMesajGecmisi.Click += new System.EventHandler(this.btnMesajGecmisi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(147, 103);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Insert receiver\'s IP";
            // 
            // tbAliciIP
            // 
            this.tbAliciIP.Location = new System.Drawing.Point(286, 99);
            this.tbAliciIP.Margin = new System.Windows.Forms.Padding(4);
            this.tbAliciIP.Name = "tbAliciIP";
            this.tbAliciIP.Size = new System.Drawing.Size(158, 22);
            this.tbAliciIP.TabIndex = 12;
            // 
            // panelAna
            // 
            this.panelAna.Controls.Add(this.labelAna);
            this.panelAna.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAna.Location = new System.Drawing.Point(0, 112);
            this.panelAna.Name = "panelAna";
            this.panelAna.Size = new System.Drawing.Size(1327, 427);
            this.panelAna.TabIndex = 8;
            // 
            // labelAna
            // 
            this.labelAna.AutoSize = true;
            this.labelAna.Location = new System.Drawing.Point(490, 87);
            this.labelAna.Name = "labelAna";
            this.labelAna.Size = new System.Drawing.Size(44, 16);
            this.labelAna.TabIndex = 0;
            this.labelAna.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panelKisiler
            // 
            this.panelKisiler.Controls.Add(this.onlinePCList);
            this.panelKisiler.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelKisiler.Location = new System.Drawing.Point(0, 112);
            this.panelKisiler.Name = "panelKisiler";
            this.panelKisiler.Size = new System.Drawing.Size(257, 427);
            this.panelKisiler.TabIndex = 9;
            // 
            // onlinePCList
            // 
            this.onlinePCList.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.onlinePCList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.onlinePCList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.onlinePCList.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlinePCList.FullRowSelect = true;
            this.onlinePCList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.onlinePCList.HideSelection = false;
            this.onlinePCList.HoverSelection = true;
            this.onlinePCList.Location = new System.Drawing.Point(0, 0);
            this.onlinePCList.Margin = new System.Windows.Forms.Padding(4);
            this.onlinePCList.MultiSelect = false;
            this.onlinePCList.Name = "onlinePCList";
            this.onlinePCList.Size = new System.Drawing.Size(257, 427);
            this.onlinePCList.TabIndex = 1;
            this.onlinePCList.UseCompatibleStateImageBehavior = false;
            this.onlinePCList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "IP Address";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Computer Name";
            this.columnHeader2.Width = 263;
            // 
            // panelMesajlasma
            // 
            this.panelMesajlasma.Controls.Add(this.lblDosyaGonderimBilgisi);
            this.panelMesajlasma.Controls.Add(this.btnDosyaGonder);
            this.panelMesajlasma.Controls.Add(this.btnTemizle);
            this.panelMesajlasma.Controls.Add(this.lblDosyaYolu);
            this.panelMesajlasma.Controls.Add(this.btnCozCıkar);
            this.panelMesajlasma.Controls.Add(this.tbAliciIP);
            this.panelMesajlasma.Controls.Add(this.label1);
            this.panelMesajlasma.Controls.Add(this.tbMesaj);
            this.panelMesajlasma.Controls.Add(this.btnDosyaEkle);
            this.panelMesajlasma.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelMesajlasma.Location = new System.Drawing.Point(257, 343);
            this.panelMesajlasma.Name = "panelMesajlasma";
            this.panelMesajlasma.Padding = new System.Windows.Forms.Padding(4, 10, 0, 0);
            this.panelMesajlasma.Size = new System.Drawing.Size(1070, 196);
            this.panelMesajlasma.TabIndex = 11;
            // 
            // lblDosyaGonderimBilgisi
            // 
            this.lblDosyaGonderimBilgisi.AutoSize = true;
            this.lblDosyaGonderimBilgisi.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblDosyaGonderimBilgisi.Location = new System.Drawing.Point(7, 58);
            this.lblDosyaGonderimBilgisi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDosyaGonderimBilgisi.Name = "lblDosyaGonderimBilgisi";
            this.lblDosyaGonderimBilgisi.Size = new System.Drawing.Size(10, 16);
            this.lblDosyaGonderimBilgisi.TabIndex = 17;
            this.lblDosyaGonderimBilgisi.Text = ".";
            // 
            // btnDosyaGonder
            // 
            this.btnDosyaGonder.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDosyaGonder.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDosyaGonder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDosyaGonder.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDosyaGonder.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnDosyaGonder.Location = new System.Drawing.Point(452, 88);
            this.btnDosyaGonder.Margin = new System.Windows.Forms.Padding(4);
            this.btnDosyaGonder.Name = "btnDosyaGonder";
            this.btnDosyaGonder.Size = new System.Drawing.Size(296, 42);
            this.btnDosyaGonder.TabIndex = 16;
            this.btnDosyaGonder.Text = "Dosyayı Secili Bilgisayara Gönder";
            this.btnDosyaGonder.UseVisualStyleBackColor = false;
            this.btnDosyaGonder.Click += new System.EventHandler(this.btnDosyaGonder_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTemizle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTemizle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnTemizle.Location = new System.Drawing.Point(756, 90);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(4);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(119, 39);
            this.btnTemizle.TabIndex = 15;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.ForeColor = System.Drawing.Color.Teal;
            this.lblDosyaYolu.Location = new System.Drawing.Point(283, 164);
            this.lblDosyaYolu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(11, 16);
            this.lblDosyaYolu.TabIndex = 14;
            this.lblDosyaYolu.Text = "-";
            // 
            // btnCozCıkar
            // 
            this.btnCozCıkar.Location = new System.Drawing.Point(629, 145);
            this.btnCozCıkar.Name = "btnCozCıkar";
            this.btnCozCıkar.Size = new System.Drawing.Size(111, 45);
            this.btnCozCıkar.TabIndex = 4;
            this.btnCozCıkar.Text = "ÇözÇıkar";
            this.btnCozCıkar.UseVisualStyleBackColor = true;
            // 
            // tbMesaj
            // 
            this.tbMesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbMesaj.Location = new System.Drawing.Point(4, 10);
            this.tbMesaj.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            this.tbMesaj.Name = "tbMesaj";
            this.tbMesaj.Size = new System.Drawing.Size(707, 45);
            this.tbMesaj.TabIndex = 3;
            // 
            // btnDosyaEkle
            // 
            this.btnDosyaEkle.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnDosyaEkle.FlatAppearance.BorderSize = 0;
            this.btnDosyaEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDosyaEkle.ForeColor = System.Drawing.Color.White;
            this.btnDosyaEkle.Location = new System.Drawing.Point(2, 81);
            this.btnDosyaEkle.MaximumSize = new System.Drawing.Size(138, 41);
            this.btnDosyaEkle.Name = "btnDosyaEkle";
            this.btnDosyaEkle.Size = new System.Drawing.Size(138, 39);
            this.btnDosyaEkle.TabIndex = 1;
            this.btnDosyaEkle.Text = "Dosya Ekle ...";
            this.btnDosyaEkle.UseVisualStyleBackColor = false;
            this.btnDosyaEkle.Click += new System.EventHandler(this.btnDosyaEkle_Click);
            // 
            // panelCikti
            // 
            this.panelCikti.BackColor = System.Drawing.SystemColors.Desktop;
            this.panelCikti.Controls.Add(this.rtbCikti);
            this.panelCikti.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelCikti.Location = new System.Drawing.Point(0, 539);
            this.panelCikti.Name = "panelCikti";
            this.panelCikti.Size = new System.Drawing.Size(1327, 209);
            this.panelCikti.TabIndex = 0;
            // 
            // rtbCikti
            // 
            this.rtbCikti.BackColor = System.Drawing.Color.Black;
            this.rtbCikti.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbCikti.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbCikti.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.rtbCikti.ForeColor = System.Drawing.Color.Lime;
            this.rtbCikti.Location = new System.Drawing.Point(0, 0);
            this.rtbCikti.Name = "rtbCikti";
            this.rtbCikti.ReadOnly = true;
            this.rtbCikti.Size = new System.Drawing.Size(1327, 209);
            this.rtbCikti.TabIndex = 1;
            this.rtbCikti.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 748);
            this.Controls.Add(this.panelMesajlasma);
            this.Controls.Add(this.panelKisiler);
            this.Controls.Add(this.panelAna);
            this.Controls.Add(this.panelGercekKisi);
            this.Controls.Add(this.panelCikti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelGercekKisi.ResumeLayout(false);
            this.panelGercekKisi.PerformLayout();
            this.panelAna.ResumeLayout(false);
            this.panelAna.PerformLayout();
            this.panelKisiler.ResumeLayout(false);
            this.panelMesajlasma.ResumeLayout(false);
            this.panelMesajlasma.PerformLayout();
            this.panelCikti.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelGercekKisi;
        private System.Windows.Forms.Button btnMesajGecmisi;
        private System.Windows.Forms.Panel panelAna;
        private System.Windows.Forms.TextBox tbCokluGorev;
        private System.Windows.Forms.Label labelMyIp;
        private System.Windows.Forms.TextBox tbAliciIP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelKisiler;
        private System.Windows.Forms.ListView onlinePCList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel panelMesajlasma;
        private System.Windows.Forms.Label labelKayitKonumu;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.Button btnKaydetmeKonumu;
        private System.Windows.Forms.Button btnCozCıkar;
        private System.Windows.Forms.TextBox tbMesaj;
        private System.Windows.Forms.Button btnDosyaEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnUygulamaDurdur;
        private System.Windows.Forms.Button btnBulBaslat;
        private System.Windows.Forms.Button btnDosyaGonder;
        private System.Windows.Forms.Label lblUygulamaDurum;
        private System.Windows.Forms.Label lblDosyaGonderimBilgisi;
        private System.Windows.Forms.Label labelAna;
        private System.Windows.Forms.Panel panelCikti;
        private System.Windows.Forms.RichTextBox rtbCikti;
    }
}

