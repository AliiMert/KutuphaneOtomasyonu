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
    public partial class FormKitapBagisla : Form
    {
        public FormKitapBagisla()
        {
            InitializeComponent();
        }

        //SQL bağışlanan kitapların olduğu veritabanı bağlantısı
        SqlConnection kitapbagislabaglanti = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");

        private void btn_kitap_bagisla_islemi_Click(object sender, EventArgs e)
        {
            if(txtbx_bagislanan_kitap_adi.Text == "" || txtbx_bagislanan_kitap_yazar.Text == "")
            {
                string message = "Lütfen tüm alanları eksiksiz doldurun!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning); //Doldurulmayan bir yer varsa uyarı veriyor
            }
            else
            {
                 SqlCommand kitapbagislakomut = new SqlCommand("INSERT INTO Kutuphane_Bagislanan_Kitaplar(Bagislanan_Kitap_Adi, Bagislanan_Kitap_Yazar_Adi, Bagislayan_Kullanici_Nick) "
                   + "VALUES (@kitapadi,@yazaradi,@bagislayannick)",
                    kitapbagislabaglanti);
                //textboxların içindeki verileri veritabanındaki ilgili yerlere yazıyor
                kitapbagislakomut.Parameters.AddWithValue("@kitapadi", txtbx_bagislanan_kitap_adi.Text);
                kitapbagislakomut.Parameters.AddWithValue("@yazaradi", txtbx_bagislanan_kitap_yazar.Text);
                kitapbagislakomut.Parameters.AddWithValue("@bagislayannick", lbl_nick.Text);
                //veritabanına erişim için bağlantıyı açıyor
                kitapbagislabaglanti.Open();
                kitapbagislakomut.ExecuteNonQuery();  //SQL komutunu çalıştırıyor
                kitapbagislabaglanti.Close();

                string message = "Kitap bağışlama işlemi başarılı.";
                string title = "BAŞARILI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);   //kitap bağışlama başarılı mesajı veriyor
            
            }
        }
    }
}
