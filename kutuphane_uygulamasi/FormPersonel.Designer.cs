namespace kutuphane_uygulamasi
{
    partial class FormPersonel
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
            this.btn_kiralanan_listele = new System.Windows.Forms.Button();
            this.btn_iade_et = new System.Windows.Forms.Button();
            this.lbl_giris_metni = new System.Windows.Forms.Label();
            this.lbl_personel_nick = new System.Windows.Forms.Label();
            this.kiralanan_listesi = new System.Windows.Forms.DataGridView();
            this.lbl_iade_edildi = new System.Windows.Forms.Label();
            this.btn_Personel_Ekle = new System.Windows.Forms.Button();
            this.lbl_yonetici = new System.Windows.Forms.Label();
            this.btn_bagıslanan_kitaplar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kiralanan_listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kiralanan_listele
            // 
            this.btn_kiralanan_listele.Location = new System.Drawing.Point(241, 30);
            this.btn_kiralanan_listele.Name = "btn_kiralanan_listele";
            this.btn_kiralanan_listele.Size = new System.Drawing.Size(152, 37);
            this.btn_kiralanan_listele.TabIndex = 0;
            this.btn_kiralanan_listele.Text = "Kiralanan Kitapları Listele";
            this.btn_kiralanan_listele.UseVisualStyleBackColor = true;
            this.btn_kiralanan_listele.Click += new System.EventHandler(this.btn_kiralanan_listele_Click);
            // 
            // btn_iade_et
            // 
            this.btn_iade_et.Location = new System.Drawing.Point(689, 106);
            this.btn_iade_et.Name = "btn_iade_et";
            this.btn_iade_et.Size = new System.Drawing.Size(163, 37);
            this.btn_iade_et.TabIndex = 1;
            this.btn_iade_et.Text = "İADE ET";
            this.btn_iade_et.UseVisualStyleBackColor = true;
            this.btn_iade_et.Click += new System.EventHandler(this.btn_iade_et_Click);
            // 
            // lbl_giris_metni
            // 
            this.lbl_giris_metni.AutoSize = true;
            this.lbl_giris_metni.Location = new System.Drawing.Point(686, 54);
            this.lbl_giris_metni.Name = "lbl_giris_metni";
            this.lbl_giris_metni.Size = new System.Drawing.Size(59, 13);
            this.lbl_giris_metni.TabIndex = 2;
            this.lbl_giris_metni.Text = "Hoş Geldin";
            // 
            // lbl_personel_nick
            // 
            this.lbl_personel_nick.AutoSize = true;
            this.lbl_personel_nick.Location = new System.Drawing.Point(751, 54);
            this.lbl_personel_nick.Name = "lbl_personel_nick";
            this.lbl_personel_nick.Size = new System.Drawing.Size(0, 13);
            this.lbl_personel_nick.TabIndex = 3;
            // 
            // kiralanan_listesi
            // 
            this.kiralanan_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kiralanan_listesi.Location = new System.Drawing.Point(12, 82);
            this.kiralanan_listesi.Name = "kiralanan_listesi";
            this.kiralanan_listesi.Size = new System.Drawing.Size(608, 292);
            this.kiralanan_listesi.TabIndex = 4;
            // 
            // lbl_iade_edildi
            // 
            this.lbl_iade_edildi.Location = new System.Drawing.Point(686, 173);
            this.lbl_iade_edildi.Name = "lbl_iade_edildi";
            this.lbl_iade_edildi.Size = new System.Drawing.Size(199, 94);
            this.lbl_iade_edildi.TabIndex = 5;
            // 
            // btn_Personel_Ekle
            // 
            this.btn_Personel_Ekle.Location = new System.Drawing.Point(754, 377);
            this.btn_Personel_Ekle.Name = "btn_Personel_Ekle";
            this.btn_Personel_Ekle.Size = new System.Drawing.Size(131, 29);
            this.btn_Personel_Ekle.TabIndex = 6;
            this.btn_Personel_Ekle.Text = "PERSONEL EKLE";
            this.btn_Personel_Ekle.UseVisualStyleBackColor = true;
            this.btn_Personel_Ekle.Click += new System.EventHandler(this.btn_Personel_Ekle_Click);
            // 
            // lbl_yonetici
            // 
            this.lbl_yonetici.AutoSize = true;
            this.lbl_yonetici.Location = new System.Drawing.Point(665, 361);
            this.lbl_yonetici.Name = "lbl_yonetici";
            this.lbl_yonetici.Size = new System.Drawing.Size(289, 13);
            this.lbl_yonetici.TabIndex = 7;
            this.lbl_yonetici.Text = "!!! SADECE YÖNETİCİ PERSONEL EKLEME YAPABİLİR!!!";
            // 
            // btn_bagıslanan_kitaplar
            // 
            this.btn_bagıslanan_kitaplar.Location = new System.Drawing.Point(726, 289);
            this.btn_bagıslanan_kitaplar.Name = "btn_bagıslanan_kitaplar";
            this.btn_bagıslanan_kitaplar.Size = new System.Drawing.Size(182, 42);
            this.btn_bagıslanan_kitaplar.TabIndex = 8;
            this.btn_bagıslanan_kitaplar.Text = "Bağışlanan Kitapları Görüntüle";
            this.btn_bagıslanan_kitaplar.UseVisualStyleBackColor = true;
            this.btn_bagıslanan_kitaplar.Click += new System.EventHandler(this.btn_bagıslanan_kitaplar_Click);
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 466);
            this.Controls.Add(this.btn_bagıslanan_kitaplar);
            this.Controls.Add(this.lbl_yonetici);
            this.Controls.Add(this.btn_Personel_Ekle);
            this.Controls.Add(this.lbl_iade_edildi);
            this.Controls.Add(this.kiralanan_listesi);
            this.Controls.Add(this.lbl_personel_nick);
            this.Controls.Add(this.lbl_giris_metni);
            this.Controls.Add(this.btn_iade_et);
            this.Controls.Add(this.btn_kiralanan_listele);
            this.Name = "FormPersonel";
            this.Text = "FormPersonel";
            ((System.ComponentModel.ISupportInitialize)(this.kiralanan_listesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kiralanan_listele;
        private System.Windows.Forms.Button btn_iade_et;
        private System.Windows.Forms.Label lbl_giris_metni;
        private System.Windows.Forms.DataGridView kiralanan_listesi;
        private System.Windows.Forms.Label lbl_iade_edildi;
        public System.Windows.Forms.Label lbl_personel_nick;
        private System.Windows.Forms.Button btn_Personel_Ekle;
        private System.Windows.Forms.Label lbl_yonetici;
        private System.Windows.Forms.Button btn_bagıslanan_kitaplar;
    }
}