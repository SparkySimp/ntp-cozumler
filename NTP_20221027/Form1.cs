using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_20221027
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            decimal balance = decimal.Parse(txtPara.Text);

            if(balance < 10_000m)
            {
                lblKredi.Text = "Kredi Alamazsınız";
                lblKredi.Show();
            }
            else
            {
                groupBox1.Show();
                if(rbFaturaHayır.Checked)
                {
                    lblKredi.Text = "Kredi Alamazsınız";
                    lblKredi.Show();
                }
                else if(rbFaturaEvet.Checked)
                {
                    groupBox2.Show();
                    if(rbKrediKartiHayır.Checked)
                    {
                        lblKredi.Text = "Kredi Alamazsınız";
                        lblKredi.Show();
                    }
                    else if(rbKrediKartıEvet.Checked)
                    {
                        lblKredi.Text = "Kredi Alabilirsiniz";
                        lblKredi.Show();
                    }
                }
            }
        }
    }
}
