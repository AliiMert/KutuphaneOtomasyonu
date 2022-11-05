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
    public partial class FormBagislananKitaplar : Form
    {
        public FormBagislananKitaplar()
        {
            InitializeComponent();
        }

        private void btn_bagislanan_kitaplari_gstr_Click(object sender, EventArgs e)
        {
            //SQL bağlantısı
            SqlConnection baglantibagislanankitaplar = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
            //SQL sorgusunun metni oluşturuldu
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT Bagıslanan_Kitap_id, Bagislanan_Kitap_Adi, Bagislanan_Kitap_Yazar_Adi, Bagislayan_Kullanici_Nick FROM Kutuphane_Bagislanan_Kitaplar";
            //komutun hangi veritabanında çalışacağı belirtildi
            komut.Connection = baglantibagislanankitaplar;
            //sorgu metni veritabanında çalıştırıldı
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            //değerler bir tabloya aktarıldı
            DataTable tablo = new DataTable();
            //tablodaki veriler datagridview içine yazıldı
            adap.Fill(tablo);
            bagislanankitaplistesi.DataSource = tablo;

        }

        private void btn_kitap_ekle_Click(object sender, EventArgs e)
        {
            //SQL bağlantısı
            SqlConnection baglantikitap = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");

            //veritabanına erişim için bağlantıyı açıyor
            baglantikitap.Open();
                SqlCommand kitapeklekomut = new SqlCommand("INSERT INTO Kutuphane_Kitaplar(Kitap_Adi, Yazar_Adi, Stok) "
                     + "VALUES (@kitapadi,@yazaradi,@stok)",
                        baglantikitap);
                //seçilen verileri veritabanındaki ilgili yerlere yazıyor
                kitapeklekomut.Parameters.AddWithValue("@kitapadi", bagislanankitaplistesi.CurrentRow.Cells["Bagislanan_Kitap_Adi"].Value);
                kitapeklekomut.Parameters.AddWithValue("@yazaradi", bagislanankitaplistesi.CurrentRow.Cells["Bagislanan_Kitap_Yazar_Adi"].Value);
                kitapeklekomut.Parameters.AddWithValue("@stok",1);        
                kitapeklekomut.ExecuteNonQuery();  //SQL komutunu çalıştırıyor
                baglantikitap.Close();

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
            kitaplarlistesi.DataSource = tablo;

            SqlConnection kitapsilbaglanti = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
            kitapsilbaglanti.Open();
            SqlCommand kitapsilkomut = new SqlCommand("DELETE FROM Kutuphane_Bagislanan_Kitaplar WHERE Bagislanan_Kitap_Adi='" +
                bagislanankitaplistesi.CurrentRow.Cells["Bagislanan_Kitap_Adi"].Value + "'",
                        kitapsilbaglanti);
            kitapsilkomut.ExecuteNonQuery();
            kitapsilbaglanti.Close();

            //SQL bağlantısı
            SqlConnection baglantibagislanankitaplar = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
            //SQL sorgusunun metni oluşturuldu
            SqlCommand komutyenile = new SqlCommand();
            komutyenile.CommandText = "SELECT Bagıslanan_Kitap_id, Bagislanan_Kitap_Adi, Bagislanan_Kitap_Yazar_Adi, Bagislayan_Kullanici_Nick FROM Kutuphane_Bagislanan_Kitaplar";
            //komutun hangi veritabanında çalışacağı belirtildi
            komutyenile.Connection = baglantibagislanankitaplar;
            //sorgu metni veritabanında çalıştırıldı
            SqlDataAdapter adapyeni = new SqlDataAdapter(komutyenile);
            //değerler bir tabloya aktarıldı
            DataTable tabloyeni = new DataTable();
            //tablodaki veriler datagridview içine yazıldı
            adapyeni.Fill(tabloyeni);
            bagislanankitaplistesi.DataSource = tabloyeni;

        }
    }
}
