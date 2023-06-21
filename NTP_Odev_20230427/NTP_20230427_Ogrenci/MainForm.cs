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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new AddStudentForm().ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddTeacherForm().ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new ListCoursesForm().Show();
        }
    }
}
