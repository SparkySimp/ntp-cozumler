using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Soru4
{
    public partial class MainForm : Form
    {
        int tikSayisi = 0;
        Random rng = new Random();
        public MainForm()
        {
            InitializeComponent();
        }

        private void SayiButon_Click(object button, EventArgs _)
        {
            ((Control)button).Text = rng.Next(1, 101).ToString();
            if (int.Parse(((Control)button).Text) % 3 == 0)
            {
                ((Control)button).BackColor = Color.DarkGreen;
            }
            else
            {
                ((Control)button).BackColor = Color.DarkGray;
            }
            tikSayisi++;
            lblSayac.Text = $"Tık Sayısı: {tikSayisi}";
        }

        private void MainForm_Load(object sender, EventArgs _)
        {
            Button[] buttons = (from Control ctl in this.Controls where ctl is Button _ select (Button)ctl).ToArray();

            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Text = "";
                // buttons[i].BackColor = Color.DarkGray;
            }
        }
    }
}
