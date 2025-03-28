using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace TTO
{
    public partial class request : UserControl
    {
        public int kullanici_id;
        public int izin_id;
        public request()
        {
            InitializeComponent();
        }

        private void user_name_Click(object sender, EventArgs e)
        {

        }

        private void description_Click(object sender, EventArgs e)
        {

        }

        private void accept_button_Click(object sender, EventArgs e)
        {
            using (OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb"))
            {
                baglanti.Open();

                using (OleDbCommand sorgu = new OleDbCommand("select izin_id, kullanici_id from Izinler where izin_id=@izin and kullanici_id=@kullanici", baglanti))
                {
                    sorgu.Parameters.AddWithValue("@izin", izin_id);
                    sorgu.Parameters.AddWithValue("@kullanici", kullanici_id);

                    using (OleDbDataReader dr = sorgu.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            onay();
                        }
                        else
                        {
                            MessageBox.Show("İzin onaylanamadı.");
                        }
                    }
                }
            }
        }

        private void deny_button_Click(object sender, EventArgs e)
        {
            using (OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb"))
            {
                baglanti.Open();

                using (OleDbCommand sorgu = new OleDbCommand("select izin_id, kullanici_id from Izinler where izin_id=@izin and kullanici_id=@kullanici", baglanti))
                {
                    sorgu.Parameters.AddWithValue("@izin", izin_id);
                    sorgu.Parameters.AddWithValue("@kullanici", kullanici_id);

                    using (OleDbDataReader dr = sorgu.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            red();
                        }
                        else
                        {
                            MessageBox.Show("İzin reddedilemedi.");
                        }
                    }
                }
            }
        }

        void onay()
        {
            using (OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb"))
            {
                baglanti.Open();
                using (OleDbCommand komut = new OleDbCommand("update Izinler set durumu=@durum where izin_id=@izin and kullanici_id=@kullanici", baglanti))
                {
                    komut.Parameters.Add(new OleDbParameter("@durum", OleDbType.VarChar)).Value = "Onaylandı";
                    komut.Parameters.Add(new OleDbParameter("@izin", OleDbType.Integer)).Value = izin_id;
                    komut.Parameters.Add(new OleDbParameter("@kullanici", OleDbType.Integer)).Value = kullanici_id;
                    komut.ExecuteNonQuery();
                }
                MessageBox.Show("İzin onaylandı.");
                this.Parent.Controls.Remove(this);
            }
        }

        void red()
        {
            using (OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb"))
            {
                baglanti.Open();
                using (OleDbCommand komut = new OleDbCommand("update Izinler set durumu=@durum where izin_id=@izin and kullanici_id=@kullanici", baglanti))
                {
                    komut.Parameters.Add(new OleDbParameter("@durum", OleDbType.VarChar)).Value = "Reddedildi";
                    komut.Parameters.Add(new OleDbParameter("@izin", OleDbType.Integer)).Value = izin_id;
                    komut.Parameters.Add(new OleDbParameter("@kullanici", OleDbType.Integer)).Value = kullanici_id;
                    komut.ExecuteNonQuery();
                }
                MessageBox.Show("İzin reddedildi.");
                this.Parent.Controls.Remove(this);
            }
        }
    }
}
