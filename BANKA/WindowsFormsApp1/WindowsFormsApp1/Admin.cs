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
    public partial class Admin : Form
    {
        private int musteriID;
        private string connectionString = "Data Source=DESKTOP-D6Q3R77\\SQLEXPRESS01;Initial Catalog=Banka;Integrated Security=True";


        public Admin()
        {
            InitializeComponent();
        }

        private void MusteriListle()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = @"select * from musteri";
                var musterilist = connection.Query<MusteriModel>(sql).ToList();


                dataGridView1.DataSource = musterilist;
            }
        }
        private void HesapListele()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var sql = @"select * from hesap";
                var musterilist = connection.Query<HesapModel>(sql).ToList();


                dataGridView2.DataSource = musterilist;
            }
        }

        private void Admin_Load(object sender, EventArgs e)
        {
            MusteriListle();
            HesapListele();
            using (var connection = new SqlConnection(connectionString))
            {
                var musteriList = connection.Query<MusteriModel>("select * from musteri").ToList();
                cmbMusteri.DataSource = musteriList;
                cmbMusteri.DisplayMember = "KimlikNumarasi";
                cmbMusteri.ValueMember = "MusteriID";
            }
        }



       




        private void btnYeni_Click(object sender, EventArgs e)
        {
            //textboxları temizlemek için 
            musteriID = -1;
            txtAd.Text = null;
            txtSoyad.Text = null;
            txtTC.Text = null;
            txtAdres.Text = null;
            txtTelefon.Text = null;
            txtEposta.Text = null;
            dtpDogumTarihi.Value = new DateTime(1900, 1, 1);
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Form kontrolleri (alanlar boş mu değil mi diye kontrol eder
            if (string.IsNullOrEmpty(txtAd.Text) || string.IsNullOrEmpty(txtSoyad.Text) || string.IsNullOrEmpty(txtTC.Text) || string.IsNullOrEmpty(txtAdres.Text) || string.IsNullOrEmpty(txtTelefon.Text)
                || string.IsNullOrEmpty(txtEposta.Text) || dtpDogumTarihi.Value == new DateTime(1900, 1, 1))
            {
                MessageBox.Show("Alanlar boş geçilemez.");
                return;
            }

            if (musteriID != -1)
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    //kullanıcı güncelleme işlemleri
                    connection.Execute(@"UPDATE 
                    Musteri 
                    SET 
                        Ad = @Ad,
                        Soyad = @Soyad,
                        KimlikNumarasi = @KimlikNumarasi,
                        Adres = @Adres,
                        TelefonNo = @TelefonNo,
                        DogumTarihi = @DogumTarihi,
                        Email = @Email
                    WHERE
                        MusteriID = @MusteriID
                    ", new
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        KimlikNumarasi = txtTC.Text,
                        Adres = txtAdres.Text,
                        TelefonNo = txtTelefon.Text,
                        DogumTarihi = dtpDogumTarihi.Value,
                        Email = txtEposta.Text,
                        MusteriID = musteriID
                    });
                    MusteriListle();

                }
                MusteriListle();

            }
            else
            {
                //eğer kullanıcı kaydı yoksa yeni kayıt ekleme işlemleri
                using (var connection = new SqlConnection(connectionString))
                {

                    // tekrarlanan kayıt engelleme
                    var kullanici = connection.QueryFirstOrDefault<KullaniciModel>("Select * from Musteri WHERE KimlikNumarasi=@KimlikNumarasi",
                        new
                        {
                            KimlikNumarasi = txtTC.Text
                        });
                    if (kullanici != null)
                    {
                        MessageBox.Show("Müşteri zaten kayıtlı.");
                        return;
                    }


                    // kayıtlı kullanıcı yoksa ekleme işlemleri
                    connection.Execute(@"
                        INSERT INTO 
	                        Musteri 
	                        ([Ad], [Soyad], [KimlikNumarasi], [Adres], [TelefonNo], [DogumTarihi], [Email], [KayitTarihi]) 
                        VALUES 
	                    (@Ad, @Soyad, @KimlikNumarasi, @Adres, @TelefonNo, @DogumTarihi, @Email, @KayitTarihi)
                    ", new
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        KimlikNumarasi = txtTC.Text,
                        Adres = txtAdres.Text,
                        TelefonNo = txtTelefon.Text,
                        DogumTarihi = dtpDogumTarihi.Value,
                        Email = txtEposta.Text,
                        KayitTarihi = DateTime.Now
                    });
                    var musteri = connection.QueryFirstOrDefault<MusteriModel>("select * from musteri where kimliknumarasi=@kimliknumarasi", new { kimliknumarasi = txtTC.Text });

                    if (musteri == null)
                    {
                        MessageBox.Show("Müşteri oluşturulurken hata oluştu");
                        return;
                    }

                    connection.Execute(@"
                        INSERT INTO 
	                        Kullanici 
	                        ([KullaniciAdi], [Sifre], [MusteriID]) 
                        VALUES 
	                    (@KullaniciAdi, @Sifre,@MusteriID)
                    ", new
                    {
                        KullaniciAdi = txtTC.Text,
                        Sifre = txtTC.Text + "_" + txtTelefon.Text,
                        MusteriID = musteri.MusteriID
                    });

                }
                MusteriListle();

            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            // kullanıcı silme işlemleri 
            using (var connection = new SqlConnection(connectionString))
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {

                    connection.Execute(@"delete from Kullanici

                             where MusteriID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'"
                            );


                    connection.Execute(@"delete from Hesap

                             where MusteriID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'"
                            );
                    connection.Execute(@"delete from Musteri

                             where MusteriID = '" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + "'"
                            );
                    MusteriListle();

                }
                else
                {
                    MessageBox.Show("Lüffen silinecek satırı seçin.");
                }
            }
        }

        private void btnGeriDon_Click(object sender, EventArgs e)
        {
            Login Login = new Login();//açılacak form
            Login.Show(); //login 2 açılıyor.
            Hide(); // Login formunu kapatır
        }

        private void btnGeriDonHesap_Click(object sender, EventArgs e)
        {
            Login Login = new Login();//açılacak form
            Login.Show(); //login 2 açılıyor.
            Hide(); // Login formunu kapatır
        }

        

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

            /// 
            /// HESAP İŞLEMLERİ
            /// 
            

        private void btnSilHesap_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Execute(@"delete from Hesap

                where HesapNo = '" + dataGridView2.CurrentRow.Cells[1].Value.ToString() + "'"
             );
                MessageBox.Show("Silme işlemi başarılı");
                HesapListele();

            }
        }


        private void btnHesapKaydet_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                //   iban oluştrma
                int iban = 3142334;
                var toplam = connection.QueryFirstOrDefault<int>("Select COUNT(*) From Hesap");

                MusteriModel musteri;
                musteri = connection.QueryFirstOrDefault<MusteriModel>("Select * From Musteri Where  MusteriID=@MusteriID", new
                {
                    musteriID = cmbMusteri.SelectedValue

                }) ;

                connection.Execute(@"
                        INSERT INTO 
	                        Hesap 
	                        ([Bakiye],[Iban],[MusteriID]) 
                        VALUES 
	                    (@Bakiye,@Iban,@MusteriID)
                    ", new
                {
                    Bakiye = txtBakiye.Text,
                    Iban = iban+""+ toplam,
                    MusteriID = musteri.MusteriID
                });

                MessageBox.Show("Kayıt Başarılı");
                HesapListele();

            }

        }



        private void btnYeniHesap_Click(object sender, EventArgs e)
        {
            txtBakiye.Text = null;
            cmbMusteri.Text = null;
        }

        private void Admin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var musteriList = connection.Query<MusteriModel>("select * from musteri").ToList();
                cmbMusteri.DataSource = musteriList;
                cmbMusteri.DisplayMember = "KimlikNumarasi";
                cmbMusteri.ValueMember = "MusteriID";
            }
        }

        private void dataGridView1_RowEnter_1(object sender, DataGridViewCellEventArgs e)
        {
            //Datagridte tıklanan satırı üstteki textboxlara atar
            musteriID = (int)(dataGridView1.Rows[e.RowIndex]?.Cells[0]?.Value ?? -1); // ?? soldaki null ise sağdakini atar
            txtAd.Text = dataGridView1.Rows[e.RowIndex]?.Cells[1]?.Value?.ToString(); // ? null değilse işleme alır
            txtSoyad.Text = dataGridView1.Rows[e.RowIndex]?.Cells[2]?.Value?.ToString();
            txtTC.Text = dataGridView1.Rows[e.RowIndex]?.Cells[3]?.Value?.ToString();
            txtAdres.Text = dataGridView1.Rows[e.RowIndex]?.Cells[4]?.Value?.ToString();
            txtTelefon.Text = dataGridView1.Rows[e.RowIndex]?.Cells[5]?.Value?.ToString();
            dtpDogumTarihi.Value = Convert.ToDateTime(dataGridView1.Rows[e.RowIndex]?.Cells[6]?.Value ?? DateTime.Now);
            txtEposta.Text = dataGridView1.Rows[e.RowIndex]?.Cells[7]?.Value?.ToString();
        }

        private void musteriBindingSource_CurrentChanged(object sender, EventArgs e)
        {
                    }
    }
}
