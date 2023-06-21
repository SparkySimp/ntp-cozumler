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
    public partial class AddStudentForm : Form
    {
        public AddStudentForm()
        {
            InitializeComponent();
        }

        private async void btnRegister_Click(object sender, EventArgs e)
        {
            var grades = new int[cklsCourses.CheckedItems.Count];

            var ogr = new Ogrenci
            {
                Ad = txtAd.Text,
                Soyad = txtSoyad.Text,
                OkulNo = int.Parse(maskedTextBox1.Text),
                GirilenDersler = cklsCourses.CheckedItems.Cast<string>().ToList()
            };

            Dynamics.Ogrenciler.Add(ogr);

            await new Task(Dynamics.SaveProgramState);
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void AddStudentForm_Load(object sender, EventArgs e)
        {
            cklsCourses.Items.Clear();
            var coursesWhichHaveATeacher = Dynamics.Ogretmenler.Select(i => i.Branch).Distinct();
            foreach (var i in coursesWhichHaveATeacher) cklsCourses.Items.Add(i);
        }
    }
}
