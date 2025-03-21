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
        public IzınAlma()
        {
            InitializeComponent();
            listView1.View = View.Details;
            listView1.Columns.Add("Başlık", 200);
            listView1.Columns.Add("Başlangıç Zamanı", 150);
            listView1.Columns.Add("Bitiş Zamanı", 150);

        }

        private void IzınAlma_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            // Outlook uygulamasını başlat
            Outlook.Application outlookApp = new Outlook.Application();

            // Varsayılan takvim klasörünü al
            Outlook.NameSpace outlookNamespace = outlookApp.GetNamespace("MAPI");
            Outlook.MAPIFolder calendarFolder = outlookNamespace.GetDefaultFolder(Outlook.OlDefaultFolders.olFolderCalendar);
            Outlook.Items calendarItems = calendarFolder.Items;

            // ListView'i temizle
            listView1.Items.Clear();

            // Takvimdeki randevuları al ve listele
            foreach (Outlook.AppointmentItem appointment in calendarItems)
            {
                // ListView'e yeni bir satır ekliyoruz
                ListViewItem item = new ListViewItem(appointment.Subject);
                item.SubItems.Add(appointment.Start.ToString());
                item.SubItems.Add(appointment.End.ToString());

                listView1.Items.Add(item);
            }

            MessageBox.Show("Takvim etkinlikleri başarıyla yüklendi.");
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
    }
}
