using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Motel
{
    public partial class FrmMusteriler : Form
    {
        public FrmMusteriler()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-LJCF444\\SQLEXPRESS;Database=Motel;Integrated Security=True;";

        private void VerileriGoster()
        {
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "Select * From MusteriEkleme";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem(oku["MusteriID"].ToString());
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);
            }

            // Sütunları otomatik olarak genişlet
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listView1.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            baglanti.Close();
        }
        int id = 0;

        private void listView1_DoubleClick(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count > 0)
            {
                id = int.Parse(listView1.SelectedItems[0].Text);
                TxtAdi.Text = listView1.SelectedItems[0].SubItems[1].Text;
                TxtSoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
                comboBox1.Text = listView1.SelectedItems[0].SubItems[3].Text;
                MsTxtTel.Text = listView1.SelectedItems[0].SubItems[4].Text;
                TxtMail.Text = listView1.SelectedItems[0].SubItems[5].Text;
                TxtTC.Text = listView1.SelectedItems[0].SubItems[6].Text;
                TxtOdaNo.Text = listView1.SelectedItems[0].SubItems[7].Text;
                TxtUcret.Text = listView1.SelectedItems[0].SubItems[8].Text;
                DtpGirisTarihi.Text = listView1.SelectedItems[0].SubItems[9].Text;
                DtpCikisTarihi.Text = listView1.SelectedItems[0].SubItems[10].Text;
            }

        }

        private void BtnVeriGoster_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            VerileriGoster();
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sql = "UPDATE MusteriEkleme SET Adi = @Adi, Soyadi = @Soyadi, Cinsiyet = @Cinsiyet, Telefon = @Telefon, Mail = @Mail, TC = @TC, OdaNo = @OdaNo, Ucret = @Ucret, GirisTarihi = @GirisTarihi, CikisTarihi = @CikisTarihi WHERE MusteriID = @MusteriID";

                    using (SqlCommand komut = new SqlCommand(sql, baglanti))
                    {
                        komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
                        komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
                        komut.Parameters.AddWithValue("@Cinsiyet", comboBox1.Text);
                        komut.Parameters.AddWithValue("@Telefon", MsTxtTel.Text);
                        komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
                        komut.Parameters.AddWithValue("@TC", TxtTC.Text);
                        komut.Parameters.AddWithValue("@OdaNo", OdaNo.Text);
                        komut.Parameters.AddWithValue("@Ucret", Convert.ToDecimal(TxtUcret.Text));
                        komut.Parameters.AddWithValue("@GirisTarihi", DtpGirisTarihi.Value);
                        komut.Parameters.AddWithValue("@CikisTarihi", DtpCikisTarihi.Value);
                        komut.Parameters.AddWithValue("@MusteriID", id);

                        komut.ExecuteNonQuery();
                    }

                    listView1.Items.Clear();
                    VerileriGoster();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
                finally
                {
                    baglanti.Close();
                }
            }

        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);

            try
            {
                baglanti.Open();

                string[] odaNumaralari = { "101", "102", "103", "104", "105", "106", "201", "202", "203", "204", "205", "206" };

                foreach (string odaNo in odaNumaralari)
                {
                    if (TxtOdaNo.Text == odaNo)
                    {
                        SqlCommand komut = new SqlCommand($"DELETE FROM Oda{odaNo} ", baglanti);
                        komut.ExecuteNonQuery();
                        break; // Doğru odanın bulunması durumunda döngüyü sonlandırır.
                    }
                }
                listView1.Items.Clear();
                VerileriGoster();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu: " + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        private void BtnTemizle_Click(object sender, EventArgs e)
        {
            TxtAdi.Clear();
            TxtSoyadi.Clear();
            comboBox1.Text = "";
            MsTxtTel.Clear();
            TxtMail.Text = "";
            TxtTC.Clear();
            TxtOdaNo.Clear();
            DtpCikisTarihi.Text = "";
            DtpGirisTarihi.Text = "";
        }

        private void BtnAra_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "Select * From MusteriEkleme where Adi like '%" + textBox1.Text + "%'";

            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem(oku["MusteriID"].ToString());
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Cinsiyet"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GirisTarihi"].ToString());
                ekle.SubItems.Add(oku["CikisTarihi"].ToString());

                listView1.Items.Add(ekle);

            }

            baglanti.Close();
        }
    }
}
