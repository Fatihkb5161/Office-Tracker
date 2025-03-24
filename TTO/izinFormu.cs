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
                MessageBox.Show($"İzin Başlangıç Tarihi: {startTime.Text}\n" +
                    $"İzin Bitiş Tarihi: {finishTime.Text}\n" +
                    $"İzin Sebebiniz: {izinSebebi.Text}\n\n Şeklinde izin talebiniz oluşturulmuştur.");
            }
                
        }
    }
}
