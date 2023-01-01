
namespace kutuphane_uygulamasi
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.Btn_ilerle = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Img_Button_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.txt_su_kullanici_nick = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Txt_Box_Yeni_Parola = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Txt_Box_Parola_Yeniden = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_su_guvenlik_sorusu = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pbox_remembernt_passw = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.BTN_AnasayfayaDon = new System.Windows.Forms.Button();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.txt_su_guvenlik_sorusu_cevabi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PictureBox_Lock_Unlock = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_remembernt_passw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Lock_Unlock)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_ilerle
            // 
            this.Btn_ilerle.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_ilerle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ilerle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_ilerle.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_ilerle.ForeColor = System.Drawing.Color.White;
            this.Btn_ilerle.Location = new System.Drawing.Point(40, 394);
            this.Btn_ilerle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Btn_ilerle.Name = "Btn_ilerle";
            this.Btn_ilerle.Size = new System.Drawing.Size(307, 39);
            this.Btn_ilerle.TabIndex = 6;
            this.Btn_ilerle.Text = "ilerle";
            this.Btn_ilerle.UseVisualStyleBackColor = false;
            this.Btn_ilerle.Click += new System.EventHandler(this.Btn_ilerle_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Img_Button_Exit
            // 
            this.Img_Button_Exit.BackColor = System.Drawing.Color.LightCoral;
            this.Img_Button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Img_Button_Exit.Image")));
            this.Img_Button_Exit.ImageActive = null;
            this.Img_Button_Exit.Location = new System.Drawing.Point(327, 14);
            this.Img_Button_Exit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Img_Button_Exit.Name = "Img_Button_Exit";
            this.Img_Button_Exit.Size = new System.Drawing.Size(69, 50);
            this.Img_Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Button_Exit.TabIndex = 11;
            this.Img_Button_Exit.TabStop = false;
            this.Img_Button_Exit.Zoom = 10;
            this.Img_Button_Exit.Click += new System.EventHandler(this.Img_Button_Exit_Click);
            // 
            // txt_su_kullanici_nick
            // 
            this.txt_su_kullanici_nick.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_su_kullanici_nick.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_su_kullanici_nick.ForeColor = System.Drawing.Color.Black;
            this.txt_su_kullanici_nick.HintForeColor = System.Drawing.Color.Black;
            this.txt_su_kullanici_nick.HintText = "Kullanıcı adınızı giriniz";
            this.txt_su_kullanici_nick.isPassword = false;
            this.txt_su_kullanici_nick.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_su_kullanici_nick.LineIdleColor = System.Drawing.Color.LightCoral;
            this.txt_su_kullanici_nick.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_su_kullanici_nick.LineThickness = 3;
            this.txt_su_kullanici_nick.Location = new System.Drawing.Point(13, 84);
            this.txt_su_kullanici_nick.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txt_su_kullanici_nick.Name = "txt_su_kullanici_nick";
            this.txt_su_kullanici_nick.Size = new System.Drawing.Size(355, 33);
            this.txt_su_kullanici_nick.TabIndex = 1;
            this.txt_su_kullanici_nick.Tag = "";
            this.txt_su_kullanici_nick.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txt_Box_Yeni_Parola
            // 
            this.Txt_Box_Yeni_Parola.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Box_Yeni_Parola.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Box_Yeni_Parola.ForeColor = System.Drawing.Color.Black;
            this.Txt_Box_Yeni_Parola.HintForeColor = System.Drawing.Color.Black;
            this.Txt_Box_Yeni_Parola.HintText = "Yeni parolanızı giriniz";
            this.Txt_Box_Yeni_Parola.isPassword = false;
            this.Txt_Box_Yeni_Parola.LineFocusedColor = System.Drawing.Color.Black;
            this.Txt_Box_Yeni_Parola.LineIdleColor = System.Drawing.Color.LightCoral;
            this.Txt_Box_Yeni_Parola.LineMouseHoverColor = System.Drawing.Color.Black;
            this.Txt_Box_Yeni_Parola.LineThickness = 3;
            this.Txt_Box_Yeni_Parola.Location = new System.Drawing.Point(13, 143);
            this.Txt_Box_Yeni_Parola.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Txt_Box_Yeni_Parola.Name = "Txt_Box_Yeni_Parola";
            this.Txt_Box_Yeni_Parola.Size = new System.Drawing.Size(361, 33);
            this.Txt_Box_Yeni_Parola.TabIndex = 2;
            this.Txt_Box_Yeni_Parola.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // Txt_Box_Parola_Yeniden
            // 
            this.Txt_Box_Parola_Yeniden.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Txt_Box_Parola_Yeniden.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Txt_Box_Parola_Yeniden.ForeColor = System.Drawing.Color.Black;
            this.Txt_Box_Parola_Yeniden.HintForeColor = System.Drawing.Color.Black;
            this.Txt_Box_Parola_Yeniden.HintText = "Parolanızı yeniden giriniz";
            this.Txt_Box_Parola_Yeniden.isPassword = false;
            this.Txt_Box_Parola_Yeniden.LineFocusedColor = System.Drawing.Color.Black;
            this.Txt_Box_Parola_Yeniden.LineIdleColor = System.Drawing.Color.LightCoral;
            this.Txt_Box_Parola_Yeniden.LineMouseHoverColor = System.Drawing.Color.Black;
            this.Txt_Box_Parola_Yeniden.LineThickness = 3;
            this.Txt_Box_Parola_Yeniden.Location = new System.Drawing.Point(13, 183);
            this.Txt_Box_Parola_Yeniden.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.Txt_Box_Parola_Yeniden.Name = "Txt_Box_Parola_Yeniden";
            this.Txt_Box_Parola_Yeniden.Size = new System.Drawing.Size(361, 33);
            this.Txt_Box_Parola_Yeniden.TabIndex = 3;
            this.Txt_Box_Parola_Yeniden.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.txt_su_guvenlik_sorusu;
            // 
            // txt_su_guvenlik_sorusu
            // 
            this.txt_su_guvenlik_sorusu.BackColor = System.Drawing.Color.LightCoral;
            this.txt_su_guvenlik_sorusu.Cursor = System.Windows.Forms.Cursors.Default;
            this.txt_su_guvenlik_sorusu.DropDownWidth = 390;
            this.txt_su_guvenlik_sorusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_su_guvenlik_sorusu.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_su_guvenlik_sorusu.ForeColor = System.Drawing.Color.White;
            this.txt_su_guvenlik_sorusu.FormattingEnabled = true;
            this.txt_su_guvenlik_sorusu.Items.AddRange(new object[] {
            "İlkokul öğretmeninizin adı?",
            "Evcil hayvanınızın adı?",
            "En sevdiğiniz renk?"});
            this.txt_su_guvenlik_sorusu.Location = new System.Drawing.Point(20, 250);
            this.txt_su_guvenlik_sorusu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_su_guvenlik_sorusu.Name = "txt_su_guvenlik_sorusu";
            this.txt_su_guvenlik_sorusu.Size = new System.Drawing.Size(353, 29);
            this.txt_su_guvenlik_sorusu.TabIndex = 4;
            this.txt_su_guvenlik_sorusu.Text = "Güvenlik sorusu seçin";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Controls.Add(this.pbox_remembernt_passw);
            this.panel1.Controls.Add(this.Img_Button_Exit);
            this.panel1.Location = new System.Drawing.Point(423, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(399, 497);
            this.panel1.TabIndex = 0;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(19, 156);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(231, 32);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Utanmana gerek yok\r\nherkes şifresini unutabilir ";
            // 
            // pbox_remembernt_passw
            // 
            this.pbox_remembernt_passw.Image = ((System.Drawing.Image)(resources.GetObject("pbox_remembernt_passw.Image")));
            this.pbox_remembernt_passw.Location = new System.Drawing.Point(23, 212);
            this.pbox_remembernt_passw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbox_remembernt_passw.Name = "pbox_remembernt_passw";
            this.pbox_remembernt_passw.Size = new System.Drawing.Size(373, 266);
            this.pbox_remembernt_passw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_remembernt_passw.TabIndex = 12;
            this.pbox_remembernt_passw.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(364, 69);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(53, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.Btn_ilerle;
            // 
            // BTN_AnasayfayaDon
            // 
            this.BTN_AnasayfayaDon.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_AnasayfayaDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_AnasayfayaDon.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold);
            this.BTN_AnasayfayaDon.ForeColor = System.Drawing.Color.White;
            this.BTN_AnasayfayaDon.Location = new System.Drawing.Point(43, 438);
            this.BTN_AnasayfayaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BTN_AnasayfayaDon.Name = "BTN_AnasayfayaDon";
            this.BTN_AnasayfayaDon.Size = new System.Drawing.Size(304, 39);
            this.BTN_AnasayfayaDon.TabIndex = 7;
            this.BTN_AnasayfayaDon.Text = "Ana sayfaya dön";
            this.BTN_AnasayfayaDon.UseVisualStyleBackColor = false;
            this.BTN_AnasayfayaDon.Click += new System.EventHandler(this.BTN_AnasayfayaDon_Click);
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.BTN_AnasayfayaDon;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 30;
            this.bunifuElipse5.TargetControl = this;
            // 
            // txt_su_guvenlik_sorusu_cevabi
            // 
            this.txt_su_guvenlik_sorusu_cevabi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_su_guvenlik_sorusu_cevabi.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_su_guvenlik_sorusu_cevabi.ForeColor = System.Drawing.Color.Black;
            this.txt_su_guvenlik_sorusu_cevabi.HintForeColor = System.Drawing.Color.Black;
            this.txt_su_guvenlik_sorusu_cevabi.HintText = "Güvenlik sorusunun cevabı";
            this.txt_su_guvenlik_sorusu_cevabi.isPassword = false;
            this.txt_su_guvenlik_sorusu_cevabi.LineFocusedColor = System.Drawing.Color.Black;
            this.txt_su_guvenlik_sorusu_cevabi.LineIdleColor = System.Drawing.Color.LightCoral;
            this.txt_su_guvenlik_sorusu_cevabi.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txt_su_guvenlik_sorusu_cevabi.LineThickness = 3;
            this.txt_su_guvenlik_sorusu_cevabi.Location = new System.Drawing.Point(19, 293);
            this.txt_su_guvenlik_sorusu_cevabi.Margin = new System.Windows.Forms.Padding(7, 5, 7, 5);
            this.txt_su_guvenlik_sorusu_cevabi.Name = "txt_su_guvenlik_sorusu_cevabi";
            this.txt_su_guvenlik_sorusu_cevabi.Size = new System.Drawing.Size(356, 33);
            this.txt_su_guvenlik_sorusu_cevabi.TabIndex = 5;
            this.txt_su_guvenlik_sorusu_cevabi.Tag = "";
            this.txt_su_guvenlik_sorusu_cevabi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PictureBox_Lock_Unlock
            // 
            this.PictureBox_Lock_Unlock.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox_Lock_Unlock.Image")));
            this.PictureBox_Lock_Unlock.Location = new System.Drawing.Point(364, 130);
            this.PictureBox_Lock_Unlock.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PictureBox_Lock_Unlock.Name = "PictureBox_Lock_Unlock";
            this.PictureBox_Lock_Unlock.Size = new System.Drawing.Size(53, 46);
            this.PictureBox_Lock_Unlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox_Lock_Unlock.TabIndex = 24;
            this.PictureBox_Lock_Unlock.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(824, 498);
            this.Controls.Add(this.PictureBox_Lock_Unlock);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_su_guvenlik_sorusu_cevabi);
            this.Controls.Add(this.BTN_AnasayfayaDon);
            this.Controls.Add(this.txt_su_kullanici_nick);
            this.Controls.Add(this.Txt_Box_Parola_Yeniden);
            this.Controls.Add(this.Txt_Box_Yeni_Parola);
            this.Controls.Add(this.Btn_ilerle);
            this.Controls.Add(this.txt_su_guvenlik_sorusu);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbox_remembernt_passw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_Lock_Unlock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Btn_ilerle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton Img_Button_Exit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt_Box_Parola_Yeniden;
        private Bunifu.Framework.UI.BunifuMaterialTextbox Txt_Box_Yeni_Parola;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_su_kullanici_nick;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Button BTN_AnasayfayaDon;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pbox_remembernt_passw;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txt_su_guvenlik_sorusu_cevabi;
        private System.Windows.Forms.ComboBox txt_su_guvenlik_sorusu;
        private System.Windows.Forms.PictureBox PictureBox_Lock_Unlock;
    }
}