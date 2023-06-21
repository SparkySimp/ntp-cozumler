using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_20221103_OR_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            var secilen = lbDonanim.SelectedItem?.ToString() ?? "Klavye";
            if (secilen == "Mouse" || secilen == "Klavye" || secilen == "Kamera" || secilen == "Tarayıcı") MessageBox.Show("Seçilen birim giriş birimidir.");
            else MessageBox.Show("Seçilen birim giriş birimidir.");
        }
    }
}
