using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_221020_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal s1 = decimal.Parse(txtSayi1.Text);
            decimal s2 = decimal.Parse(txtSayi2.Text);

            if (rbCarp.Checked)
            {
                lblSonuc.Text = $"Sonuç: {s1 * s2}";
            }
            else if(rbTopla.Checked)
            {
                lblSonuc.Text = $"Sonuç: {s1 + s2}";
            }
        }
    }
}
