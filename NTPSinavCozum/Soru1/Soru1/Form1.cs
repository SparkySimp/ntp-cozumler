using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru1
{
    public partial class Form1 : Form
    {
        Random rng = new Random();
        int tikSayisi = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pbMavi.Left = 0;
            pbSari.Left = 0;
        }

        private void btnBasla_Click(object sender, EventArgs e)
        {
            tikSayisi++;
            pbMavi.Left += rng.Next(1, 101);
            pbSari.Left += rng.Next(1, 101);
            label1.Text = tikSayisi.ToString();
            if (tikSayisi >= 5)
            {
                if(pbMavi.Left > pbSari.Left)
                {
                    MessageBox.Show("Kazanan: Mavi");
                }
                else if(pbSari.Left > pbMavi.Left)
                {
                    MessageBox.Show("Kazanan: Sarı");
                }
                else
                {
                    MessageBox.Show("Beraberlik");
                }
            }
        }
    }
}
