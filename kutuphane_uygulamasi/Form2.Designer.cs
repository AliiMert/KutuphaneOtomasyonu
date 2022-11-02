
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
            this.Txt_Box_Yeni_Parola = new System.Windows.Forms.TextBox();
            this.Txt_Box_Parola_Yeniden = new System.Windows.Forms.TextBox();
            this.txt_su_guvenlik_sorusu = new System.Windows.Forms.ComboBox();
            this.txt_su_guvenlik_sorusu_cevabi = new System.Windows.Forms.TextBox();
            this.Btn_ilerle = new System.Windows.Forms.Button();
            this.txt_su_kullanici_nick = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_Box_Yeni_Parola
            // 
            this.Txt_Box_Yeni_Parola.Location = new System.Drawing.Point(166, 153);
            this.Txt_Box_Yeni_Parola.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Box_Yeni_Parola.Name = "Txt_Box_Yeni_Parola";
            this.Txt_Box_Yeni_Parola.Size = new System.Drawing.Size(153, 20);
            this.Txt_Box_Yeni_Parola.TabIndex = 0;
            this.Txt_Box_Yeni_Parola.Text = "yeni parola giriniz ";
            // 
            // Txt_Box_Parola_Yeniden
            // 
            this.Txt_Box_Parola_Yeniden.Location = new System.Drawing.Point(166, 176);
            this.Txt_Box_Parola_Yeniden.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Txt_Box_Parola_Yeniden.Name = "Txt_Box_Parola_Yeniden";
            this.Txt_Box_Parola_Yeniden.Size = new System.Drawing.Size(153, 20);
            this.Txt_Box_Parola_Yeniden.TabIndex = 1;
            this.Txt_Box_Parola_Yeniden.Text = "parolayı  yeniden giriniz";
            // 
            // txt_su_guvenlik_sorusu
            // 
            this.txt_su_guvenlik_sorusu.FormattingEnabled = true;
            this.txt_su_guvenlik_sorusu.Items.AddRange(new object[] {
            "İlkokul öğretmeninizin adı?",
            "Evcil hayvanınızın adı?",
            "En sevdiğiniz renk?"});
            this.txt_su_guvenlik_sorusu.Location = new System.Drawing.Point(166, 198);
            this.txt_su_guvenlik_sorusu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_su_guvenlik_sorusu.Name = "txt_su_guvenlik_sorusu";
            this.txt_su_guvenlik_sorusu.Size = new System.Drawing.Size(153, 21);
            this.txt_su_guvenlik_sorusu.TabIndex = 2;
            this.txt_su_guvenlik_sorusu.Text = "Güvenlik sorusu seçin";
            // 
            // txt_su_guvenlik_sorusu_cevabi
            // 
            this.txt_su_guvenlik_sorusu_cevabi.Location = new System.Drawing.Point(166, 223);
            this.txt_su_guvenlik_sorusu_cevabi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_su_guvenlik_sorusu_cevabi.Name = "txt_su_guvenlik_sorusu_cevabi";
            this.txt_su_guvenlik_sorusu_cevabi.Size = new System.Drawing.Size(153, 20);
            this.txt_su_guvenlik_sorusu_cevabi.TabIndex = 3;
            this.txt_su_guvenlik_sorusu_cevabi.Text = "cevap";
            // 
            // Btn_ilerle
            // 
            this.Btn_ilerle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_ilerle.Location = new System.Drawing.Point(166, 245);
            this.Btn_ilerle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ilerle.Name = "Btn_ilerle";
            this.Btn_ilerle.Size = new System.Drawing.Size(152, 32);
            this.Btn_ilerle.TabIndex = 4;
            this.Btn_ilerle.Text = "ilerle";
            this.Btn_ilerle.UseVisualStyleBackColor = true;
            this.Btn_ilerle.Click += new System.EventHandler(this.Btn_ilerle_Click);
            // 
            // txt_su_kullanici_nick
            // 
            this.txt_su_kullanici_nick.Location = new System.Drawing.Point(166, 128);
            this.txt_su_kullanici_nick.Name = "txt_su_kullanici_nick";
            this.txt_su_kullanici_nick.Size = new System.Drawing.Size(152, 20);
            this.txt_su_kullanici_nick.TabIndex = 5;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.txt_su_kullanici_nick);
            this.Controls.Add(this.Btn_ilerle);
            this.Controls.Add(this.txt_su_guvenlik_sorusu_cevabi);
            this.Controls.Add(this.txt_su_guvenlik_sorusu);
            this.Controls.Add(this.Txt_Box_Parola_Yeniden);
            this.Controls.Add(this.Txt_Box_Yeni_Parola);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Box_Yeni_Parola;
        private System.Windows.Forms.TextBox Txt_Box_Parola_Yeniden;
        private System.Windows.Forms.ComboBox txt_su_guvenlik_sorusu;
        private System.Windows.Forms.TextBox txt_su_guvenlik_sorusu_cevabi;
        private System.Windows.Forms.Button Btn_ilerle;
        private System.Windows.Forms.TextBox txt_su_kullanici_nick;
    }
}