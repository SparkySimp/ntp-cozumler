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
        protected double sayi = 0;
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
            sayi = double.Parse(lblEkran.Text);
            lblEkran.Text = "0";
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            islem = Opeartor.Subtract;
            sayi = double.Parse(lblEkran.Text);
            lblEkran.Text = "0";
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            islem = Opeartor.Times;
            sayi = double.Parse(lblEkran.Text);
            lblEkran.Text = "0";
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            islem = Opeartor.Divide;
            sayi = double.Parse(lblEkran.Text);
            lblEkran.Text = "0";
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {
            var n1 = sayi;
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
                    case Opeartor.None:
                        sonuc = n1;
                        break;
                }
            }
            catch(DivideByZeroException)
            {
                MessageBox.Show(caption: "Hata", icon: MessageBoxIcon.Error, buttons: default, text: "Sıfıra bölme yapılamıyor.");
                islem = Opeartor.None;
                sayi = 0;
            }
            lblEkran.Text = sonuc.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayi = 0;
            islem = Opeartor.None;
            lblEkran.Text = "0";
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            buttonEquals.Select();
        }

        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (lblEkran.Text.Length == 1)
                lblEkran.Text = "0";
            else
                lblEkran.Text = lblEkran.Text.Substring(0, lblEkran.Text.Length - 1);
        }
        #region
        private void key1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void key2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void key3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void key4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void key5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void key6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void key7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void key8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void key9_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void key0_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void buttonPlus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void buttonMinus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void buttonTimes_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void buttonDivide_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void buttonEquals_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void btn_clr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }

        private void buttonBackspace_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                buttonBackspace_Click(sender, e);
        }
        #endregion
    }
}
