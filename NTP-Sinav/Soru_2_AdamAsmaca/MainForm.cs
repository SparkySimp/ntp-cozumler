using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Diagnostics;

namespace Soru_2_AdamAsmaca
{
    public partial class MainForm : Form
    {
        protected static readonly string[] WORDS =
        {
            "bilgisayar",
            "kedi",
            "bilişim",
            "fonksiyon",
            "sınıf",
            "kelime",
            "algoritma",
            "kemal",
            "deneme",
            "karakter",
            "kontrol",
        };

        protected string chosenWord;
        protected Stopwatch sw;
        protected List<char> testedLetters = new List<char>(5);
        protected uint _rl = 5;
        protected uint RightsLeft
        {
            get
            {
                return _rl;
            }
            set
            {
                _rl = value;
                label2.Text = $"Kalan Hak: {_rl}";
                MessageBox.Show("Tahmin başarısız!", caption: "", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                if (_rl == 0)
                {
                    btnDene.Enabled = false;
                    btnTahminEt.Enabled = false;
                }
            }
        }
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            sw = new Stopwatch();
            tmGameCycle.Tick += (_sender, _e) => label1.Text = new DateTime(sw.Elapsed.Ticks).ToLongTimeString();
            tmGameCycle.Start();
            sw.Start();
            chosenWord = WORDS.ChooseRandomItem();
            Debug.WriteLine(chosenWord);

            for (int i = 0; i < chosenWord.Length -1; i++)
                  lblWord.Text += "_";
        }
        private void btnDene_Click(object sender, EventArgs e)
        {
            if (tbHarf.Text.Length != 1)
            {
                tbHarf.Clear();
                MessageBox.Show("Tek harf giriniz");
            }
            if (testedLetters.Contains(char.Parse(tbHarf.Text)))
                MessageBox.Show("Bu harfi zaten denediniz.");
            else if(chosenWord.IndexOf(char.Parse(tbHarf.Text)) == -1)
            {
                testedLetters.Add(char.Parse(tbHarf.Text));
                RightsLeft--;
            }

            int hIndex = 0;
            for (int i = 0; i < chosenWord.Length; i++)
            {
                if (chosenWord[i] == Char.Parse(tbHarf.Text))
                    lblWord.Text = lblWord.Text.ReplaceIndex(hIndex, Char.Parse(tbHarf.Text));
                hIndex++;
            }

            if (lblWord.Text == $"{chosenWord}")
            {
                MessageBox.Show("Tebrikler... Keilmeyi bildiniz!");
                tmGameCycle.Stop();
            }
        }

        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            if (tbTahmin.Text != chosenWord)
                RightsLeft--;
            else
            {
                lblWord.Text = chosenWord;
                tmGameCycle.Stop();
                sw.Stop();
            }
        }
    }
}
