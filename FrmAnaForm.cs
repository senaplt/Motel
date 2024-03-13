using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motel
{
    public partial class FrmAnaForm : Form
    {
        public FrmAnaForm()
        {
            InitializeComponent();
        }

        private void BtnMusteriler_Click(object sender, EventArgs e)
        {
            FrmMusteriler frm = new FrmMusteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BtnMusteriler.Enabled = false;
            }
            else
                BtnMusteriler.Enabled = true;
        }

        private void BtnAdminGiris_Click(object sender, EventArgs e)
        {
            FrmAdminGiris frm = new FrmAdminGiris();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BtnAdminGiris.Enabled = false;
            }
            else
                BtnAdminGiris.Enabled = true;
        }

        private void BtnOdalar_Click(object sender, EventArgs e)
        {
            FrmOdalar frm = new FrmOdalar();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BtnOdalar.Enabled = false;
            }
            else
                BtnOdalar.Enabled = true;
        }

        private void BtnMusEkleEkran_Click(object sender, EventArgs e)
        {
            FrmMusteriEkle frm = new FrmMusteriEkle();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BtnMusEkleEkran.Enabled = false;
            }
            else
                BtnMusEkleEkran.Enabled = true;
        }

        private bool hakkimizdaMesajiGosterildi = false; // Mesaj kutusu gösterildi mi?

        private void BtnHakkimizda_Click(object sender, EventArgs e)
        {
            if (!hakkimizdaMesajiGosterildi)
            {
                MessageBox.Show("Motel Pansiyonu Kayıt Uygulaması / 2024 - Tüm Hakları Saklıdır.");
                hakkimizdaMesajiGosterildi = true; // Mesaj kutusunun gösterildiğini işaretle
            }
        }
        private void BtnMaas_Click(object sender, EventArgs e)
        {
            FrmGelirGider frm = new FrmGelirGider();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BtnMaas.Enabled = false;
            }
            else
                BtnMaas.Enabled = true;

        }

        private void FrmAnaForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnStoklar_Click(object sender, EventArgs e)
        {
            FrmStoklar frm = new FrmStoklar();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BtnStoklar.Enabled = false;
            }
            else
                BtnStoklar.Enabled = true;

        }

        private void BtnSifreGuncelle_Click(object sender, EventArgs e)
        {
            FrmSifreGuncelle frm = new FrmSifreGuncelle();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BtnSifreGuncelle.Enabled = false;
            }
            else
                BtnSifreGuncelle.Enabled = true;
        }

        private void BtnMemnuniyet_Click(object sender, EventArgs e)
        {
            FrmMesajlar frm = new FrmMesajlar();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                BtnMemnuniyet.Enabled = false;
            }
            else
                BtnMemnuniyet.Enabled = true;

        }
    }
}
