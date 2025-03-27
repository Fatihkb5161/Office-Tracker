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
    public partial class IzinYonetimi: Form
    {

        bekleyenIzinler bekleyen_izinler;
        public IzinYonetimi()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.IzinYonetimi_Load_1);
        }

        private void bekleBtn_Click(object sender, EventArgs e)
        {
            if (bekleyen_izinler == null)
            {
                bekleyen_izinler = new bekleyenIzinler();
                bekleyen_izinler.FormClosed += bekleyenIzinler_Closed;
                bekleyen_izinler.Show();
            }
            else
            {
                bekleyen_izinler.Activate();

            }
        }

        private void bekleyenIzinler_Closed(object sender, EventArgs e)
        {
            bekleyen_izinler = null;
        }


        void goster()
        {
            OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb");
            baglanti.Open();

            OleDbCommand komut = new OleDbCommand("select count(*) from Izinler where durumu = 'beklemede'", baglanti);
            int beklemedeSayisi = (int)komut.ExecuteScalar();
            bekleme_label.Text = beklemedeSayisi.ToString();

            DataSet ds = new DataSet();
            Console.WriteLine("Debug: 1");
            OleDbDataAdapter adbtr = new OleDbDataAdapter("select K.ad, K.soyad, I.baslangic_tarihi, I.bitis_tarihi, I.aciklama, I.durumu  from Izinler as I INNER JOIN Kullanici as K on I.kullanici_id = K.kullanici_id order by baslangic_tarihi", baglanti);
            Console.WriteLine("Debug: 2");
            adbtr.Fill(ds, "okunan veri");
            dataGridView1.DataSource = ds.Tables["okunan veri"];
            baglanti.Close();

        }

        private void IzinYonetimi_Load_1(object sender, EventArgs e)
        {
            goster();
        }
    }
}
