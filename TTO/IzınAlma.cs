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
            goster();
        }


        void goster()
        {
            OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb");
            baglanti.Open();
            DataSet ds = new DataSet();
            OleDbDataAdapter adbtr = new OleDbDataAdapter("select basvuru_tarihi, baslangic_tarihi, bitis_tarihi, aciklama, durumu from Izinler order by baslangic_tarihi", baglanti);
            adbtr.Fill(ds, "okunan veri");

            dataGridView1.DataSource = ds.Tables["okunan veri"];
            baglanti.Close();

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
