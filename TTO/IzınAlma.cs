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
    public partial class IzınAlma: Form
    {
        izinFormu izin_formu;
        public IzınAlma()
        {
            InitializeComponent();

        }

        private void IzınAlma_Load(object sender, EventArgs e)
        {

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
    }
}
