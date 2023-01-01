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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormYonetici));
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_yonetici_nick = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Img_Button_Exit = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtbx_yonetici_nick = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtbx_yonetici_sifre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bunifuElipse2 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse3 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuElipse4 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(153, 119);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 52);
            this.button1.TabIndex = 2;
            this.button1.Text = "Giriş ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl_yonetici_nick
            // 
            this.lbl_yonetici_nick.AutoSize = true;
            this.lbl_yonetici_nick.BackColor = System.Drawing.Color.Transparent;
            this.lbl_yonetici_nick.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_yonetici_nick.Location = new System.Drawing.Point(91, 37);
            this.lbl_yonetici_nick.Name = "lbl_yonetici_nick";
            this.lbl_yonetici_nick.Size = new System.Drawing.Size(170, 17);
            this.lbl_yonetici_nick.TabIndex = 3;
            this.lbl_yonetici_nick.Text = "Kullanıcı Adınız: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(92, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Kullanıcı Şifreniz: ";
            // 
            // Img_Button_Exit
            // 
            this.Img_Button_Exit.BackColor = System.Drawing.Color.LightCoral;
            this.Img_Button_Exit.Image = ((System.Drawing.Image)(resources.GetObject("Img_Button_Exit.Image")));
            this.Img_Button_Exit.ImageActive = null;
            this.Img_Button_Exit.Location = new System.Drawing.Point(464, 10);
            this.Img_Button_Exit.Margin = new System.Windows.Forms.Padding(2);
            this.Img_Button_Exit.Name = "Img_Button_Exit";
            this.Img_Button_Exit.Size = new System.Drawing.Size(49, 46);
            this.Img_Button_Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_Button_Exit.TabIndex = 11;
            this.Img_Button_Exit.TabStop = false;
            this.Img_Button_Exit.Zoom = 10;
            this.Img_Button_Exit.Click += new System.EventHandler(this.Img_Button_Exit_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 30;
            this.bunifuElipse1.TargetControl = this;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(84, 176);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(372, 197);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // txtbx_yonetici_nick
            // 
            this.txtbx_yonetici_nick.BackColor = System.Drawing.Color.White;
            this.txtbx_yonetici_nick.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_yonetici_nick.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbx_yonetici_nick.ForeColor = System.Drawing.Color.Black;
            this.txtbx_yonetici_nick.HintForeColor = System.Drawing.Color.Black;
            this.txtbx_yonetici_nick.HintText = "";
            this.txtbx_yonetici_nick.isPassword = false;
            this.txtbx_yonetici_nick.LineFocusedColor = System.Drawing.Color.Black;
            this.txtbx_yonetici_nick.LineIdleColor = System.Drawing.Color.LightCoral;
            this.txtbx_yonetici_nick.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtbx_yonetici_nick.LineThickness = 7;
            this.txtbx_yonetici_nick.Location = new System.Drawing.Point(251, 27);
            this.txtbx_yonetici_nick.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbx_yonetici_nick.Name = "txtbx_yonetici_nick";
            this.txtbx_yonetici_nick.Size = new System.Drawing.Size(204, 36);
            this.txtbx_yonetici_nick.TabIndex = 0;
            this.txtbx_yonetici_nick.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtbx_yonetici_sifre
            // 
            this.txtbx_yonetici_sifre.BackColor = System.Drawing.Color.White;
            this.txtbx_yonetici_sifre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtbx_yonetici_sifre.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbx_yonetici_sifre.ForeColor = System.Drawing.Color.Black;
            this.txtbx_yonetici_sifre.HintForeColor = System.Drawing.Color.Black;
            this.txtbx_yonetici_sifre.HintText = "";
            this.txtbx_yonetici_sifre.isPassword = false;
            this.txtbx_yonetici_sifre.LineFocusedColor = System.Drawing.Color.Black;
            this.txtbx_yonetici_sifre.LineIdleColor = System.Drawing.Color.LightCoral;
            this.txtbx_yonetici_sifre.LineMouseHoverColor = System.Drawing.Color.Black;
            this.txtbx_yonetici_sifre.LineThickness = 7;
            this.txtbx_yonetici_sifre.Location = new System.Drawing.Point(266, 76);
            this.txtbx_yonetici_sifre.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtbx_yonetici_sifre.Name = "txtbx_yonetici_sifre";
            this.txtbx_yonetici_sifre.Size = new System.Drawing.Size(190, 36);
            this.txtbx_yonetici_sifre.TabIndex = 1;
            this.txtbx_yonetici_sifre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCoral;
            this.panel1.Location = new System.Drawing.Point(454, -11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(90, 395);
            this.panel1.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(-2, -11);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(88, 395);
            this.panel2.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(3, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 18);
            this.label3.TabIndex = 21;
            this.label3.Text = "Yönetici";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(3, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 18);
            this.label2.TabIndex = 20;
            this.label2.Text = "Yönetici";
            // 
            // bunifuElipse2
            // 
            this.bunifuElipse2.ElipseRadius = 60;
            this.bunifuElipse2.TargetControl = this.button1;
            // 
            // bunifuElipse3
            // 
            this.bunifuElipse3.ElipseRadius = 30;
            this.bunifuElipse3.TargetControl = this.txtbx_yonetici_nick;
            // 
            // bunifuElipse4
            // 
            this.bunifuElipse4.ElipseRadius = 30;
            this.bunifuElipse4.TargetControl = this.txtbx_yonetici_sifre;
            // 
            // FormYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(531, 374);
            this.Controls.Add(this.txtbx_yonetici_sifre);
            this.Controls.Add(this.txtbx_yonetici_nick);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Img_Button_Exit);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_yonetici_nick);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormYonetici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormYonetici";
            ((System.ComponentModel.ISupportInitialize)(this.Img_Button_Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_yonetici_nick;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton Img_Button_Exit;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbx_yonetici_nick;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtbx_yonetici_sifre;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse2;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse3;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse4;
    }
}