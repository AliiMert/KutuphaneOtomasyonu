namespace kutuphane_uygulamasi
{
    partial class FormBagislananKitaplar
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
            this.bagislanankitaplistesi = new System.Windows.Forms.DataGridView();
            this.kitaplarlistesi = new System.Windows.Forms.DataGridView();
            this.btn_bagislanan_kitaplari_gstr = new System.Windows.Forms.Button();
            this.btn_kitap_ekle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bagislanankitaplistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarlistesi)).BeginInit();
            this.SuspendLayout();
            // 
            // bagislanankitaplistesi
            // 
            this.bagislanankitaplistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bagislanankitaplistesi.Location = new System.Drawing.Point(57, 79);
            this.bagislanankitaplistesi.Name = "bagislanankitaplistesi";
            this.bagislanankitaplistesi.Size = new System.Drawing.Size(501, 187);
            this.bagislanankitaplistesi.TabIndex = 0;
            // 
            // kitaplarlistesi
            // 
            this.kitaplarlistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplarlistesi.Location = new System.Drawing.Point(57, 329);
            this.kitaplarlistesi.Name = "kitaplarlistesi";
            this.kitaplarlistesi.Size = new System.Drawing.Size(501, 178);
            this.kitaplarlistesi.TabIndex = 1;
            // 
            // btn_bagislanan_kitaplari_gstr
            // 
            this.btn_bagislanan_kitaplari_gstr.Location = new System.Drawing.Point(232, 33);
            this.btn_bagislanan_kitaplari_gstr.Name = "btn_bagislanan_kitaplari_gstr";
            this.btn_bagislanan_kitaplari_gstr.Size = new System.Drawing.Size(167, 40);
            this.btn_bagislanan_kitaplari_gstr.TabIndex = 2;
            this.btn_bagislanan_kitaplari_gstr.Text = "Bağışlanan Kitapları Göster";
            this.btn_bagislanan_kitaplari_gstr.UseVisualStyleBackColor = true;
            this.btn_bagislanan_kitaplari_gstr.Click += new System.EventHandler(this.btn_bagislanan_kitaplari_gstr_Click);
            // 
            // btn_kitap_ekle
            // 
            this.btn_kitap_ekle.Location = new System.Drawing.Point(218, 288);
            this.btn_kitap_ekle.Name = "btn_kitap_ekle";
            this.btn_kitap_ekle.Size = new System.Drawing.Size(198, 35);
            this.btn_kitap_ekle.TabIndex = 3;
            this.btn_kitap_ekle.Text = "Bağışlanan kitabı kütüphaneye ekle";
            this.btn_kitap_ekle.UseVisualStyleBackColor = true;
            this.btn_kitap_ekle.Click += new System.EventHandler(this.btn_kitap_ekle_Click);
            // 
            // FormBagislananKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 528);
            this.Controls.Add(this.btn_kitap_ekle);
            this.Controls.Add(this.btn_bagislanan_kitaplari_gstr);
            this.Controls.Add(this.kitaplarlistesi);
            this.Controls.Add(this.bagislanankitaplistesi);
            this.Name = "FormBagislananKitaplar";
            this.Text = "FormBagislananKitaplar";
            ((System.ComponentModel.ISupportInitialize)(this.bagislanankitaplistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarlistesi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bagislanankitaplistesi;
        private System.Windows.Forms.DataGridView kitaplarlistesi;
        private System.Windows.Forms.Button btn_bagislanan_kitaplari_gstr;
        private System.Windows.Forms.Button btn_kitap_ekle;
    }
}