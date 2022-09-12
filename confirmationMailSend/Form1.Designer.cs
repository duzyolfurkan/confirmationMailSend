
namespace confirmationMailSend
{
    partial class Form1
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
            this.lbl_mail = new System.Windows.Forms.Label();
            this.txt_mail = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.btn_sifreKontrol = new System.Windows.Forms.Button();
            this.btn_mailKontrol = new System.Windows.Forms.Button();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.btn_kaydet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_mail
            // 
            this.lbl_mail.AutoSize = true;
            this.lbl_mail.Location = new System.Drawing.Point(12, 9);
            this.lbl_mail.Name = "lbl_mail";
            this.lbl_mail.Size = new System.Drawing.Size(109, 13);
            this.lbl_mail.TabIndex = 0;
            this.lbl_mail.Text = "Mail Adresinizi Yazınız";
            // 
            // txt_mail
            // 
            this.txt_mail.Location = new System.Drawing.Point(15, 25);
            this.txt_mail.Name = "txt_mail";
            this.txt_mail.Size = new System.Drawing.Size(185, 20);
            this.txt_mail.TabIndex = 1;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(15, 92);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(185, 20);
            this.txt_sifre.TabIndex = 3;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(12, 76);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(170, 13);
            this.lbl_sifre.TabIndex = 2;
            this.lbl_sifre.Text = "Mail Adresinize Gelen Şifreyi Giriniz";
            // 
            // btn_sifreKontrol
            // 
            this.btn_sifreKontrol.Location = new System.Drawing.Point(15, 118);
            this.btn_sifreKontrol.Name = "btn_sifreKontrol";
            this.btn_sifreKontrol.Size = new System.Drawing.Size(185, 23);
            this.btn_sifreKontrol.TabIndex = 4;
            this.btn_sifreKontrol.Text = "Şifreyi Onayla";
            this.btn_sifreKontrol.UseVisualStyleBackColor = true;
            this.btn_sifreKontrol.Click += new System.EventHandler(this.btn_sifreKontrol_Click);
            // 
            // btn_mailKontrol
            // 
            this.btn_mailKontrol.Location = new System.Drawing.Point(15, 50);
            this.btn_mailKontrol.Name = "btn_mailKontrol";
            this.btn_mailKontrol.Size = new System.Drawing.Size(185, 23);
            this.btn_mailKontrol.TabIndex = 5;
            this.btn_mailKontrol.Text = "Şifre Gönder";
            this.btn_mailKontrol.UseVisualStyleBackColor = true;
            this.btn_mailKontrol.Click += new System.EventHandler(this.btn_mailKontrol_Click);
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(15, 163);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(185, 20);
            this.txt_ad.TabIndex = 7;
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(12, 147);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(68, 13);
            this.lbl_ad.TabIndex = 6;
            this.lbl_ad.Text = "Adınızı Giriniz";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(15, 206);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(185, 20);
            this.txt_soyad.TabIndex = 9;
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(12, 190);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(85, 13);
            this.lbl_soyad.TabIndex = 8;
            this.lbl_soyad.Text = "Soyadınızı Giriniz";
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Location = new System.Drawing.Point(15, 232);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(185, 23);
            this.btn_kaydet.TabIndex = 10;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 273);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.txt_ad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.btn_mailKontrol);
            this.Controls.Add(this.btn_sifreKontrol);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.txt_mail);
            this.Controls.Add(this.lbl_mail);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_mail;
        private System.Windows.Forms.TextBox txt_mail;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.Button btn_sifreKontrol;
        private System.Windows.Forms.Button btn_mailKontrol;
        private System.Windows.Forms.TextBox txt_ad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Button btn_kaydet;
    }
}

