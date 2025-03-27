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

namespace TTO
{
    public partial class izinFormu: Form
    {
        public izinFormu()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (izinSebebi.Text.Length < 1)
            {
                MessageBox.Show("Sebep girilmeden izin alınamaz!");
            }
            else
            {
                OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb");
                baglanti.Open();

                OleDbCommand komut = new OleDbCommand("insert into Izinler(basvuru_tarihi, baslangic_tarihi, bitis_tarihi, kullanici_id, aciklama, durumu) values(@basv_tarihi, @bas_tarihi, @bit_tarihi, @kullanici_id, @acik, @durum)", baglanti);
                komut.Parameters.Add(new OleDbParameter("@basv_tarihi", OleDbType.Date)).Value = DateTime.Now;
                komut.Parameters.Add(new OleDbParameter("@bas_tarihi", OleDbType.Date)).Value = startTime.Value;
                komut.Parameters.Add(new OleDbParameter("@bit_tarihi", OleDbType.Date)).Value = finishTime.Value;
                komut.Parameters.Add(new OleDbParameter("@kullanici_id", OleDbType.Integer)).Value = 2;
                komut.Parameters.Add(new OleDbParameter("@acik", OleDbType.VarChar)).Value = izinSebebi.Text;
                komut.Parameters.Add(new OleDbParameter("@durum", OleDbType.VarChar)).Value = "Beklemede";
                komut.ExecuteNonQuery();
                baglanti.Close();



                MessageBox.Show($"İzin Başlangıç Tarihi: {startTime.Text}\n" +
                    $"İzin Bitiş Tarihi: {finishTime.Text}\n" +
                    $"İzin Sebebiniz: {izinSebebi.Text}\n\n Şeklinde izin talebiniz oluşturulmuştur.");
            }
                
        }

    }
}
