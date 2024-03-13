namespace Motel
{
    partial class FrmAdminGiris
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            TxtKullaniciAdi = new TextBox();
            TxtSifre = new TextBox();
            button1 = new Button();
            button2 = new Button();
            LblKullaniciAdi = new Label();
            LblSifre = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // TxtKullaniciAdi
            // 
            TxtKullaniciAdi.Location = new Point(171, 83);
            TxtKullaniciAdi.Name = "TxtKullaniciAdi";
            TxtKullaniciAdi.Size = new Size(174, 27);
            TxtKullaniciAdi.TabIndex = 0;
            // 
            // TxtSifre
            // 
            TxtSifre.Location = new Point(171, 129);
            TxtSifre.Name = "TxtSifre";
            TxtSifre.Size = new Size(174, 27);
            TxtSifre.TabIndex = 1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(383, 191);
            button1.Name = "button1";
            button1.Size = new Size(94, 43);
            button1.TabIndex = 2;
            button1.Text = "İptal";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(251, 191);
            button2.Name = "button2";
            button2.Size = new Size(94, 43);
            button2.TabIndex = 3;
            button2.Text = "Giriş ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // LblKullaniciAdi
            // 
            LblKullaniciAdi.AutoSize = true;
            LblKullaniciAdi.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            LblKullaniciAdi.Location = new Point(44, 82);
            LblKullaniciAdi.Name = "LblKullaniciAdi";
            LblKullaniciAdi.Size = new Size(121, 25);
            LblKullaniciAdi.TabIndex = 4;
            LblKullaniciAdi.Text = "Kullanıcı Adı :";
            // 
            // LblSifre
            // 
            LblSifre.AutoSize = true;
            LblSifre.Font = new Font("Segoe UI", 10.8F, FontStyle.Italic, GraphicsUnit.Point);
            LblSifre.Location = new Point(110, 131);
            LblSifre.Name = "LblSifre";
            LblSifre.Size = new Size(55, 25);
            LblSifre.TabIndex = 5;
            LblSifre.Text = "Şifre :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(180, 26);
            label3.Name = "label3";
            label3.Size = new Size(149, 31);
            label3.TabIndex = 6;
            label3.Text = "Admin Paneli";
            // 
            // FrmAdminGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.SandyBrown;
            ClientSize = new Size(501, 357);
            Controls.Add(label3);
            Controls.Add(LblSifre);
            Controls.Add(LblKullaniciAdi);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(TxtSifre);
            Controls.Add(TxtKullaniciAdi);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAdminGiris";
            Text = "Admin Girişi ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox TxtKullaniciAdi;
        private TextBox TxtSifre;
        private Button button1;
        private Button button2;
        private Label LblKullaniciAdi;
        private Label LblSifre;
        private Label label3;
    }
}