namespace kutuphane_uygulamasi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Chc_Box_Ad_Hatirla = new System.Windows.Forms.CheckBox();
            this.Chc_Box_Parola = new System.Windows.Forms.CheckBox();
            this.Txt_Box_Kullanici_ismi = new System.Windows.Forms.TextBox();
            this.Txt_Box_Parola = new System.Windows.Forms.TextBox();
            this.BTN_Parola = new System.Windows.Forms.Button();
            this.BTN_Yeni_uye = new System.Windows.Forms.Button();
            this.Pict_Box_Giris = new System.Windows.Forms.PictureBox();
            this.Btn_Giris_Yap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Pict_Box_Giris)).BeginInit();
            this.SuspendLayout();
            // 
            // Chc_Box_Ad_Hatirla
            // 
            this.Chc_Box_Ad_Hatirla.AutoSize = true;
            this.Chc_Box_Ad_Hatirla.Location = new System.Drawing.Point(9, 225);
            this.Chc_Box_Ad_Hatirla.Margin = new System.Windows.Forms.Padding(2);
            this.Chc_Box_Ad_Hatirla.Name = "Chc_Box_Ad_Hatirla";
            this.Chc_Box_Ad_Hatirla.Size = new System.Drawing.Size(122, 17);
            this.Chc_Box_Ad_Hatirla.TabIndex = 0;
            this.Chc_Box_Ad_Hatirla.Text = "kullanıcı adımı hatırla";
            this.Chc_Box_Ad_Hatirla.UseVisualStyleBackColor = true;
            // 
            // Chc_Box_Parola
            // 
            this.Chc_Box_Parola.AutoSize = true;
            this.Chc_Box_Parola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chc_Box_Parola.Location = new System.Drawing.Point(9, 284);
            this.Chc_Box_Parola.Margin = new System.Windows.Forms.Padding(2);
            this.Chc_Box_Parola.Name = "Chc_Box_Parola";
            this.Chc_Box_Parola.Size = new System.Drawing.Size(100, 17);
            this.Chc_Box_Parola.TabIndex = 1;
            this.Chc_Box_Parola.Text = "Parolamı Göster";
            this.Chc_Box_Parola.UseVisualStyleBackColor = true;
            this.Chc_Box_Parola.CheckedChanged += new System.EventHandler(this.Chc_Box_Parola_CheckedChanged);
            // 
            // Txt_Box_Kullanici_ismi
            // 
            this.Txt_Box_Kullanici_ismi.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Box_Kullanici_ismi.Location = new System.Drawing.Point(9, 193);
            this.Txt_Box_Kullanici_ismi.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Box_Kullanici_ismi.Name = "Txt_Box_Kullanici_ismi";
            this.Txt_Box_Kullanici_ismi.Size = new System.Drawing.Size(257, 28);
            this.Txt_Box_Kullanici_ismi.TabIndex = 2;
            // 
            // Txt_Box_Parola
            // 
            this.Txt_Box_Parola.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Box_Parola.Location = new System.Drawing.Point(9, 247);
            this.Txt_Box_Parola.Margin = new System.Windows.Forms.Padding(2);
            this.Txt_Box_Parola.Name = "Txt_Box_Parola";
            this.Txt_Box_Parola.Size = new System.Drawing.Size(192, 28);
            this.Txt_Box_Parola.TabIndex = 3;
            this.Txt_Box_Parola.Text = "Parola Giriniz";
            this.Txt_Box_Parola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_Box_Parola_KeyPress);
            // 
            // BTN_Parola
            // 
            this.BTN_Parola.Location = new System.Drawing.Point(146, 306);
            this.BTN_Parola.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Parola.Name = "BTN_Parola";
            this.BTN_Parola.Size = new System.Drawing.Size(119, 36);
            this.BTN_Parola.TabIndex = 4;
            this.BTN_Parola.Text = "Parolamı Unuttum";
            this.BTN_Parola.UseVisualStyleBackColor = true;
            this.BTN_Parola.Click += new System.EventHandler(this.BTN_Parola_Click);
            // 
            // BTN_Yeni_uye
            // 
            this.BTN_Yeni_uye.Location = new System.Drawing.Point(9, 306);
            this.BTN_Yeni_uye.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Yeni_uye.Name = "BTN_Yeni_uye";
            this.BTN_Yeni_uye.Size = new System.Drawing.Size(119, 36);
            this.BTN_Yeni_uye.TabIndex = 5;
            this.BTN_Yeni_uye.Text = "Yeni üye";
            this.BTN_Yeni_uye.UseVisualStyleBackColor = true;
            this.BTN_Yeni_uye.Click += new System.EventHandler(this.BTN_Yeni_uye_Click);
            // 
            // Pict_Box_Giris
            // 
            this.Pict_Box_Giris.Image = ((System.Drawing.Image)(resources.GetObject("Pict_Box_Giris.Image")));
            this.Pict_Box_Giris.InitialImage = null;
            this.Pict_Box_Giris.Location = new System.Drawing.Point(9, 10);
            this.Pict_Box_Giris.Margin = new System.Windows.Forms.Padding(2);
            this.Pict_Box_Giris.Name = "Pict_Box_Giris";
            this.Pict_Box_Giris.Size = new System.Drawing.Size(256, 178);
            this.Pict_Box_Giris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Pict_Box_Giris.TabIndex = 6;
            this.Pict_Box_Giris.TabStop = false;
            // 
            // Btn_Giris_Yap
            // 
            this.Btn_Giris_Yap.Location = new System.Drawing.Point(307, 225);
            this.Btn_Giris_Yap.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Giris_Yap.Name = "Btn_Giris_Yap";
            this.Btn_Giris_Yap.Size = new System.Drawing.Size(237, 63);
            this.Btn_Giris_Yap.TabIndex = 7;
            this.Btn_Giris_Yap.Text = "Giriş yapınız";
            this.Btn_Giris_Yap.UseVisualStyleBackColor = true;
            this.Btn_Giris_Yap.Click += new System.EventHandler(this.Btn_Giris_Yap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 366);
            this.Controls.Add(this.Btn_Giris_Yap);
            this.Controls.Add(this.Pict_Box_Giris);
            this.Controls.Add(this.BTN_Yeni_uye);
            this.Controls.Add(this.BTN_Parola);
            this.Controls.Add(this.Txt_Box_Parola);
            this.Controls.Add(this.Txt_Box_Kullanici_ismi);
            this.Controls.Add(this.Chc_Box_Parola);
            this.Controls.Add(this.Chc_Box_Ad_Hatirla);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Pict_Box_Giris)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Chc_Box_Ad_Hatirla;
        private System.Windows.Forms.CheckBox Chc_Box_Parola;
        private System.Windows.Forms.TextBox Txt_Box_Kullanici_ismi;
        private System.Windows.Forms.TextBox Txt_Box_Parola;
        private System.Windows.Forms.Button BTN_Parola;
        private System.Windows.Forms.Button BTN_Yeni_uye;
        private System.Windows.Forms.PictureBox Pict_Box_Giris;
        private System.Windows.Forms.Button Btn_Giris_Yap;
    }
}