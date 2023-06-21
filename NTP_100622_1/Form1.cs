using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_120622_01
{
    public partial class Form1 : Form
    {
        protected Random prng = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        { 
            var btn = (Button)sender;
            if(btn.BackColor != Color.Red )
                btn.BackColor = Color.Red;
            else
                btn.BackColor = SystemColors.Control;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var buttons = new Button[] {
                                         button1, button10, button11, button12, button13, button14, button15, button16, button17, button18, button19, 
                                         button2, button20, button21, button22, button23, button24, button25, button26, button27, button28, button29,
                                         button3, button30, button31, button32, button33, button34, button35, button36, button37, button38, button39,
                                         button4, button40,
                                         button5, button6, button7, button8, button9
            };
            for (int i = 0; i < buttons.Length; i++)
                buttons[i].Text = prng.Next(1, 101).ToString();
           

        }
    }
}
