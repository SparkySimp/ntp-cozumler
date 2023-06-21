using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Taksit\t\n\rToplam Fiyat:0";
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            decimal fiyat = decimal.Parse(textBox1.Text);
            decimal taksit = 0M;
            if(rbTekCek.Checked)
            {
                taksit = fiyat;
            }
            else if(rb2Taksit.Checked)
            {
                fiyat *= 1.05M;
                taksit = fiyat / 2;
            }
            else if(rb4Taksit.Checked)
            {
                fiyat *= 1.10m;
                taksit = fiyat / 4;
            }
            label1.Text = $"Taksit {taksit} TL\n\rToplam Fiyat:{fiyat} TL";
        }
    }
}
