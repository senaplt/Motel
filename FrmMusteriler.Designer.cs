namespace Motel
{
    partial class FrmMusteriler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            ListViewItem listViewItem1 = new ListViewItem("");
            ListViewItem listViewItem2 = new ListViewItem("");
            ListViewItem listViewItem3 = new ListViewItem("");
            ListViewItem listViewItem4 = new ListViewItem("");
            ListViewItem listViewItem5 = new ListViewItem("");
            ListViewItem listViewItem6 = new ListViewItem("");
            ListViewItem listViewItem7 = new ListViewItem("");
            ListViewItem listViewItem8 = new ListViewItem("");
            ListViewItem listViewItem9 = new ListViewItem("");
            ListViewItem listViewItem10 = new ListViewItem("");
            ListViewItem listViewItem11 = new ListViewItem("");
            listView1 = new ListView();
            MusteriID = new ColumnHeader();
            Adi = new ColumnHeader();
            Soyadi = new ColumnHeader();
            Cinsiyet = new ColumnHeader();
            Telefon = new ColumnHeader();
            Mail = new ColumnHeader();
            TC = new ColumnHeader();
            OdaNo = new ColumnHeader();
            Ucret = new ColumnHeader();
            GirisTarihi = new ColumnHeader();
            CikisTarihi = new ColumnHeader();
            BtnTemizle = new Button();
            BtnSil = new Button();
            BtnGuncelle = new Button();
            BtnVeriGoster = new Button();
            BtnAra = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            TxtOdaNo = new TextBox();
            LblOdaNo = new Label();
            DtpCikisTarihi = new DateTimePicker();
            DtpGirisTarihi = new DateTimePicker();
            MsTxtTel = new MaskedTextBox();
            TxtSoyadi = new TextBox();
            TxtTC = new TextBox();
            TxtMail = new TextBox();
            TxtUcret = new TextBox();
            TxtAdi = new TextBox();
            LblUcret = new Label();
            LblGirisDate = new Label();
            LblCikisDate = new Label();
            LblTlf = new Label();
            LblKN = new Label();
            LblMusteriAdi = new Label();
            LbMail = new Label();
            LblMusteriSoyadi = new Label();
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { MusteriID, Adi, Soyadi, Cinsiyet, Telefon, Mail, TC, OdaNo, Ucret, GirisTarihi, CikisTarihi });
            listView1.Items.AddRange(new ListViewItem[] { listViewItem1, listViewItem2, listViewItem3, listViewItem4, listViewItem5, listViewItem6, listViewItem7, listViewItem8, listViewItem9, listViewItem10, listViewItem11 });
            listView1.Location = new Point(3, 303);
            listView1.Name = "listView1";
            listView1.Size = new Size(1134, 190);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            listView1.DoubleClick += listView1_DoubleClick;
            // 
            // MusteriID
            // 
            MusteriID.Text = "No";
            MusteriID.Width = 100;
            // 
            // Adi
            // 
            Adi.Text = "Adı";
            Adi.Width = 100;
            // 
            // Soyadi
            // 
            Soyadi.Text = "Soyadı";
            Soyadi.Width = 100;
            // 
            // Cinsiyet
            // 
            Cinsiyet.Text = "Cinsiyet";
            Cinsiyet.Width = 100;
            // 
            // Telefon
            // 
            Telefon.Text = "Telefon";
            Telefon.Width = 100;
            // 
            // Mail
            // 
            Mail.Text = "Mail";
            Mail.Width = 100;
            // 
            // TC
            // 
            TC.Text = "TC";
            TC.Width = 100;
            // 
            // OdaNo
            // 
            OdaNo.Text = "OdaNo";
            OdaNo.Width = 100;
            // 
            // Ucret
            // 
            Ucret.Text = "Ücret";
            Ucret.Width = 100;
            // 
            // GirisTarihi
            // 
            GirisTarihi.Text = "Giriş Tarihi";
            GirisTarihi.Width = 100;
            // 
            // CikisTarihi
            // 
            CikisTarihi.Text = "Çıkış Tarihi";
            CikisTarihi.Width = 100;
            // 
            // BtnTemizle
            // 
            BtnTemizle.BackColor = Color.Chartreuse;
            BtnTemizle.Location = new Point(995, 148);
            BtnTemizle.Name = "BtnTemizle";
            BtnTemizle.Size = new Size(126, 36);
            BtnTemizle.TabIndex = 2;
            BtnTemizle.Text = "Temizle";
            BtnTemizle.UseVisualStyleBackColor = false;
            BtnTemizle.Click += BtnTemizle_Click;
            // 
            // BtnSil
            // 
            BtnSil.BackColor = Color.Red;
            BtnSil.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            BtnSil.Location = new Point(995, 106);
            BtnSil.Name = "BtnSil";
            BtnSil.Size = new Size(126, 36);
            BtnSil.TabIndex = 3;
            BtnSil.Text = "Sil";
            BtnSil.UseVisualStyleBackColor = false;
            BtnSil.Click += BtnSil_Click;
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.BackColor = Color.Chocolate;
            BtnGuncelle.Location = new Point(994, 64);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(126, 36);
            BtnGuncelle.TabIndex = 4;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = false;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // BtnVeriGoster
            // 
            BtnVeriGoster.BackColor = Color.Chocolate;
            BtnVeriGoster.Location = new Point(994, 22);
            BtnVeriGoster.Name = "BtnVeriGoster";
            BtnVeriGoster.Size = new Size(126, 36);
            BtnVeriGoster.TabIndex = 5;
            BtnVeriGoster.Text = "Verileri Göster";
            BtnVeriGoster.UseVisualStyleBackColor = false;
            BtnVeriGoster.Click += BtnVeriGoster_Click;
            // 
            // BtnAra
            // 
            BtnAra.BackColor = Color.Fuchsia;
            BtnAra.Location = new Point(994, 233);
            BtnAra.Name = "BtnAra";
            BtnAra.Size = new Size(126, 36);
            BtnAra.TabIndex = 6;
            BtnAra.Text = "Ara";
            BtnAra.UseVisualStyleBackColor = false;
            BtnAra.Click += BtnAra_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(995, 194);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(126, 27);
            textBox1.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(927, 198);
            label1.Name = "label1";
            label1.Size = new Size(50, 23);
            label1.TabIndex = 8;
            label1.Text = "İsim :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(67, 147);
            label2.Name = "label2";
            label2.Size = new Size(78, 23);
            label2.TabIndex = 44;
            label2.Text = "Cinsiyet :";
            // 
            // TxtOdaNo
            // 
            TxtOdaNo.Enabled = false;
            TxtOdaNo.Location = new Point(601, 146);
            TxtOdaNo.Name = "TxtOdaNo";
            TxtOdaNo.Size = new Size(249, 27);
            TxtOdaNo.TabIndex = 42;
            // 
            // LblOdaNo
            // 
            LblOdaNo.AutoSize = true;
            LblOdaNo.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblOdaNo.Location = new Point(442, 147);
            LblOdaNo.Name = "LblOdaNo";
            LblOdaNo.Size = new Size(129, 23);
            LblOdaNo.TabIndex = 41;
            LblOdaNo.Text = "Oda Numarası :";
            // 
            // DtpCikisTarihi
            // 
            DtpCikisTarihi.Location = new Point(601, 242);
            DtpCikisTarihi.Name = "DtpCikisTarihi";
            DtpCikisTarihi.Size = new Size(250, 27);
            DtpCikisTarihi.TabIndex = 40;
            // 
            // DtpGirisTarihi
            // 
            DtpGirisTarihi.Location = new Point(600, 192);
            DtpGirisTarihi.Name = "DtpGirisTarihi";
            DtpGirisTarihi.Size = new Size(250, 27);
            DtpGirisTarihi.TabIndex = 39;
            // 
            // MsTxtTel
            // 
            MsTxtTel.Location = new Point(600, 42);
            MsTxtTel.Mask = "(999) 000-0000";
            MsTxtTel.Name = "MsTxtTel";
            MsTxtTel.Size = new Size(250, 27);
            MsTxtTel.TabIndex = 38;
            // 
            // TxtSoyadi
            // 
            TxtSoyadi.Location = new Point(158, 92);
            TxtSoyadi.Name = "TxtSoyadi";
            TxtSoyadi.Size = new Size(249, 27);
            TxtSoyadi.TabIndex = 37;
            // 
            // TxtTC
            // 
            TxtTC.Location = new Point(158, 188);
            TxtTC.MaxLength = 11;
            TxtTC.Name = "TxtTC";
            TxtTC.Size = new Size(249, 27);
            TxtTC.TabIndex = 36;
            // 
            // TxtMail
            // 
            TxtMail.Location = new Point(158, 241);
            TxtMail.Name = "TxtMail";
            TxtMail.Size = new Size(249, 27);
            TxtMail.TabIndex = 35;
            // 
            // TxtUcret
            // 
            TxtUcret.Location = new Point(600, 94);
            TxtUcret.Name = "TxtUcret";
            TxtUcret.Size = new Size(250, 27);
            TxtUcret.TabIndex = 34;
            // 
            // TxtAdi
            // 
            TxtAdi.Location = new Point(158, 38);
            TxtAdi.Name = "TxtAdi";
            TxtAdi.Size = new Size(249, 27);
            TxtAdi.TabIndex = 33;
            // 
            // LblUcret
            // 
            LblUcret.AutoSize = true;
            LblUcret.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblUcret.Location = new Point(443, 93);
            LblUcret.Name = "LblUcret";
            LblUcret.Size = new Size(127, 23);
            LblUcret.TabIndex = 32;
            LblUcret.Text = "Ücretlendirme :";
            // 
            // LblGirisDate
            // 
            LblGirisDate.AutoSize = true;
            LblGirisDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblGirisDate.Location = new Point(473, 189);
            LblGirisDate.Name = "LblGirisDate";
            LblGirisDate.Size = new Size(97, 23);
            LblGirisDate.TabIndex = 31;
            LblGirisDate.Text = "Giriş Tarihi :";
            // 
            // LblCikisDate
            // 
            LblCikisDate.AutoSize = true;
            LblCikisDate.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblCikisDate.Location = new Point(473, 242);
            LblCikisDate.Name = "LblCikisDate";
            LblCikisDate.Size = new Size(98, 23);
            LblCikisDate.TabIndex = 30;
            LblCikisDate.Text = "Çıkış Tarihi :";
            // 
            // LblTlf
            // 
            LblTlf.AutoSize = true;
            LblTlf.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblTlf.Location = new Point(420, 42);
            LblTlf.Name = "LblTlf";
            LblTlf.Size = new Size(151, 23);
            LblTlf.TabIndex = 29;
            LblTlf.Text = "Telefon Numarası :";
            // 
            // LblKN
            // 
            LblKN.AutoSize = true;
            LblKN.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblKN.Location = new Point(3, 192);
            LblKN.Name = "LblKN";
            LblKN.Size = new Size(142, 23);
            LblKN.TabIndex = 27;
            LblKN.Text = "Kimlik Numarası :";
            // 
            // LblMusteriAdi
            // 
            LblMusteriAdi.AutoSize = true;
            LblMusteriAdi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblMusteriAdi.Location = new Point(39, 42);
            LblMusteriAdi.Name = "LblMusteriAdi";
            LblMusteriAdi.Size = new Size(106, 23);
            LblMusteriAdi.TabIndex = 25;
            LblMusteriAdi.Text = "Müşteri Adı :";
            // 
            // LbMail
            // 
            LbMail.AutoSize = true;
            LbMail.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LbMail.Location = new Point(42, 242);
            LbMail.Name = "LbMail";
            LbMail.Size = new Size(103, 23);
            LbMail.TabIndex = 28;
            LbMail.Text = "Mail Adresi :";
            // 
            // LblMusteriSoyadi
            // 
            LblMusteriSoyadi.AutoSize = true;
            LblMusteriSoyadi.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            LblMusteriSoyadi.Location = new Point(14, 93);
            LblMusteriSoyadi.Name = "LblMusteriSoyadi";
            LblMusteriSoyadi.Size = new Size(131, 23);
            LblMusteriSoyadi.TabIndex = 26;
            LblMusteriSoyadi.Text = "Müşteri Soyadı :";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Kadın ", "Erkek" });
            comboBox1.Location = new Point(158, 142);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(249, 28);
            comboBox1.TabIndex = 46;
            // 
            // FrmMusteriler
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(1141, 490);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(TxtOdaNo);
            Controls.Add(LblOdaNo);
            Controls.Add(DtpCikisTarihi);
            Controls.Add(DtpGirisTarihi);
            Controls.Add(MsTxtTel);
            Controls.Add(TxtSoyadi);
            Controls.Add(TxtTC);
            Controls.Add(TxtMail);
            Controls.Add(TxtUcret);
            Controls.Add(TxtAdi);
            Controls.Add(LblUcret);
            Controls.Add(LblGirisDate);
            Controls.Add(LblCikisDate);
            Controls.Add(LblTlf);
            Controls.Add(LblKN);
            Controls.Add(LblMusteriAdi);
            Controls.Add(LbMail);
            Controls.Add(LblMusteriSoyadi);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(BtnAra);
            Controls.Add(BtnVeriGoster);
            Controls.Add(BtnGuncelle);
            Controls.Add(BtnSil);
            Controls.Add(BtnTemizle);
            Controls.Add(listView1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMusteriler";
            Text = "Müşteri Bilgileri";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ListView listView1;
        private ColumnHeader MusteriID;
        private ColumnHeader Adi;
        private ColumnHeader Soyadi;
        private ColumnHeader Cinsiyet;
        private ColumnHeader Telefon;
        private ColumnHeader Mail;
        private ColumnHeader TC;
        private ColumnHeader OdaNo;
        private ColumnHeader Ucret;
        private ColumnHeader GirisTarihi;
        private ColumnHeader CikisTarihi;
        private Button BtnTemizle;
        private Button BtnSil;
        private Button BtnGuncelle;
        private Button BtnVeriGoster;
        private Button BtnAra;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private TextBox TxtOdaNo;
        private Label LblOdaNo;
        private DateTimePicker DtpCikisTarihi;
        private DateTimePicker DtpGirisTarihi;
        private MaskedTextBox MsTxtTel;
        private TextBox TxtSoyadi;
        private TextBox TxtTC;
        private TextBox TxtMail;
        private TextBox TxtUcret;
        private TextBox TxtAdi;
        private Label LblUcret;
        private Label LblGirisDate;
        private Label LblCikisDate;
        private Label LblTlf;
        private Label LblKN;
        private Label LblMusteriAdi;
        private Label LbMail;
        private Label LblMusteriSoyadi;
        private ComboBox comboBox1;
    }
}