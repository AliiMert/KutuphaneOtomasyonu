using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace kutuphane_uygulamasi
{
    public partial class YeniUyelik : Form
    {
        //SQL kullanıcıların olduğu veritabanı bağlantısı
        SqlConnection kullanicilarbaglanti = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
        public YeniUyelik()
        {
            InitializeComponent();
        }

        private void btn_Uye_Ol_Click(object sender, EventArgs e)
        {
            //bu tc kayıtlı mı sorgusu 
            kullanicilarbaglanti.Open();
            SqlCommand kullanicitcsorgukomut = new SqlCommand("SELECT Count(tc_kimlik_no) FROM Kutuphane_Kullanicilar WHERE tc_kimlik_no = '" + txt_tc_no.Text + "'"
                    , kullanicilarbaglanti);
            kullanicitcsorgukomut.ExecuteNonQuery();
            int varmi = (int)kullanicitcsorgukomut.ExecuteScalar();
            kullanicilarbaglanti.Close();


            //Tüm alanların eksiksiz doldurulduğu kontrol ediliyor
            if (txt_ad.Text == "" || txt_soyad.Text == "" || txt_cinsiyet.Text == "" || txt_dgt.Text == ""
                || txt_guvenlik_sorusu.Text == "" || txt_guvenlik_sorusu_cevabi.Text == "" || txt_kullanici_nick.Text == ""
                || txt_sifre.Text == "" || txt_sifre_tekrar.Text == "" || txt_tc_no.Text == "")
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
            else if (varmi == 1)
            {
                string message = "Girmiş olduğunuz TC Kimlik Nuamarasıyla kayıtlı bir kullanıcı bulundu.!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning); //TC no kullanılmışsa
            }
            else
            {
                string selam = @"\";
                // bu nick kullanılıyor mu kontrolü
                kullanicilarbaglanti.Open();
                SqlCommand nickvarmisorgu = new SqlCommand("SELECT Count(kullanici_nick) FROM Kutuphane_Kullanicilar WHERE kullanici_nick = '" + txt_kullanici_nick.Text + "'"
                    , kullanicilarbaglanti);
                nickvarmisorgu.ExecuteNonQuery();
                int nickvarmi = (int)nickvarmisorgu.ExecuteScalar();
                kullanicilarbaglanti.Close();

                if (nickvarmi != 0) // girilen kullanıcı başkası tarafından kullanılıyorsa kaydedilmesine izin verilmez
                {
                    string message1 = "Girmiş olduğunuz kullanıcı adıyla kayıtlı bir kullanıcı bulundu.!";
                    string title1 = "UYARI";
                    MessageBox.Show(message1, title1, MessageBoxButtons.OK, MessageBoxIcon.Warning); //nick kullanılmışsa
                }
                else
                {
                //hiçbir sorun yoksa veritabanına veri ekleme komutu yazılıyor
                SqlCommand yeniuyelikkomut = new SqlCommand("INSERT INTO Kutuphane_Kullanicilar(kullanici_ad, kullanici_soyad, kullanici_cinsiyet, " +
                    "kullanici_dg_t, kullanici_guvenlik_sorusu, kullanici_guvenlik_sorusu_cevabi, kullanici_nick, kullanici_sifre, tc_kimlik_no) " +
                    "VALUES (@ad,@soyad,@cinsiyet,@dt,@guvenliksorusu,@guvenliksorusucevabi,@nick,@sifre,@tc)",
                    kullanicilarbaglanti);
                //textboxların içindeki verileri veritabanındaki ilgili yerlere yazıyor
                yeniuyelikkomut.Parameters.AddWithValue("@ad", txt_ad.Text);
                yeniuyelikkomut.Parameters.AddWithValue("@soyad", txt_soyad.Text);
                yeniuyelikkomut.Parameters.AddWithValue("@cinsiyet", txt_cinsiyet.Text);
                yeniuyelikkomut.Parameters.AddWithValue("@dt", Convert.ToDateTime(txt_dgt.Text));
                yeniuyelikkomut.Parameters.AddWithValue("@guvenliksorusu", txt_guvenlik_sorusu.Text);
                yeniuyelikkomut.Parameters.AddWithValue("@guvenliksorusucevabi", txt_guvenlik_sorusu_cevabi.Text);
                yeniuyelikkomut.Parameters.AddWithValue("@nick", txt_kullanici_nick.Text);
                yeniuyelikkomut.Parameters.AddWithValue("@sifre", txt_sifre.Text);
                yeniuyelikkomut.Parameters.AddWithValue("@tc", txt_tc_no.Text);
                //veritabanına erişim için bağlantıyı açıyor
                kullanicilarbaglanti.Open();
                yeniuyelikkomut.ExecuteNonQuery();  //SQL komutunu çalıştırıyor
                kullanicilarbaglanti.Close();

                string message = "Yeni üyelik işlemi başarılı.";
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

        private void txt_tc_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            //tc kimlik numarası girilen textboxa sadece saı girilmesi sağlandı
            e.Handled = !(char.IsNumber(e.KeyChar) || char.IsControl(e.KeyChar));        //sadece sayı giriş izni
        }

        private void txt_ad_KeyPress(object sender, KeyPressEventArgs e)
        {
            // ad giriilen textboxa sadece harf girilmesi sağlandı
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void txt_soyad_KeyPress(object sender, KeyPressEventArgs e)
        {
            //soyad girilen textboxa sadece harf girilmesi sağlandı
            e.Handled = !(char.IsLetter(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || char.IsControl(e.KeyChar));
        }

        private void kayit_yardim_foto_Click(object sender, EventArgs e)
        {
            //yardım butonuna basıldıgında yardım ekranı görünür oluyor
            if (kayit_yardim_foto.Visible == true)
            {
                kayit_yardim_foto.Visible = false;
            }
            else
            {
                kayit_yardim_foto.Visible = true;
            }
        }

        private void txt_tc_no_Leave(object sender, EventArgs e)
        {
            //girilen tc kimlik numarası 11 haneden farklıysa uyarı veriliyor ve yeniden yazması için siliniyor
            int length;
            length = txt_tc_no.Text.Length;
            if (length != 11)
            {
                string message = "TC Kimlik numaranız 11 rakamadan oluşmalıdır.!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);   //tc kimlik numarası 11 karakter
                txt_tc_no.ResetText();
            }
        }

        private void txt_tc_no_OnValueChanged(object sender, EventArgs e)
        {
            //tc kimlik numarasının 11 karakter olmasını kontrol ediliyor fazlası girilirse siliniyor
            int length;
            length = txt_tc_no.Text.Length;
            if (length < 12)
            {
            }
            else
            {
                string message = "TC Kimlik numaranız 11 rakamadan oluşmalıdır.!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);   //tc kimlik numarası 11 karakter
                txt_tc_no.Text = txt_tc_no.Text.Remove(length-1);    
                
            }
        }
    }
}
