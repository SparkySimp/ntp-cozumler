
namespace MerhabaDunya
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_kirmizi = new System.Windows.Forms.Button();
            this.btn_mavi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_kirmizi
            // 
            resources.ApplyResources(this.btn_kirmizi, "btn_kirmizi");
            this.btn_kirmizi.ForeColor = System.Drawing.Color.Blue;
            this.btn_kirmizi.Name = "btn_kirmizi";
            this.btn_kirmizi.UseVisualStyleBackColor = true;
            // 
            // btn_mavi
            // 
            resources.ApplyResources(this.btn_mavi, "btn_mavi");
            this.btn_mavi.ForeColor = System.Drawing.Color.Red;
            this.btn_mavi.Name = "btn_mavi";
            this.btn_mavi.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_mavi);
            this.Controls.Add(this.btn_kirmizi);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_kirmizi;
        private System.Windows.Forms.Button btn_mavi;
    }
}

