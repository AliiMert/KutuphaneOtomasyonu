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
        {   //Tüm alanların eksiksiz doldurulduğu kontrol ediliyor
            if(txt_ad.Text == "" || txt_soyad.Text == "" || txt_cinsiyet.Text == "" || txt_dgt.Text == "" 
                || txt_guvenlik_sorusu.Text == "" || txt_guvenlik_sorusu_cevabi.Text == "" 
                || txt_sifre.Text == "" || txt_sifre_tekrar.Text == "")
            {
                string message = "Lütfen tüm alanları eksiksiz doldurun!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning); //Doldurulmayan bir yer varsa uyarı veriyor
            }else if(txt_sifre.Text != txt_sifre_tekrar.Text) //Girilen şifrelerin aynı olup olmadığı kontrol ediliyor
            {
                string message = "Lütfen girdiğiniz şifrelerin aynı olduğuna emin olunuz!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning); //Girilen şifreler aynı değilse uyarı veriyor
            }
            else
            {  //hiçbir sorun yoksa veritabanına veri ekleme komutu yazılıyor
                SqlCommand yeniuyelikkomut = new SqlCommand("INSERT INTO Kutuphane_Kullanicilar(kullanici_ad, kullanici_soyad, kullanici_cinsiyet ,kullanici_dg_t, kullanici_guvenlik_sorusu, kullanici_guvenlik_sorusu_cevabi, kullanici_nick, kullanici_sifre) " +
                    "VALUES (@ad,@soyad,@cinsiyet,@dt,@guvenliksorusu,@guvenliksorusucevabi,@nick,@sifre)",
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
                //veritabanına erişim için bağlantıyı açıyor
                kullanicilarbaglanti.Open();
                yeniuyelikkomut.ExecuteNonQuery();  //SQL komutunu çalıştırıyor
                kullanicilarbaglanti.Close();

                string message = "Yeni üyelik işlemi başarılı.";
                string title = "BAŞARILI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);   //Üyelik başarılı mesajı veriyor
            } 
        }

        
    }
}
