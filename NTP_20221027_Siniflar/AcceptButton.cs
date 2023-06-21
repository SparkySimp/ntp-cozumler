using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NTP_20221027_Siniflar
{
    public partial class AcceptButton : UserControl
    {

        public event EventHandler Accept
        {
            add
            {
                btnAccept.Click += value;
            }
            remove
            {
                btnAccept.Click -= value;
            }
        }
        public AcceptButton()
        {
            InitializeComponent();
            if(this.Container is Form frm)
            {
                frm.AcceptButton = this.btnAccept;
            }
        }

        private void AcceptButton_SizeChanged(object sender, EventArgs e)
        {
            btnAccept.Size = this.Size;
        }
        public override string Text { get => btnAccept.Text; set => btnAccept.Text = value; }

        public static implicit operator Button(AcceptButton acceptButton)
        {
            return acceptButton.btnAccept;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
