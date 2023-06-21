
namespace Soru1
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
            this.pbMavi = new System.Windows.Forms.PictureBox();
            this.pbSari = new System.Windows.Forms.PictureBox();
            this.btnBasla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbMavi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSari)).BeginInit();
            this.SuspendLayout();
            // 
            // pbMavi
            // 
            this.pbMavi.BackColor = System.Drawing.Color.DodgerBlue;
            this.pbMavi.Location = new System.Drawing.Point(0, 2);
            this.pbMavi.Name = "pbMavi";
            this.pbMavi.Size = new System.Drawing.Size(100, 100);
            this.pbMavi.TabIndex = 0;
            this.pbMavi.TabStop = false;
            // 
            // pbSari
            // 
            this.pbSari.BackColor = System.Drawing.Color.Yellow;
            this.pbSari.Location = new System.Drawing.Point(0, 131);
            this.pbSari.Name = "pbSari";
            this.pbSari.Size = new System.Drawing.Size(100, 100);
            this.pbSari.TabIndex = 1;
            this.pbSari.TabStop = false;
            // 
            // btnBasla
            // 
            this.btnBasla.ForeColor = System.Drawing.Color.Black;
            this.btnBasla.Location = new System.Drawing.Point(12, 246);
            this.btnBasla.Name = "btnBasla";
            this.btnBasla.Size = new System.Drawing.Size(75, 23);
            this.btnBasla.TabIndex = 2;
            this.btnBasla.Text = "Başla";
            this.btnBasla.UseVisualStyleBackColor = true;
            this.btnBasla.Click += new System.EventHandler(this.btnBasla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 306);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBasla);
            this.Controls.Add(this.pbSari);
            this.Controls.Add(this.pbMavi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbMavi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbSari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbMavi;
        private System.Windows.Forms.PictureBox pbSari;
        private System.Windows.Forms.Button btnBasla;
        private System.Windows.Forms.Label label1;
    }
}

