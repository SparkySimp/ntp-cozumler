using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_20221103_OR_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((radioButton1.Checked && ((string)listBox1.SelectedItem == "MP4" || (string)listBox1.SelectedItem == "MOV")) || (radioButton2.Checked && ((string)listBox1.SelectedItem == "JPG" || (string)listBox1.SelectedItem == "PNG")))
            {
                MessageBox.Show("Cevabınız Doğru");
            }
            else
            {
                MessageBox.Show("Cevabınız Yanlış");
            }
        }
    }
}
