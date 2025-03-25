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
    public partial class IzinYonetimi: Form
    {

        bekleyenIzinler bekleyen_izinler;
        public IzinYonetimi()
        {
            InitializeComponent();
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
    }
}
