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
using System.Windows;
using System.Windows.Forms;

namespace kutuphane_uygulamasi
{
    public partial class FormPersonel : Form
    {
        //SQL bağlantısı
        SqlConnection kitapiadeet = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");

        public FormPersonel()
        {
            InitializeComponent();
        }

        private void btn_kiralanan_listele_Click(object sender, EventArgs e)
        {
            //SQL bağlantısı
            SqlConnection baglantiKitap = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
            //SQL sorgusunun metni oluşturuldu
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM Kutuphane_Kiralama ";
            //komutun hangi veritabanında çalışacağı belirtildi
            komut.Connection = baglantiKitap;
            //sorgu metni veritabanında çalıştırıldı
            SqlDataAdapter adap = new SqlDataAdapter(komut);
            //değerler bir tabloya aktarıldı
            DataTable tablo = new DataTable();
            //tablodaki veriler datagridview içine yazıldı
            adap.Fill(tablo);
            kiralanan_listesi.DataSource = tablo;
        }

        private void btn_iade_et_Click(object sender, EventArgs e)
        {
            if (kiralanan_listesi.CurrentRow == null)   //kiralanan kitaplar tablosundan veri seçilmiş mi sorgulaması
            {
                string message = "Lütfen iade edilecek kitabı seçtiğinizden emin olunuz!";
                string title = "UYARI";
                System.Windows.Forms.MessageBox.Show(message, title, MessageBoxButtons.OK, MessageBoxIcon.Warning); //Kitap seçilmediyse uyarı verir
            }
            else {
                //veritabanına erişim için bağlantıyı açıyor
                kitapiadeet.Open();
                SqlCommand iadeetkomut = new SqlCommand("DELETE FROM Kutuphane_Kiralama WHERE Kiralama_id = '"
                    + kiralanan_listesi.CurrentRow.Cells["Kiralama_id"].Value + "'"
                     , kitapiadeet);

                //kitap iade edildiğinde stok durumu 1 arttırılıyor
                iadeetkomut.ExecuteNonQuery();  //SQL komutunu çalıştırıyor
                kitapiadeet.Close();
                SqlConnection baglantiKitaplar = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
                SqlCommand stokguncellekomut = new SqlCommand("UPDATE Kutuphane_Kitaplar SET Stok = (Stok+1) WHERE Kitap_Adi = '" + kiralanan_listesi.CurrentRow.Cells["Kiralanan_Kitap_Adi"].Value + "'",
                    baglantiKitaplar);
                baglantiKitaplar.Open();
                stokguncellekomut.ExecuteNonQuery();
                baglantiKitaplar.Close();

                //SQL bağlantısı
                SqlConnection baglantiKitap = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kutuphane_Kullanicilar;Integrated Security=True");
                //SQL sorgusunun metni oluşturuldu
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "SELECT * FROM Kutuphane_Kiralama ";
                //komutun hangi veritabanında çalışacağı belirtildi
                komut.Connection = baglantiKitap;
                //sorgu metni veritabanında çalıştırıldı
                SqlDataAdapter adap = new SqlDataAdapter(komut);
                //değerler bir tabloya aktarıldı
                DataTable tablo = new DataTable();
                //tablodaki veriler datagridview içine yazıldı
                adap.Fill(tablo);
                kiralanan_listesi.DataSource = tablo;

                string iadeedilenkitap = kiralanan_listesi.CurrentRow.Cells[2].Value.ToString();
                string iadeedilenkitapkullanici = kiralanan_listesi.CurrentRow.Cells[1].Value.ToString();
                label_iade_bilgilendirme.Text = iadeedilenkitapkullanici + " kullanıcısının " + iadeedilenkitap + " kitap kiralama işlemini bitirdiniz.";
            }
            
        }

        private void btn_Personel_Ekle_Click(object sender, EventArgs e)
        {
            //yönetici giriş sayfasına geçiyor
            FormYonetici yoneticigiris = new FormYonetici();
            yoneticigiris.Show();
        }

        private void btn_bagıslanan_kitaplar_Click(object sender, EventArgs e)
        {
            //bagışlanan kitapları görüntüle butonuna tıklandığında bagıslanan kitaplar sayfasına geçiyor
            FormBagislananKitaplar formgoruntule = new FormBagislananKitaplar();
            formgoruntule.Show();
        }

        private void Img_Button_Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
