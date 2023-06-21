using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SparkySimp.ArrayUtils;

namespace Soru_1_sayilar
{

    public partial class MainForm : Form
    {
        protected State state = new State();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
           
        }

        private void btnDoldur_Click(object sender, EventArgs e)
        {
            int[] _sayilar = Stuffer.GenerateUniqueRandomNumbers(20, 100, 1);
            object[] sayilar = new object[20];
            Array.Copy(_sayilar, sayilar, 20);
            lbSayilar.Items.AddRange(sayilar);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                epError.Clear();
                int sayi = int.Parse(tbSayi.Text);
                if (lbSayilar.Items.Contains(sayi))
                    epError.SetError(tbSayi, "Sayı zaten kutuda");
                else
                {
                    lbSayilar.Items.Add(Int32.Parse(tbSayi.Text));
                    state.FillRightsLeft--;
                    label1.Text = $"Kalan ekleme hakkı: {state.FillRightsLeft}";
                    if (state.FillRightsLeft == 0)
                        btnEkle.Enabled = false;
                }
            }
            catch (FormatException)
            {
                epError.SetError(tbSayi, "Lütfen sadece sayı giriniz.");
            }
        }

        private void btnSirala_Click(object sender, EventArgs e)
        {
            object[] sayilar = new object[lbSayilar.Items.Count];
            lbSayilar.Items.CopyTo(sayilar, 0);

            Array.Sort(sayilar);
            lbSayilar.Items.Clear();
            lbSayilar.Items.AddRange(sayilar);
        }
    }
    public class State
    {
        public int FillRightsLeft { get; set; } = 5;
    }
}
