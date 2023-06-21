
namespace NTP_20221103_OR_2
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
            this.lbDonanim = new System.Windows.Forms.ListBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbDonanim
            // 
            this.lbDonanim.FormattingEnabled = true;
            this.lbDonanim.Items.AddRange(new object[] {
            "Mouse",
            "Yazıcı",
            "Klavye",
            "Kamera",
            "Tarayıcı",
            "Projeksiyon",
            "Hoparlör"});
            this.lbDonanim.Location = new System.Drawing.Point(12, 15);
            this.lbDonanim.Name = "lbDonanim";
            this.lbDonanim.Size = new System.Drawing.Size(163, 394);
            this.lbDonanim.TabIndex = 0;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(100, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(187, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.lbDonanim);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbDonanim;
        private System.Windows.Forms.Button btnOK;
    }
}

