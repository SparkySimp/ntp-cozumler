using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_20221027_MonthOfYear
{
    public enum MonthOfYear : int
    {
        /// <summary>
        /// Indicates January.
        /// </summary>
        January = 1,
        /// <summary>
        /// Indicates February.
        /// </summary>
        February,
        /// <summary>
        /// Indicates March.
        /// </summary>
        March,
        /// <summary>
        /// Indicates April.
        /// </summary>
        April,
        /// <summary>
        /// Indicates May.
        /// </summary>
        May,
        /// <summary>
        /// Indicates June.
        /// </summary>
        June,
        /// <summary>
        /// Indicates July.
        /// </summary>
        July,
        /// <summary>
        /// Indicates August.
        /// </summary>
        August,
        /// <summary>
        /// Indicates September.
        /// </summary>
        September,
        /// <summary>
        /// Indicates October.
        /// </summary>
        October,
        /// <summary>
        /// Indicates November.
        /// </summary>
        November,
        /// <summary>
        /// Indicates December.
        /// </summary>
        December
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected MonthOfYear GetMonthOfYear(DateTime date)
        {
           switch(date.Month)
            {
                case 1:
                    return MonthOfYear.January;
                case 2:
                    return MonthOfYear.February;
                case 3:
                    return MonthOfYear.March;
                case 4:
                    return MonthOfYear.April;
                case 5:
                    return MonthOfYear.May;
                case 6:
                    return MonthOfYear.June;
                case 7:
                    return MonthOfYear.July;
                case 8:
                    return MonthOfYear.August;
                case 9:
                    return MonthOfYear.September;
                case 10:
                    return MonthOfYear.October;
                case 11:
                    return MonthOfYear.November;
                case 12:
                    return MonthOfYear.December;
            }
            return 0;

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var month = (MonthOfYear)DateTime.Today.Month;

            switch(month)
            {
                case MonthOfYear.January:
                    label1.Text = "Ocak";
                    break;
                case MonthOfYear.February:
                    label1.Text = "Şubat";
                    break;
                case MonthOfYear.March:
                    label1.Text = "Mart";
                    break;
                case MonthOfYear.April:
                    label1.Text = "Nisan";
                    break;
                case MonthOfYear.May:
                    label1.Text = "Mayıs";
                    break;
                case MonthOfYear.June:
                    label1.Text = "Haziran";
                    break;
                case MonthOfYear.July:
                    label1.Text = "Temmuz";
                    break;
                case MonthOfYear.August:
                    label1.Text = "Ağustos";
                    break;
                case MonthOfYear.September:
                    label1.Text = "Eylül";
                    break;
                case MonthOfYear.October:
                    label1.Text = "Ekim";
                    break;
                case MonthOfYear.November:
                    label1.Text = "Kasım";
                    break;
                case MonthOfYear.December:
                    label1.Text = "Aralık";
                    break;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            var nuThis = (NumericUpDown)sender;

            switch((MonthOfYear)(int)nuThis.Value)
            {
                case MonthOfYear.January:
                    label1.Text = "Ocak";
                    break;
                case MonthOfYear.February:
                    label1.Text = "Şubat";
                    break;
                case MonthOfYear.March:
                    label1.Text = "Mart";
                    break;
                case MonthOfYear.April:
                    label1.Text = "Nisan";
                    break;
                case MonthOfYear.May:
                    label1.Text = "Mayıs";
                    break;
                case MonthOfYear.June:
                    label1.Text = "Haziran";
                    break;
                case MonthOfYear.July:
                    label1.Text = "Temmuz";
                    break;
                case MonthOfYear.August:
                    label1.Text = "Ağustos";
                    break;
                case MonthOfYear.September:
                    label1.Text = "Eylül";
                    break;
                case MonthOfYear.October:
                    label1.Text = "Ekim";
                    break;
                case MonthOfYear.November:
                    label1.Text = "Kasım";
                    break;
                case MonthOfYear.December:
                    label1.Text = "Aralık";
                    break;
            }
        }
    }
}
