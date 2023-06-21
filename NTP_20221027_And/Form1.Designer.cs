
namespace NTP_20221027_And
{
    partial class SesSeviyesi
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
            this.lblErr = new System.Windows.Forms.Label();
            this.tbSes = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbSes)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblErr
            // 
            this.lblErr.AutoSize = true;
            this.lblErr.Location = new System.Drawing.Point(67, 67);
            this.lblErr.Name = "lblErr";
            this.lblErr.Size = new System.Drawing.Size(35, 13);
            this.lblErr.TabIndex = 0;
            this.lblErr.Text = "label1";
            // 
            // tbSes
            // 
            this.tbSes.Location = new System.Drawing.Point(40, 19);
            this.tbSes.Maximum = 15;
            this.tbSes.Name = "tbSes";
            this.tbSes.Size = new System.Drawing.Size(104, 45);
            this.tbSes.TabIndex = 1;
            this.tbSes.Scroll += new System.EventHandler(this.tbSes_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbSes);
            this.groupBox1.Controls.Add(this.lblErr);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 164);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tbSes)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblErr;
        private System.Windows.Forms.TrackBar tbSes;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

