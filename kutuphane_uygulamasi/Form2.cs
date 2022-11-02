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

           

            if(yenisifre == yenisifretekrar)    //girilen sifreler aynı mı
            {
                kullanicilarbaglanti.Open();
                SqlCommand guvenliksorusudogrulamakomut = new SqlCommand("SELECT kullanici_guvenlik_sorusu_cevabi FROM Kutuphane_Kullanicilar WHERE kullanici_nick = '" + kullanicinick + "'"
                   , kullanicilarbaglanti);
                guvenliksorusudogrulamakomut.ExecuteNonQuery();
                SqlDataReader guvenliksorusucevabial = guvenliksorusudogrulamakomut.ExecuteReader();
                guvenliksorusucevabial.Read();
                string alinancevap = guvenliksorusucevabial["kullanici_guvenlik_sorusu_cevabi"].ToString();
                kullanicilarbaglanti.Close();
                if(alinancevap == guvenliksorusucevabi)
                {
                    kullanicilarbaglanti.Open();
                    SqlCommand sifredegistirmekomut = new SqlCommand("UPDATE Kutuphane_Kullanicilar SET kullanici_sifre = '" + yenisifre + "'" + " WHERE kullanici_nick = '" + kullanicinick + "'"
                  , kullanicilarbaglanti);
                    sifredegistirmekomut.ExecuteNonQuery();
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
                string message = "Lütfen girdiğiniz şifrelerin aynı olmasını kontrol edin!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // aynı şifre girilmezse
            }
        }
    }
}
