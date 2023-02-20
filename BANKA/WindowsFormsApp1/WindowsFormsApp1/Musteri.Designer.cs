
namespace WindowsFormsApp1
{
    partial class Musteri
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.cmbHesapCekme = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTutarCekme = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnParaCekme = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.cmbHesapPara = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTutarYatırma = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnParaYatırma = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cmbParaHesap = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIbanAdres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnParaGonder = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.cmbOdemeHesap = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbKurum = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtOdemeTutar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnOdeme = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbHesapBilgisi = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.btnHesapBilgileriGoster = new System.Windows.Forms.Button();
            this.txtHesapBilgiBakiye = new System.Windows.Forms.TextBox();
            this.txtHesapBilgiIban = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(23, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(574, 240);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControl1_Selected);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtHesapBilgiIban);
            this.tabPage1.Controls.Add(this.txtHesapBilgiBakiye);
            this.tabPage1.Controls.Add(this.btnHesapBilgileriGoster);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.cmbHesapBilgisi);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label12);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(566, 207);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Hesap Bilgileri";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.cmbHesapCekme);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.txtTutarCekme);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.btnParaCekme);
            this.tabPage4.Location = new System.Drawing.Point(4, 29);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(566, 207);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Para Çekme";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // cmbHesapCekme
            // 
            this.cmbHesapCekme.FormattingEnabled = true;
            this.cmbHesapCekme.Location = new System.Drawing.Point(248, 40);
            this.cmbHesapCekme.Name = "cmbHesapCekme";
            this.cmbHesapCekme.Size = new System.Drawing.Size(121, 28);
            this.cmbHesapCekme.TabIndex = 27;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(124, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(119, 20);
            this.label9.TabIndex = 26;
            this.label9.Text = "Hesap Seçiniz :";
            // 
            // txtTutarCekme
            // 
            this.txtTutarCekme.Location = new System.Drawing.Point(248, 92);
            this.txtTutarCekme.Name = "txtTutarCekme";
            this.txtTutarCekme.Size = new System.Drawing.Size(121, 26);
            this.txtTutarCekme.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(188, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 20);
            this.label10.TabIndex = 24;
            this.label10.Text = "Tutar: ";
            // 
            // btnParaCekme
            // 
            this.btnParaCekme.Location = new System.Drawing.Point(248, 138);
            this.btnParaCekme.Name = "btnParaCekme";
            this.btnParaCekme.Size = new System.Drawing.Size(100, 31);
            this.btnParaCekme.TabIndex = 23;
            this.btnParaCekme.Text = "Para Çek";
            this.btnParaCekme.UseVisualStyleBackColor = true;
            this.btnParaCekme.Click += new System.EventHandler(this.btnParaCekme_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.cmbHesapPara);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.txtTutarYatırma);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.btnParaYatırma);
            this.tabPage5.Location = new System.Drawing.Point(4, 29);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(566, 207);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Para Yatırma";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // cmbHesapPara
            // 
            this.cmbHesapPara.FormattingEnabled = true;
            this.cmbHesapPara.Location = new System.Drawing.Point(248, 40);
            this.cmbHesapPara.Name = "cmbHesapPara";
            this.cmbHesapPara.Size = new System.Drawing.Size(121, 28);
            this.cmbHesapPara.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(124, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Hesap Seçiniz :";
            // 
            // txtTutarYatırma
            // 
            this.txtTutarYatırma.Location = new System.Drawing.Point(248, 92);
            this.txtTutarYatırma.Name = "txtTutarYatırma";
            this.txtTutarYatırma.Size = new System.Drawing.Size(121, 26);
            this.txtTutarYatırma.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(188, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 20);
            this.label6.TabIndex = 19;
            this.label6.Text = "Tutar: ";
            // 
            // btnParaYatırma
            // 
            this.btnParaYatırma.Location = new System.Drawing.Point(248, 138);
            this.btnParaYatırma.Name = "btnParaYatırma";
            this.btnParaYatırma.Size = new System.Drawing.Size(100, 31);
            this.btnParaYatırma.TabIndex = 18;
            this.btnParaYatırma.Text = "Para Yatır";
            this.btnParaYatırma.UseVisualStyleBackColor = true;
            this.btnParaYatırma.Click += new System.EventHandler(this.btnParaYatırma_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cmbParaHesap);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtIbanAdres);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.txtTutar);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnParaGonder);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(566, 207);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Para Gönderme";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cmbParaHesap
            // 
            this.cmbParaHesap.FormattingEnabled = true;
            this.cmbParaHesap.Location = new System.Drawing.Point(253, 40);
            this.cmbParaHesap.Name = "cmbParaHesap";
            this.cmbParaHesap.Size = new System.Drawing.Size(121, 28);
            this.cmbParaHesap.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(129, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Hesap Seçiniz :";
            // 
            // txtIbanAdres
            // 
            this.txtIbanAdres.Location = new System.Drawing.Point(253, 74);
            this.txtIbanAdres.Name = "txtIbanAdres";
            this.txtIbanAdres.Size = new System.Drawing.Size(121, 26);
            this.txtIbanAdres.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gönderilecek Hesap :";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(253, 106);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(121, 26);
            this.txtTutar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(193, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tutar: ";
            // 
            // btnParaGonder
            // 
            this.btnParaGonder.Location = new System.Drawing.Point(253, 138);
            this.btnParaGonder.Name = "btnParaGonder";
            this.btnParaGonder.Size = new System.Drawing.Size(100, 31);
            this.btnParaGonder.TabIndex = 0;
            this.btnParaGonder.Text = "Gönder";
            this.btnParaGonder.UseVisualStyleBackColor = true;
            this.btnParaGonder.Click += new System.EventHandler(this.btnParaGonder_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.cmbOdemeHesap);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.cmbKurum);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.txtOdemeTutar);
            this.tabPage3.Controls.Add(this.label8);
            this.tabPage3.Controls.Add(this.btnOdeme);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(566, 207);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ödeme Yapma";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // cmbOdemeHesap
            // 
            this.cmbOdemeHesap.FormattingEnabled = true;
            this.cmbOdemeHesap.Items.AddRange(new object[] {
            "Turkcell",
            "Türk Telekom",
            "Vodafone",
            "PTTCell",
            "Superonline",
            "Turknet",
            "Uydunet",
            "D-Smart",
            "İski",
            "Kastamonu Su",
            "Ck Boğaziçi Elektirik",
            "Enerjisa Başkent",
            ""});
            this.cmbOdemeHesap.Location = new System.Drawing.Point(224, 27);
            this.cmbOdemeHesap.Name = "cmbOdemeHesap";
            this.cmbOdemeHesap.Size = new System.Drawing.Size(121, 28);
            this.cmbOdemeHesap.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(119, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Hesap Seçiniz :";
            // 
            // cmbKurum
            // 
            this.cmbKurum.FormattingEnabled = true;
            this.cmbKurum.Items.AddRange(new object[] {
            "Turkcell",
            "Türk Telekom",
            "Vodafone",
            "PTTCell",
            "Superonline",
            "Turknet",
            "Uydunet",
            "D-Smart",
            "İski",
            "Kastamonu Su",
            "Ck Boğaziçi Elektirik",
            "Enerjisa Başkent",
            ""});
            this.cmbKurum.Location = new System.Drawing.Point(224, 73);
            this.cmbKurum.Name = "cmbKurum";
            this.cmbKurum.Size = new System.Drawing.Size(121, 28);
            this.cmbKurum.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(100, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Kurum Seçiniz :";
            // 
            // txtOdemeTutar
            // 
            this.txtOdemeTutar.Location = new System.Drawing.Point(224, 117);
            this.txtOdemeTutar.Name = "txtOdemeTutar";
            this.txtOdemeTutar.Size = new System.Drawing.Size(121, 26);
            this.txtOdemeTutar.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(164, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 8;
            this.label8.Text = "Tutar: ";
            // 
            // btnOdeme
            // 
            this.btnOdeme.Location = new System.Drawing.Point(224, 162);
            this.btnOdeme.Name = "btnOdeme";
            this.btnOdeme.Size = new System.Drawing.Size(121, 31);
            this.btnOdeme.TabIndex = 7;
            this.btnOdeme.Text = "Ödeme Yap";
            this.btnOdeme.UseVisualStyleBackColor = true;
            this.btnOdeme.Click += new System.EventHandler(this.btnOdeme_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(124, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(119, 20);
            this.label11.TabIndex = 28;
            this.label11.Text = "Hesap Seçiniz :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(183, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Bakiye:";
            // 
            // cmbHesapBilgisi
            // 
            this.cmbHesapBilgisi.FormattingEnabled = true;
            this.cmbHesapBilgisi.Location = new System.Drawing.Point(248, 40);
            this.cmbHesapBilgisi.Name = "cmbHesapBilgisi";
            this.cmbHesapBilgisi.Size = new System.Drawing.Size(121, 28);
            this.cmbHesapBilgisi.TabIndex = 29;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(198, 126);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 20);
            this.label13.TabIndex = 30;
            this.label13.Text = "Iban:";
            // 
            // btnHesapBilgileriGoster
            // 
            this.btnHesapBilgileriGoster.Location = new System.Drawing.Point(202, 160);
            this.btnHesapBilgileriGoster.Name = "btnHesapBilgileriGoster";
            this.btnHesapBilgileriGoster.Size = new System.Drawing.Size(190, 31);
            this.btnHesapBilgileriGoster.TabIndex = 31;
            this.btnHesapBilgileriGoster.Text = "Hesap Bilgilerini Göster";
            this.btnHesapBilgileriGoster.UseVisualStyleBackColor = true;
            this.btnHesapBilgileriGoster.Click += new System.EventHandler(this.btnHesapBilgileriGoster_Click);
            // 
            // txtHesapBilgiBakiye
            // 
            this.txtHesapBilgiBakiye.Location = new System.Drawing.Point(250, 88);
            this.txtHesapBilgiBakiye.Name = "txtHesapBilgiBakiye";
            this.txtHesapBilgiBakiye.ReadOnly = true;
            this.txtHesapBilgiBakiye.Size = new System.Drawing.Size(100, 26);
            this.txtHesapBilgiBakiye.TabIndex = 32;
            // 
            // txtHesapBilgiIban
            // 
            this.txtHesapBilgiIban.Location = new System.Drawing.Point(250, 126);
            this.txtHesapBilgiIban.Name = "txtHesapBilgiIban";
            this.txtHesapBilgiIban.ReadOnly = true;
            this.txtHesapBilgiIban.Size = new System.Drawing.Size(100, 26);
            this.txtHesapBilgiIban.TabIndex = 33;
            // 
            // Musteri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 255);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Musteri";
            this.Text = "Musteri";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Musteri_FormClosing);
            this.Load += new System.EventHandler(this.Musteri_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtIbanAdres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnParaGonder;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ComboBox cmbKurum;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtOdemeTutar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnOdeme;
        private System.Windows.Forms.ComboBox cmbHesapCekme;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTutarCekme;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnParaCekme;
        private System.Windows.Forms.ComboBox cmbHesapPara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTutarYatırma;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnParaYatırma;
        private System.Windows.Forms.ComboBox cmbParaHesap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbOdemeHesap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbHesapBilgisi;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnHesapBilgileriGoster;
        private System.Windows.Forms.TextBox txtHesapBilgiIban;
        private System.Windows.Forms.TextBox txtHesapBilgiBakiye;
    }
}