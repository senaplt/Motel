namespace Motel
{
    partial class FrmAnaForm
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
            components = new System.ComponentModel.Container();
            BtnAdminGiris = new Button();
            BtnOdalar = new Button();
            BtnMusEkleEkran = new Button();
            BtnMusteriler = new Button();
            BtnMaas = new Button();
            BtnStoklar = new Button();
            BtnMemnuniyet = new Button();
            BtnHakkimizda = new Button();
            label1 = new Label();
            label2 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button1 = new Button();
            BtnSifreGuncelle = new Button();
            SuspendLayout();
            // 
            // BtnAdminGiris
            // 
            BtnAdminGiris.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            BtnAdminGiris.Location = new Point(24, 38);
            BtnAdminGiris.Name = "BtnAdminGiris";
            BtnAdminGiris.Size = new Size(146, 85);
            BtnAdminGiris.TabIndex = 0;
            BtnAdminGiris.Text = "Admin Giriş";
            BtnAdminGiris.UseVisualStyleBackColor = true;
            BtnAdminGiris.Click += BtnAdminGiris_Click;
            // 
            // BtnOdalar
            // 
            BtnOdalar.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            BtnOdalar.Location = new Point(213, 42);
            BtnOdalar.Name = "BtnOdalar";
            BtnOdalar.Size = new Size(146, 85);
            BtnOdalar.TabIndex = 1;
            BtnOdalar.Text = "Odalar";
            BtnOdalar.UseVisualStyleBackColor = true;
            BtnOdalar.Click += BtnOdalar_Click;
            // 
            // BtnMusEkleEkran
            // 
            BtnMusEkleEkran.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMusEkleEkran.Location = new Point(586, 42);
            BtnMusEkleEkran.Name = "BtnMusEkleEkran";
            BtnMusEkleEkran.Size = new Size(226, 85);
            BtnMusEkleEkran.TabIndex = 2;
            BtnMusEkleEkran.Text = "Müşteri Ekleme Ekranı";
            BtnMusEkleEkran.UseVisualStyleBackColor = true;
            BtnMusEkleEkran.Click += BtnMusEkleEkran_Click;
            // 
            // BtnMusteriler
            // 
            BtnMusteriler.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMusteriler.Location = new Point(403, 42);
            BtnMusteriler.Name = "BtnMusteriler";
            BtnMusteriler.Size = new Size(146, 85);
            BtnMusteriler.TabIndex = 3;
            BtnMusteriler.Text = "Müşteriler";
            BtnMusteriler.UseVisualStyleBackColor = true;
            BtnMusteriler.Click += BtnMusteriler_Click;
            // 
            // BtnMaas
            // 
            BtnMaas.BackColor = SystemColors.ControlLight;
            BtnMaas.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMaas.Location = new Point(586, 197);
            BtnMaas.Name = "BtnMaas";
            BtnMaas.Size = new Size(226, 85);
            BtnMaas.TabIndex = 4;
            BtnMaas.Text = "Gelir-Gider Formu";
            BtnMaas.UseVisualStyleBackColor = false;
            BtnMaas.Click += BtnMaas_Click;
            // 
            // BtnStoklar
            // 
            BtnStoklar.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            BtnStoklar.Location = new Point(24, 197);
            BtnStoklar.Name = "BtnStoklar";
            BtnStoklar.Size = new Size(146, 85);
            BtnStoklar.TabIndex = 5;
            BtnStoklar.Text = "Stoklar";
            BtnStoklar.UseVisualStyleBackColor = true;
            BtnStoklar.Click += BtnStoklar_Click;
            // 
            // BtnMemnuniyet
            // 
            BtnMemnuniyet.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            BtnMemnuniyet.Location = new Point(213, 197);
            BtnMemnuniyet.Name = "BtnMemnuniyet";
            BtnMemnuniyet.Size = new Size(146, 85);
            BtnMemnuniyet.TabIndex = 6;
            BtnMemnuniyet.Text = "Müşteri Mesajları";
            BtnMemnuniyet.UseVisualStyleBackColor = true;
            BtnMemnuniyet.Click += BtnMemnuniyet_Click;
            // 
            // BtnHakkimizda
            // 
            BtnHakkimizda.Font = new Font("Georgia", 12F, FontStyle.Italic, GraphicsUnit.Point);
            BtnHakkimizda.Location = new Point(403, 197);
            BtnHakkimizda.Name = "BtnHakkimizda";
            BtnHakkimizda.Size = new Size(146, 85);
            BtnHakkimizda.TabIndex = 8;
            BtnHakkimizda.Text = "Hakkımızda";
            BtnHakkimizda.UseVisualStyleBackColor = true;
            BtnHakkimizda.Click += BtnHakkimizda_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(851, 86);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 9;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(851, 138);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 10;
            label2.Text = "label2";
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // button1
            // 
            button1.BackColor = Color.Red;
            button1.Location = new Point(715, 326);
            button1.Name = "button1";
            button1.Size = new Size(97, 32);
            button1.TabIndex = 11;
            button1.Text = "ÇIKIŞ";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // BtnSifreGuncelle
            // 
            BtnSifreGuncelle.BackColor = Color.Ivory;
            BtnSifreGuncelle.Location = new Point(536, 326);
            BtnSifreGuncelle.Name = "BtnSifreGuncelle";
            BtnSifreGuncelle.Size = new Size(136, 52);
            BtnSifreGuncelle.TabIndex = 12;
            BtnSifreGuncelle.Text = "Şifre Güncelle";
            BtnSifreGuncelle.UseVisualStyleBackColor = false;
            BtnSifreGuncelle.Click += BtnSifreGuncelle_Click;
            // 
            // FrmAnaForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.BurlyWood;
            ClientSize = new Size(1012, 461);
            Controls.Add(BtnSifreGuncelle);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(BtnHakkimizda);
            Controls.Add(BtnMemnuniyet);
            Controls.Add(BtnStoklar);
            Controls.Add(BtnMaas);
            Controls.Add(BtnMusteriler);
            Controls.Add(BtnMusEkleEkran);
            Controls.Add(BtnOdalar);
            Controls.Add(BtnAdminGiris);
            ForeColor = SystemColors.ActiveCaptionText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmAnaForm";
            Text = "FrmAnaForm";
            Load += FrmAnaForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnAdminGiris;
        private Button BtnOdalar;
        private Button BtnMusEkleEkran;
        private Button BtnMusteriler;
        private Button BtnMaas;
        private Button BtnStoklar;
        private Button BtnMemnuniyet;
        private Button BtnHakkimizda;
        private Label label1;
        private Label label2;
        private System.Windows.Forms.Timer timer1;
        private Button button1;
        private Button BtnSifreGuncelle;
    }
}