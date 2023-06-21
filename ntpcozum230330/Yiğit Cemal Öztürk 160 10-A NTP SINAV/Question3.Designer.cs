
namespace Yiğit_Cemal_Öztürk_160_10_A_NTP_SINAV
{
    partial class Question3
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNumber1 = new System.Windows.Forms.Button();
            this.btnNumber2 = new System.Windows.Forms.Button();
            this.btnNumber3 = new System.Windows.Forms.Button();
            this.btnOperand1 = new System.Windows.Forms.Button();
            this.btnOperand2 = new System.Windows.Forms.Button();
            this.btnOperation = new System.Windows.Forms.Button();
            this.btnPickColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(12, 110);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(113, 106);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "OYNA";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNumber1
            // 
            this.btnNumber1.BackColor = System.Drawing.Color.Red;
            this.btnNumber1.Location = new System.Drawing.Point(258, 12);
            this.btnNumber1.Name = "btnNumber1";
            this.btnNumber1.Size = new System.Drawing.Size(67, 66);
            this.btnNumber1.TabIndex = 1;
            this.btnNumber1.Text = "Sayı 1";
            this.btnNumber1.UseVisualStyleBackColor = false;
            // 
            // btnNumber2
            // 
            this.btnNumber2.BackColor = System.Drawing.Color.Yellow;
            this.btnNumber2.Location = new System.Drawing.Point(331, 12);
            this.btnNumber2.Name = "btnNumber2";
            this.btnNumber2.Size = new System.Drawing.Size(67, 66);
            this.btnNumber2.TabIndex = 2;
            this.btnNumber2.Text = "Sayı 2";
            this.btnNumber2.UseVisualStyleBackColor = false;
            // 
            // btnNumber3
            // 
            this.btnNumber3.BackColor = System.Drawing.Color.Blue;
            this.btnNumber3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNumber3.Location = new System.Drawing.Point(404, 12);
            this.btnNumber3.Name = "btnNumber3";
            this.btnNumber3.Size = new System.Drawing.Size(67, 66);
            this.btnNumber3.TabIndex = 3;
            this.btnNumber3.Text = "Sayı 3";
            this.btnNumber3.UseVisualStyleBackColor = false;
            // 
            // btnOperand1
            // 
            this.btnOperand1.Location = new System.Drawing.Point(221, 127);
            this.btnOperand1.Name = "btnOperand1";
            this.btnOperand1.Size = new System.Drawing.Size(104, 89);
            this.btnOperand1.TabIndex = 4;
            this.btnOperand1.UseVisualStyleBackColor = true;
            // 
            // btnOperand2
            // 
            this.btnOperand2.Location = new System.Drawing.Point(404, 127);
            this.btnOperand2.Name = "btnOperand2";
            this.btnOperand2.Size = new System.Drawing.Size(102, 89);
            this.btnOperand2.TabIndex = 5;
            this.btnOperand2.UseVisualStyleBackColor = true;
            // 
            // btnOperation
            // 
            this.btnOperation.Location = new System.Drawing.Point(331, 150);
            this.btnOperation.Name = "btnOperation";
            this.btnOperation.Size = new System.Drawing.Size(67, 43);
            this.btnOperation.TabIndex = 6;
            this.btnOperation.Text = "+";
            this.btnOperation.UseVisualStyleBackColor = true;
            // 
            // btnPickColor
            // 
            this.btnPickColor.Location = new System.Drawing.Point(538, 127);
            this.btnPickColor.Name = "btnPickColor";
            this.btnPickColor.Size = new System.Drawing.Size(154, 149);
            this.btnPickColor.TabIndex = 7;
            this.btnPickColor.Text = "RENK SEÇ";
            this.btnPickColor.UseVisualStyleBackColor = true;
            this.btnPickColor.Click += new System.EventHandler(this.btnPickColor_Click);
            // 
            // Question3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPickColor);
            this.Controls.Add(this.btnOperation);
            this.Controls.Add(this.btnOperand2);
            this.Controls.Add(this.btnOperand1);
            this.Controls.Add(this.btnNumber3);
            this.Controls.Add(this.btnNumber2);
            this.Controls.Add(this.btnNumber1);
            this.Controls.Add(this.btnPlay);
            this.Name = "Question3";
            this.Text = "Question3";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNumber1;
        private System.Windows.Forms.Button btnNumber2;
        private System.Windows.Forms.Button btnNumber3;
        private System.Windows.Forms.Button btnOperand1;
        private System.Windows.Forms.Button btnOperand2;
        private System.Windows.Forms.Button btnOperation;
        private System.Windows.Forms.Button btnPickColor;
    }
}