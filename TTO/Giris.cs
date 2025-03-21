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



namespace TTO
{
    public partial class Giris: Form
    {
        MainScreen main_screen;
        KayitOl kayit_ol;
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
            main_screen = new MainScreen();
            main_screen.Show();

            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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
