using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTO
{
    public partial class Anasayfa: Form
    {
        public int kullanici_id;
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {

            //////// Bu kısım Düzenlenecek ///////
            OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb");
            baglanti.Open();

            DataSet ds = new DataSet();
            Console.WriteLine("Debug: 1");
            OleDbDataAdapter adbtr = new OleDbDataAdapter("select kullanici_id, e_posta, ad, soyad, cinsiyet, tel_no, ofis_no, pozisyon where", baglanti);
            Console.WriteLine("Debug: 2");
            adbtr.Fill(ds, "okunan veri");
            DataTable dt = ds.Tables["okunan veri"];
            using (OleDbCommand sorgu = new OleDbCommand("select durumu from Izinler where durumu='Beklemede'", baglanti))
            {
                using (OleDbDataReader dr = sorgu.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        foreach (DataRow row in dt.Rows)
                        {
                            request my_request = new request();
                            string ad_soyad = row["ad"].ToString() + " " + row["soyad"].ToString();
                            string pozisyonu = Convert.ToString(row["pozisyon"]);
                            string baslangicTarihi = Convert.ToString(row["baslangic_tarihi"]);
                            string bitisTarihi = Convert.ToString(row["bitis_tarihi"]);
                            string aciklama = row["aciklama"].ToString();
                            int kullanici = (int)row["kullanici_id"];
                            int izinid = (int)row["izin_id"];



                        }
                    }
                    else
                    {
                        MessageBox.Show("İzin istekleri Yüklenemedi");
                    }
                }
            }
        }
    }
}
