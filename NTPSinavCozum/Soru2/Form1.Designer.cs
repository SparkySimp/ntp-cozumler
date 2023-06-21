
namespace Soru2
{
    partial class Form1
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbTekCek = new System.Windows.Forms.RadioButton();
            this.rb2Taksit = new System.Windows.Forms.RadioButton();
            this.rb4Taksit = new System.Windows.Forms.RadioButton();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(22, 22);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 38);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "0";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb4Taksit);
            this.groupBox1.Controls.Add(this.rb2Taksit);
            this.groupBox1.Controls.Add(this.rbTekCek);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(22, 103);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.groupBox1.Size = new System.Drawing.Size(264, 181);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Taksit";
            // 
            // rbTekCek
            // 
            this.rbTekCek.AutoSize = true;
            this.rbTekCek.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTekCek.Location = new System.Drawing.Point(12, 45);
            this.rbTekCek.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rbTekCek.Name = "rbTekCek";
            this.rbTekCek.Size = new System.Drawing.Size(118, 28);
            this.rbTekCek.TabIndex = 0;
            this.rbTekCek.TabStop = true;
            this.rbTekCek.Text = "Tek Çekim";
            this.rbTekCek.UseVisualStyleBackColor = true;
            // 
            // rb2Taksit
            // 
            this.rb2Taksit.AutoSize = true;
            this.rb2Taksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb2Taksit.Location = new System.Drawing.Point(12, 85);
            this.rb2Taksit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb2Taksit.Name = "rb2Taksit";
            this.rb2Taksit.Size = new System.Drawing.Size(194, 28);
            this.rb2Taksit.TabIndex = 1;
            this.rb2Taksit.TabStop = true;
            this.rb2Taksit.Text = "2 Taksit (%5 ek fiyat)";
            this.rb2Taksit.UseVisualStyleBackColor = true;
            // 
            // rb4Taksit
            // 
            this.rb4Taksit.AutoSize = true;
            this.rb4Taksit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rb4Taksit.Location = new System.Drawing.Point(12, 125);
            this.rb4Taksit.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.rb4Taksit.Name = "rb4Taksit";
            this.rb4Taksit.Size = new System.Drawing.Size(204, 28);
            this.rb4Taksit.TabIndex = 2;
            this.rb4Taksit.TabStop = true;
            this.rb4Taksit.Text = "4 Taksit (%10 ek fiyat)";
            this.rb4Taksit.UseVisualStyleBackColor = true;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(94, 293);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(101, 32);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 374);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AcceptButton = this.btnHesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(315, 445);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb4Taksit;
        private System.Windows.Forms.RadioButton rb2Taksit;
        private System.Windows.Forms.RadioButton rbTekCek;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label1;
    }
}

