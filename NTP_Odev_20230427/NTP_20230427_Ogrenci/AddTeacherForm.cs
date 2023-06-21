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
    public partial class AddTeacherForm : Form
    {
        public AddTeacherForm()
        {
            InitializeComponent();
        }

        private async void btnOk_Click(object sender, EventArgs e)
        {
            Dynamics.Ogretmenler.Add(new Ogretmen
            {
                Name = txName.Text,
                Surname = txSurname.Text,
                Branch = Dynamics.BRANCHES[cbBranch.SelectedIndex]
            });

            await new Task(Dynamics.SaveProgramState);
        }

        private void AddTeacherForm_Load(object sender, EventArgs e)
        {
            cbBranch.DataSource = Dynamics.BRANCHES;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
