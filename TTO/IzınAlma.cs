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
    public partial class IzınAlma: Form
    {
        izinFormu izin_formu;
        public int kullanici_id;
        public IzınAlma()
        {
            InitializeComponent();

        }

        

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (izin_formu == null)
            {
                izin_formu = new izinFormu();
                izin_formu.kullanici_id = kullanici_id;
                izin_formu.FormClosed += izinFormu_Closed;
                izin_formu.Show();
            }
            else
            {
                izin_formu.Activate();

            }
        }

        private void izinFormu_Closed(object sender, EventArgs e)
        {
            izin_formu = null;
        }

        private void IzınAlma_Load(object sender, EventArgs e)
        {
            using (OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb"))
            {
                baglanti.Open();

                using (OleDbCommand sorgu = new OleDbCommand("select kullanici_id, izin_id from Izinler where kullanici_id=@kullanici", baglanti))
                {
                    sorgu.Parameters.AddWithValue("@kullanici", kullanici_id);
                    using (OleDbDataReader dr = sorgu.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            goster();
                        }
                        else
                        {
                            MessageBox.Show("İzinler Yüklenemedi");
                        }
                    }
                }
            }
        }


        void goster()
        {
            using (OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb"))
            {
                baglanti.Open();
                DataSet ds = new DataSet();
                OleDbDataAdapter adbtr = new OleDbDataAdapter($"select basvuru_tarihi, baslangic_tarihi, bitis_tarihi, aciklama, durumu from Izinler where kullanici_id=@kullanici order by baslangic_tarihi", baglanti);
                adbtr.SelectCommand.Parameters.AddWithValue("@kullanici", kullanici_id);
                adbtr.Fill(ds, "okunan veri");

                dataGridView1.DataSource = ds.Tables["okunan veri"];
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
