namespace kutuphane_uygulamasi
{
    partial class FormPersonelKayit
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
            this.txt_kullanici_nick = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btn_Uye_Ol = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_sifre_tekrar = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.txt_guvenlik_sorusu = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_guvenlik_sorusu_cevabi = new System.Windows.Forms.TextBox();
            this.txt_cinsiyet = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_soyad = new System.Windows.Forms.TextBox();
            this.txt_ad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txt_kullanici_nick
            // 
            this.txt_kullanici_nick.Location = new System.Drawing.Point(564, 198);
            this.txt_kullanici_nick.Name = "txt_kullanici_nick";
            this.txt_kullanici_nick.Size = new System.Drawing.Size(132, 20);
            this.txt_kullanici_nick.TabIndex = 38;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(434, 205);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Kullanıcı adınızı giriniz :";
            // 
            // btn_Uye_Ol
            // 
            this.btn_Uye_Ol.Location = new System.Drawing.Point(316, 340);
            this.btn_Uye_Ol.Name = "btn_Uye_Ol";
            this.btn_Uye_Ol.Size = new System.Drawing.Size(207, 43);
            this.btn_Uye_Ol.TabIndex = 36;
            this.btn_Uye_Ol.Text = "ÜYE OL";
            this.btn_Uye_Ol.UseVisualStyleBackColor = true;
            this.btn_Uye_Ol.Click += new System.EventHandler(this.btn_Uye_Ol_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(434, 282);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(109, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Şİfrenizi tekrar giriniz :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(434, 238);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Şifrenizi giriniz :";
            // 
            // txt_sifre_tekrar
            // 
            this.txt_sifre_tekrar.Location = new System.Drawing.Point(564, 279);
            this.txt_sifre_tekrar.Name = "txt_sifre_tekrar";
            this.txt_sifre_tekrar.Size = new System.Drawing.Size(132, 20);
            this.txt_sifre_tekrar.TabIndex = 33;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(564, 238);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(132, 20);
            this.txt_sifre.TabIndex = 32;
            // 
            // txt_guvenlik_sorusu
            // 
            this.txt_guvenlik_sorusu.FormattingEnabled = true;
            this.txt_guvenlik_sorusu.Items.AddRange(new object[] {
            "İlkokul öğretmeninizin adı?",
            "Evcil hayvanınızın adı?",
            "En sevdiğiniz renk?"});
            this.txt_guvenlik_sorusu.Location = new System.Drawing.Point(564, 67);
            this.txt_guvenlik_sorusu.Name = "txt_guvenlik_sorusu";
            this.txt_guvenlik_sorusu.Size = new System.Drawing.Size(132, 21);
            this.txt_guvenlik_sorusu.TabIndex = 31;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(434, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 13);
            this.label6.TabIndex = 30;
            this.label6.Text = "Güvenlik sorusu cevabı : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(434, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 13);
            this.label5.TabIndex = 29;
            this.label5.Text = "Güvenlik sorusu seçiniz :";
            // 
            // txt_guvenlik_sorusu_cevabi
            // 
            this.txt_guvenlik_sorusu_cevabi.Location = new System.Drawing.Point(564, 126);
            this.txt_guvenlik_sorusu_cevabi.Name = "txt_guvenlik_sorusu_cevabi";
            this.txt_guvenlik_sorusu_cevabi.Size = new System.Drawing.Size(132, 20);
            this.txt_guvenlik_sorusu_cevabi.TabIndex = 28;
            // 
            // txt_cinsiyet
            // 
            this.txt_cinsiyet.FormattingEnabled = true;
            this.txt_cinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kız",
            "Belirtmek İstemiyorum"});
            this.txt_cinsiyet.Location = new System.Drawing.Point(169, 178);
            this.txt_cinsiyet.Name = "txt_cinsiyet";
            this.txt_cinsiyet.Size = new System.Drawing.Size(131, 21);
            this.txt_cinsiyet.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Cinsiyetiniz :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Soyadınız :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 23;
            this.label1.Text = "Adınız :";
            // 
            // txt_soyad
            // 
            this.txt_soyad.Location = new System.Drawing.Point(169, 119);
            this.txt_soyad.Name = "txt_soyad";
            this.txt_soyad.Size = new System.Drawing.Size(131, 20);
            this.txt_soyad.TabIndex = 22;
            // 
            // txt_ad
            // 
            this.txt_ad.Location = new System.Drawing.Point(152, 72);
            this.txt_ad.Name = "txt_ad";
            this.txt_ad.Size = new System.Drawing.Size(148, 20);
            this.txt_ad.TabIndex = 21;
            // 
            // FormPersonelKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_kullanici_nick);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btn_Uye_Ol);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_sifre_tekrar);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_guvenlik_sorusu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_guvenlik_sorusu_cevabi);
            this.Controls.Add(this.txt_cinsiyet);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_soyad);
            this.Controls.Add(this.txt_ad);
            this.Name = "FormPersonelKayit";
            this.Text = "FormPersonelKayit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_kullanici_nick;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btn_Uye_Ol;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_sifre_tekrar;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.ComboBox txt_guvenlik_sorusu;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_guvenlik_sorusu_cevabi;
        private System.Windows.Forms.ComboBox txt_cinsiyet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_soyad;
        private System.Windows.Forms.TextBox txt_ad;
    }
}