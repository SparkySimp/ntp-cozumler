using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yiğit_Cemal_Öztürk_160_10_A_NTP_SINAV
{
    public partial class Question1 : Form
    {
        public Question1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "10A" && textBox2.Text == "123")
            {
                new Question2().Show();
                // this.Hide();
            }
        }
    }
}
