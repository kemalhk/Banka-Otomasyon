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
    public partial class Yonetici : Form
    {
        private int PersonelID;
        private string connectionString = "Data Source=DESKTOP-D6Q3R77\\SQLEXPRESS01;Initial Catalog=Banka;Integrated Security=True";
        public Yonetici()
        {
            InitializeComponent();
        }
        private void PersonelListele()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = @"select * from personel";
                var personellist = connection.Query<PersonelModel>(sql).ToList();


                dataGridView1.DataSource = personellist;
            }
        }
        private void Yonetici_Load(object sender, EventArgs e)
        {

            PersonelListele();
        }


        private void btnYeniPersonel_Click(object sender, EventArgs e)
        {
            //textboxları temizlemek için 
            PersonelID = -1;
            txtAdPersonel.Text = null;
            txtSoyadPersonel.Text = null;
            txtTcPersonel.Text = null;
            txtAdresPersonel.Text = null;
            txtTelefonPersonel.Text = null;
            txtEpostaPersonel.Text = null;
            dtpDogumTarihiPersonel.Value = new DateTime(1900, 1, 1);
        }

        private void btnSilPersonel_Click(object sender, EventArgs e)
        {
            // personel silme işlemleri 
            using (var connection = new SqlConnection(connectionString))
            {
                if (dataGridView1.SelectedRows.Count > 0) //satır seçili olup olmadığını kontrol eder
                {
                    connection.Execute(@"delete from Kullanici

                             where PersonelID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'"
                            );
                    connection.Execute(@"delete from Personel

                             where PersonelID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'"
                           );

                    PersonelListele();

                }
                else
                {
                    MessageBox.Show("Lüffen silinecek satırı seçin.");
                }
                MessageBox.Show("İşlem Başarılı");
            }
        }

        private void btnKaydetPersonel_Click(object sender, EventArgs e)
        {
            // Form kontrolleri (alanlar boş mu değil mi diye kontrol eder
            if (string.IsNullOrEmpty(txtAdPersonel.Text) || string.IsNullOrEmpty(txtSoyadPersonel.Text) || string.IsNullOrEmpty(txtTcPersonel.Text)
                || string.IsNullOrEmpty(txtAdresPersonel.Text) || string.IsNullOrEmpty(txtTelefonPersonel.Text)
                || string.IsNullOrEmpty(txtEpostaPersonel.Text) || dtpDogumTarihiPersonel.Value == new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }

            if (PersonelID != -1)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    //Personel güncelleme işlemleri
                    connection.Execute(@"UPDATE 
                    Personel 
                    SET 
                        Ad = @Ad,
                        Soyad = @Soyad,
                        KimlikNumarasi = @KimlikNumarasi,
                        Adres = @Adres,
                        TelefonNo = @TelefonNo,
                        DogumTarihi = @DogumTarihi,
                        Email = @Email
                    WHERE
                        PersonelID = @PersonelID
                    ", new
                    {
                        Ad = txtAdPersonel.Text,
                        Soyad = txtSoyadPersonel.Text,
                        KimlikNumarasi = txtTcPersonel.Text,
                        Adres = txtAdresPersonel.Text,
                        TelefonNo = txtTelefonPersonel.Text,
                        DogumTarihi = dtpDogumTarihiPersonel.Value,
                        Email = txtEpostaPersonel.Text,
                        PersonelID = PersonelID
                    });
                }
                PersonelListele();
            }


            else
            {
                
                //eğer personel kaydı yoksa yeni kayıt ekleme işlemleri
                using (var connection = new SqlConnection(connectionString))
                {
                    // tekrarlanan kayıt engelleme
                    var kullanici = connection.QueryFirstOrDefault<PersonelModel>("Select * from Personel WHERE KimlikNumarasi=@KimlikNumarasi",
                        new
                        {
                            KimlikNumarasi = txtTcPersonel.Text
                        });
                    if (kullanici != null)
                    {
                        MessageBox.Show("Personel zaten kayıtlı.");
                        return;
                    }

                    // kayıtlı kullanıcı yoksa ekleme işlemleri
                    connection.Execute(@"
                        INSERT INTO 
	                        Personel 
	                        ([Ad], [Soyad], [KimlikNumarasi], [Adres], [TelefonNo], [DogumTarihi], [Email]) 
                        VALUES 
	                    (@Ad, @Soyad, @KimlikNumarasi, @Adres, @TelefonNo, @DogumTarihi, @Email)
                    ", new
                    {
                        Ad = txtAdPersonel.Text,
                        Soyad = txtSoyadPersonel.Text,
                        KimlikNumarasi = txtTcPersonel.Text,
                        Adres = txtAdresPersonel.Text,
                        TelefonNo = txtTelefonPersonel.Text,
                        DogumTarihi = dtpDogumTarihiPersonel.Value,
                        Email = txtEpostaPersonel.Text,
                    });

                    var personel = connection.QueryFirstOrDefault<PersonelModel>("select * from personel where kimliknumarasi=@kimliknumarasi", new { kimliknumarasi = txtTcPersonel.Text });

                    connection.Execute(@"
                        INSERT INTO 
	                        Kullanici 
	                        ([KullaniciAdi], [Sifre], [PersonelID]) 
                        VALUES 
	                    (@KullaniciAdi, @Sifre,@PersonelID)
                    ", new
                    {
                        KullaniciAdi = txtTcPersonel.Text,
                        Sifre = txtTcPersonel.Text + "_" + txtTelefonPersonel.Text,
                        PersonelID = personel.PersonelID

                    });
                    MessageBox.Show("Kayıt Başarılı");
                    PersonelListele();
                }


            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Login Login = new Login();//açılacak form
            Login.Show(); //login 2 açılıyor.
            Hide(); // Login formunu kapatır
        }

        private void Yonetici_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        private void btnListele_Click(object sender, EventArgs e)
        {
            PersonelListele();
        }

        private void dataGridView1_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridte tıklanan satırı üstteki textboxlara atar
            PersonelID = (int)(dataGridView1.Rows[e.RowIndex]?.Cells[0]?.Value ?? -1); // ?? soldaki null ise sağdakini atar
            txtAdPersonel.Text = dataGridView1.Rows[e.RowIndex]?.Cells[1]?.Value?.ToString(); // ? null değilse işleme alır
            txtSoyadPersonel.Text = dataGridView1.Rows[e.RowIndex]?.Cells[2]?.Value?.ToString();
            txtTcPersonel.Text = dataGridView1.Rows[e.RowIndex]?.Cells[3]?.Value?.ToString();
            txtAdresPersonel.Text = dataGridView1.Rows[e.RowIndex]?.Cells[4]?.Value?.ToString();
            txtTelefonPersonel.Text = dataGridView1.Rows[e.RowIndex]?.Cells[5]?.Value?.ToString();
            dtpDogumTarihiPersonel.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex]?.Cells[6]?.Value ?? DateTime.Now);
            txtEpostaPersonel.Text = dataGridView1.Rows[e.RowIndex]?.Cells[7]?.Value?.ToString();
        }
    }
}
