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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPersonel));
            this.btn_kiralanan_listele = new System.Windows.Forms.Button();
            this.btn_iade_et = new System.Windows.Forms.Button();
            this.lbl_giris_metni = new System.Windows.Forms.Label();
            this.lbl_personel_nick = new System.Windows.Forms.Label();
            this.kiralanan_listesi = new System.Windows.Forms.DataGridView();
            this.lbl_iade_edildi = new System.Windows.Forms.Label();
            this.btn_Personel_Ekle = new System.Windows.Forms.Button();
            this.lbl_yonetici = new System.Windows.Forms.Label();
            this.btn_bagıslanan_kitaplar = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Img_Button_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.kiralanan_listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_kiralanan_listele
            // 
            this.btn_kiralanan_listele.BackColor = System.Drawing.Color.LightCoral;
            this.btn_kiralanan_listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kiralanan_listele.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_kiralanan_listele.ForeColor = System.Drawing.Color.Black;
            this.btn_kiralanan_listele.Location = new System.Drawing.Point(243, 4);
            this.btn_kiralanan_listele.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_kiralanan_listele.Name = "btn_kiralanan_listele";
            this.btn_kiralanan_listele.Size = new System.Drawing.Size(348, 58);
            this.btn_kiralanan_listele.TabIndex = 0;
            this.btn_kiralanan_listele.Text = "Kiralanan Kitapları Listele";
            this.btn_kiralanan_listele.UseVisualStyleBackColor = false;
            this.btn_kiralanan_listele.Click += new System.EventHandler(this.btn_kiralanan_listele_Click);
            // 
            // btn_iade_et
            // 
            this.btn_iade_et.BackColor = System.Drawing.Color.LightCoral;
            this.btn_iade_et.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_iade_et.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_iade_et.Location = new System.Drawing.Point(913, 107);
            this.btn_iade_et.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_iade_et.Name = "btn_iade_et";
            this.btn_iade_et.Size = new System.Drawing.Size(217, 46);
            this.btn_iade_et.TabIndex = 1;
            this.btn_iade_et.Text = "İADE ET";
            this.btn_iade_et.UseVisualStyleBackColor = false;
            this.btn_iade_et.Click += new System.EventHandler(this.btn_iade_et_Click);
            // 
            // lbl_giris_metni
            // 
            this.lbl_giris_metni.AutoSize = true;
            this.lbl_giris_metni.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_giris_metni.Location = new System.Drawing.Point(32, 58);
            this.lbl_giris_metni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_giris_metni.Name = "lbl_giris_metni";
            this.lbl_giris_metni.Size = new System.Drawing.Size(108, 18);
            this.lbl_giris_metni.TabIndex = 2;
            this.lbl_giris_metni.Text = "Hoş Geldin";
            // 
            // lbl_personel_nick
            // 
            this.lbl_personel_nick.AutoSize = true;
            this.lbl_personel_nick.Location = new System.Drawing.Point(989, 54);
            this.lbl_personel_nick.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_personel_nick.Name = "lbl_personel_nick";
            this.lbl_personel_nick.Size = new System.Drawing.Size(0, 16);
            this.lbl_personel_nick.TabIndex = 3;
            // 
            // kiralanan_listesi
            // 
            this.kiralanan_listesi.BackgroundColor = System.Drawing.Color.LightCoral;
            this.kiralanan_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kiralanan_listesi.Location = new System.Drawing.Point(16, 101);
            this.kiralanan_listesi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.kiralanan_listesi.Name = "kiralanan_listesi";
            this.kiralanan_listesi.RowHeadersWidth = 51;
            this.kiralanan_listesi.Size = new System.Drawing.Size(811, 359);
            this.kiralanan_listesi.TabIndex = 4;
            // 
            // lbl_iade_edildi
            // 
            this.lbl_iade_edildi.Location = new System.Drawing.Point(852, 174);
            this.lbl_iade_edildi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_iade_edildi.Name = "lbl_iade_edildi";
            this.lbl_iade_edildi.Size = new System.Drawing.Size(265, 116);
            this.lbl_iade_edildi.TabIndex = 5;
            // 
            // btn_Personel_Ekle
            // 
            this.btn_Personel_Ekle.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Personel_Ekle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Personel_Ekle.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_Personel_Ekle.Location = new System.Drawing.Point(913, 425);
            this.btn_Personel_Ekle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Personel_Ekle.Name = "btn_Personel_Ekle";
            this.btn_Personel_Ekle.Size = new System.Drawing.Size(217, 36);
            this.btn_Personel_Ekle.TabIndex = 3;
            this.btn_Personel_Ekle.Text = "PERSONEL EKLE";
            this.btn_Personel_Ekle.UseVisualStyleBackColor = false;
            this.btn_Personel_Ekle.Click += new System.EventHandler(this.btn_Personel_Ekle_Click);
            // 
            // lbl_yonetici
            // 
            this.lbl_yonetici.AutoSize = true;
            this.lbl_yonetici.Location = new System.Drawing.Point(835, 399);
            this.lbl_yonetici.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_yonetici.Name = "lbl_yonetici";
            this.lbl_yonetici.Size = new System.Drawing.Size(351, 16);
            this.lbl_yonetici.TabIndex = 7;
            this.lbl_yonetici.Text = "!!! SADECE YÖNETİCİ PERSONEL EKLEME YAPABİLİR!!!";
            // 
            // btn_bagıslanan_kitaplar
            // 
            this.btn_bagıslanan_kitaplar.BackColor = System.Drawing.Color.LightCoral;
            this.btn_bagıslanan_kitaplar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bagıslanan_kitaplar.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.btn_bagıslanan_kitaplar.Location = new System.Drawing.Point(868, 310);
            this.btn_bagıslanan_kitaplar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_bagıslanan_kitaplar.Name = "btn_bagıslanan_kitaplar";
            this.btn_bagıslanan_kitaplar.Size = new System.Drawing.Size(319, 57);
            this.btn_bagıslanan_kitaplar.TabIndex = 2;
            this.btn_bagıslanan_kitaplar.Text = "Bağışlanan Kitapları \r\nGörüntüle";
            this.btn_bagıslanan_kitaplar.UseVisualStyleBackColor = false;
            this.btn_bagıslanan_kitaplar.Click += new System.EventHandler(this.btn_bagıslanan_kitaplar_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Img_Button_Exit
            // 
            this.Img_Button_Exit.BackColor = System.Drawing.Color.Transparent;
            this.Img_Button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Img_Button_Exit.Image")));
            this.Img_Button_Exit.ImageActive = null;
            this.Img_Button_Exit.Location = new System.Drawing.Point(1143, 16);
            this.Img_Button_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Img_Button_Exit.Name = "Img_Button_Exit";
            this.Img_Button_Exit.Size = new System.Drawing.Size(65, 57);
            this.Img_Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Button_Exit.TabIndex = 11;
            this.Img_Button_Exit.TabStop = false;
            this.Img_Button_Exit.Zoom = 10;
            this.Img_Button_Exit.Click += new System.EventHandler(this.Img_Button_Exit_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.btn_bagıslanan_kitaplar;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.btn_iade_et;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 30;
            this.bunifuElipse5.TargetControl = this.btn_Personel_Ekle;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.btn_kiralanan_listele;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.Img_Button_Exit);
            this.panel1.Controls.Add(this.lbl_personel_nick);
            this.panel1.Controls.Add(this.lbl_giris_metni);
            this.panel1.Location = new System.Drawing.Point(-4, -2);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1235, 103);
            this.panel1.TabIndex = 12;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel2.Controls.Add(this.btn_kiralanan_listele);
            this.panel2.Location = new System.Drawing.Point(-4, 476);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1227, 114);
            this.panel2.TabIndex = 0;
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1219, 574);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btn_bagıslanan_kitaplar);
            this.Controls.Add(this.lbl_yonetici);
            this.Controls.Add(this.btn_Personel_Ekle);
            this.Controls.Add(this.lbl_iade_edildi);
            this.Controls.Add(this.kiralanan_listesi);
            this.Controls.Add(this.btn_iade_et);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormPersonel";
            ((System.ComponentModel.ISupportInitialize)(this.kiralanan_listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton Img_Button_Exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}