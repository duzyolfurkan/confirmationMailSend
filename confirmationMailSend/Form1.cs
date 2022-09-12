using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace confirmationMailSend
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Mail adresi girilmeden diğer girişlerin yapılması engellendi
            txt_sifre.Enabled = false;
            btn_sifreKontrol.Enabled = false;
            txt_ad.Enabled = false;
            txt_sifre.Enabled = false;
            txt_soyad.Enabled = false;
            btn_sifreKontrol.Enabled = false;
            btn_kaydet.Enabled = false;
        }
        int kullaniciSifre = 0;
        private void btn_mailKontrol_Click(object sender, EventArgs e)
        {
            //Random şifre üretildi
            Random rnd = new Random();
            kullaniciSifre = rnd.Next(1000, 9999);

            //Mail sunucusu tanımlandı
            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp-mail.outlook.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.Credentials = new System.Net.NetworkCredential("baskulapp@outlook.com.tr", "DudukluTencere1234*");

            //E-Posta özellikleri tanımlandı
            MailMessage eposta = new MailMessage();
            eposta.From = new MailAddress("baskulapp@outlook.com.tr", "BaskülAPP");
            eposta.To.Add(txt_mail.Text);
            eposta.Subject = "BaskülAPP Doğrulama Kodunuz";
            eposta.Body = $"BaskülAPP doğrulama kodunuz {kullaniciSifre} dir. Lütfen programdaki ilgili alana giriniz.";

            //E-Posta gönderimi yapıldı
            smtp.Send(eposta);

            //Şifre girme alanları aktif edildi
            txt_sifre.Enabled = true;
            btn_sifreKontrol.Enabled = true;

        }

        private void btn_sifreKontrol_Click(object sender, EventArgs e)
        {
            //Şifre kontrolü yapıldı
            if (txt_sifre.Text == Convert.ToString(kullaniciSifre))
            {
                txt_ad.Enabled = true;
                txt_soyad.Enabled = true;
                btn_kaydet.Enabled = true;
            }
            else
            {
                MessageBox.Show("Yanlış şifre girdiniz, lütfen tekrar deneyiniz.");
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            // Ad ve soyad değişkenleri kaydedildi
            string ad = txt_ad.Text;
            string soyad = txt_soyad.Text;

            MessageBox.Show("Verileriniz kaydedilmiştir.");
        }
    }
}
