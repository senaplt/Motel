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
    public partial class FrmStoklar : Form
    {
        public FrmStoklar()
        {
            InitializeComponent();
        }

        string connectionString = "Server=DESKTOP-LJCF444\\SQLEXPRESS;Database=Motel;Integrated Security=True;";


        private void Veriler()
        {
            listView1.Items.Clear();
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            string sql = "Select * from Stoklar";
            SqlCommand komut = new SqlCommand(sql, baglanti);

            SqlDataReader reader = komut.ExecuteReader();

            while (reader.Read())
            {

                ListViewItem ekle = new ListViewItem();

                ekle.Text = reader["Gidalar"].ToString();
                ekle.SubItems.Add(reader["Icecekler"].ToString());
                ekle.SubItems.Add(reader["Atistirmaliklar"].ToString());

                listView1.Items.Add(ekle);

            }
            baglanti.Close();
        }


        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(connectionString);
            baglanti.Open();
            string sql = "Insert into Stoklar (Gidalar,Icecekler, Atistirmaliklar) values ('" + TxtGida.Text + "','" + TxtIcecekler.Text + "','" + TxtAtistirmalik.Text + "')";
            SqlCommand komut = new SqlCommand(sql, baglanti);
            komut.ExecuteReader();
            baglanti.Close();
            Veriler();

        }

        private void FrmStoklar_Load(object sender, EventArgs e)
        {
            Veriler();
        }
    }
}
