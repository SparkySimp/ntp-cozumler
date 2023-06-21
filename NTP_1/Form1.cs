using System;
#region Ivır Zıvır
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
using System.Windows.Forms;

namespace Yiğit_Cemal_Öztürk_160_10AZ
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region KOPYA ÇEKMEYİN
            try
            {
                int n1 = int.Parse(textBox1.Text);
                int n2 = int.Parse(textBox2.Text);
                textBox3.Text = (n1 + n2).ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Lütfen Sayı Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            #endregion
        }
        #region beceriksizlik
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
 
        }
        #endregion
    }
}
