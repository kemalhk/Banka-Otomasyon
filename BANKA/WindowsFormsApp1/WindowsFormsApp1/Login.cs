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
using Dapper;

namespace WindowsFormsApp1
{
    public partial class Login : Form
    {
        private string connectionString = "Data Source=DESKTOP-D6Q3R77\\SQLEXPRESS01;Initial Catalog=Banka;Integrated Security=True";
        public Login()
        {
            InitializeComponent();
        }
        public static int giden;
        private void btnGiris_Click(object sender, EventArgs e)
        {
            KullaniciModel kullanici;
            using (var connection = new SqlConnection(connectionString))
            {
                kullanici = connection.QueryFirstOrDefault<KullaniciModel>("SELECT * FROM Kullanici WHERE KullaniciAdi = @KullaniciAdi AND Sifre = @Sifre", new
                {
                    KullaniciAdi = txtKullaniciAdi.Text,
                    Sifre = txtSifre.Text
                });

                if (kullanici == null)
                {
                    MessageBox.Show("Kullanıcı adı ya da şifre yanlış.");
                    return;
                }
            }

            if (kullanici.PersonelID != null)
            {
                Admin Admin = new Admin();//açılacak form
                Admin.Show(); //form 2 açılıyor.
                Hide(); // Login formunu kapatır
            }
            else if (kullanici.MusteriID != null)
            {
                giden = Convert.ToInt32(kullanici.MusteriID);
                Musteri Musteri = new Musteri();//açılacak form
                Musteri.Show(); //form 2 açılıyor.
                Hide(); // Login formunu kapatır
            }
            else if (kullanici.YoneticiID != null)
            {
                Yonetici Yonetici = new Yonetici();//açılacak form
                Yonetici.Show(); //form 2 açılıyor.
                Hide(); // Login formunu kapatır
            }

            else
            {
                MessageBox.Show("Kullanıcı Müşteri ya da Personel değil!");
                return;
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
