using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TTO
{
    public partial class KayitOl: Form
    {
        Giris giris;
        public KayitOl()
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

        private void button1_Click(object sender, EventArgs e)
        {
            giris = new Giris();
            giris.Show();

            this.Hide();
        }


        private void Giris_Closed(object sender, FormClosedEventArgs e)
        {
            giris = null;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Kayıt Başarılı bir şekilde oluşturuldu. Giriş ekranına dönünüz.");
        }

        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (giris == null)
            {
                giris = new Giris();
                giris.FormClosed += Giris_Closed;
                this.Hide();
                giris.Show();
            }
            else
            {
                giris.Activate();

            }
        }

        private void username_Click_1(object sender, EventArgs e)
        {
            username.Text = "";
        }

        private void password_Click_1(object sender, EventArgs e)
        {
            password.PasswordChar = '*';
            password.Text = "";
        }
    }
}
