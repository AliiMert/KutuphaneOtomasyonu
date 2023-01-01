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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BTN_Parola = new System.Windows.Forms.Button();
            this.BTN_Yeni_uye = new System.Windows.Forms.Button();
            this.Btn_Giris_Yap = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Picture_box_Giris = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Img_Button_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.Label_Giris_Yap = new System.Windows.Forms.Label();
            this.Txt_Box_Kullanici_ism = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Txt_Box_Parola = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Chc_Box_Parola = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.chcbx_Personel = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Chc_Box_Ad_Hatirla = new Bunifu.Framework.UI.BunifuCheckbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.PictureBox_Lock_Unlock = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_box_Giris)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Lock_Unlock)).BeginInit();
            this.SuspendLayout();
            // 
            // BTN_Parola
            // 
            this.BTN_Parola.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_Parola.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Parola.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Parola.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BTN_Parola.ForeColor = System.Drawing.Color.White;
            this.BTN_Parola.Location = new System.Drawing.Point(378, 275);
            this.BTN_Parola.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Parola.Name = "BTN_Parola";
            this.BTN_Parola.Size = new System.Drawing.Size(191, 36);
            this.BTN_Parola.TabIndex = 7;
            this.BTN_Parola.Text = "Parolamı Unuttum";
            this.BTN_Parola.UseVisualStyleBackColor = false;
            this.BTN_Parola.Click += new System.EventHandler(this.BTN_Parola_Click);
            // 
            // BTN_Yeni_uye
            // 
            this.BTN_Yeni_uye.BackColor = System.Drawing.Color.White;
            this.BTN_Yeni_uye.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Yeni_uye.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Yeni_uye.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold);
            this.BTN_Yeni_uye.ForeColor = System.Drawing.Color.LightCoral;
            this.BTN_Yeni_uye.Location = new System.Drawing.Point(18, 383);
            this.BTN_Yeni_uye.Margin = new System.Windows.Forms.Padding(2);
            this.BTN_Yeni_uye.Name = "BTN_Yeni_uye";
            this.BTN_Yeni_uye.Size = new System.Drawing.Size(294, 39);
            this.BTN_Yeni_uye.TabIndex = 0;
            this.BTN_Yeni_uye.Text = "Yeni üye";
            this.BTN_Yeni_uye.UseVisualStyleBackColor = false;
            this.BTN_Yeni_uye.Click += new System.EventHandler(this.BTN_Yeni_uye_Click);
            // 
            // Btn_Giris_Yap
            // 
            this.Btn_Giris_Yap.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_Giris_Yap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Giris_Yap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Giris_Yap.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_Giris_Yap.ForeColor = System.Drawing.Color.White;
            this.Btn_Giris_Yap.Location = new System.Drawing.Point(376, 383);
            this.Btn_Giris_Yap.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_Giris_Yap.Name = "Btn_Giris_Yap";
            this.Btn_Giris_Yap.Size = new System.Drawing.Size(294, 39);
            this.Btn_Giris_Yap.TabIndex = 3;
            this.Btn_Giris_Yap.Text = "Giriş yapınız";
            this.Btn_Giris_Yap.UseVisualStyleBackColor = false;
            this.Btn_Giris_Yap.Click += new System.EventHandler(this.Btn_Giris_Yap_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.Picture_box_Giris);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.BTN_Yeni_uye);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 463);
            this.panel1.TabIndex = 0;
            // 
            // Picture_box_Giris
            // 
            this.Picture_box_Giris.Image = ((System.Drawing.Image)(resources.GetObject("Picture_box_Giris.Image")));
            this.Picture_box_Giris.Location = new System.Drawing.Point(18, 126);
            this.Picture_box_Giris.Margin = new System.Windows.Forms.Padding(2);
            this.Picture_box_Giris.Name = "Picture_box_Giris";
            this.Picture_box_Giris.Size = new System.Drawing.Size(294, 220);
            this.Picture_box_Giris.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Picture_box_Giris.TabIndex = 13;
            this.Picture_box_Giris.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Courier New", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(342, 108);
            this.label1.TabIndex = 0;
            this.label1.Text = "HALK\r\nKÜTÜPHANESİ";
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Img_Button_Exit
            // 
            this.Img_Button_Exit.BackColor = System.Drawing.Color.White;
            this.Img_Button_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Img_Button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Img_Button_Exit.Image")));
            this.Img_Button_Exit.ImageActive = null;
            this.Img_Button_Exit.Location = new System.Drawing.Point(716, 7);
            this.Img_Button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Img_Button_Exit.Name = "Img_Button_Exit";
            this.Img_Button_Exit.Size = new System.Drawing.Size(49, 46);
            this.Img_Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Button_Exit.TabIndex = 10;
            this.Img_Button_Exit.TabStop = false;
            this.Img_Button_Exit.Zoom = 10;
            this.Img_Button_Exit.Click += new System.EventHandler(this.Img_Button_Exit_Click);
            // 
            // Label_Giris_Yap
            // 
            this.Label_Giris_Yap.AutoSize = true;
            this.Label_Giris_Yap.Font = new System.Drawing.Font("Courier New", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label_Giris_Yap.ForeColor = System.Drawing.Color.LightCoral;
            this.Label_Giris_Yap.Location = new System.Drawing.Point(370, 42);
            this.Label_Giris_Yap.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Label_Giris_Yap.Name = "Label_Giris_Yap";
            this.Label_Giris_Yap.Size = new System.Drawing.Size(206, 40);
            this.Label_Giris_Yap.TabIndex = 0;
            this.Label_Giris_Yap.Text = "Giriş Yap";
            // 
            // Txt_Box_Kullanici_ism
            // 
            this.Txt_Box_Kullanici_ism.BackColor = System.Drawing.Color.White;
            this.Txt_Box_Kullanici_ism.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Box_Kullanici_ism.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Box_Kullanici_ism.ForeColor = System.Drawing.Color.Black;
            this.Txt_Box_Kullanici_ism.HintForeColor = System.Drawing.Color.Black;
            this.Txt_Box_Kullanici_ism.HintText = "Kullanıcı Adınızı Girin";
            this.Txt_Box_Kullanici_ism.isPassword = false;
            this.Txt_Box_Kullanici_ism.LineFocusedColor = System.Drawing.Color.Black;
            this.Txt_Box_Kullanici_ism.LineIdleColor = System.Drawing.Color.LightCoral;
            this.Txt_Box_Kullanici_ism.LineMouseHoverColor = System.Drawing.Color.Black;
            this.Txt_Box_Kullanici_ism.LineThickness = 7;
            this.Txt_Box_Kullanici_ism.Location = new System.Drawing.Point(376, 117);
            this.Txt_Box_Kullanici_ism.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txt_Box_Kullanici_ism.Name = "Txt_Box_Kullanici_ism";
            this.Txt_Box_Kullanici_ism.Size = new System.Drawing.Size(316, 36);
            this.Txt_Box_Kullanici_ism.TabIndex = 1;
            this.Txt_Box_Kullanici_ism.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_Box_Kullanici_ism.Enter += new System.EventHandler(this.Txt_Box_Kullanici_ism_Enter);
            // 
            // Txt_Box_Parola
            // 
            this.Txt_Box_Parola.BackColor = System.Drawing.Color.White;
            this.Txt_Box_Parola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Box_Parola.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Box_Parola.ForeColor = System.Drawing.Color.Black;
            this.Txt_Box_Parola.HintForeColor = System.Drawing.Color.Black;
            this.Txt_Box_Parola.HintText = "";
            this.Txt_Box_Parola.isPassword = false;
            this.Txt_Box_Parola.LineFocusedColor = System.Drawing.Color.Black;
            this.Txt_Box_Parola.LineIdleColor = System.Drawing.Color.LightCoral;
            this.Txt_Box_Parola.LineMouseHoverColor = System.Drawing.Color.Black;
            this.Txt_Box_Parola.LineThickness = 7;
            this.Txt_Box_Parola.Location = new System.Drawing.Point(376, 234);
            this.Txt_Box_Parola.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Txt_Box_Parola.Name = "Txt_Box_Parola";
            this.Txt_Box_Parola.Size = new System.Drawing.Size(316, 36);
            this.Txt_Box_Parola.TabIndex = 2;
            this.Txt_Box_Parola.Text = "Parolanızı Girin";
            this.Txt_Box_Parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Txt_Box_Parola.Enter += new System.EventHandler(this.Txt_Box_Parola_Enter);
            // 
            // Chc_Box_Parola
            // 
            this.Chc_Box_Parola.BackColor = System.Drawing.Color.LightCoral;
            this.Chc_Box_Parola.ChechedOffColor = System.Drawing.Color.LightCoral;
            this.Chc_Box_Parola.Checked = false;
            this.Chc_Box_Parola.CheckedOnColor = System.Drawing.Color.LightCoral;
            this.Chc_Box_Parola.ForeColor = System.Drawing.Color.Black;
            this.Chc_Box_Parola.Location = new System.Drawing.Point(582, 284);
            this.Chc_Box_Parola.Name = "Chc_Box_Parola";
            this.Chc_Box_Parola.Size = new System.Drawing.Size(20, 20);
            this.Chc_Box_Parola.TabIndex = 6;
            this.Chc_Box_Parola.OnChange += new System.EventHandler(this.Chc_Box_Parola_OnChange);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.LightCoral;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(607, 284);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(158, 18);
            this.bunifuCustomLabel1.TabIndex = 8;
            this.bunifuCustomLabel1.Text = "Parolamı Goster";
            // 
            // chcbx_Personel
            // 
            this.chcbx_Personel.BackColor = System.Drawing.Color.LightCoral;
            this.chcbx_Personel.ChechedOffColor = System.Drawing.Color.LightCoral;
            this.chcbx_Personel.Checked = false;
            this.chcbx_Personel.CheckedOnColor = System.Drawing.Color.LightCoral;
            this.chcbx_Personel.ForeColor = System.Drawing.Color.Black;
            this.chcbx_Personel.Location = new System.Drawing.Point(376, 195);
            this.chcbx_Personel.Name = "chcbx_Personel";
            this.chcbx_Personel.Size = new System.Drawing.Size(20, 20);
            this.chcbx_Personel.TabIndex = 5;
            this.chcbx_Personel.Click += new System.EventHandler(this.chcbx_Personel_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.LightCoral;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(397, 195);
            this.bunifuCustomLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(108, 18);
            this.bunifuCustomLabel2.TabIndex = 19;
            this.bunifuCustomLabel2.Text = "Personelim";
            // 
            // Chc_Box_Ad_Hatirla
            // 
            this.Chc_Box_Ad_Hatirla.BackColor = System.Drawing.Color.LightCoral;
            this.Chc_Box_Ad_Hatirla.ChechedOffColor = System.Drawing.Color.LightCoral;
            this.Chc_Box_Ad_Hatirla.Checked = false;
            this.Chc_Box_Ad_Hatirla.CheckedOnColor = System.Drawing.Color.LightCoral;
            this.Chc_Box_Ad_Hatirla.ForeColor = System.Drawing.Color.Black;
            this.Chc_Box_Ad_Hatirla.Location = new System.Drawing.Point(376, 172);
            this.Chc_Box_Ad_Hatirla.Name = "Chc_Box_Ad_Hatirla";
            this.Chc_Box_Ad_Hatirla.Size = new System.Drawing.Size(20, 20);
            this.Chc_Box_Ad_Hatirla.TabIndex = 4;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.LightCoral;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(397, 172);
            this.bunifuCustomLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(238, 18);
            this.bunifuCustomLabel3.TabIndex = 21;
            this.bunifuCustomLabel3.Text = "Kullanıcı adımı hatırla";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.Btn_Giris_Yap;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.BTN_Parola;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.BTN_Yeni_uye;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(652, 102);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // PictureBox_Lock_Unlock
            // 
            this.PictureBox_Lock_Unlock.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Lock_Unlock.Image")));
            this.PictureBox_Lock_Unlock.Location = new System.Drawing.Point(652, 224);
            this.PictureBox_Lock_Unlock.Margin = new System.Windows.Forms.Padding(2);
            this.PictureBox_Lock_Unlock.Name = "PictureBox_Lock_Unlock";
            this.PictureBox_Lock_Unlock.Size = new System.Drawing.Size(40, 37);
            this.PictureBox_Lock_Unlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Lock_Unlock.TabIndex = 23;
            this.PictureBox_Lock_Unlock.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(776, 463);
            this.Controls.Add(this.PictureBox_Lock_Unlock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.Chc_Box_Ad_Hatirla);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.chcbx_Personel);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.Chc_Box_Parola);
            this.Controls.Add(this.Txt_Box_Parola);
            this.Controls.Add(this.Txt_Box_Kullanici_ism);
            this.Controls.Add(this.Btn_Giris_Yap);
            this.Controls.Add(this.Label_Giris_Yap);
            this.Controls.Add(this.BTN_Parola);
            this.Controls.Add(this.Img_Button_Exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Picture_box_Giris)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Lock_Unlock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BTN_Parola;
        private System.Windows.Forms.Button BTN_Yeni_uye;
        private System.Windows.Forms.Button Btn_Giris_Yap;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton Img_Button_Exit;
        private System.Windows.Forms.Label Label_Giris_Yap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox Picture_box_Giris;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt_Box_Parola;
        public Bunifu.Framework.UI.BunifuMaterialTextbox Txt_Box_Kullanici_ism;
        private Bunifu.Framework.UI.BunifuCheckbox Chc_Box_Parola;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCheckbox Chc_Box_Ad_Hatirla;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCheckbox chcbx_Personel;
        private System.Windows.Forms.PictureBox PictureBox_Lock_Unlock;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
    }
}