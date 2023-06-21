using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_10132022_01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIslet_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(numericUpDown1.Value);
            int sayi2 = Convert.ToInt32(numericUpDown2.Value);

            int cozum = (sayi1 + sayi2) * 2 + 5;

            MessageBox.Show($"Çözüm: {cozum}", caption: "Sonuç");
        }
    }
}
