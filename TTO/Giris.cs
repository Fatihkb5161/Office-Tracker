using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Data.OleDb;


namespace TTO
{
    public partial class Giris: Form
    {
        MainScreen main_screen;
        KayitOl kayit_ol;
        public bool kullaniciTuru;
        public int kullanici_id;
        public Giris()
        {
            InitializeComponent();
           
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void resize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void password_Click(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            password.Text = "";
        }

        private void username_Click(object sender, EventArgs e)
        {
            username.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OleDbConnection baglanti = new OleDbConnection("provider=microsoft.jet.oledb.4.0; data source=Database.mdb");
            baglanti.Open();



            OleDbCommand sorgu = new OleDbCommand("select kullanici_id, e_posta, sifre from Kullanici where e_posta=@ad and sifre=@sifre", baglanti);

            sorgu.Parameters.AddWithValue("@ad", username.Text);
            sorgu.Parameters.AddWithValue("@sifre", password.Text);

            OleDbDataReader dr;

            dr = sorgu.ExecuteReader();

            if (dr.Read())
            {
                //giriş yapacak
                OleDbCommand new_sorgu = new OleDbCommand("select kullanici_id, kullanici_turu from Kullanici where e_posta=@tur", baglanti);
                new_sorgu.Parameters.AddWithValue("@tur", username.Text);

                OleDbDataReader dr1;
                dr1 = new_sorgu.ExecuteReader();
                if (dr1.Read())
                {
                    kullanici_id = Convert.ToInt16(dr1.GetInt32(0));
                    kullaniciTuru = dr1.GetBoolean(1);

                }
                dr1.Close();

                main_screen = new MainScreen(kullaniciTuru);
                main_screen.kullanici_id = kullanici_id;
                main_screen.Show();
                this.Hide();
            }
            else
            {
                baglanti.Close();
                MessageBox.Show("Yanlış kullanıcı adı veya parolası. Lütfen Tekrar deneyiniz.");
            }
                

            
        }

        private void linkLabel2_LinkClicked(object sender,
            LinkLabelLinkClickedEventArgs e)
        {
            if (kayit_ol == null)
            {
                kayit_ol = new KayitOl();
                kayit_ol.FormClosed += KayitOl_Closed;
                this.Hide();
                kayit_ol.Show();
            }
            else
            {
                kayit_ol.Activate();

            }
        }

        private void KayitOl_Closed(object sender, FormClosedEventArgs e)
        {
            kayit_ol = null;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Lütfen Yöneticinizle Görüşün");
        }

    }
}
