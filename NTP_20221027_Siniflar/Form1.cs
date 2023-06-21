using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_20221027_Siniflar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var sinif = byte.Parse(domainUpDown1.Text);

            if(sinif > 0 && sinif < 5)
            {
                MessageBox.Show("İlkokul");
            }
            else if(sinif > 4 && sinif < 9)
            {
                MessageBox.Show("Ortaokul");
            }
            else
            {
                MessageBox.Show("Lise");
            }
        }
    }
}
