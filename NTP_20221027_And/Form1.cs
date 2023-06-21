using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_20221027_And
{
    public partial class SesSeviyesi : Form
    {
        public SesSeviyesi()
        {
            InitializeComponent();
        }

        private void tbSes_Scroll(object sender, EventArgs e)
        {
            if(tbSes.Value == 0)
            {
                lblErr.Text = "Ses Yok";
                lblErr.ForeColor = Color.Black;
            }
            else if(tbSes.Value > 0 && tbSes.Value < 10)
            {
                lblErr.Text = "Normal";
                lblErr.ForeColor = Color.Green;
            }
            else if(tbSes.Value >=10)
            {
                lblErr.Text = "Yüksek";
                lblErr.ForeColor = Color.Red;
            }
        }
    }
}
