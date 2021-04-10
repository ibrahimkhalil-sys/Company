
namespace ComboboxNesnesi
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
            this.combo_gunler = new System.Windows.Forms.ComboBox();
            this.btn_gunsec = new System.Windows.Forms.Button();
            this.lbl_gun = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // combo_gunler
            // 
            this.combo_gunler.FormattingEnabled = true;
            this.combo_gunler.Items.AddRange(new object[] {
            "pazarertesi",
            "sali",
            "carsanba",
            "persenbe"});
            this.combo_gunler.Location = new System.Drawing.Point(112, 22);
            this.combo_gunler.Name = "combo_gunler";
            this.combo_gunler.Size = new System.Drawing.Size(121, 20);
            this.combo_gunler.TabIndex = 0;
            // 
            // btn_gunsec
            // 
            this.btn_gunsec.Location = new System.Drawing.Point(112, 63);
            this.btn_gunsec.Name = "btn_gunsec";
            this.btn_gunsec.Size = new System.Drawing.Size(75, 23);
            this.btn_gunsec.TabIndex = 1;
            this.btn_gunsec.Text = "gunsec";
            this.btn_gunsec.UseVisualStyleBackColor = true;
            this.btn_gunsec.Click += new System.EventHandler(this.btn_gunsec_Click);
            // 
            // lbl_gun
            // 
            this.lbl_gun.AutoSize = true;
            this.lbl_gun.Location = new System.Drawing.Point(32, 29);
            this.lbl_gun.Name = "lbl_gun";
            this.lbl_gun.Size = new System.Drawing.Size(62, 12);
            this.lbl_gun.TabIndex = 2;
            this.lbl_gun.Text = "gun seciniz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 277);
            this.Controls.Add(this.lbl_gun);
            this.Controls.Add(this.btn_gunsec);
            this.Controls.Add(this.combo_gunler);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combo_gunler;
        private System.Windows.Forms.Button btn_gunsec;
        private System.Windows.Forms.Label lbl_gun;
    }
}

