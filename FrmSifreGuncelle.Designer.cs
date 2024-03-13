namespace Motel
{
    partial class FrmSifreGuncelle
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
            LblSifre = new Label();
            LblKullaniciAdi = new Label();
            BtnGuncelle = new Button();
            TxtSifre = new TextBox();
            TxtKullaniciAdi = new TextBox();
            SuspendLayout();
            // 
            // LblSifre
            // 
            LblSifre.AutoSize = true;
            LblSifre.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            LblSifre.Location = new Point(108, 139);
            LblSifre.Name = "LblSifre";
            LblSifre.Size = new Size(55, 25);
            LblSifre.TabIndex = 11;
            LblSifre.Text = "Şifre :";
            // 
            // LblKullaniciAdi
            // 
            LblKullaniciAdi.AutoSize = true;
            LblKullaniciAdi.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            LblKullaniciAdi.Location = new Point(42, 90);
            LblKullaniciAdi.Name = "LblKullaniciAdi";
            LblKullaniciAdi.Size = new Size(121, 25);
            LblKullaniciAdi.TabIndex = 10;
            LblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // BtnGuncelle
            // 
            BtnGuncelle.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            BtnGuncelle.Location = new Point(289, 203);
            BtnGuncelle.Name = "BtnGuncelle";
            BtnGuncelle.Size = new Size(94, 37);
            BtnGuncelle.TabIndex = 9;
            BtnGuncelle.Text = "Güncelle";
            BtnGuncelle.UseVisualStyleBackColor = true;
            BtnGuncelle.Click += BtnGuncelle_Click;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(169, 137);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(174, 27);
            TxtSifre.TabIndex = 7;
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.Location = new Point(169, 91);
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(174, 27);
            TxtKullaniciAdi.TabIndex = 6;
            // 
            // FrmSifreGuncelle
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(581, 374);
            Controls.Add(LblSifre);
            Controls.Add(LblKullaniciAdi);
            Controls.Add(BtnGuncelle);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullaniciAdi);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmSifreGuncelle";
            Text = "FrmSifreGuncelle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblSifre;
        private Label LblKullaniciAdi;
        private Button BtnGuncelle;
        private TextBox TxtSifre;
        private TextBox TxtKullaniciAdi;
    }
}