namespace kutuphane_uygulamasi
{
    partial class FormYonetici
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
            this.txtbx_yonetici_nick = new System.Windows.Forms.TextBox();
            this.txtbx_yonetici_sifre = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_yonetici_nick = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtbx_yonetici_nick
            // 
            this.txtbx_yonetici_nick.Location = new System.Drawing.Point(149, 34);
            this.txtbx_yonetici_nick.Name = "txtbx_yonetici_nick";
            this.txtbx_yonetici_nick.Size = new System.Drawing.Size(121, 20);
            this.txtbx_yonetici_nick.TabIndex = 0;
            // 
            // txtbx_yonetici_sifre
            // 
            this.txtbx_yonetici_sifre.Location = new System.Drawing.Point(149, 87);
            this.txtbx_yonetici_sifre.Name = "txtbx_yonetici_sifre";
            this.txtbx_yonetici_sifre.Size = new System.Drawing.Size(121, 20);
            this.txtbx_yonetici_sifre.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_yonetici_nick
            // 
            this.lbl_yonetici_nick.AutoSize = true;
            this.lbl_yonetici_nick.Location = new System.Drawing.Point(22, 37);
            this.lbl_yonetici_nick.Name = "lbl_yonetici_nick";
            this.lbl_yonetici_nick.Size = new System.Drawing.Size(124, 13);
            this.lbl_yonetici_nick.TabIndex = 3;
            this.lbl_yonetici_nick.Text = "Yönetici Kullanıcı Adınız: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Yönetici Kullanıcı Şifreniz: ";
            // 
            // FormYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 202);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_yonetici_nick);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtbx_yonetici_sifre);
            this.Controls.Add(this.txtbx_yonetici_nick);
            this.Name = "FormYonetici";
            this.Text = "FormYonetici";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtbx_yonetici_nick;
        private System.Windows.Forms.TextBox txtbx_yonetici_sifre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_yonetici_nick;
        private System.Windows.Forms.Label label1;
    }
}