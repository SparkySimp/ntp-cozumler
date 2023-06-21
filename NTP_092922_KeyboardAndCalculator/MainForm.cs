using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_092922_KeyboardAndCalculator
{
    /// <summary>
    /// Describes the operation
    /// </summary>
    public enum Opeartor
    {
        /// <summary>
        /// No operation was chosen
        /// </summary>
        None,
        /// <summary>
        /// Operation of additon.
        /// </summary>
        Add,
        /// <summary>
        /// Operation of subtraction.
        /// </summary>
        Subtract,
        /// <summary>
        /// Operation of multiplication.
        /// </summary>
        Times,
        /// <summary>
        /// Operation of division.
        /// </summary>
        Divide
    }
    public partial class MainForm : Form
    {
        protected Opeartor islem = Opeartor.None;
        protected string sayi = "";
        public MainForm()
        {
            InitializeComponent();
        }
        // All `key*` buttons represent their respective numeric keys
        // All `button*` buttons represent their respective operations
        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void key1_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";

            lblEkran.Text += "1";
        }

        private void key2_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            lblEkran.Text += "2";
        }

        private void key3_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            lblEkran.Text += "3";
        }

        private void key4_Click(object sender, EventArgs e)
        {if (lblEkran.Text == "0")
                lblEkran.Text = "";
            lblEkran.Text += "4";
        }

        private void key5_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            lblEkran.Text += "5";
        }

        private void key6_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            lblEkran.Text += "6";
        }

        private void key7_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            lblEkran.Text += "7";
        }

        private void key8_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            lblEkran.Text += "8";
        }

        private void key9_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            lblEkran.Text += "9";
        }

        private void key0_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text == "0")
                lblEkran.Text = "";
            lblEkran.Text += "0";
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            islem = Opeartor.Add;
            sayi = lblEkran.Text;
            lblEkran.Text = "0";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            islem = Opeartor.Subtract;
            sayi = lblEkran.Text;
            lblEkran.Text = "0";
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            islem = Opeartor.Times;
            sayi = lblEkran.Text;
            lblEkran.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            islem = Opeartor.Divide;
            sayi = lblEkran.Text;
            lblEkran.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            var n1 = double.Parse(sayi);
            var n2 = double.Parse(lblEkran.Text);
            double sonuc = default;
            try
            {
                switch (islem) {
                    case Opeartor.Add:
                        sonuc = n1 + n2;
                        break;

                    case Opeartor.Subtract:
                        sonuc = n1 - n2;
                        break;

                    case Opeartor.Times:
                        sonuc = n1 * n2;
                        break;

                    case Opeartor.Divide:
                        sonuc = n1 / n2;
                        break;
                }
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show(caption: "Hata", icon: MessageBoxIcon.Error, buttons: default, text: "Sıfıra bölme yapılamıyor.");
                islem = Opeartor.None;
                sayi = "0";
            }
            lblEkran.Text = sonuc.ToString();
        }
    }
}
