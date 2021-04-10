
namespace LinkLabelnesnesi
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
            this.linkLabel_tikla = new System.Windows.Forms.LinkLabel();
            this.lbl_google = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // linkLabel_tikla
            // 
            this.linkLabel_tikla.AutoSize = true;
            this.linkLabel_tikla.Location = new System.Drawing.Point(120, 74);
            this.linkLabel_tikla.Name = "linkLabel_tikla";
            this.linkLabel_tikla.Size = new System.Drawing.Size(27, 12);
            this.linkLabel_tikla.TabIndex = 0;
            this.linkLabel_tikla.TabStop = true;
            this.linkLabel_tikla.Text = "tikla";
            this.linkLabel_tikla.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_tikla_LinkClicked);
            // 
            // lbl_google
            // 
            this.lbl_google.AutoSize = true;
            this.lbl_google.Location = new System.Drawing.Point(16, 74);
            this.lbl_google.Name = "lbl_google";
            this.lbl_google.Size = new System.Drawing.Size(98, 12);
            this.lbl_google.TabIndex = 1;
            this.lbl_google.Text = "google gitmek icin";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_google);
            this.Controls.Add(this.linkLabel_tikla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel linkLabel_tikla;
        private System.Windows.Forms.Label lbl_google;
    }
}

