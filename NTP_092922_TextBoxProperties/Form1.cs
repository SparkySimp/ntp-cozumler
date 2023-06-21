using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_092922_TextBoxProperties
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(rbAktif.Checked)
            {
                textBox1.Enabled = true;
            }
            else if(rbPasif.Checked)
            {
                textBox1.Enabled = false;
            }

            if(rbGoster.Checked)
            {
                textBox1.Visible = true;
            }
            else if(rbGizle.Checked)
            {
                textBox1.Visible = false;
            }
            if(rbKirmizi.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
            else if(rbMavi.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
            else if(rbMor.Checked)
            {
                textBox1.ForeColor = Color.Purple;
            }
            try
            {
                textBox1.Font = new Font(familyName: "Calibri", emSize: float.Parse(txbSize.Text));
            }
            catch(FormatException)
            {
                txbSize.Text = "18.5"; // fixes #1
                textBox1.Font = new Font(familyName: "Calibri", emSize: float.Parse(txbSize.Text));
            }
            

        }
    }
}
