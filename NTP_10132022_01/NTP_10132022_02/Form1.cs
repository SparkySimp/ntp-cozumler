using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_10132022_02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var btn = (Button)sender;

            //switch(btn.Text)
            //{
            //     // Formula of discounting: Discounted Price = Startup Price * (100 - Discount Percentage);
            //     case "10%":
            //         nuIndirim.Value = nuEtiket.Value * 0.90M;
            //         break;

            //     case "25%":
            //         nuIndirim.Value = nuEtiket.Value * 0.75M;
            //         break;

            //     case "50%":
            //         nuIndirim.Value = nuEtiket.Value * 0.50M;
            //         break;

            //     case "75%":
            //         nuIndirim.Value = nuEtiket.Value * 0.25M;
            //         break;
            // }

            var perc = Convert.ToDecimal(btn.Text.Substring(6, 2));

            nuIndirim.Value = nuEtiket.Value * (1 - (perc/100));

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            nuIndirim.Maximum = decimal.MaxValue;
            nuEtiket.Maximum = decimal.MaxValue;
        }
    }
}
