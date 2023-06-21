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
    public partial class Question2 : Form
    {
        FontDialog hostFontDialog = new FontDialog();
        ColorDialog hostColorDialog = new ColorDialog();
        bool colorDialogHasEnded = false;
        public Question2()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hostFontDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control item in tabPage2.Controls)
                {
                    item.Font = hostFontDialog.Font;
                }
            }
        }

        private void renkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (hostColorDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (Control item in tabPage2.Controls)
                {
                    item.BackColor = hostColorDialog.Color;
                    colorDialogHasEnded = true;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tabPage2.Controls.Clear();
            Random prng = new Random(Seed: DateTime.Now.Ticks.GetHashCode());
            int length = 69, rowLength;
            if (rd3x3.Checked) length = 9;
            else if (rd4x4.Checked) length = 16;
            else if (rd5x5.Checked) length = 25;
            rowLength = (int)Math.Sqrt(length);
            Point origin = Point.Empty;
            for (int i = 0; i < length; i++)
            {
                try
                {
                    Button btn = new Button();
                    if (rdTypeNumeric.Checked)
                        btn.Text = prng.Next(0, int.Parse(textBox1.Text)).ToString();
                    else if (rdTypeText.Checked)
                        btn.Text = textBox1.Text;

                    btn.Font = hostFontDialog.Font ?? button1.Font;
                    btn.BackColor = colorDialogHasEnded ? hostColorDialog.Color : SystemColors.Control;
                    //origin.Offset(dx: i % rowLength == 0 ? 0 : 15,
                    //              dy: i % rowLength == 0 ? 15 : 0);

                    if (i % rowLength == 0)
                    {
                        origin.X = 0;
                        origin.Y += 55;
                    }
                    else
                    {
                        origin.X += 55;
                    }

                    btn.Location = origin;

                    btn.Size = new Size(50, 50);

                    tabPage2.Controls.Add(btn);
                }
                catch (FormatException)
                {
                    MessageBox.Show("Sayı butonu oluşturmayı seçmişsiniz gibi görünüyor.\n\rAncak sayı girmemişsiniz.\n\rLütfen sayı giriniz efendim.", 
                        caption:"Hata", 
                        buttons: MessageBoxButtons.AbortRetryIgnore, 
                        icon: MessageBoxIcon.Error);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Question3().Show();
        }
    }
}
