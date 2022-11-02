using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kutuphane_uygulamasi
{
    public partial class Form1 : Form
    {
        //SQL kullanıcıların olduğu veritabanı bağlantısı
        SqlConnection kullanicilarbaglanti = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");

        public Form1()
        {
            InitializeComponent();
            Nick_Hatirla();
        }

        private void Txt_Box_Parola_KeyPress(object sender, KeyPressEventArgs e)
        {
           Txt_Box_Parola.UseSystemPasswordChar = true; //Yazılan şifreyi gizliyorum.
        }

        private void Chc_Box_Parola_CheckedChanged(object sender, EventArgs e)
        {
            if (Chc_Box_Parola.CheckState==CheckState.Unchecked) //if sorgusu yapıp check boxın durumunu kontrol ediyorum.if koşulu sağlıyorsa Parolamı göster yazıyor.
            {
                Txt_Box_Parola.UseSystemPasswordChar = true;
                Chc_Box_Parola.Text = "Parolamı Göster";
            }
            else if (Chc_Box_Parola.CheckState==CheckState.Checked)
            {
                Txt_Box_Parola.UseSystemPasswordChar = false;
                
            }
        }

        private void BTN_Parola_Click(object sender, EventArgs e)
        {
            //parola unuttum butonuna tıklandığında parola değiştirme sayfasına geçiyor
            Form2 form2 = new Form2();
            form2.Show();
            

        }

        private void BTN_Yeni_uye_Click(object sender, EventArgs e)
        {
            //Yeni üyelik butonuna basıldığında üyelik sayfasına geçiyor
            YeniUyelik yeniUyelik = new YeniUyelik();
            yeniUyelik.Show();
        }

        private void Btn_Giris_Yap_Click(object sender, EventArgs e)
        {
            string kullanicinick = Txt_Box_Kullanici_ismi.Text;
            string kullanicisifre = Txt_Box_Parola.Text;
            kullanicilarbaglanti.Open();
            //girilen kullanıcı adındaki şifreyi alır
            SqlCommand girisyapkomut = new SqlCommand("Select kullanici_sifre From Kutuphane_Kullanicilar Where kullanici_nick = '" + kullanicinick + "'"
                    , kullanicilarbaglanti);
            girisyapkomut.ExecuteNonQuery();

           SqlDataReader sifreal = girisyapkomut.ExecuteReader();
            sifreal.Read();
            string alinansifre = sifreal["kullanici_sifre"].ToString();

             if(kullanicisifre != alinansifre)
            {
                string message = "Lütfen kullanıcı adı veya şifrenizi kontrol edin!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // yanlış şifre girilirse
            }
            else
            {
                string message = "Giriş Başarılı!";
                string title = "BAŞARILI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);  // boş yer varsa uyarı verir

                FormKitapKiralama formac = new FormKitapKiralama();
                formac.Show();
                Son_Nick_Kaydet();
            }
            kullanicilarbaglanti.Close();
        }

        //Projenin ayarlar kısmına son girlen nick ve beni hatırla tuşunun verileri kaydediliyor
       private void Nick_Hatirla()
        {
            if (Properties.Settings.Default.KullaniciNick != String.Empty)
            {
                if (Properties.Settings.Default.NickHatirla == true)
                {
                    Txt_Box_Kullanici_ismi.Text = Properties.Settings.Default.KullaniciNick;
                    Chc_Box_Ad_Hatirla.Checked = true;
                }
                else
                {
                    Txt_Box_Kullanici_ismi.Text = Properties.Settings.Default.KullaniciNick;
                }
            }
        }

        //Projenin ayarlar kısmından girilen nick ve beni hatırla kayıtlı ise veriler çekilip ekrana yazdırılıyor
        private void Son_Nick_Kaydet()
        {
            if (Chc_Box_Ad_Hatirla.Checked)
            {
                Properties.Settings.Default.KullaniciNick = Txt_Box_Kullanici_ismi.Text;
                Properties.Settings.Default.NickHatirla = true;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.KullaniciNick = "";
                Properties.Settings.Default.NickHatirla = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
