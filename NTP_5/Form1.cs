using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace yigitcemalozturk16010aornek
{
    public partial class Form1 : Form
    {
        private int val = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
             * if (radioButton1.Checked)
                 val += 3;
             else if (radioButton2.Checked)
                 val += 5;
             else
            */
            val += 1;
            //{
            //    radioButton1.Checked = true;
            //    button1_Click(sender, e);
            //}
            label1.Text = val.ToString();
        }
    }
}
