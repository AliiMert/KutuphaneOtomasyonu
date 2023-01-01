using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_uygulamasi
{
    public partial class FormYonetici : Form
    {
        public FormYonetici()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //yonetici kullanıcı adı ve şifresi değişkenlere atıldı 
            string yonetici_nick = "admin";
            string yonetici_sifre = "password";
            string girilen_nick = txtbx_yonetici_nick.Text;
            string girilen_sifre = txtbx_yonetici_sifre.Text;

            if (girilen_nick == yonetici_nick && girilen_sifre == yonetici_sifre) //girilen kullanıcı adı ve şifre dogruysa personel kayıt ekranı açılıyor
            {
                //personel kayıt sayfasına geçiyor
                FormPersonelKayit personelkayit = new FormPersonelKayit();
                personelkayit.Show();
            }
            else 
            {
                string message = "Lütfen bilgileri kontrol edip tekrar deneyiniz!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning); //Yanlış giriş bilgileri
            }
        }

        private void Img_Button_Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

    }
}
