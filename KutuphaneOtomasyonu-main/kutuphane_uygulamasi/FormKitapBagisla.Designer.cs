namespace kutuphane_uygulamasi
{
    partial class FormKitapBagisla
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKitapBagisla));
            this.btn_kitap_bagisla_islemi = new System.Windows.Forms.Button();
            this.lbl_nick = new System.Windows.Forms.Label();
            this.lbl_metin = new System.Windows.Forms.Label();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Img_Button_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.txtbx_bagislanan_kitap_adi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.BTN_Geri = new System.Windows.Forms.Button();
            this.txtbx_bagislanan_kitap_yazar = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_kitap_bagisla_islemi
            // 
            this.btn_kitap_bagisla_islemi.BackColor = System.Drawing.Color.LightCoral;
            this.btn_kitap_bagisla_islemi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kitap_bagisla_islemi.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_kitap_bagisla_islemi.ForeColor = System.Drawing.Color.White;
            this.btn_kitap_bagisla_islemi.Location = new System.Drawing.Point(18, 207);
            this.btn_kitap_bagisla_islemi.Name = "btn_kitap_bagisla_islemi";
            this.btn_kitap_bagisla_islemi.Size = new System.Drawing.Size(390, 44);
            this.btn_kitap_bagisla_islemi.TabIndex = 3;
            this.btn_kitap_bagisla_islemi.Text = "Kitabı Bağışla";
            this.btn_kitap_bagisla_islemi.UseVisualStyleBackColor = false;
            this.btn_kitap_bagisla_islemi.Click += new System.EventHandler(this.btn_kitap_bagisla_islemi_Click);
            // 
            // lbl_nick
            // 
            this.lbl_nick.AutoSize = true;
            this.lbl_nick.Location = new System.Drawing.Point(302, 93);
            this.lbl_nick.Name = "lbl_nick";
            this.lbl_nick.Size = new System.Drawing.Size(0, 13);
            this.lbl_nick.TabIndex = 3;
            // 
            // lbl_metin
            // 
            this.lbl_metin.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_metin.Location = new System.Drawing.Point(18, 142);
            this.lbl_metin.Name = "lbl_metin";
            this.lbl_metin.Size = new System.Drawing.Size(390, 62);
            this.lbl_metin.TabIndex = 5;
            this.lbl_metin.Text = "!!! Kitap bağışlama işlemini bitirdikten sonra kitabı kütüphane görevlisine tesli" +
    "m etmeyi unutmayınız. !!!";
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
            this.Img_Button_Exit.Location = new System.Drawing.Point(348, 26);
            this.Img_Button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Img_Button_Exit.Name = "Img_Button_Exit";
            this.Img_Button_Exit.Size = new System.Drawing.Size(49, 46);
            this.Img_Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Button_Exit.TabIndex = 11;
            this.Img_Button_Exit.TabStop = false;
            this.Img_Button_Exit.Zoom = 10;
            this.Img_Button_Exit.Click += new System.EventHandler(this.Img_Button_Exit_Click);
            // 
            // txtbx_bagislanan_kitap_adi
            // 
            this.txtbx_bagislanan_kitap_adi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_bagislanan_kitap_adi.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbx_bagislanan_kitap_adi.ForeColor = System.Drawing.Color.LightCoral;
            this.txtbx_bagislanan_kitap_adi.HintForeColor = System.Drawing.Color.Black;
            this.txtbx_bagislanan_kitap_adi.HintText = "Kitap adını giriniz ";
            this.txtbx_bagislanan_kitap_adi.isPassword = false;
            this.txtbx_bagislanan_kitap_adi.LineFocusedColor = System.Drawing.Color.Black;
            this.txtbx_bagislanan_kitap_adi.LineIdleColor = System.Drawing.Color.LightCoral;
            this.txtbx_bagislanan_kitap_adi.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtbx_bagislanan_kitap_adi.LineThickness = 3;
            this.txtbx_bagislanan_kitap_adi.Location = new System.Drawing.Point(18, 51);
            this.txtbx_bagislanan_kitap_adi.Margin = new System.Windows.Forms.Padding(4);
            this.txtbx_bagislanan_kitap_adi.Name = "txtbx_bagislanan_kitap_adi";
            this.txtbx_bagislanan_kitap_adi.Size = new System.Drawing.Size(263, 31);
            this.txtbx_bagislanan_kitap_adi.TabIndex = 1;
            this.txtbx_bagislanan_kitap_adi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // BTN_Geri
            // 
            this.BTN_Geri.BackColor = System.Drawing.Color.LightCoral;
            this.BTN_Geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Geri.Font = new System.Drawing.Font("Courier New", 16.2F, System.Drawing.FontStyle.Bold);
            this.BTN_Geri.ForeColor = System.Drawing.Color.White;
            this.BTN_Geri.Location = new System.Drawing.Point(18, 252);
            this.BTN_Geri.Name = "BTN_Geri";
            this.BTN_Geri.Size = new System.Drawing.Size(390, 44);
            this.BTN_Geri.TabIndex = 4;
            this.BTN_Geri.Text = "Geri dön ";
            this.BTN_Geri.UseVisualStyleBackColor = false;
            this.BTN_Geri.Click += new System.EventHandler(this.BTN_Geri_Click);
            // 
            // txtbx_bagislanan_kitap_yazar
            // 
            this.txtbx_bagislanan_kitap_yazar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_bagislanan_kitap_yazar.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbx_bagislanan_kitap_yazar.ForeColor = System.Drawing.Color.LightCoral;
            this.txtbx_bagislanan_kitap_yazar.HintForeColor = System.Drawing.Color.Black;
            this.txtbx_bagislanan_kitap_yazar.HintText = "Yazarın adını giriniz";
            this.txtbx_bagislanan_kitap_yazar.isPassword = false;
            this.txtbx_bagislanan_kitap_yazar.LineFocusedColor = System.Drawing.Color.Black;
            this.txtbx_bagislanan_kitap_yazar.LineIdleColor = System.Drawing.Color.LightCoral;
            this.txtbx_bagislanan_kitap_yazar.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtbx_bagislanan_kitap_yazar.LineThickness = 3;
            this.txtbx_bagislanan_kitap_yazar.Location = new System.Drawing.Point(16, 93);
            this.txtbx_bagislanan_kitap_yazar.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.txtbx_bagislanan_kitap_yazar.Name = "txtbx_bagislanan_kitap_yazar";
            this.txtbx_bagislanan_kitap_yazar.Size = new System.Drawing.Size(266, 36);
            this.txtbx_bagislanan_kitap_yazar.TabIndex = 2;
            this.txtbx_bagislanan_kitap_yazar.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.BTN_Geri;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.btn_kitap_bagisla_islemi;
            // 
            // FormKitapBagisla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 306);
            this.Controls.Add(this.txtbx_bagislanan_kitap_yazar);
            this.Controls.Add(this.BTN_Geri);
            this.Controls.Add(this.txtbx_bagislanan_kitap_adi);
            this.Controls.Add(this.Img_Button_Exit);
            this.Controls.Add(this.lbl_metin);
            this.Controls.Add(this.lbl_nick);
            this.Controls.Add(this.btn_kitap_bagisla_islemi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormKitapBagisla";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKitapBagisla";
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kitap_bagisla_islemi;
        private System.Windows.Forms.Label lbl_metin;
        public System.Windows.Forms.Label lbl_nick;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton Img_Button_Exit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbx_bagislanan_kitap_adi;
        private System.Windows.Forms.Button BTN_Geri;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbx_bagislanan_kitap_yazar;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
    }
}