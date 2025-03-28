using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace TTO
{
    public partial class bekleyenIzinler: Form
    {
        public int kullanici_id;
        public bekleyenIzinler()
        {
            InitializeComponent();
            Panel panel2 = panel1;
        }

        void goster()
        {
            OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb");
            baglanti.Open();

            DataSet ds = new DataSet();
            Console.WriteLine("Debug: 1");
            OleDbDataAdapter adbtr = new OleDbDataAdapter("select K.kullanici_id, K.ad, K.soyad, K.pozisyon, I.izin_id, I.baslangic_tarihi, I.bitis_tarihi, I.aciklama, I.durumu  from Izinler as I INNER JOIN Kullanici as K on I.kullanici_id = K.kullanici_id where I.durumu = 'Beklemede' order by I.basvuru_tarihi", baglanti);
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

                            my_request.user_name.Text = ad_soyad;
                            my_request.user_position.Text = pozisyonu;
                            my_request.start_time.Text = baslangicTarihi;
                            my_request.finish_time.Text = bitisTarihi;
                            my_request.description.Text = aciklama;
                            my_request.kullanici_id = kullanici;
                            my_request.izin_id = izinid;
                            flowLayoutPanel1.Controls.Add(my_request);


                        }
                    }
                    else
                    {
                        MessageBox.Show("İzin istekleri Yüklenemedi");
                    }
                }
            }
            baglanti.Close();

            

        }

        private void bekleyenIzinler_Load(object sender, EventArgs e)
        {

            
            goster();
        }
    }
}
