namespace Motel
{
    partial class FrmStoklar
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
            LblGida = new Label();
            LblIcecek = new Label();
            LblAtistirmalik = new Label();
            TxtGida = new TextBox();
            TxtAtistirmalik = new TextBox();
            TxtIcecekler = new TextBox();
            BtnKaydet = new Button();
            listView1 = new ListView();
            ClmGida = new ColumnHeader();
            ClmIcecekler = new ColumnHeader();
            ClmAtistirmalik = new ColumnHeader();
            SuspendLayout();
            // 
            // LblGida
            // 
            LblGida.AutoSize = true;
            LblGida.Location = new Point(42, 31);
            LblGida.Name = "LblGida";
            LblGida.Size = new Size(89, 20);
            LblGida.TabIndex = 0;
            LblGida.Text = "Gıda Tutarı :";
            // 
            // LblIcecek
            // 
            LblIcecek.AutoSize = true;
            LblIcecek.Location = new Point(32, 88);
            LblIcecek.Name = "LblIcecek";
            LblIcecek.Size = new Size(99, 20);
            LblIcecek.TabIndex = 1;
            LblIcecek.Text = "İçecek Tutarı :";
            // 
            // LblAtistirmalik
            // 
            LblAtistirmalik.AutoSize = true;
            LblAtistirmalik.Location = new Point(23, 149);
            LblAtistirmalik.Name = "LblAtistirmalik";
            LblAtistirmalik.Size = new Size(108, 20);
            LblAtistirmalik.TabIndex = 2;
            LblAtistirmalik.Text = "Atıştırmalıklar :";
            // 
            // TxtGida
            // 
            TxtGida.Location = new Point(147, 28);
            TxtGida.Name = "TxtGida";
            TxtGida.Size = new Size(125, 27);
            TxtGida.TabIndex = 3;
            // 
            // TxtAtistirmalik
            // 
            TxtAtistirmalik.Location = new Point(147, 149);
            TxtAtistirmalik.Name = "TxtAtistirmalik";
            TxtAtistirmalik.Size = new Size(125, 27);
            TxtAtistirmalik.TabIndex = 4;
            // 
            // TxtIcecekler
            // 
            TxtIcecekler.Location = new Point(147, 88);
            TxtIcecekler.Name = "TxtIcecekler";
            TxtIcecekler.Size = new Size(125, 27);
            TxtIcecekler.TabIndex = 5;
            // 
            // BtnKaydet
            // 
            BtnKaydet.Location = new Point(236, 202);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(94, 29);
            BtnKaydet.TabIndex = 6;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = true;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { ClmGida, ClmIcecekler, ClmAtistirmalik });
            listView1.Location = new Point(0, 246);
            listView1.Name = "listView1";
            listView1.Size = new Size(455, 201);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // ClmGida
            // 
            ClmGida.Text = "Gıdalar";
            ClmGida.Width = 150;
            // 
            // ClmIcecekler
            // 
            ClmIcecekler.Text = "İçecekler";
            ClmIcecekler.Width = 150;
            // 
            // ClmAtistirmalik
            // 
            ClmAtistirmalik.Text = "Atıştırmalıklar";
            ClmAtistirmalik.Width = 150;
            // 
            // FrmStoklar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.FromArgb(192, 192, 255);
            ClientSize = new Size(457, 450);
            Controls.Add(listView1);
            Controls.Add(BtnKaydet);
            Controls.Add(TxtIcecekler);
            Controls.Add(TxtAtistirmalik);
            Controls.Add(TxtGida);
            Controls.Add(LblAtistirmalik);
            Controls.Add(LblIcecek);
            Controls.Add(LblGida);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmStoklar";
            Text = "FrmStoklar";
            Load += FrmStoklar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblGida;
        private Label LblIcecek;
        private Label LblAtistirmalik;
        private TextBox TxtGida;
        private TextBox TxtAtistirmalik;
        private TextBox TxtIcecekler;
        private Button BtnKaydet;
        private ListView listView1;
        private ColumnHeader ClmGida;
        private ColumnHeader ClmIcecekler;
        private ColumnHeader ClmAtistirmalik;
    }
}