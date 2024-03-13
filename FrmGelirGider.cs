using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Motel
{
    public partial class FrmGelirGider : Form
    {
        public FrmGelirGider()
        {
            InitializeComponent();
        }
        string connectionString = "Server=DESKTOP-LJCF444\\SQLEXPRESS;Database=Motel;Integrated Security=True;";
        private void BtnHesapla_Click(object sender, EventArgs e)
        {

            if (int.TryParse(textBox1.Text, out int personel))
            {
                LblPM00.Text = (personel * 20000).ToString();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir sayı girin.");
            }

            int sonuc;

            sonuc = Convert.ToInt32(LblKTT00.Text) - (Convert.ToInt32(LblPM00.Text)) + (Convert.ToInt16(LblFaturalar00.Text));
            LblSonuc00.Text = sonuc.ToString();
        }

        private void FrmGelirGider_Load(object sender, EventArgs e)
        {

            SqlConnection baglanti = new SqlConnection(connectionString);

            ///////////////// Kasadaki Toplam Tutar
            baglanti.Open();
            string sql = "Select SUM (Ucret) as Toplam from MusteriEkleme";
            SqlCommand komut = new SqlCommand(sql, baglanti);

            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {
                LblKTT00.Text = reader["Toplam"].ToString();
            }
            baglanti.Close();
            ////////////////////////////////////////////////////////
            /// Stokların Giderleri 
            baglanti.Open();
            string sql1 = "Select SUM (Gidalar) as Toplam1 from Stoklar";
            SqlCommand komut1 = new SqlCommand(sql1, baglanti);

            SqlDataReader reader1 = komut1.ExecuteReader();

            while (reader1.Read())
            {
                LblAUTGida00.Text = reader1["Toplam1"].ToString();
            }
            baglanti.Close();

            // int personel = Convert.ToInt16(textBox1.Text);
            // LblPM00.Text = (personel * 20000).ToString();

            baglanti.Open();
            string sql2 = "Select SUM (Icecekler) as Toplam2 from Stoklar";
            SqlCommand komut2 = new SqlCommand(sql2, baglanti);

            SqlDataReader reader2 = komut2.ExecuteReader();

            while (reader2.Read())
            {
                LblAUTIcecek00.Text = reader2["Toplam2"].ToString();
            }
            baglanti.Close();

            ///////////////////////////
            ///
            baglanti.Open();
            string sql3 = "Select SUM (Atistirmaliklar) as Toplam3 from Stoklar";
            SqlCommand komut3 = new SqlCommand(sql3, baglanti);

            SqlDataReader reader3 = komut3.ExecuteReader();

            while (reader3.Read())
            {
                LblAUTAtistirma00.Text = reader3["Toplam3"].ToString();
            }
            baglanti.Close();

            /////// Faturalar
            baglanti.Open();
            string sql4 = "Select SUM(Gidalar + Icecekler + Atistirmaliklar) as Toplam4 from Stoklar";
            SqlCommand komut4 = new SqlCommand(sql4, baglanti);

            SqlDataReader reader4 = komut4.ExecuteReader();

            while (reader4.Read())
            {
                LblFaturalar00.Text = reader4["Toplam4"].ToString();
            }
            baglanti.Close();


        }
    }
}
