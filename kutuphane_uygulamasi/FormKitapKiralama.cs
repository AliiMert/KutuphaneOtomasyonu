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
    public partial class FormKitapKiralama : Form
    {
        //SQL kullanıcıların olduğu veritabanı bağlantısı
        SqlConnection kitapkirala = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
        public FormKitapKiralama()
        {
            InitializeComponent();
        }

        private void btn_Kitap_Listele_Click_1(object sender, EventArgs e)
        {
            //SQL bağlantısı
            SqlConnection baglantiKitap = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
            //SQL sorgusunun metni oluşturuldu
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT Kitap_Adi, Yazar_Adi, Stok FROM Kutuphane_Kitaplar order by Kitap_Adi ASC";
            //komutun hangi veritabanında çalışacağı belirtildi
            komut.Connection = baglantiKitap;
            //sorgu metni veritabanında çalıştırıldı
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            //değerler bir tabloya aktarıldı
            DataTable tablo = new DataTable();
            //tablodaki veriler datagridview içine yazıldı
            adap.Fill(tablo);
            kitaplar_listesi.DataSource = tablo;
        }

        private void btn_Kitap_Kirala_Click_1(object sender, EventArgs e)
        {
            //veritabanına erişim için bağlantıyı açıyor
            kitapkirala.Open();
            SqlCommand kitapkiralamakomut = new SqlCommand("INSERT INTO Kutuphane_Kiralama(Kiralayan_Kullanici_Nick, Kiralanan_Kitap_Adi, Kitap_Alis_Tarihi, Kitap_Teslim_Tarihi) "
                 + "VALUES (@nick,@kitapadi,@aliştarihi,@teslimtarihi)",
                    kitapkirala);
            //textboxların içindeki verileri veritabanındaki ilgili yerlere yazıyor
            kitapkiralamakomut.Parameters.AddWithValue("@nick", txt_giris_metni.Text);
            string secilenkitap = kitaplar_listesi.CurrentRow.Cells["Kitap_Adi"].Value.ToString();
            kitapkiralamakomut.Parameters.AddWithValue("@kitapadi", secilenkitap);
            kitapkiralamakomut.Parameters.AddWithValue("@aliştarihi", kiralama_tarihi.Text);        //o günün tarihini alış tarihine atar
            kitapkiralamakomut.Parameters.AddWithValue("@teslimtarihi", dateTimePicker1.Value.AddDays(15));     //o günkü tarihe 15 gün ekleyerek veritabanındaki teslim tarihine atar
            kitapkiralamakomut.ExecuteNonQuery();  //SQL komutunu çalıştırıyor
            kitapkirala.Close();


            //alış tarihi değişkenine anlık olarak gözüken tarih atandı
            string atarih = kiralama_tarihi.Text;
            string secilensatir = kitaplar_listesi.CurrentRow.Cells[1].Value.ToString();
            txt_secilen_kitaplar.Text = atarih + " tarihinde ' " + secilensatir + "' kitabını kiraladınız. 15 gün içinde geri teslim etmeniz önemle rica edilir.";

            
            SqlConnection baglantiKitaplar = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
            SqlCommand stokguncellekomut = new SqlCommand("UPDATE Kutuphane_Kitaplar SET Stok = (Stok-1) WHERE Kitap_Adi = '" + secilenkitap +"'",
                baglantiKitaplar);
            baglantiKitaplar.Open();
            stokguncellekomut.ExecuteNonQuery();
            baglantiKitaplar.Close();
            //kitaplar listesi yenilenir stok durumu güncellenir
            //SQL bağlantısı
            SqlConnection baglantiKitap = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
            //SQL sorgusunun metni oluşturuldu
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT Kitap_Adi, Yazar_Adi, Stok FROM Kutuphane_Kitaplar order by Kitap_Adi ASC";
            //komutun hangi veritabanında çalışacağı belirtildi
            komut.Connection = baglantiKitap;
            //sorgu metni veritabanında çalıştırıldı
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            //değerler bir tabloya aktarıldı
            DataTable tablo = new DataTable();
            //tablodaki veriler datagridview içine yazıldı
            adap.Fill(tablo);
            kitaplar_listesi.DataSource = tablo;
        }

        private void FormKitapKiralama_Load(object sender, EventArgs e)
        {
            //ekranda anlık zamanı göstermek için kullanıldı
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //günün tarihini alıp label içine yazıyor
            kiralama_tarihi.Text = DateTime.Now.ToString();
        }

        private void btn_kitap_bagisla_Click(object sender, EventArgs e)
        {
            //parola unuttum butonuna tıklandığında parola değiştirme sayfasına geçiyor
            FormKitapBagisla formbagisla = new FormKitapBagisla();
            formbagisla.lbl_nick.Text = txt_giris_metni.Text;
            formbagisla.Show();
        }
    }
}
