
namespace PictureBoxnesnesi
{
    partial class anasayfa
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
            this.lbl_hosgeldin = new System.Windows.Forms.Label();
            this.lbl_deger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_hosgeldin
            // 
            this.lbl_hosgeldin.AutoSize = true;
            this.lbl_hosgeldin.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_hosgeldin.Location = new System.Drawing.Point(76, 48);
            this.lbl_hosgeldin.Name = "lbl_hosgeldin";
            this.lbl_hosgeldin.Size = new System.Drawing.Size(89, 16);
            this.lbl_hosgeldin.TabIndex = 0;
            this.lbl_hosgeldin.Text = "hosgeldiniz";
            // 
            // lbl_deger
            // 
            this.lbl_deger.AutoSize = true;
            this.lbl_deger.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_deger.Location = new System.Drawing.Point(171, 48);
            this.lbl_deger.Name = "lbl_deger";
            this.lbl_deger.Size = new System.Drawing.Size(12, 16);
            this.lbl_deger.TabIndex = 0;
            this.lbl_deger.Text = ".";
            this.lbl_deger.Click += new System.EventHandler(this.lbl_deger_Click);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 240);
            this.Controls.Add(this.lbl_deger);
            this.Controls.Add(this.lbl_hosgeldin);
            this.Name = "anasayfa";
            this.Text = "anasayfa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_hosgeldin;
        public System.Windows.Forms.Label lbl_deger;
    }
}