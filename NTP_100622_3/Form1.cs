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
        /// <summary>
        /// The count of the numeric display buttons on the form.
        /// </summary>
        const int BUTTON_COUNT = 21;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_click(object sender, EventArgs e)
        {
            var btn = (Button)sender;
            if (btn.BackColor != Color.Red)
            {
                btn.BackColor = Color.Red;
            }
            else
            {
                btn.BackColor = SystemColors.Control;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {



        }

        private void btnSayiUret_Click(object sender, EventArgs e)
        {
            Random prng = new Random();
            for (int i = 1; i < BUTTON_COUNT; i++)
            {
                this.Controls[$"button{i}"].Text = prng.Next(0, 100).ToString();
                this.Controls[$"button{i}"].BackColor = SystemColors.ButtonShadow;
            }
        }

        private void btnTekler_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < BUTTON_COUNT; i++)
            {
                var btn = (Button)this.Controls[$"button{i}"];
                if(int.Parse(btn.Text).IsOdd())
                {
                    btn.BackColor = Color.Yellow;
                }
            }
        }

        private void btnCiftler_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < BUTTON_COUNT; i++)
            {
                var btn = (Button)this.Controls[$"button{i}"];
                if (int.Parse(btn.Text).IsEven())
                {
                    btn.BackColor = Color.Green;
                }
            }
        }

        private void btnTekCift_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < BUTTON_COUNT; i++)
            {
                var btn = (Button)this.Controls[$"button{i}"];
                if (int.Parse(btn.Text).IsEven())
                {
                    btn.BackColor = Color.Green;
                }
                else if(int.Parse(btn.Text).IsOdd())
                {
                    btn.BackColor = Color.Yellow;
                }
                else
                {
                    throw new Exception();
                }
            }
        }
    }
}
