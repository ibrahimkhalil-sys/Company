
namespace TabbControlnesnesi
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.anasayfa = new System.Windows.Forms.TabPage();
            this.uyelik = new System.Windows.Forms.TabPage();
            this.ayarlar = new System.Windows.Forms.TabPage();
            this.lbl_anasayfa = new System.Windows.Forms.Label();
            this.lbl_uyelik = new System.Windows.Forms.Label();
            this.lbl_ayar = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.anasayfa.SuspendLayout();
            this.uyelik.SuspendLayout();
            this.ayarlar.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.uyelik);
            this.tabControl1.Controls.Add(this.anasayfa);
            this.tabControl1.Controls.Add(this.ayarlar);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // anasayfa
            // 
            this.anasayfa.Controls.Add(this.lbl_anasayfa);
            this.anasayfa.Location = new System.Drawing.Point(4, 22);
            this.anasayfa.Name = "anasayfa";
            this.anasayfa.Padding = new System.Windows.Forms.Padding(3);
            this.anasayfa.Size = new System.Drawing.Size(792, 424);
            this.anasayfa.TabIndex = 0;
            this.anasayfa.Text = "anasayfa";
            this.anasayfa.UseVisualStyleBackColor = true;
            this.anasayfa.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // uyelik
            // 
            this.uyelik.Controls.Add(this.lbl_uyelik);
            this.uyelik.Location = new System.Drawing.Point(4, 22);
            this.uyelik.Name = "uyelik";
            this.uyelik.Padding = new System.Windows.Forms.Padding(3);
            this.uyelik.Size = new System.Drawing.Size(792, 424);
            this.uyelik.TabIndex = 1;
            this.uyelik.Text = "uyelik islemleri";
            this.uyelik.UseVisualStyleBackColor = true;
            // 
            // ayarlar
            // 
            this.ayarlar.Controls.Add(this.lbl_ayar);
            this.ayarlar.Location = new System.Drawing.Point(4, 22);
            this.ayarlar.Name = "ayarlar";
            this.ayarlar.Size = new System.Drawing.Size(792, 424);
            this.ayarlar.TabIndex = 2;
            this.ayarlar.Text = "ayarlar";
            this.ayarlar.UseVisualStyleBackColor = true;
            // 
            // lbl_anasayfa
            // 
            this.lbl_anasayfa.AutoSize = true;
            this.lbl_anasayfa.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_anasayfa.Location = new System.Drawing.Point(101, 65);
            this.lbl_anasayfa.Name = "lbl_anasayfa";
            this.lbl_anasayfa.Size = new System.Drawing.Size(146, 20);
            this.lbl_anasayfa.TabIndex = 0;
            this.lbl_anasayfa.Text = "burasi ana sayfa";
            // 
            // lbl_uyelik
            // 
            this.lbl_uyelik.AutoSize = true;
            this.lbl_uyelik.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_uyelik.Location = new System.Drawing.Point(44, 53);
            this.lbl_uyelik.Name = "lbl_uyelik";
            this.lbl_uyelik.Size = new System.Drawing.Size(185, 20);
            this.lbl_uyelik.TabIndex = 0;
            this.lbl_uyelik.Text = "burasi uyelik islemleri";
            // 
            // lbl_ayar
            // 
            this.lbl_ayar.AutoSize = true;
            this.lbl_ayar.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_ayar.Location = new System.Drawing.Point(42, 41);
            this.lbl_ayar.Name = "lbl_ayar";
            this.lbl_ayar.Size = new System.Drawing.Size(123, 20);
            this.lbl_ayar.TabIndex = 0;
            this.lbl_ayar.Text = "burasi ayarlar";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.anasayfa.ResumeLayout(false);
            this.anasayfa.PerformLayout();
            this.uyelik.ResumeLayout(false);
            this.uyelik.PerformLayout();
            this.ayarlar.ResumeLayout(false);
            this.ayarlar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage anasayfa;
        private System.Windows.Forms.TabPage uyelik;
        private System.Windows.Forms.Label lbl_uyelik;
        private System.Windows.Forms.Label lbl_anasayfa;
        private System.Windows.Forms.TabPage ayarlar;
        private System.Windows.Forms.Label lbl_ayar;
    }
}

