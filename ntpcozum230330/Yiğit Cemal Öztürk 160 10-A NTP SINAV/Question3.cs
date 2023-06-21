using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PO = Yiğit_Cemal_Öztürk_160_10_A_NTP_SINAV.Question3.PossibleOperations;

namespace Yiğit_Cemal_Öztürk_160_10_A_NTP_SINAV
{
    public partial class Question3 : Form
    {
        internal enum PossibleOperations : byte
        {
            Addition,
            Multiplication
        }

        internal int[]
            numbers = { -1, -1, -1 },
            operands = { -1, -1 };

        internal PO operation;

        internal Color solution;

        internal Random prng = new Random();
 
        public Question3()
        {
            InitializeComponent();
        }

        private void btnPickColor_Click(object sender, EventArgs e)
        {
            int calculation;
            switch (operation)
            {
                case PO.Addition:
                    calculation = (int)btnOperand1.Tag + (int)btnOperand2.Tag;
                    break;
                case PO.Multiplication:
                    calculation = (int)btnOperand2.Tag * (int)btnOperand2.Tag;
                    break;
                default:
                    throw new NullReferenceException();
            }

            int[] differences = new int[3];
            differences[0] = Math.Abs(calculation - numbers[0]);
            differences[1] = Math.Abs(calculation - numbers[1]);
            differences[2] = Math.Abs(calculation - numbers[2]);

            if (differences.Min() == differences[0])
                solution = Color.Red;
            else if (differences.Min() == differences[1])
                solution = Color.Yellow;
            else if (differences.Min() == differences[2])
                solution = Color.Blue;

            ColorDialog colorDialog = new ColorDialog();
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                btnPickColor.BackColor = colorDialog.Color;
                if(colorDialog.Color == solution)
                    MessageBox.Show("Tebrikler");
                else MessageBox.Show("Kaybettiniz");
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            btnPickColor.BackColor = SystemColors.Control;
            for (int i = 0; i < 3; i++)
            {
                int producedNumber = -1;
                do
                {
                    producedNumber = prng.Next(1, 100);
                } while (Array.IndexOf(numbers, producedNumber) != -1);
                numbers[i] = producedNumber;
            }

            for (int i = 0; i < 2; i++)
            {
                int producedNumber = -1;
                do
                {
                    producedNumber = prng.Next(1, 15);
                } while (Array.IndexOf(numbers, producedNumber) != -1);
                operands[i] = producedNumber;
            }

            operation = (PO)(int)Math.Round(prng.NextDouble());

            btnNumber1.Text = (btnNumber1.Tag = numbers[0]).ToString();
            btnNumber2.Text = (btnNumber2.Tag = numbers[1]).ToString();
            btnNumber3.Text = (btnNumber3.Tag = numbers[2]).ToString();

            btnOperand1.Text = (btnOperand1.Tag = operands[0]).ToString();
            btnOperand2.Text = (btnOperand2.Tag = operands[1]).ToString();

            btnOperation.Text = operation == PO.Addition ? "+" : "*";

            btnOperation.Tag = operation;
        }
    }
}
