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
    public partial class Projeler: Form
    {
        public Projeler()
        {
            InitializeComponent();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Length < 1)
            {
                MessageBox.Show("PG adı girilmeden izin alınamaz!");
            }
            else
            {
                OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb");
                baglanti.Open();
                OleDbCommand komut2 = new OleDbCommand("insert into PG(gosterge_adi, ofis_id, aciklama) values(@gosterge_adi, @ofis_id, @aciklama)", baglanti);
                komut2.Parameters.Add(new OleDbParameter("@gosterge_adi", OleDbType.Integer)).Value = Convert.ToInt32(textBox2.Text);
                komut2.Parameters.Add(new OleDbParameter("@ofis_id", OleDbType.Integer)).Value = Convert.ToInt32(comboBox2.SelectedItem.ToString().Split(' ')[1]);
                komut2.Parameters.Add(new OleDbParameter("@aciklama", OleDbType.VarChar)).Value = textBox3.Text;
                komut2.ExecuteNonQuery();
                MessageBox.Show("Proje göstergesi eklendi!");
                baglanti.Close();


            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            if (soru_adi.Text.Length < 1)
            {
                MessageBox.Show("Soru adı girilmeden izin alınamaz!");
            }
            else
            {
                OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb");
                baglanti.Open();

                OleDbCommand komut1 = new OleDbCommand("insert into Sorular(soru_adi) values(@soruadi)", baglanti);
                komut1.Parameters.Add(new OleDbParameter("@soruadi", OleDbType.VarChar)).Value = soru_adi.Text;
                komut1.ExecuteNonQuery();
                baglanti.Close();

                MessageBox.Show("Soru Eklendi!");


            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }
    }
}
