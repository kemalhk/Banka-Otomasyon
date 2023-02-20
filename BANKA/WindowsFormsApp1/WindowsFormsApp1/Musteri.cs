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
    public partial class Musteri : Form
    {
        public Musteri()
        {
            InitializeComponent();
        }
       
        private string connectionString = "Data Source=DESKTOP-D6Q3R77\\SQLEXPRESS01;Initial Catalog=Banka;Integrated Security=True";
       



        public void HesapListelemeParaCekme() 
        {
            // para çekme hesap listeleme
            using (var connection = new SqlConnection(connectionString))
            {
                var HesapList = connection.Query<HesapModel>("Select * From Hesap Where MusteriID=@MusteriID", new
                {
                    MusteriID = Login.giden
                }).ToList();
                cmbHesapCekme.DataSource = HesapList;
                cmbHesapCekme.DisplayMember = "HesapNo";
                cmbHesapCekme.ValueMember = "HesapNo";
            }
        }

        public void HesapListelemeParaYatirma()
        {
            // para yatırma hesap listeleme
            using (var connection = new SqlConnection(connectionString))
            {
                var HesapList = connection.Query<HesapModel>("Select * From Hesap Where MusteriID=@MusteriID", new
                {
                    MusteriID = Login.giden
                }).ToList();
                cmbHesapPara.DataSource = HesapList;
                cmbHesapPara.DisplayMember = "HesapNo";
                cmbHesapPara.ValueMember = "HesapNo";
            }
        }


        public void HesapListelemeParaGonderme()
        {
            // para gönderme hesap listeleme
            using (var connection = new SqlConnection(connectionString))
            {
                var HesapList = connection.Query<HesapModel>("Select * From Hesap Where MusteriID=@MusteriID", new
                {
                    MusteriID = Login.giden
                }).ToList();
                cmbParaHesap.DataSource = HesapList;
                cmbParaHesap.DisplayMember = "HesapNo";
                cmbParaHesap.ValueMember = "HesapNo";
            }
        }


        public void HesapListelemeOdemeYap()
        {
            // ödeme yapma hesap listeleme
            using (var connection = new SqlConnection(connectionString))
            {
                var HesapList = connection.Query<HesapModel> ("Select * From Hesap Where MusteriID=@MusteriID", new
                {
                    MusteriID = Login.giden
                }).ToList();
                cmbOdemeHesap.DataSource = HesapList;
                cmbOdemeHesap.DisplayMember = "HesapNo";
                cmbOdemeHesap.ValueMember = "HesapNo";
            }
        }

        public void HesapBilgileriListleme()
        {
            // Hesap Bilgileri listeleme
            using (var connection = new SqlConnection(connectionString))
            {
                var HesapList = connection.Query<HesapModel>("Select * From Hesap Where MusteriID=@MusteriID", new
                {
                    MusteriID = Login.giden
                }).ToList();
                cmbHesapBilgisi.DataSource = HesapList;
                cmbHesapBilgisi.DisplayMember = "HesapNo";
                cmbHesapBilgisi.ValueMember = "HesapNo";
            }
        }


        private void Musteri_Load(object sender, EventArgs e)
        {
            HesapListelemeParaCekme();
            HesapListelemeParaYatirma();
            HesapListelemeParaGonderme();
            HesapListelemeOdemeYap();
            HesapBilgileriListleme();
        }
        private void Musteri_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            
        }


        private void btnOdeme_Click(object sender, EventArgs e)
        {
            // kurum ödeme 

            if (string.IsNullOrEmpty(cmbKurum.Text) || string.IsNullOrEmpty(txtOdemeTutar.Text) || string.IsNullOrEmpty(cmbOdemeHesap.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez");
                return;
            }
            using (var connection =new SqlConnection(connectionString))
            {
                HesapModel hesap;
                hesap = connection.QueryFirstOrDefault<HesapModel>("Select * From Hesap Where  HesapNo=@HesapNo", new
                    {
                        HesapNo = cmbOdemeHesap.SelectedValue
                    });
                if (hesap.Bakiye < float.Parse(txtOdemeTutar.Text))
                {
                    MessageBox.Show("Bakiye Yetersiz");
                    return;
                }
                connection.Execute(@"UPDATE 
                    Hesap 
                    SET 
                        Bakiye = @Bakiye
                    WHERE
                        HesapNo = @HesapNo
                    ", new
                {
                    Bakiye = hesap.Bakiye - float.Parse(txtOdemeTutar.Text),
                    HesapNo = cmbOdemeHesap.SelectedValue
                });
                float guncelBakiye = hesap.Bakiye - float.Parse(txtOdemeTutar.Text);
                MessageBox.Show("Ödeme işleminiz başarılı\n"+"Güncel bakiyeniz" + guncelBakiye);
            }
        }


        // havale işlemi 
        private void btnParaGonder_Click(object sender, EventArgs e)
        {
            
            
            if (string.IsNullOrEmpty(txtTutar.Text)|| string.IsNullOrEmpty(txtIbanAdres.Text) || string.IsNullOrEmpty(cmbParaHesap.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez");
                return;
            }
            using (var connection = new SqlConnection(connectionString))
            {

                HesapModel hesap;
                HesapModel hesaptransfer;
                hesap = connection.QueryFirstOrDefault<HesapModel>("Select * From Hesap Where  HesapNo=@HesapNo", new
                {
                    HesapNo = cmbParaHesap.SelectedValue
                });

                hesaptransfer = connection.QueryFirstOrDefault<HesapModel>("Select * From Hesap Where  Iban=@Iban", new
                {
                    Iban = txtIbanAdres.Text
                });

                if (hesaptransfer.Iban != Convert.ToInt32(txtIbanAdres.Text))
                {
                    MessageBox.Show("Hatalı iban");
                    return;
                }

                if (hesap.Bakiye < float.Parse(txtTutar.Text))
                {
                    MessageBox.Show("Bakiye Yetersiz");
                    return;
                }
                // hesaptan para çıkışı
                connection.Execute(@"UPDATE 
                    Hesap 
                    SET 
                        Bakiye = @Bakiye
                    WHERE
                        HesapNo = @HesapNo
                    ", new
                {
                    Bakiye = hesap.Bakiye - float.Parse(txtTutar.Text),
                    HesapNo = cmbParaHesap.SelectedValue
                });
                // hesap para girişi
                connection.Execute(@"UPDATE 
                    Hesap 
                    SET 
                        Bakiye = @Bakiye
                    WHERE
                        Iban = @Iban
                    ", new
                {
                    Bakiye = hesaptransfer.Bakiye + float.Parse(txtTutar.Text),
                    Iban = txtIbanAdres.Text
                });

                float guncelBakiye = hesap.Bakiye - float.Parse(txtTutar.Text);
                MessageBox.Show("Güncel Bakiyeniz " + guncelBakiye);

            }
        }





        private void btnParaCekme_Click(object sender, EventArgs e)
        {
            // para çekme işlemi 

            if (string.IsNullOrEmpty(txtTutarCekme.Text) || string.IsNullOrEmpty(cmbHesapCekme.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez");
                return;
            }

           
            using (var connection = new SqlConnection(connectionString))
            {

                HesapModel hesap;
                hesap = connection.QueryFirstOrDefault<HesapModel>
                    ("Select * From Hesap Where  HesapNo=@HesapNo", new
                {
                    HesapNo = cmbHesapCekme.SelectedValue
                });

               if (hesap.Bakiye < float.Parse(txtTutarCekme.Text))
                 {
                    MessageBox.Show("Bakiye Yetersiz"); 
                    return; 
                 }

                connection.Execute(@"UPDATE 
                    Hesap 
                    SET 
                        Bakiye = @Bakiye
                    WHERE
                        HesapNo = @HesapNo
                    ", new
                {
                    Bakiye = hesap.Bakiye - float.Parse(txtTutarCekme.Text),
                    HesapNo = cmbHesapCekme.SelectedValue
                });
                int guncelBakiye = Convert.ToInt32(hesap.Bakiye) - Convert.ToInt32(txtTutarCekme.Text);
                MessageBox.Show("Güncel Bakiyeniz " + guncelBakiye);
            }  
        }







        private void btnParaYatırma_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtTutarYatırma.Text) || string.IsNullOrEmpty(cmbHesapPara.Text))
            {
                MessageBox.Show("Alanlar Boş Geçilemez");
                return;
            }


            using (var connection = new SqlConnection(connectionString))
            {

                HesapModel hesap;
                hesap = connection.QueryFirstOrDefault<HesapModel>
                    ("Select * From Hesap Where  HesapNo=@HesapNo", new
                    {
                        HesapNo = cmbHesapPara.SelectedValue
                    });
                connection.Execute(@"UPDATE 
                    Hesap 
                    SET 
                        Bakiye = @Bakiye
                    WHERE
                        HesapNo = @HesapNo
                    ", new
                {
                    Bakiye = hesap.Bakiye + float.Parse(txtTutarYatırma.Text),
                    HesapNo = cmbHesapPara.SelectedValue
                });
                float guncelBakiye = hesap.Bakiye + float.Parse(txtTutarYatırma.Text);
                MessageBox.Show("Güncel Bakiyeniz " + guncelBakiye);
            }
        }

        private void btnHesapBilgileriGoster_Click(object sender, EventArgs e)
        {
            
            if (cmbHesapBilgisi.SelectedValue==null)
            {
                MessageBox.Show("Lütfen hesap seçiniz");
                return;

            }
            using (var connection = new SqlConnection(connectionString))
            {
                HesapModel hesap;
                hesap = connection.QueryFirstOrDefault<HesapModel>
                    ("Select * From Hesap Where  HesapNo=@HesapNo", new
                    {
                        HesapNo = cmbHesapBilgisi.SelectedValue
                        
                    });
                txtHesapBilgiBakiye.Text = hesap.Bakiye.ToString();
                txtHesapBilgiIban.Text = hesap.Iban.ToString();
                
            }
            
        }
    }
}


