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
    public partial class FormPersonelKayit : Form
    {
        //SQL kullanıcıların olduğu veritabanı bağlantısı
        SqlConnection kullanicilarbaglanti = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");

        public FormPersonelKayit()
        {
            InitializeComponent();
        }

        private void btn_Uye_Ol_Click(object sender, EventArgs e)
        {
            kullanicilarbaglanti.Open();
            SqlCommand personeltcsorgukomut = new SqlCommand("SELECT Count(Personel_TC) FROM Kutuphane_Personeller WHERE Personel_TC = '" + txt_personel_tc_no.Text + "'"
                    , kullanicilarbaglanti);
            personeltcsorgukomut.ExecuteNonQuery();
            int personeltcvarmi = (int)personeltcsorgukomut.ExecuteScalar();        // girilen tc noda kayıt var mı sorgusu
            kullanicilarbaglanti.Close();

            //Tüm alanların eksiksiz doldurulduğu kontrol ediliyor
            if (txt_ad.Text == "" || txt_soyad.Text == "" || txt_cinsiyet.Text == "" || txt_kullanici_nick.Text == ""
                || txt_guvenlik_sorusu.Text == "" || txt_guvenlik_sorusu_cevabi.Text == ""
                || txt_sifre.Text == "" || txt_sifre_tekrar.Text == "" || txt_personel_tc_no.Text == "")
            {
                string message = "Lütfen tüm alanları eksiksiz doldurun!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning); //Doldurulmayan bir yer varsa uyarı veriyor
            }
            else if (txt_sifre.Text != txt_sifre_tekrar.Text) //Girilen şifrelerin aynı olup olmadığı kontrol ediliyor
            {
                string message = "Lütfen girdiğiniz şifrelerin aynı olduğuna emin olunuz!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning); //Girilen şifreler aynı değilse uyarı veriyor
            }
            else if (personeltcvarmi == 1)
            {
                string message = "Girmiş olduğunuz TC Kimlik Nuamarasıyla kayıtlı bir kullanıcı bulundu.!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning); //TC no kullanılmışsa
            }
            else
            {
                // bu nick kullanılıyor mu kontrolü
                kullanicilarbaglanti.Open();
                SqlCommand nickvarmisorgu = new SqlCommand("SELECT Count(Personel_Nick) FROM Kutuphane_Personeller WHERE Personel_Nick = '" + txt_kullanici_nick.Text + "'"
                    , kullanicilarbaglanti);
                nickvarmisorgu.ExecuteNonQuery();
                int nickvarmi = (int)nickvarmisorgu.ExecuteScalar();
                kullanicilarbaglanti.Close();

                if (nickvarmi != 0)
                {
                    string message1 = "Girmiş olduğunuz kullanıcı adıyla kayıtlı bir kullanıcı bulundu.!";
                    string title1 = "UYARI";
                    MessageBox.Show(message1, title1, MessageBoxButtons.OK, MessageBoxIcon.Warning); //nick kullanılmışsa
                }
                else
                {
                    //hiçbir sorun yoksa veritabanına veri ekleme komutu yazılıyor
                    SqlCommand yeniuyelikkomut = new SqlCommand("INSERT INTO Kutuphane_Personeller(Personel_Adi, Personel_Soyadi,Personel_Cinsiyet, " +
                        " Personel_g_s, Personel_g_s_c, Personel_Nick, Personel_Sifre, Personel_TC) " +
                        "VALUES (@ad,@soyad,@cinsiyet,@guvenliksorusu,@guvenliksorusucevabi,@nick,@sifre, @tc)",
                        kullanicilarbaglanti);
                    //textboxların içindeki verileri veritabanındaki ilgili yerlere yazıyor
                    yeniuyelikkomut.Parameters.AddWithValue("@ad", txt_ad.Text);
                    yeniuyelikkomut.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                    yeniuyelikkomut.Parameters.AddWithValue("@cinsiyet", txt_cinsiyet.Text);
                    yeniuyelikkomut.Parameters.AddWithValue("@guvenliksorusu", txt_guvenlik_sorusu.Text);
                    yeniuyelikkomut.Parameters.AddWithValue("@guvenliksorusucevabi", txt_guvenlik_sorusu_cevabi.Text);
                    yeniuyelikkomut.Parameters.AddWithValue("@nick", txt_kullanici_nick.Text);
                    yeniuyelikkomut.Parameters.AddWithValue("@sifre", txt_sifre.Text);
                    yeniuyelikkomut.Parameters.AddWithValue("@tc", txt_personel_tc_no.Text);
                    //veritabanına erişim için bağlantıyı açıyor
                    kullanicilarbaglanti.Open();
                    yeniuyelikkomut.ExecuteNonQuery();  //SQL komutunu çalıştırıyor
                    kullanicilarbaglanti.Close();

                    string message = "Yeni kayıt işlemi başarılı.";
                    string title = "BAŞARILI";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);   //Üyelik başarılı mesajı veriyor
                    Hide();
                }
            }
        }

        private void Img_Button_Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void txt_personel_tc_no_Leave(object sender, EventArgs e)
        {
            //tc kimlik numarası 11 haneli olması sağlandı
            int length;
            length = txt_personel_tc_no.Text.Length;
            if (length != 11)
            {
                string message = "TC Kimlik numaranız 11 rakamadan oluşmalıdır.!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);   //tc kimlik numarası 11 karakter
                txt_personel_tc_no.ResetText();
            }
        }

        private void txt_personel_tc_no_OnValueChanged(object sender, EventArgs e)
        {
            //tc kimlik numarası 11 haneli olması sağlandı
            int length;
            length = txt_personel_tc_no.Text.Length;
            if (length < 12)
            {
            }
            else
            {
                string message = "TC Kimlik numaranız 11 rakamadan oluşmalıdır.!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);   //tc kimlik numarası 11 karakter
                txt_personel_tc_no.Text = txt_personel_tc_no.Text.Remove(length - 1);

            }
        }

        private void txt_personel_tc_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tc kimlik no textboxına sadece rakam girilmesi sağlandı
            e.Handled = !(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar));        //sadece sayı giriş izni
        }

        private void txt_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //ad textboxına sadece harf girilmesi sağlandı
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void txt_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //soyad textboxına sadece harf girilmesi sağlandı
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        
    }
}
