namespace Motel
{
    partial class FrmMesajlar
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
            LblAdSoyad = new Label();
            TxtAdSoyad = new TextBox();
            LblMesaj = new Label();
            RichTxtMesaj = new RichTextBox();
            BtnKaydet = new Button();
            listView1 = new ListView();
            columnHeader1 = new ColumnHeader();
            columnHeader2 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            TxtID = new TextBox();
            LblID = new Label();
            SuspendLayout();
            // 
            // LblAdSoyad
            // 
            LblAdSoyad.AutoSize = true;
            LblAdSoyad.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblAdSoyad.Location = new Point(12, 71);
            LblAdSoyad.Name = "LblAdSoyad";
            LblAdSoyad.Size = new Size(92, 23);
            LblAdSoyad.TabIndex = 0;
            LblAdSoyad.Text = "Ad Soyad :";
            // 
            // TxtAdSoyad
            // 
            TxtAdSoyad.Location = new Point(145, 70);
            TxtAdSoyad.Name = "TxtAdSoyad";
            TxtAdSoyad.Size = new Size(327, 27);
            TxtAdSoyad.TabIndex = 1;
            // 
            // LblMesaj
            // 
            LblMesaj.AutoSize = true;
            LblMesaj.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblMesaj.Location = new Point(12, 156);
            LblMesaj.Name = "LblMesaj";
            LblMesaj.Size = new Size(64, 23);
            LblMesaj.TabIndex = 2;
            LblMesaj.Text = "Mesaj :";
            // 
            // RichTxtMesaj
            // 
            RichTxtMesaj.Location = new Point(145, 152);
            RichTxtMesaj.Name = "RichTxtMesaj";
            RichTxtMesaj.Size = new Size(327, 120);
            RichTxtMesaj.TabIndex = 3;
            RichTxtMesaj.Text = "";
            // 
            // BtnKaydet
            // 
            BtnKaydet.BackColor = Color.HotPink;
            BtnKaydet.Location = new Point(378, 315);
            BtnKaydet.Name = "BtnKaydet";
            BtnKaydet.Size = new Size(94, 38);
            BtnKaydet.TabIndex = 4;
            BtnKaydet.Text = "Kaydet";
            BtnKaydet.UseVisualStyleBackColor = false;
            BtnKaydet.Click += BtnKaydet_Click;
            // 
            // listView1
            // 
            listView1.Columns.AddRange(new ColumnHeader[] { columnHeader1, columnHeader2, columnHeader3 });
            listView1.Location = new Point(1, 385);
            listView1.Name = "listView1";
            listView1.Size = new Size(588, 168);
            listView1.TabIndex = 5;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "ID";
            columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "Ad Soyad";
            columnHeader2.Width = 150;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Mesaj";
            columnHeader3.Width = 350;
            // 
            // TxtID
            // 
            TxtID.Location = new Point(145, 12);
            TxtID.Name = "TxtID";
            TxtID.Size = new Size(327, 27);
            TxtID.TabIndex = 7;
            // 
            // LblID
            // 
            LblID.AutoSize = true;
            LblID.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            LblID.Location = new Point(12, 16);
            LblID.Name = "LblID";
            LblID.Size = new Size(99, 23);
            LblID.TabIndex = 6;
            LblID.Text = "Müşteri ID :";
            // 
            // FrmMesajlar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = Color.LightPink;
            ClientSize = new Size(588, 548);
            Controls.Add(TxtID);
            Controls.Add(LblID);
            Controls.Add(listView1);
            Controls.Add(BtnKaydet);
            Controls.Add(RichTxtMesaj);
            Controls.Add(LblMesaj);
            Controls.Add(TxtAdSoyad);
            Controls.Add(LblAdSoyad);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmMesajlar";
            Text = "FrmMesajlar";
            Load += FrmMesajlar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblAdSoyad;
        private TextBox TxtAdSoyad;
        private Label LblMesaj;
        private RichTextBox RichTxtMesaj;
        private Button BtnKaydet;
        private ListView listView1;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private TextBox TxtID;
        private Label LblID;
    }
}