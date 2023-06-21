
namespace NTP_20221027
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
            this.txtPara = new System.Windows.Forms.TextBox();
            this.btnKontrolEt = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblKredi = new System.Windows.Forms.Label();
            this.rbFaturaEvet = new System.Windows.Forms.RadioButton();
            this.rbFaturaHayır = new System.Windows.Forms.RadioButton();
            this.rbKrediKartıEvet = new System.Windows.Forms.RadioButton();
            this.rbKrediKartiHayır = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtPara
            // 
            this.txtPara.Location = new System.Drawing.Point(13, 35);
            this.txtPara.Name = "txtPara";
            this.txtPara.Size = new System.Drawing.Size(138, 20);
            this.txtPara.TabIndex = 0;
            // 
            // btnKontrolEt
            // 
            this.btnKontrolEt.Location = new System.Drawing.Point(13, 61);
            this.btnKontrolEt.Name = "btnKontrolEt";
            this.btnKontrolEt.Size = new System.Drawing.Size(138, 23);
            this.btnKontrolEt.TabIndex = 1;
            this.btnKontrolEt.Text = "Kontrol Et";
            this.btnKontrolEt.UseVisualStyleBackColor = true;
            this.btnKontrolEt.Click += new System.EventHandler(this.btnKontrolEt_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbFaturaHayır);
            this.groupBox1.Controls.Add(this.rbFaturaEvet);
            this.groupBox1.Location = new System.Drawing.Point(170, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 101);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Otomatik Fatura Ödeme";
            this.groupBox1.Visible = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbKrediKartiHayır);
            this.groupBox2.Controls.Add(this.rbKrediKartıEvet);
            this.groupBox2.Location = new System.Drawing.Point(376, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Kredi Kartı";
            this.groupBox2.Visible = false;
            // 
            // lblKredi
            // 
            this.lblKredi.AutoSize = true;
            this.lblKredi.BackColor = System.Drawing.SystemColors.Control;
            this.lblKredi.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKredi.ForeColor = System.Drawing.Color.Red;
            this.lblKredi.Location = new System.Drawing.Point(46, 139);
            this.lblKredi.Name = "lblKredi";
            this.lblKredi.Size = new System.Drawing.Size(299, 108);
            this.lblKredi.TabIndex = 4;
            this.lblKredi.Text = "label1";
            this.lblKredi.Visible = false;
            // 
            // rbFaturaEvet
            // 
            this.rbFaturaEvet.AutoSize = true;
            this.rbFaturaEvet.Location = new System.Drawing.Point(46, 20);
            this.rbFaturaEvet.Name = "rbFaturaEvet";
            this.rbFaturaEvet.Size = new System.Drawing.Size(47, 17);
            this.rbFaturaEvet.TabIndex = 0;
            this.rbFaturaEvet.TabStop = true;
            this.rbFaturaEvet.Text = "Evet";
            this.rbFaturaEvet.UseVisualStyleBackColor = true;
            // 
            // rbFaturaHayır
            // 
            this.rbFaturaHayır.AutoSize = true;
            this.rbFaturaHayır.Location = new System.Drawing.Point(46, 49);
            this.rbFaturaHayır.Name = "rbFaturaHayır";
            this.rbFaturaHayır.Size = new System.Drawing.Size(49, 17);
            this.rbFaturaHayır.TabIndex = 1;
            this.rbFaturaHayır.TabStop = true;
            this.rbFaturaHayır.Text = "Hayır";
            this.rbFaturaHayır.UseVisualStyleBackColor = true;
            // 
            // rbKrediKartıEvet
            // 
            this.rbKrediKartıEvet.AutoSize = true;
            this.rbKrediKartıEvet.Location = new System.Drawing.Point(15, 25);
            this.rbKrediKartıEvet.Name = "rbKrediKartıEvet";
            this.rbKrediKartıEvet.Size = new System.Drawing.Size(47, 17);
            this.rbKrediKartıEvet.TabIndex = 2;
            this.rbKrediKartıEvet.TabStop = true;
            this.rbKrediKartıEvet.Text = "Evet";
            this.rbKrediKartıEvet.UseVisualStyleBackColor = true;
            // 
            // rbKrediKartiHayır
            // 
            this.rbKrediKartiHayır.AutoSize = true;
            this.rbKrediKartiHayır.Location = new System.Drawing.Point(15, 48);
            this.rbKrediKartiHayır.Name = "rbKrediKartiHayır";
            this.rbKrediKartiHayır.Size = new System.Drawing.Size(49, 17);
            this.rbKrediKartiHayır.TabIndex = 3;
            this.rbKrediKartiHayır.TabStop = true;
            this.rbKrediKartiHayır.Text = "Hayır";
            this.rbKrediKartiHayır.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblKredi);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnKontrolEt);
            this.Controls.Add(this.txtPara);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtPara;
        private System.Windows.Forms.Button btnKontrolEt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbFaturaHayır;
        private System.Windows.Forms.RadioButton rbFaturaEvet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton rbKrediKartiHayır;
        private System.Windows.Forms.RadioButton rbKrediKartıEvet;
        private System.Windows.Forms.Label lblKredi;
    }
}

