using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ntp_20230427
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var father = new
            {
                Name = "Deniz",
                Surname = "Hatipoğlu",
                Birthday = new DateTime(2007, 3, 8)
            };
        }
    }
}
