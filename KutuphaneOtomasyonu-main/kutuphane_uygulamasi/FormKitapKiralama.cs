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
            if (kitaplar_listesi.CurrentRow == null)   //kitaplar tablosundan veri seçilmemişse
            {
                string message = "Kiralanacak kitap seçilmedi!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // kitap seçilmedi
            }
            else
            { 
            //SQL bağlantısı
            SqlConnection baglantikitaplar = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
            string kitapadi = kitaplar_listesi.CurrentRow.Cells["Kitap_Adi"].Value.ToString();
            baglantikitaplar.Open();
            SqlCommand kitapsorgukomut = new SqlCommand("SELECT Stok FROM Kutuphane_Kitaplar WHERE Kitap_Adi = '" + kitapadi + "'"
                    , baglantikitaplar);
            kitapsorgukomut.ExecuteNonQuery();
            int kitapvarmi = (int)kitapsorgukomut.ExecuteScalar();  //stok sayısını bir değişkene atıyor
            baglantikitaplar.Close();
            if (kitapvarmi == 0) //stok durumu 0 sa uyarı veriliyor
            {
                string message = "Seçtiğiniz kitap stokta yok!";
                string title = "UYARI";
                MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning);  // kitap stokta yok

            }
            else
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
                kitapkiralamakomut.Parameters.AddWithValue("@aliştarihi", DateTime.Now);        //o günün tarihini alış tarihine atar
                kitapkiralamakomut.Parameters.AddWithValue("@teslimtarihi",DateTime.Now.AddDays(15));     //o günkü tarihe 15 gün ekleyerek veritabanındaki teslim tarihine atar
                kitapkiralamakomut.ExecuteNonQuery();  //SQL komutunu çalıştırıyor
                kitapkirala.Close();


                //alış tarihi değişkenine anlık olarak gözüken tarih atandı
                string atarih = kiralama_tarihi.Text;
                string secilensatir = kitaplar_listesi.CurrentRow.Cells[0].Value.ToString(); //kitap adı tablodan cekilip bir değişkene atılıyor ve ekrana bilgilendirme mesajı veriliyor
                txt_secilen_kitaplar.Text = atarih + " tarihinde ' " + secilensatir + "' kitabını kiraladınız. 15 gün içinde geri teslim etmeniz önemle rica edilir.";


                SqlConnection baglantiKitaplar = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
                SqlCommand stokguncellekomut = new SqlCommand("UPDATE Kutuphane_Kitaplar SET Stok = (Stok-1) WHERE Kitap_Adi = '" + secilenkitap + "'",
                    baglantiKitaplar);
                baglantiKitaplar.Open();
                stokguncellekomut.ExecuteNonQuery();    //kirlanan kitabın stok durumu 1 azaltırılıyor
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
            }
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
            //kitap bağışla butonuna tıklandığında kitap biligleri girilen sayfaya geçiyor
            FormKitapBagisla formbagisla = new FormKitapBagisla();
            formbagisla.lbl_nick.Text = txt_giris_metni.Text;
            formbagisla.Show();
        }

        private void Img_Button_Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void Txt_Box_Kitap_Ara_OnValueChanged(object sender, EventArgs e)
        {
            string aranankitap = Txt_Box_Kitap_Ara.Text;
            //SQL bağlantısı
            SqlConnection baglantiKitap = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
            //SQL sorgusunun metni oluşturuldu
            SqlCommand komut = new SqlCommand();    //arama yerine girilen kitap ismini filtreleyen komut
            komut.CommandText = "SELECT Kitap_Adi, Yazar_Adi, Stok FROM Kutuphane_Kitaplar Where Kitap_Adi LIKE '%" + aranankitap + "%' order by Kitap_Adi ASC";
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
    }
}
