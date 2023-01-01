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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBagislananKitaplar));
            this.bagislanankitaplistesi = new System.Windows.Forms.DataGridView();
            this.kitaplarlistesi = new System.Windows.Forms.DataGridView();
            this.btn_bagislanan_kitaplari_gstr = new System.Windows.Forms.Button();
            this.btn_kitap_ekle = new System.Windows.Forms.Button();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Img_Button_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse5 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bagislanankitaplistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarlistesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).BeginInit();
            this.SuspendLayout();
            // 
            // bagislanankitaplistesi
            // 
            this.bagislanankitaplistesi.BackgroundColor = System.Drawing.Color.LightCoral;
            this.bagislanankitaplistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bagislanankitaplistesi.GridColor = System.Drawing.Color.LightCoral;
            this.bagislanankitaplistesi.Location = new System.Drawing.Point(57, 79);
            this.bagislanankitaplistesi.Name = "bagislanankitaplistesi";
            this.bagislanankitaplistesi.RowHeadersWidth = 51;
            this.bagislanankitaplistesi.Size = new System.Drawing.Size(501, 187);
            this.bagislanankitaplistesi.TabIndex = 0;
            // 
            // kitaplarlistesi
            // 
            this.kitaplarlistesi.BackgroundColor = System.Drawing.Color.White;
            this.kitaplarlistesi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kitaplarlistesi.Location = new System.Drawing.Point(57, 329);
            this.kitaplarlistesi.Name = "kitaplarlistesi";
            this.kitaplarlistesi.RowHeadersWidth = 51;
            this.kitaplarlistesi.Size = new System.Drawing.Size(501, 178);
            this.kitaplarlistesi.TabIndex = 1;
            // 
            // btn_bagislanan_kitaplari_gstr
            // 
            this.btn_bagislanan_kitaplari_gstr.BackColor = System.Drawing.Color.LightCoral;
            this.btn_bagislanan_kitaplari_gstr.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_bagislanan_kitaplari_gstr.Location = new System.Drawing.Point(232, 33);
            this.btn_bagislanan_kitaplari_gstr.Name = "btn_bagislanan_kitaplari_gstr";
            this.btn_bagislanan_kitaplari_gstr.Size = new System.Drawing.Size(166, 40);
            this.btn_bagislanan_kitaplari_gstr.TabIndex = 2;
            this.btn_bagislanan_kitaplari_gstr.Text = "Bağışlanan Kitapları Göster";
            this.btn_bagislanan_kitaplari_gstr.UseVisualStyleBackColor = false;
            this.btn_bagislanan_kitaplari_gstr.Click += new System.EventHandler(this.btn_bagislanan_kitaplari_gstr_Click);
            // 
            // btn_kitap_ekle
            // 
            this.btn_kitap_ekle.BackColor = System.Drawing.Color.White;
            this.btn_kitap_ekle.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Bold);
            this.btn_kitap_ekle.ForeColor = System.Drawing.Color.Black;
            this.btn_kitap_ekle.Location = new System.Drawing.Point(218, 285);
            this.btn_kitap_ekle.Name = "btn_kitap_ekle";
            this.btn_kitap_ekle.Size = new System.Drawing.Size(202, 44);
            this.btn_kitap_ekle.TabIndex = 3;
            this.btn_kitap_ekle.Text = "Bağışlanan kitabı kütüphaneye ekle";
            this.btn_kitap_ekle.UseVisualStyleBackColor = false;
            this.btn_kitap_ekle.Click += new System.EventHandler(this.btn_kitap_ekle_Click);
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
            this.Img_Button_Exit.Location = new System.Drawing.Point(598, 11);
            this.Img_Button_Exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Img_Button_Exit.Name = "Img_Button_Exit";
            this.Img_Button_Exit.Size = new System.Drawing.Size(49, 46);
            this.Img_Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Button_Exit.TabIndex = 11;
            this.Img_Button_Exit.TabStop = false;
            this.Img_Button_Exit.Zoom = 10;
            this.Img_Button_Exit.Click += new System.EventHandler(this.Img_Button_Exit_Click);
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 30;
            this.bunifuElipse2.TargetControl = this.bagislanankitaplistesi;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.kitaplarlistesi;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(-8, 282);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(671, 236);
            this.panel1.TabIndex = 12;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.btn_kitap_ekle;
            // 
            // bunifuElipse5
            // 
            this.bunifuElipse5.ElipseRadius = 30;
            this.bunifuElipse5.TargetControl = this.btn_bagislanan_kitaplari_gstr;
            // 
            // FormBagislananKitaplar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(658, 528);
            this.Controls.Add(this.Img_Button_Exit);
            this.Controls.Add(this.btn_kitap_ekle);
            this.Controls.Add(this.btn_bagislanan_kitaplari_gstr);
            this.Controls.Add(this.kitaplarlistesi);
            this.Controls.Add(this.bagislanankitaplistesi);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBagislananKitaplar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBagislananKitaplar";
            ((System.ComponentModel.ISupportInitialize)(this.bagislanankitaplistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kitaplarlistesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView bagislanankitaplistesi;
        private System.Windows.Forms.DataGridView kitaplarlistesi;
        private System.Windows.Forms.Button btn_bagislanan_kitaplari_gstr;
        private System.Windows.Forms.Button btn_kitap_ekle;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuImageButton Img_Button_Exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse5;
    }
}