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
    public partial class bekleyenIzinler: Form
    {
        public bekleyenIzinler()
        {
            InitializeComponent();
            Panel panel2 = panel1;
        }

        private void bekleyenIzinler_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            request my_request = new request();
            flowLayoutPanel1.Controls.Add(my_request); // max 21
        }
    }
}
