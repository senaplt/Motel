using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Security;


namespace Motel
{
    public partial class FrmAdminGiris : Form
    {
        public FrmAdminGiris()
        {
            InitializeComponent();


        }
        string connectionString = "Server=DESKTOP-LJCF444\\SQLEXPRESS;Database=Motel;Integrated Security=True;";
        public void button2_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection baglanti = new SqlConnection(connectionString)) // connectionString'i kendi ba�lant� dizesiyle de�i�tirin
                {
                    baglanti.Open();

                    string sql = "SELECT COUNT(*) FROM AdminGiris WHERE Kullanici = @Kullaniciadi AND Sifre = @Sifresi";

                    SqlCommand komut = new SqlCommand(sql, baglanti);

                    komut.Parameters.AddWithValue("@Kullaniciadi", TxtKullaniciAdi.Text.Trim());
                    komut.Parameters.AddWithValue("@Sifresi", TxtSifre.Text.Trim());

                    int count = (int)komut.ExecuteScalar(); // Kullan�c� giri�i do�rulama i�in sorgunun sonucunu al�r.

                    if (count > 0)
                    {
                        FrmAnaForm frmAnaForm = new FrmAnaForm();
                        frmAnaForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Kullan�c� ad� veya �ifre hatal�.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata olu�tu: " + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("��k�� Yap�ld�.");
            Application.Exit();
        }
    }
}