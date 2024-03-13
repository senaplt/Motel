using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Motel
{
    public partial class FrmSifreGuncelle : Form
    {
        public FrmSifreGuncelle()
        {
            InitializeComponent();
        }
        string connectionString = "Server=DESKTOP-LJCF444\\SQLEXPRESS;Database=Motel;Integrated Security=True;";
        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                try
                {
                    baglanti.Open();

                    string sql = "UPDATE AdminGiris SET Kullanici = @Kullanici, Sifre = @Sifre";

                    SqlCommand komut = new SqlCommand(sql, baglanti);
                    komut.Parameters.AddWithValue("@Kullanici", TxtKullaniciAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@Sifre", TxtSifre.Text.Trim());

                    komut.ExecuteNonQuery();

                    baglanti.Close();
                    MessageBox.Show("Şifre Güncellenmiştir.");

                    TxtKullaniciAdi.Clear();
                    TxtSifre.Clear();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            }


        }
    }
}
