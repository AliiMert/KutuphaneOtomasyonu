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
        public FormKitapKiralama()
        {
            InitializeComponent();
        }

        private void btn_Kitap_Listele_Click_1(object sender, EventArgs e)
        {
            //SQL bağlantısı
            SqlConnection baglantiKitap = new SqlConnection("Data Source=DESKTOP-TSDL2U5\\MSSQLSERVER3;Initial Catalog=Kitaplar;Integrated Security=True");
            //SQL sorgusunun metni oluşturuldu
            SqlCommand komut = new SqlCommand();
            komut.CommandText = "SELECT * FROM kitap_bilgi order by Kitap_Adi ASC";
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
            //alış tarihi değişkenine anlık olarak gözüken tarih atandı
            string atarih = kiralama_tarihi.Text;
            string secilensatir = kitaplar_listesi.CurrentRow.Cells[1].Value.ToString();
            txt_secilen_kitaplar.Text = atarih + " tarihinde " + secilensatir + " kitabını kiraladınız. 15 gün içinde geri teslim etmeniz önemle rica edilir.";

        }

        private void FormKitapKiralama_Load(object sender, EventArgs e)
        {
            //ekranda zamanı göstermek için kullanıldı
            timer1.Start();

            string giren_kullanici_adi = "Ali Mert";
            txt_giris_metni.Text = "Hoş geldin " + giren_kullanici_adi;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //günün tarihini alıp label içine yazıyor
            kiralama_tarihi.Text = DateTime.Now.ToString();
        }
    }
}
