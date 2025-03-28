using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Outlook = Microsoft.Office.Interop.Outlook;


namespace TTO
{
    public partial class MainScreen: Form
    {
        public int kullanici_id;
        bool kullanici_turu; // true: Yönetici, false: personel
        IzınAlma izin_alma;
        ConferanceReservation reservation;
        Anasayfa anasayfa;
        Etkinlik etkinlik;
        Projeler projeler;

        IzinYonetimi izin_yonetimi;
        public MainScreen(bool tur)
        {
            InitializeComponent();
            kullanici_turu = tur;
            this.IsMdiContainer = true;
            if (kullanici_turu == false) { this.Text = "Personel Ekranı"; }
            else if (kullanici_turu == true) { this.Text = "Yönetici Ekranı"; }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (kullanici_turu == false)
            {
                if (izin_alma == null)
                {
                    izin_alma = new IzınAlma();
                    izin_alma.kullanici_id = kullanici_id;
                    izin_alma.FormClosed += IzinAlma_Closed;
                    izin_alma.MdiParent = this;
                    izin_alma.Dock = DockStyle.Fill;
                    izin_alma.Show();
                }
                else
                {
                    izin_alma.Activate();

                }
            }

            else if (kullanici_turu == true )
            {
                if (izin_yonetimi == null)
                {
                    izin_yonetimi = new IzinYonetimi();
                    izin_yonetimi.kullanici_id = kullanici_id;
                    izin_yonetimi.FormClosed += IzinYonetimi_Closed;
                    izin_yonetimi.MdiParent = this;
                    izin_yonetimi.Dock = DockStyle.Fill;
                    izin_yonetimi.Show();
                }
                else
                {
                    izin_yonetimi.Activate();

                }
            }
            
        }

        private void IzinAlma_Closed(object sender, EventArgs e)
        {
            izin_alma = null;
        }

        private void IzinYonetimi_Closed(object sender, EventArgs e)
        {
            izin_yonetimi = null;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (reservation == null)
            {
                reservation = new ConferanceReservation();
                reservation.FormClosed += ConferanceReservation_Closed;
                reservation.MdiParent = this;
                reservation.Dock = DockStyle.Fill;
                reservation.Show();
            }
            else
            {
                reservation.Activate();

            }

        }

        private void ConferanceReservation_Closed(object sender, EventArgs e)
        {
            izin_alma = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (anasayfa == null)
            {
                anasayfa = new Anasayfa();
                anasayfa.kullanici_id = kullanici_id;
                anasayfa.FormClosed += Anasayfa_Closed;
                anasayfa.MdiParent = this;
                anasayfa.Dock = DockStyle.Fill;
                anasayfa.Show();
            }
            else
            {
                anasayfa.Activate();

            }
        }

        private void Anasayfa_Closed(object sender, FormClosedEventArgs e)
        {
            anasayfa = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (etkinlik == null)
            {
                etkinlik = new Etkinlik();
                etkinlik.FormClosed += Etkinlik_Closed;
                etkinlik.MdiParent = this;
                etkinlik.Dock = DockStyle.Fill;
                etkinlik.Show();
            }
            else
            {
                etkinlik.Activate();

            }
        }

        private void Etkinlik_Closed(object sender, FormClosedEventArgs e)
        {
            etkinlik = null;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (projeler == null)
            {
                projeler = new Projeler();
                projeler.FormClosed += Projeler_Closed;
                projeler.MdiParent = this;
                projeler.Dock = DockStyle.Fill;
                projeler.Show();
            }
            else
            {
                projeler.Activate();

            }
        }

        private void Projeler_Closed(object sender, FormClosedEventArgs e)
        {
            projeler = null;
        }

       

        private void MainScreen_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
