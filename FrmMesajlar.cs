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

namespace Motel
{
    public partial class FrmMesajlar : Form
    {
        public FrmMesajlar()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-LJCF444\\SQLEXPRESS;Database=Motel;Integrated Security=True;";

        private void VerileriGoster()
        {
            SqlConnection baglanti = new SqlConnection(connectionString);

            baglanti.Open();
            string sql = "Select * From Mesajlar";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            SqlDataReader oku = komut.ExecuteReader();

            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem(oku["MesajID"].ToString());
                ekle.SubItems.Add(oku["AdSoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());

                listView1.Items.Add(ekle);

            }

            baglanti.Close();

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection baglanti = new SqlConnection(connectionString))
            {
                baglanti.Open();
                string sql = "Insert into Mesajlar(MesajID, AdSoyad, Mesaj) values (@MesajID, @AdSoyad, @Mesaj)";
                SqlCommand komut = new SqlCommand(sql, baglanti);
                komut.Parameters.AddWithValue("@MesajID", TxtID.Text);
                komut.Parameters.AddWithValue("@AdSoyad", TxtAdSoyad.Text);
                komut.Parameters.AddWithValue("@Mesaj", RichTxtMesaj.Text);
                komut.ExecuteNonQuery();
                baglanti.Close();
            }

            listView1.Clear();
            VerileriGoster();
        }

        private void FrmMesajlar_Load(object sender, EventArgs e)
        {
            VerileriGoster();
        }
    }
}
