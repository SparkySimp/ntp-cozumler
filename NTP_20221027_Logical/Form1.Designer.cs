
namespace NTP_20221027_Logical
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
            this.cbCemalAnd = new System.Windows.Forms.CheckBox();
            this.cbSemihAnd = new System.Windows.Forms.CheckBox();
            this.cbSugiAnd = new System.Windows.Forms.CheckBox();
            this.cbCemalOr = new System.Windows.Forms.CheckBox();
            this.cbSemihOr = new System.Windows.Forms.CheckBox();
            this.cbSugiOr = new System.Windows.Forms.CheckBox();
            this.pbAnd = new System.Windows.Forms.PictureBox();
            this.pbOr = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbAnd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOr)).BeginInit();
            this.SuspendLayout();
            // 
            // cbCemalAnd
            // 
            this.cbCemalAnd.AutoSize = true;
            this.cbCemalAnd.Location = new System.Drawing.Point(23, 29);
            this.cbCemalAnd.Name = "cbCemalAnd";
            this.cbCemalAnd.Size = new System.Drawing.Size(55, 17);
            this.cbCemalAnd.TabIndex = 0;
            this.cbCemalAnd.Text = "Cemal";
            this.cbCemalAnd.UseVisualStyleBackColor = true;
            this.cbCemalAnd.CheckedChanged += new System.EventHandler(this.cbAnd_CheckedChanged);
            // 
            // cbSemihAnd
            // 
            this.cbSemihAnd.AutoSize = true;
            this.cbSemihAnd.Location = new System.Drawing.Point(23, 71);
            this.cbSemihAnd.Name = "cbSemihAnd";
            this.cbSemihAnd.Size = new System.Drawing.Size(55, 17);
            this.cbSemihAnd.TabIndex = 1;
            this.cbSemihAnd.Text = "Semih";
            this.cbSemihAnd.UseVisualStyleBackColor = true;
            this.cbSemihAnd.CheckedChanged += new System.EventHandler(this.cbAnd_CheckedChanged);
            // 
            // cbSugiAnd
            // 
            this.cbSugiAnd.AutoSize = true;
            this.cbSugiAnd.Location = new System.Drawing.Point(23, 115);
            this.cbSugiAnd.Name = "cbSugiAnd";
            this.cbSugiAnd.Size = new System.Drawing.Size(47, 17);
            this.cbSugiAnd.TabIndex = 2;
            this.cbSugiAnd.Text = "Sugi";
            this.cbSugiAnd.UseVisualStyleBackColor = true;
            this.cbSugiAnd.CheckedChanged += new System.EventHandler(this.cbAnd_CheckedChanged);
            // 
            // cbCemalOr
            // 
            this.cbCemalOr.AutoSize = true;
            this.cbCemalOr.Location = new System.Drawing.Point(338, 29);
            this.cbCemalOr.Name = "cbCemalOr";
            this.cbCemalOr.Size = new System.Drawing.Size(55, 17);
            this.cbCemalOr.TabIndex = 3;
            this.cbCemalOr.Text = "Cemal";
            this.cbCemalOr.UseVisualStyleBackColor = true;
            this.cbCemalOr.CheckedChanged += new System.EventHandler(this.cbOr_CheckedChanged);
            // 
            // cbSemihOr
            // 
            this.cbSemihOr.AutoSize = true;
            this.cbSemihOr.Location = new System.Drawing.Point(338, 71);
            this.cbSemihOr.Name = "cbSemihOr";
            this.cbSemihOr.Size = new System.Drawing.Size(55, 17);
            this.cbSemihOr.TabIndex = 4;
            this.cbSemihOr.Text = "Semih";
            this.cbSemihOr.UseVisualStyleBackColor = true;
            this.cbSemihOr.CheckedChanged += new System.EventHandler(this.cbOr_CheckedChanged);
            // 
            // cbSugiOr
            // 
            this.cbSugiOr.AutoSize = true;
            this.cbSugiOr.Location = new System.Drawing.Point(338, 115);
            this.cbSugiOr.Name = "cbSugiOr";
            this.cbSugiOr.Size = new System.Drawing.Size(47, 17);
            this.cbSugiOr.TabIndex = 5;
            this.cbSugiOr.Text = "Sugi";
            this.cbSugiOr.UseVisualStyleBackColor = true;
            this.cbSugiOr.CheckedChanged += new System.EventHandler(this.cbOr_CheckedChanged);
            // 
            // pbAnd
            // 
            this.pbAnd.Location = new System.Drawing.Point(123, 29);
            this.pbAnd.Name = "pbAnd";
            this.pbAnd.Size = new System.Drawing.Size(200, 103);
            this.pbAnd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAnd.TabIndex = 6;
            this.pbAnd.TabStop = false;
            // 
            // pbOr
            // 
            this.pbOr.Location = new System.Drawing.Point(424, 29);
            this.pbOr.Name = "pbOr";
            this.pbOr.Size = new System.Drawing.Size(200, 103);
            this.pbOr.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbOr.TabIndex = 7;
            this.pbOr.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 179);
            this.Controls.Add(this.pbOr);
            this.Controls.Add(this.pbAnd);
            this.Controls.Add(this.cbSugiOr);
            this.Controls.Add(this.cbSemihOr);
            this.Controls.Add(this.cbCemalOr);
            this.Controls.Add(this.cbSugiAnd);
            this.Controls.Add(this.cbSemihAnd);
            this.Controls.Add(this.cbCemalAnd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbAnd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbOr)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbCemalAnd;
        private System.Windows.Forms.CheckBox cbSemihAnd;
        private System.Windows.Forms.CheckBox cbSugiAnd;
        private System.Windows.Forms.CheckBox cbCemalOr;
        private System.Windows.Forms.CheckBox cbSemihOr;
        private System.Windows.Forms.CheckBox cbSugiOr;
        private System.Windows.Forms.PictureBox pbAnd;
        private System.Windows.Forms.PictureBox pbOr;
    }
}

