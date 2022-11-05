namespace kutuphane_uygulamasi
{
    partial class FormKitapKiralama
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
            this.btn_Kitap_Listele = new System.Windows.Forms.Button();
            this.btn_Kitap_Kirala = new System.Windows.Forms.Button();
            this.kitaplar_listesi = new System.Windows.Forms.DataGridView();
            this.kiralama_tarihi = new System.Windows.Forms.Label();
            this.txt_secilen_kitaplar = new System.Windows.Forms.Label();
            this.txt_giris_metni = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_hos_geldin = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_kitap_bagisla = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar_listesi)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Kitap_Listele
            // 
            this.btn_Kitap_Listele.Location = new System.Drawing.Point(161, 36);
            this.btn_Kitap_Listele.Name = "btn_Kitap_Listele";
            this.btn_Kitap_Listele.Size = new System.Drawing.Size(166, 40);
            this.btn_Kitap_Listele.TabIndex = 0;
            this.btn_Kitap_Listele.Text = "Kitapları Listele";
            this.btn_Kitap_Listele.UseVisualStyleBackColor = true;
            this.btn_Kitap_Listele.Click += new System.EventHandler(this.btn_Kitap_Listele_Click_1);
            // 
            // btn_Kitap_Kirala
            // 
            this.btn_Kitap_Kirala.Location = new System.Drawing.Point(516, 185);
            this.btn_Kitap_Kirala.Name = "btn_Kitap_Kirala";
            this.btn_Kitap_Kirala.Size = new System.Drawing.Size(176, 28);
            this.btn_Kitap_Kirala.TabIndex = 1;
            this.btn_Kitap_Kirala.Text = "KİRALA";
            this.btn_Kitap_Kirala.UseVisualStyleBackColor = true;
            this.btn_Kitap_Kirala.Click += new System.EventHandler(this.btn_Kitap_Kirala_Click_1);
            // 
            // kitaplar_listesi
            // 
            this.kitaplar_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplar_listesi.Location = new System.Drawing.Point(51, 89);
            this.kitaplar_listesi.Name = "kitaplar_listesi";
            this.kitaplar_listesi.Size = new System.Drawing.Size(380, 269);
            this.kitaplar_listesi.TabIndex = 2;
            // 
            // kiralama_tarihi
            // 
            this.kiralama_tarihi.AutoSize = true;
            this.kiralama_tarihi.Location = new System.Drawing.Point(667, 36);
            this.kiralama_tarihi.Name = "kiralama_tarihi";
            this.kiralama_tarihi.Size = new System.Drawing.Size(0, 13);
            this.kiralama_tarihi.TabIndex = 3;
            // 
            // txt_secilen_kitaplar
            // 
            this.txt_secilen_kitaplar.Location = new System.Drawing.Point(471, 237);
            this.txt_secilen_kitaplar.Name = "txt_secilen_kitaplar";
            this.txt_secilen_kitaplar.Size = new System.Drawing.Size(249, 121);
            this.txt_secilen_kitaplar.TabIndex = 4;
            // 
            // txt_giris_metni
            // 
            this.txt_giris_metni.AutoSize = true;
            this.txt_giris_metni.Location = new System.Drawing.Point(564, 134);
            this.txt_giris_metni.Name = "txt_giris_metni";
            this.txt_giris_metni.Size = new System.Drawing.Size(0, 13);
            this.txt_giris_metni.TabIndex = 5;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_hos_geldin
            // 
            this.lbl_hos_geldin.AutoSize = true;
            this.lbl_hos_geldin.Location = new System.Drawing.Point(505, 134);
            this.lbl_hos_geldin.Name = "lbl_hos_geldin";
            this.lbl_hos_geldin.Size = new System.Drawing.Size(59, 13);
            this.lbl_hos_geldin.TabIndex = 6;
            this.lbl_hos_geldin.Text = "Hoş Geldin";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(79, 231);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            this.dateTimePicker1.Visible = false;
            // 
            // btn_kitap_bagisla
            // 
            this.btn_kitap_bagisla.Location = new System.Drawing.Point(516, 374);
            this.btn_kitap_bagisla.Name = "btn_kitap_bagisla";
            this.btn_kitap_bagisla.Size = new System.Drawing.Size(155, 37);
            this.btn_kitap_bagisla.TabIndex = 8;
            this.btn_kitap_bagisla.Text = "Kitap Bağışla";
            this.btn_kitap_bagisla.UseVisualStyleBackColor = true;
            this.btn_kitap_bagisla.Click += new System.EventHandler(this.btn_kitap_bagisla_Click);
            // 
            // FormKitapKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_kitap_bagisla);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_hos_geldin);
            this.Controls.Add(this.txt_giris_metni);
            this.Controls.Add(this.txt_secilen_kitaplar);
            this.Controls.Add(this.kiralama_tarihi);
            this.Controls.Add(this.kitaplar_listesi);
            this.Controls.Add(this.btn_Kitap_Kirala);
            this.Controls.Add(this.btn_Kitap_Listele);
            this.Name = "FormKitapKiralama";
            this.Text = "FormKitapKiralama";
            this.Load += new System.EventHandler(this.FormKitapKiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar_listesi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Kitap_Listele;
        private System.Windows.Forms.Button btn_Kitap_Kirala;
        private System.Windows.Forms.DataGridView kitaplar_listesi;
        private System.Windows.Forms.Label kiralama_tarihi;
        private System.Windows.Forms.Label txt_secilen_kitaplar;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label txt_giris_metni;
        private System.Windows.Forms.Label lbl_hos_geldin;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_kitap_bagisla;
    }
}