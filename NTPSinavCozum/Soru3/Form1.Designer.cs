
namespace Soru3
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
            this.cbAcik = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbAcik
            // 
            this.cbAcik.AutoSize = true;
            this.cbAcik.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cbAcik.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cbAcik.Location = new System.Drawing.Point(124, 12);
            this.cbAcik.Name = "cbAcik";
            this.cbAcik.Size = new System.Drawing.Size(154, 35);
            this.cbAcik.TabIndex = 0;
            this.cbAcik.Text = "Lamba Aç";
            this.cbAcik.UseVisualStyleBackColor = true;
            this.cbAcik.CheckedChanged += new System.EventHandler(this.cbAcik_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(109, 53);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(179, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 117);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbAcik);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbAcik;
        private System.Windows.Forms.Button button1;
    }
}

