using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_20221027_Logical
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbAnd_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCemalAnd.Checked && cbSemihAnd.Checked && cbSugiAnd.Checked)
            {
                pbAnd.Image = Image.FromFile($"C:\\Users\\{Environment.UserName}\\Pictures\\gulen.png");
            }
            else
            {
                pbAnd.Image = Image.FromFile($"C:\\Users\\{Environment.UserName}\\Pictures\\asik.png");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbAnd.Image = Image.FromFile($"C:\\Users\\{Environment.UserName}\\Pictures\\notr.png");
            pbOr.Image = Image.FromFile($"C:\\Users\\{Environment.UserName}\\Pictures\\notr.png");
        }

        private void cbOr_CheckedChanged(object sender, EventArgs e)
        {
            if(cbCemalOr.Checked || cbSemihOr.Checked || cbSugiOr.Checked)
            {
                pbOr.Image = Image.FromFile($"C:\\Users\\{Environment.UserName}\\Pictures\\gulen.png");
            }
            else
            {
                pbOr.Image = Image.FromFile($"C:\\Users\\{Environment.UserName}\\Pictures\\asik.png");
            }
        }
    }
}
