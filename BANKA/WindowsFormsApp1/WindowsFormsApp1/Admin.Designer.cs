
namespace WindowsFormsApp1
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnGeriDon = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYeni = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtEposta = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtTC = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.btnGeriDonHesap = new System.Windows.Forms.Button();
            this.label22 = new System.Windows.Forms.Label();
            this.cmbMusteri = new System.Windows.Forms.ComboBox();
            this.btnSilHesap = new System.Windows.Forms.Button();
            this.btnYeniHesap = new System.Windows.Forms.Button();
            this.btnKaydetHesap = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(960, 516);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.btnGeriDon);
            this.tabPage2.Controls.Add(this.btnSil);
            this.tabPage2.Controls.Add(this.btnYeni);
            this.tabPage2.Controls.Add(this.btnKaydet);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.dtpDogumTarihi);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.txtAdres);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.txtEposta);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.txtTelefon);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.txtSoyad);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.txtTC);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.txtAd);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(952, 483);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Müşteri Ekle/Güncelle";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 294);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(921, 177);
            this.dataGridView1.TabIndex = 99;
            this.dataGridView1.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_RowEnter_1);
            // 
            // btnGeriDon
            // 
            this.btnGeriDon.BackColor = System.Drawing.SystemColors.Control;
            this.btnGeriDon.Location = new System.Drawing.Point(821, 19);
            this.btnGeriDon.Name = "btnGeriDon";
            this.btnGeriDon.Size = new System.Drawing.Size(106, 33);
            this.btnGeriDon.TabIndex = 98;
            this.btnGeriDon.Text = "Geri Dön";
            this.btnGeriDon.UseVisualStyleBackColor = false;
            this.btnGeriDon.Click += new System.EventHandler(this.btnGeriDon_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(456, 226);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(106, 33);
            this.btnSil.TabIndex = 43;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Location = new System.Drawing.Point(117, 226);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(106, 33);
            this.btnYeni.TabIndex = 42;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.UseVisualStyleBackColor = true;
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(287, 226);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(106, 33);
            this.btnKaydet.TabIndex = 40;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(175, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(242, 24);
            this.label9.TabIndex = 39;
            this.label9.Text = "Müşteri Güncelleme Sayfası";
            // 
            // dtpDogumTarihi
            // 
            this.dtpDogumTarihi.Location = new System.Drawing.Point(371, 131);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(273, 26);
            this.dtpDogumTarihi.TabIndex = 38;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(243, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Doğum Tarihi:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(39, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 20);
            this.label11.TabIndex = 36;
            this.label11.Text = "Adres: ";
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(117, 163);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAdres.Size = new System.Drawing.Size(527, 26);
            this.txtAdres.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(25, 134);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "E Posta: ";
            // 
            // txtEposta
            // 
            this.txtEposta.Location = new System.Drawing.Point(117, 131);
            this.txtEposta.Name = "txtEposta";
            this.txtEposta.Size = new System.Drawing.Size(100, 26);
            this.txtEposta.TabIndex = 33;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(283, 102);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(66, 20);
            this.label13.TabIndex = 32;
            this.label13.Text = "Telefon:";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(371, 99);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(100, 26);
            this.txtTelefon.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(283, 70);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 20);
            this.label14.TabIndex = 30;
            this.label14.Text = "Soyisim:";
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(371, 67);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(100, 26);
            this.txtSoyad.TabIndex = 29;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(65, 102);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 20);
            this.label15.TabIndex = 28;
            this.label15.Text = "TC:";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(117, 99);
            this.txtTC.Name = "txtTC";
            this.txtTC.Size = new System.Drawing.Size(100, 26);
            this.txtTC.TabIndex = 27;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(52, 70);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 20);
            this.label16.TabIndex = 26;
            this.label16.Text = "İsim: ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(117, 67);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 26);
            this.txtAd.TabIndex = 25;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.btnGeriDonHesap);
            this.tabPage3.Controls.Add(this.label22);
            this.tabPage3.Controls.Add(this.cmbMusteri);
            this.tabPage3.Controls.Add(this.btnSilHesap);
            this.tabPage3.Controls.Add(this.btnYeniHesap);
            this.tabPage3.Controls.Add(this.btnKaydetHesap);
            this.tabPage3.Controls.Add(this.label17);
            this.tabPage3.Controls.Add(this.label18);
            this.tabPage3.Controls.Add(this.txtBakiye);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(952, 483);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Hesap Ekle/Sil";
            this.tabPage3.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(242, 291);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(448, 150);
            this.dataGridView2.TabIndex = 102;
            // 
            // btnGeriDonHesap
            // 
            this.btnGeriDonHesap.BackColor = System.Drawing.SystemColors.Control;
            this.btnGeriDonHesap.Location = new System.Drawing.Point(819, 6);
            this.btnGeriDonHesap.Name = "btnGeriDonHesap";
            this.btnGeriDonHesap.Size = new System.Drawing.Size(106, 33);
            this.btnGeriDonHesap.TabIndex = 99;
            this.btnGeriDonHesap.Text = "Geri Dön";
            this.btnGeriDonHesap.UseVisualStyleBackColor = false;
            this.btnGeriDonHesap.Click += new System.EventHandler(this.btnGeriDonHesap_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(314, 126);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(61, 20);
            this.label22.TabIndex = 73;
            this.label22.Text = "Müşteri";
            // 
            // cmbMusteri
            // 
            this.cmbMusteri.FormattingEnabled = true;
            this.cmbMusteri.Location = new System.Drawing.Point(382, 123);
            this.cmbMusteri.Name = "cmbMusteri";
            this.cmbMusteri.Size = new System.Drawing.Size(168, 28);
            this.cmbMusteri.TabIndex = 68;
            // 
            // btnSilHesap
            // 
            this.btnSilHesap.Location = new System.Drawing.Point(521, 225);
            this.btnSilHesap.Name = "btnSilHesap";
            this.btnSilHesap.Size = new System.Drawing.Size(106, 33);
            this.btnSilHesap.TabIndex = 67;
            this.btnSilHesap.Text = "Sil";
            this.btnSilHesap.UseVisualStyleBackColor = true;
            this.btnSilHesap.Click += new System.EventHandler(this.btnSilHesap_Click);
            // 
            // btnYeniHesap
            // 
            this.btnYeniHesap.Location = new System.Drawing.Point(267, 225);
            this.btnYeniHesap.Name = "btnYeniHesap";
            this.btnYeniHesap.Size = new System.Drawing.Size(106, 33);
            this.btnYeniHesap.TabIndex = 66;
            this.btnYeniHesap.Text = "Yeni";
            this.btnYeniHesap.UseVisualStyleBackColor = true;
            this.btnYeniHesap.Click += new System.EventHandler(this.btnYeniHesap_Click);
            // 
            // btnKaydetHesap
            // 
            this.btnKaydetHesap.Location = new System.Drawing.Point(391, 225);
            this.btnKaydetHesap.Name = "btnKaydetHesap";
            this.btnKaydetHesap.Size = new System.Drawing.Size(106, 33);
            this.btnKaydetHesap.TabIndex = 65;
            this.btnKaydetHesap.Text = "Kaydet";
            this.btnKaydetHesap.UseVisualStyleBackColor = true;
            this.btnKaydetHesap.Click += new System.EventHandler(this.btnHesapKaydet_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label17.Location = new System.Drawing.Point(378, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(119, 24);
            this.label17.TabIndex = 64;
            this.label17.Text = "Hesap Açma";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(311, 173);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(64, 20);
            this.label18.TabIndex = 63;
            this.label18.Text = "Bakiye: ";
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(382, 170);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.Size = new System.Drawing.Size(168, 26);
            this.txtBakiye.TabIndex = 62;
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 528);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Admin";
            this.Text = "Admin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Admin_FormClosing);
            this.Load += new System.EventHandler(this.Admin_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYeni;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtEposta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtTC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.Button btnSilHesap;
        private System.Windows.Forms.Button btnYeniHesap;
        private System.Windows.Forms.Button btnKaydetHesap;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Button btnGeriDon;
        private System.Windows.Forms.Button btnGeriDonHesap;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}