using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MerhabaDunya
{
    public partial class Form1 : Form
    {
        private Size size;
        public Form1()
        {
            InitializeComponent();
        }

       /* private void textBox1_TextChanged(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
       */
        private void Form1_Resize(object sender, EventArgs e)
        {
            this.Size = size;
            System.Media.SystemSounds.Exclamation.Play();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            size = this.Size;
            btn_kirmizi.BackColor = Color.Red;
            btn_mavi.BackColor = Color.Blue;
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            this.Size = size;
            System.Media.SystemSounds.Exclamation.Play();
        }

       /* private void textBox1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }
       */
    }
}
