
namespace Soru_2_AdamAsmaca
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.tmGameCycle = new System.Windows.Forms.Timer(this.components);
            this.lblWord = new System.Windows.Forms.Label();
            this.btnDene = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.epMain = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbHarf = new System.Windows.Forms.TextBox();
            this.btnTahminEt = new System.Windows.Forms.Button();
            this.tbTahmin = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.epMain)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 1;
            // 
            // tmGameCycle
            // 
            this.tmGameCycle.Interval = 1000;
            // 
            // lblWord
            // 
            this.lblWord.AutoSize = true;
            this.lblWord.Location = new System.Drawing.Point(226, 100);
            this.lblWord.Name = "lblWord";
            this.lblWord.Size = new System.Drawing.Size(13, 13);
            this.lblWord.TabIndex = 2;
            this.lblWord.Text = "_";
            // 
            // btnDene
            // 
            this.btnDene.Location = new System.Drawing.Point(26, 56);
            this.btnDene.Name = "btnDene";
            this.btnDene.Size = new System.Drawing.Size(75, 23);
            this.btnDene.TabIndex = 3;
            this.btnDene.Text = "Gönder";
            this.btnDene.UseVisualStyleBackColor = true;
            this.btnDene.Click += new System.EventHandler(this.btnDene_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Kalan Hak: 5";
            // 
            // epMain
            // 
            this.epMain.ContainerControl = this;
            // 
            // tbHarf
            // 
            this.tbHarf.Location = new System.Drawing.Point(35, 12);
            this.tbHarf.Name = "tbHarf";
            this.tbHarf.Size = new System.Drawing.Size(32, 20);
            this.tbHarf.TabIndex = 5;
            // 
            // btnTahminEt
            // 
            this.btnTahminEt.Location = new System.Drawing.Point(26, 189);
            this.btnTahminEt.Name = "btnTahminEt";
            this.btnTahminEt.Size = new System.Drawing.Size(75, 23);
            this.btnTahminEt.TabIndex = 6;
            this.btnTahminEt.Text = "Tahmin Et";
            this.btnTahminEt.UseVisualStyleBackColor = true;
            this.btnTahminEt.Click += new System.EventHandler(this.btnTahminEt_Click);
            // 
            // tbTahmin
            // 
            this.tbTahmin.Location = new System.Drawing.Point(18, 163);
            this.tbTahmin.Name = "tbTahmin";
            this.tbTahmin.Size = new System.Drawing.Size(100, 20);
            this.tbTahmin.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(339, 450);
            this.Controls.Add(this.tbTahmin);
            this.Controls.Add(this.btnTahminEt);
            this.Controls.Add(this.tbHarf);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDene);
            this.Controls.Add(this.lblWord);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epMain)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer tmGameCycle;
        private System.Windows.Forms.Label lblWord;
        private System.Windows.Forms.Button btnDene;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider epMain;
        private System.Windows.Forms.TextBox tbHarf;
        private System.Windows.Forms.TextBox tbTahmin;
        private System.Windows.Forms.Button btnTahminEt;
    }
}

