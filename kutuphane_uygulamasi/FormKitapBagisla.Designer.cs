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
            this.btn_kitap_bagisla_islemi = new System.Windows.Forms.Button();
            this.txtbx_bagislanan_kitap_adi = new System.Windows.Forms.TextBox();
            this.txtbx_bagislanan_kitap_yazar = new System.Windows.Forms.TextBox();
            this.lbl_nick = new System.Windows.Forms.Label();
            this.lbl_metin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_kitap_bagisla_islemi
            // 
            this.btn_kitap_bagisla_islemi.Location = new System.Drawing.Point(47, 198);
            this.btn_kitap_bagisla_islemi.Name = "btn_kitap_bagisla_islemi";
            this.btn_kitap_bagisla_islemi.Size = new System.Drawing.Size(176, 44);
            this.btn_kitap_bagisla_islemi.TabIndex = 0;
            this.btn_kitap_bagisla_islemi.Text = "Kitabı Bağışla";
            this.btn_kitap_bagisla_islemi.UseVisualStyleBackColor = true;
            this.btn_kitap_bagisla_islemi.Click += new System.EventHandler(this.btn_kitap_bagisla_islemi_Click);
            // 
            // txtbx_bagislanan_kitap_adi
            // 
            this.txtbx_bagislanan_kitap_adi.Location = new System.Drawing.Point(47, 93);
            this.txtbx_bagislanan_kitap_adi.Name = "txtbx_bagislanan_kitap_adi";
            this.txtbx_bagislanan_kitap_adi.Size = new System.Drawing.Size(184, 20);
            this.txtbx_bagislanan_kitap_adi.TabIndex = 1;
            // 
            // txtbx_bagislanan_kitap_yazar
            // 
            this.txtbx_bagislanan_kitap_yazar.Location = new System.Drawing.Point(47, 139);
            this.txtbx_bagislanan_kitap_yazar.Name = "txtbx_bagislanan_kitap_yazar";
            this.txtbx_bagislanan_kitap_yazar.Size = new System.Drawing.Size(184, 20);
            this.txtbx_bagislanan_kitap_yazar.TabIndex = 2;
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
            this.lbl_metin.Location = new System.Drawing.Point(259, 142);
            this.lbl_metin.Name = "lbl_metin";
            this.lbl_metin.Size = new System.Drawing.Size(149, 77);
            this.lbl_metin.TabIndex = 4;
            this.lbl_metin.Text = "!!! Kitap bağışlama işlemini bitirdikten sonra kitabı kütüphane görevlisine tesli" +
    "m etmeyi unutmayınız. !!!";
            // 
            // FormKitapBagisla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 306);
            this.Controls.Add(this.lbl_metin);
            this.Controls.Add(this.lbl_nick);
            this.Controls.Add(this.txtbx_bagislanan_kitap_yazar);
            this.Controls.Add(this.txtbx_bagislanan_kitap_adi);
            this.Controls.Add(this.btn_kitap_bagisla_islemi);
            this.Name = "FormKitapBagisla";
            this.Text = "FormKitapBagisla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_kitap_bagisla_islemi;
        private System.Windows.Forms.TextBox txtbx_bagislanan_kitap_adi;
        private System.Windows.Forms.TextBox txtbx_bagislanan_kitap_yazar;
        private System.Windows.Forms.Label lbl_metin;
        public System.Windows.Forms.Label lbl_nick;
    }
}