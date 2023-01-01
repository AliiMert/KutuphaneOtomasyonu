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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //SQL kullanıcıların olduğu veritabanı bağlantısı
        SqlConnection kullanicilarbaglanti = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");

        private void Btn_ilerle_Click(object sender, EventArgs e)
        {
            //textboxların içindeki veriler değişkenlere atıldı
            string kullanicinick = txt_su_kullanici_nick.Text;
            string yenisifre = Txt_Box_Yeni_Parola.Text;
            string yenisifretekrar = Txt_Box_Parola_Yeniden.Text;
            string guvenliksorusu = txt_su_guvenlik_sorusu.Text;
            string guvenliksorusucevabi = txt_su_guvenlik_sorusu_cevabi.Text;

            //bu kullanıcı adı kayıtlı mı sorgusu 
            kullanicilarbaglanti.Open();
            SqlCommand kullanicinicksorgukomut = new SqlCommand("SELECT Count(kullanici_nick) FROM Kutuphane_Kullanicilar WHERE kullanici_nick = '" + kullanicinick + "'"
                    , kullanicilarbaglanti);
            kullanicinicksorgukomut.ExecuteNonQuery();
            int varmi = (int)kullanicinicksorgukomut.ExecuteScalar();
            kullanicilarbaglanti.Close();

            if (varmi == 1)      //bu nickte personel varsa veritabanından şifresini çekiyor
            {

                if (yenisifre == yenisifretekrar)    //girilen sifreler aynı mı
                {
                    kullanicilarbaglanti.Open();
                    SqlCommand guvenliksorusualmakomut = new SqlCommand("SELECT kullanici_guvenlik_sorusu FROM Kutuphane_Kullanicilar WHERE kullanici_nick = '"
                        + kullanicinick + "'", kullanicilarbaglanti);
                    guvenliksorusualmakomut.ExecuteNonQuery();
                    SqlDataReader guvenliksorusual = guvenliksorusualmakomut.ExecuteReader();
                    guvenliksorusual.Read();
                    string alinansoru = guvenliksorusual["kullanici_guvenlik_sorusu"].ToString();
                    kullanicilarbaglanti.Close();

                    if (alinansoru == guvenliksorusu)   //veritabanındaki güvenlik sorusu ile kullanıcının seçtiği güvenlik sorusu aynı mı kontrolü
                    {
                        kullanicilarbaglanti.Open();
                        SqlCommand guvenliksorusudogrulamakomut = new SqlCommand("SELECT kullanici_guvenlik_sorusu_cevabi FROM Kutuphane_Kullanicilar WHERE kullanici_nick = '"
                            + kullanicinick + "'", kullanicilarbaglanti);
                        guvenliksorusudogrulamakomut.ExecuteNonQuery();
                        SqlDataReader guvenliksorusucevabial = guvenliksorusudogrulamakomut.ExecuteReader();
                        guvenliksorusucevabial.Read();
                        string alinancevap = guvenliksorusucevabial["kullanici_guvenlik_sorusu_cevabi"].ToString();     // veri tabanından cevap çakiliyor
                        kullanicilarbaglanti.Close();

                        if (alinancevap == guvenliksorusucevabi)    //gğvenlik sorusuna doğru cevap verildi mi kontrolü
                        {
                            kullanicilarbaglanti.Open();
                            SqlCommand sifredegistirmekomut = new SqlCommand("UPDATE Kutuphane_Kullanicilar SET kullanici_sifre = '" + yenisifre + "'" + " WHERE kullanici_nick = '" + kullanicinick + "'"
                          , kullanicilarbaglanti);
                            sifredegistirmekomut.ExecuteNonQuery();     //veri tabanında tutulan şifre değiştiriliyor
                            kullanicilarbaglanti.Close();

                            string message = "Şifreniz başarıyla değiştirildi.";
                            string title = "BAŞARILI";
                            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);  // şifre değiştirme başarılı
                            kullanicilarbaglanti.Close();
                            this.Close();
                        }
                        else
                        {
                            string message = "Güvenlik sorusu cevabınız yanlış!";
                            string title = "UYARI";
                            MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // yanlış cevap girilmişse
                            kullanicilarbaglanti.Close();
                        }

                    }
                    else
                    {
                        string message = "Lütfen güvenlik sorunuzu doğru seçtiğinizden emin olun!.";
                        string title = "UYARI";
                        MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // yanlış güvenlik sorusu
                    }

                }
                else
                {
                    string message = "Lütfen girdiğiniz şifrelerin aynı olmasını kontrol edin!";
                    string title = "UYARI";
                    MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // aynı şifre girilmezse
                }
            }
            else
            {
                string message = "Bu kullanıcı adında bir kayıt bulunmuyor!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // kullanıcı adı kayıtlı değilse
            }
        }

        private void Img_Button_Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void BTN_AnasayfayaDon_Click(object sender, EventArgs e)// Buraya bak ana sayfaya atması gerekirken programı tamamen kapatıyor olabilir burayı düzelt 
        {
            Hide();
        }

    }
}
