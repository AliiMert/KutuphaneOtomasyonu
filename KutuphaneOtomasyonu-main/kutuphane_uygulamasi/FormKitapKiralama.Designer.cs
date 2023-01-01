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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitapKiralama));
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
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Img_Button_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Txt_Box_Kitap_Ara = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar_listesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Kitap_Listele
            // 
            this.btn_Kitap_Listele.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Kitap_Listele.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kitap_Listele.Location = new System.Drawing.Point(208, 28);
            this.btn_Kitap_Listele.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Kitap_Listele.Name = "btn_Kitap_Listele";
            this.btn_Kitap_Listele.Size = new System.Drawing.Size(228, 53);
            this.btn_Kitap_Listele.TabIndex = 1;
            this.btn_Kitap_Listele.Text = "Kitapları Listele";
            this.btn_Kitap_Listele.UseVisualStyleBackColor = false;
            this.btn_Kitap_Listele.Click += new System.EventHandler(this.btn_Kitap_Listele_Click_1);
            // 
            // btn_Kitap_Kirala
            // 
            this.btn_Kitap_Kirala.BackColor = System.Drawing.Color.LightCoral;
            this.btn_Kitap_Kirala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Kitap_Kirala.Location = new System.Drawing.Point(701, 222);
            this.btn_Kitap_Kirala.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Kitap_Kirala.Name = "btn_Kitap_Kirala";
            this.btn_Kitap_Kirala.Size = new System.Drawing.Size(235, 34);
            this.btn_Kitap_Kirala.TabIndex = 2;
            this.btn_Kitap_Kirala.Text = "KİRALA";
            this.btn_Kitap_Kirala.UseVisualStyleBackColor = false;
            this.btn_Kitap_Kirala.Click += new System.EventHandler(this.btn_Kitap_Kirala_Click_1);
            // 
            // kitaplar_listesi
            // 
            this.kitaplar_listesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplar_listesi.Location = new System.Drawing.Point(62, 148);
            this.kitaplar_listesi.Margin = new System.Windows.Forms.Padding(4);
            this.kitaplar_listesi.Name = "kitaplar_listesi";
            this.kitaplar_listesi.RowHeadersWidth = 51;
            this.kitaplar_listesi.Size = new System.Drawing.Size(507, 331);
            this.kitaplar_listesi.TabIndex = 8;
            // 
            // kiralama_tarihi
            // 
            this.kiralama_tarihi.AutoSize = true;
            this.kiralama_tarihi.BackColor = System.Drawing.Color.White;
            this.kiralama_tarihi.Location = new System.Drawing.Point(621, 110);
            this.kiralama_tarihi.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.kiralama_tarihi.Name = "kiralama_tarihi";
            this.kiralama_tarihi.Size = new System.Drawing.Size(14, 16);
            this.kiralama_tarihi.TabIndex = 4;
            this.kiralama_tarihi.Text = "s";
            // 
            // txt_secilen_kitaplar
            // 
            this.txt_secilen_kitaplar.Location = new System.Drawing.Point(643, 286);
            this.txt_secilen_kitaplar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_secilen_kitaplar.Name = "txt_secilen_kitaplar";
            this.txt_secilen_kitaplar.Size = new System.Drawing.Size(332, 149);
            this.txt_secilen_kitaplar.TabIndex = 5;
            // 
            // txt_giris_metni
            // 
            this.txt_giris_metni.AutoSize = true;
            this.txt_giris_metni.Location = new System.Drawing.Point(765, 158);
            this.txt_giris_metni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txt_giris_metni.Name = "txt_giris_metni";
            this.txt_giris_metni.Size = new System.Drawing.Size(0, 16);
            this.txt_giris_metni.TabIndex = 6;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_hos_geldin
            // 
            this.lbl_hos_geldin.AutoSize = true;
            this.lbl_hos_geldin.Location = new System.Drawing.Point(687, 158);
            this.lbl_hos_geldin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_hos_geldin.Name = "lbl_hos_geldin";
            this.lbl_hos_geldin.Size = new System.Drawing.Size(74, 16);
            this.lbl_hos_geldin.TabIndex = 7;
            this.lbl_hos_geldin.Text = "Hoş Geldin";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 286);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(265, 22);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Visible = false;
            // 
            // btn_kitap_bagisla
            // 
            this.btn_kitap_bagisla.BackColor = System.Drawing.Color.LightCoral;
            this.btn_kitap_bagisla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitap_bagisla.Location = new System.Drawing.Point(701, 453);
            this.btn_kitap_bagisla.Margin = new System.Windows.Forms.Padding(4);
            this.btn_kitap_bagisla.Name = "btn_kitap_bagisla";
            this.btn_kitap_bagisla.Size = new System.Drawing.Size(207, 46);
            this.btn_kitap_bagisla.TabIndex = 3;
            this.btn_kitap_bagisla.Text = "Kitap Bağışla";
            this.btn_kitap_bagisla.UseVisualStyleBackColor = false;
            this.btn_kitap_bagisla.Click += new System.EventHandler(this.btn_kitap_bagisla_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Img_Button_Exit
            // 
            this.Img_Button_Exit.BackColor = System.Drawing.Color.White;
            this.Img_Button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Img_Button_Exit.Image")));
            this.Img_Button_Exit.ImageActive = null;
            this.Img_Button_Exit.Location = new System.Drawing.Point(987, 14);
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
            this.bunifuElipse2.TargetControl = this.btn_kitap_bagisla;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.btn_Kitap_Kirala;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.btn_Kitap_Listele;
            // 
            // Txt_Box_Kitap_Ara
            // 
            this.Txt_Box_Kitap_Ara.BackColor = System.Drawing.Color.Gainsboro;
            this.Txt_Box_Kitap_Ara.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Box_Kitap_Ara.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Box_Kitap_Ara.ForeColor = System.Drawing.Color.Black;
            this.Txt_Box_Kitap_Ara.HintForeColor = System.Drawing.Color.Black;
            this.Txt_Box_Kitap_Ara.HintText = "Aramak istedğiniz kitabın ismini giriniz";
            this.Txt_Box_Kitap_Ara.isPassword = false;
            this.Txt_Box_Kitap_Ara.LineFocusedColor = System.Drawing.Color.Black;
            this.Txt_Box_Kitap_Ara.LineIdleColor = System.Drawing.Color.LightCoral;
            this.Txt_Box_Kitap_Ara.LineMouseHoverColor = System.Drawing.Color.Black;
            this.Txt_Box_Kitap_Ara.LineThickness = 5;
            this.Txt_Box_Kitap_Ara.Location = new System.Drawing.Point(127, 97);
            this.Txt_Box_Kitap_Ara.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txt_Box_Kitap_Ara.Name = "Txt_Box_Kitap_Ara";
            this.Txt_Box_Kitap_Ara.Size = new System.Drawing.Size(386, 43);
            this.Txt_Box_Kitap_Ara.TabIndex = 12;
            this.Txt_Box_Kitap_Ara.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_Box_Kitap_Ara.OnValueChanged += new System.EventHandler(this.Txt_Box_Kitap_Ara_OnValueChanged);
            // 
            // FormKitapKiralama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.Txt_Box_Kitap_Ara);
            this.Controls.Add(this.Img_Button_Exit);
            this.Controls.Add(this.btn_kitap_bagisla);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbl_hos_geldin);
            this.Controls.Add(this.txt_giris_metni);
            this.Controls.Add(this.txt_secilen_kitaplar);
            this.Controls.Add(this.kiralama_tarihi);
            this.Controls.Add(this.kitaplar_listesi);
            this.Controls.Add(this.btn_Kitap_Kirala);
            this.Controls.Add(this.btn_Kitap_Listele);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormKitapKiralama";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKitapKiralama";
            this.Load += new System.EventHandler(this.FormKitapKiralama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kitaplar_listesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).EndInit();
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
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton Img_Button_Exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Txt_Box_Kitap_Ara;
    }
}