using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Motel
{
    public partial class FrmMusteriEkle : Form
    {
        public FrmMusteriEkle()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-LJCF444\\SQLEXPRESS;Database=Motel;Integrated Security=True;";


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                // SQL komutunu oluştur
                string sql = "INSERT INTO MusteriEkleme (Adi, Soyadi, Cinsiyet, Telefon, Mail, TC, OdaNo, Ucret, GirisTarihi, CikisTarihi) VALUES (@Adi, @Soyadi, @Cinsiyet, @Telefon, @Mail, @TC, @OdaNo, @Ucret, @GirisTarihi, @CikisTarihi)";
                using (SqlCommand komut = new SqlCommand(sql, baglanti))
                {
                    // Parametreleri ekleyerek SQL komutunu hazırla
                    komut.Parameters.AddWithValue("@Adi", TxtAdi.Text);
                    komut.Parameters.AddWithValue("@Soyadi", TxtSoyadi.Text);
                    komut.Parameters.AddWithValue("@Cinsiyet", TxtCinsiyet.Text);
                    komut.Parameters.AddWithValue("@Telefon", MsTxtTel.Text);
                    komut.Parameters.AddWithValue("@Mail", TxtMail.Text);
                    komut.Parameters.AddWithValue("@TC", TxtTC.Text);
                    komut.Parameters.AddWithValue("@OdaNo", TxtOdaNo.Text);
                    komut.Parameters.AddWithValue("@Ucret", TxtUcret.Text);
                    komut.Parameters.AddWithValue("@GirisTarihi", DtpGirisTarihi.Value);
                    komut.Parameters.AddWithValue("@CikisTarihi", DtpCikisTarihi.Value);

                    try
                    {
                        // Bağlantıyı aç
                        baglanti.Open();

                        // Komutu çalıştır ve etkilenen satır sayısını döndür
                        int rowsAffected = komut.ExecuteNonQuery();

                        // Etkilenen satır sayısını kontrol et
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Müşteri Kaydı Yapıldı.");

                        }
                        else
                        {
                            MessageBox.Show("Müşteri Kaydı Yapılamadı.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Hata: " + ex.Message);
                    }

                    TxtAdi.Text = "";
                    TxtSoyadi.Text = "";
                    TxtCinsiyet.Text = "";
                    MsTxtTel.Text = "";
                    TxtMail.Text = "";
                    TxtTC.Text = "";
                    TxtOdaNo.Text = "";
                    TxtUcret.Text = "";
                    DtpGirisTarihi.Value = DateTime.Now;
                    DtpCikisTarihi.Value = DateTime.Now;



                }
            }

        }

        private void BtnIptal_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Admin sayfasına yönlendiriliyorsunuz.");
            this.Close();


        }


        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                int Ucret;

                DateTime KucukTarih = Convert.ToDateTime(DtpGirisTarihi.Text);
                DateTime BuyukTarih = Convert.ToDateTime(DtpCikisTarihi.Text);

                TimeSpan sonuc;
                sonuc = BuyukTarih - KucukTarih;

                label1.Text = sonuc.TotalDays.ToString();

                Ucret = Convert.ToInt32(label1.Text) * 300;

                TxtUcret.Text = Ucret.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hatalı tarih girdiniz. Tekrar deneyiniz. " + "\n" + ex.Message);

                throw;
            }


        }

        private void BtnOda101_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "101";
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda101 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        private void BtnOda105_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "105";

            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda105 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();

        }

        private void BtnOda106_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "106";
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda106 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda205_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "205";
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda205 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda206_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "206";
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda206 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void BtnOda201_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "201";
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda201 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda202_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "202";
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda202 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda203_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "203";
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda203 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda204_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "204";
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda204 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        private void BtnOda102_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "102";
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda102 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();


        }

        private void BtnOda103_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "103";
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda103 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnOda104_Click(object sender, EventArgs e)
        {
            TxtOdaNo.Text = "104";
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "insert into Oda104 (Adi,Soyadi) values ('" + TxtAdi.Text + "','" + TxtSoyadi.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteNonQuery();
            baglanti.Close();
        }

        private void BtnDolu_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dolu odaları gösterir");
        }

        private void BtnBos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Boş odaları gösterir");
        }

        private void FrmMusteriEkle_Load(object sender, EventArgs e)
        {
            string connectionString = "Server=DESKTOP-LJCF444\\SQLEXPRESS;Database=Motel;Integrated Security=True;";

            SqlConnection baglanti = new SqlConnection(connectionString);

            // ODA 101
            baglanti.Open();

            SqlCommand komut1 = new SqlCommand("Select * from Oda101 ", baglanti);
            SqlDataReader reader = komut1.ExecuteReader();

            while (reader.Read())
            {
                BtnOda101.Text = reader["Adi"].ToString() + " " + reader["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda101.Text != "101")
            {
                BtnOda101.BackColor = Color.Red;
                BtnOda101.Enabled = false;
            }

            // ODA 102
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("Select * from Oda102 ", baglanti);
            SqlDataReader reader2 = komut2.ExecuteReader();

            while (reader2.Read())
            {
                BtnOda102.Text = reader2["Adi"].ToString() + " " + reader2["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda102.Text != "102")
            {
                BtnOda102.BackColor = Color.Red;
                BtnOda102.Enabled = false;
            }
            // ODA 103
            baglanti.Open();

            SqlCommand komut3 = new SqlCommand("Select * from Oda103", baglanti);
            SqlDataReader reader3 = komut3.ExecuteReader();

            while (reader3.Read())
            {
                BtnOda103.Text = reader3["Adi"].ToString() + " " + reader3["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda103.Text != "103")
            {
                BtnOda103.BackColor = Color.Red;
                BtnOda103.Enabled = false;
            }

            // ODA 104
            baglanti.Open();

            SqlCommand komut4 = new SqlCommand("Select * from Oda104 ", baglanti);
            SqlDataReader reader4 = komut4.ExecuteReader();

            while (reader4.Read())
            {
                BtnOda104.Text = reader4["Adi"].ToString() + " " + reader4["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda104.Text != "104")
            {
                BtnOda104.BackColor = Color.Red;
                BtnOda104.Enabled = false;
            }

            //ODA 105
            baglanti.Open();

            SqlCommand komut5 = new SqlCommand("Select * from Oda105 ", baglanti);
            SqlDataReader reader5 = komut5.ExecuteReader();

            while (reader5.Read())
            {
                BtnOda105.Text = reader5["Adi"].ToString() + " " + reader5["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda105.Text != "105")
            {
                BtnOda105.BackColor = Color.Red;
                BtnOda105.Enabled = false;
            }

            //ODA 106
            baglanti.Open();

            SqlCommand komut6 = new SqlCommand("Select * from Oda106 ", baglanti);
            SqlDataReader reader6 = komut6.ExecuteReader();

            while (reader6.Read())
            {
                BtnOda106.Text = reader6["Adi"].ToString() + " " + reader6["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda106.Text != "106")
            {
                BtnOda106.BackColor = Color.Red;
                BtnOda106.Enabled = false;
            }

            // ODA 201
            baglanti.Open();

            SqlCommand komut7 = new SqlCommand("Select * from Oda201 ", baglanti);
            SqlDataReader reader7 = komut7.ExecuteReader();

            while (reader7.Read())
            {
                BtnOda201.Text = reader7["Adi"].ToString() + " " + reader7["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda201.Text != "201")
            {
                BtnOda201.BackColor = Color.Red;
                BtnOda201.Enabled = false;
            }

            // ODA 202
            baglanti.Open();

            SqlCommand komut8 = new SqlCommand("Select * from Oda202 ", baglanti);
            SqlDataReader reader8 = komut8.ExecuteReader();

            while (reader8.Read())
            {
                BtnOda202.Text = reader8["Adi"].ToString() + " " + reader8["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda202.Text != "202")
            {
                BtnOda202.BackColor = Color.Red;
                BtnOda202.Enabled = false;
            }

            // ODA 203
            baglanti.Open();

            SqlCommand komut9 = new SqlCommand("Select * from Oda203 ", baglanti);
            SqlDataReader reader9 = komut9.ExecuteReader();

            while (reader9.Read())
            {
                BtnOda203.Text = reader9["Adi"].ToString() + " " + reader9["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda203.Text != "203")
            {
                BtnOda203.BackColor = Color.Red;
                BtnOda203.Enabled = false;
            }

            // ODA 204
            baglanti.Open();

            SqlCommand komut10 = new SqlCommand("Select * from Oda204 ", baglanti);
            SqlDataReader reader10 = komut10.ExecuteReader();

            while (reader10.Read())
            {
                BtnOda204.Text = reader10["Adi"].ToString() + " " + reader10["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda204.Text != "204")
            {
                BtnOda204.BackColor = Color.Red;
                BtnOda204.Enabled = false;
            }

            // ODA 205
            baglanti.Open();

            SqlCommand komut11 = new SqlCommand("Select * from Oda205 ", baglanti);
            SqlDataReader reader11 = komut11.ExecuteReader();

            while (reader11.Read())
            {
                BtnOda205.Text = reader11["Adi"].ToString() + " " + reader11["Soyadi"].ToString();
            }

            baglanti.Close();

            if (BtnOda205.Text != "205")
            {
                BtnOda205.BackColor = Color.Red;
                BtnOda205.Enabled = false;
            }

            // ODA 206

            baglanti.Open();

            SqlCommand komut12 = new SqlCommand("Select * from Oda206", baglanti);
            SqlDataReader reader12 = komut12.ExecuteReader();

            while (reader12.Read())
            {
                BtnOda206.Text = reader12["Adi"].ToString() + " " + reader12["Soyadi"].ToString();
            }
            baglanti.Close();

            if (BtnOda206.Text != "206")
            {
                BtnOda206.BackColor = Color.Red;
                BtnOda206.Enabled = false;
            }
        }
    }
}
