using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_20230427_Ogrenci
{
    public partial class ListCoursesForm : Form
    {
        public ListCoursesForm()
        {
            InitializeComponent();
        }

        private void ListCoursesForm_Load(object sender, EventArgs e)
        {
            foreach (var i in Dynamics.Ogrenciler)
            {
                lbStudents.Items.Add($"{i.Ad} {i.Soyad}");
            }
        }

        private void lbStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbClasses.DataSource = Dynamics.Ogrenciler[lbStudents.SelectedIndex].GirilenDersler;
        }

        private void lbClasses_SelectedIndexChanged(object sender, EventArgs e)
        {
            var entry = Dynamics.Ogrenciler[lbStudents.SelectedIndex].Notlar[lbClasses.SelectedItem.ToString()];
            switch(entry.Length)
            {
                case 0:
                    numericUpDown1.Value = numericUpDown2.Value = numericUpDown3.Value = 0M;
                    break;

                case 1:
                    numericUpDown1.Value = new decimal(entry[0]);
                    numericUpDown2.Value = numericUpDown3.Value = 0M;
                    break;

                case 2:
                    numericUpDown1.Value = new decimal(entry[0]);
                    numericUpDown2.Value = new decimal(entry[1]);
                    numericUpDown3.Value = 0M;
                    break;

                case 3:
                    numericUpDown1.Value = new decimal(entry[0]);
                    numericUpDown2.Value = new decimal(entry[1]);
                    numericUpDown3.Value = new decimal(entry[2]);
                    break;
            }
        }
    }
}
