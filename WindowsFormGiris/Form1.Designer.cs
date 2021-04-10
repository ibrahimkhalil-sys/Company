
namespace WindowsFormGiris
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_birincinot = new System.Windows.Forms.TextBox();
            this.txt_ikincinot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_ortalamahesabla = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_ortalamasonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(122, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.ci notunuzu giriniz.";
            // 
            // txt_birincinot
            // 
            this.txt_birincinot.Location = new System.Drawing.Point(273, 36);
            this.txt_birincinot.Name = "txt_birincinot";
            this.txt_birincinot.Size = new System.Drawing.Size(100, 19);
            this.txt_birincinot.TabIndex = 1;
            // 
            // txt_ikincinot
            // 
            this.txt_ikincinot.Location = new System.Drawing.Point(273, 64);
            this.txt_ikincinot.Name = "txt_ikincinot";
            this.txt_ikincinot.Size = new System.Drawing.Size(100, 19);
            this.txt_ikincinot.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(122, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "2.ci notunuzu giriniz.";
            // 
            // btn_ortalamahesabla
            // 
            this.btn_ortalamahesabla.Location = new System.Drawing.Point(120, 98);
            this.btn_ortalamahesabla.Name = "btn_ortalamahesabla";
            this.btn_ortalamahesabla.Size = new System.Drawing.Size(131, 23);
            this.btn_ortalamahesabla.TabIndex = 4;
            this.btn_ortalamahesabla.Text = "ortalamayi bul.";
            this.btn_ortalamahesabla.UseVisualStyleBackColor = true;
            this.btn_ortalamahesabla.Click += new System.EventHandler(this.btn_ortalamahesabla_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(282, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "ortalama";
            // 
            // lbl_ortalamasonuc
            // 
            this.lbl_ortalamasonuc.AutoSize = true;
            this.lbl_ortalamasonuc.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_ortalamasonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ortalamasonuc.Location = new System.Drawing.Point(354, 106);
            this.lbl_ortalamasonuc.Name = "lbl_ortalamasonuc";
            this.lbl_ortalamasonuc.Size = new System.Drawing.Size(14, 15);
            this.lbl_ortalamasonuc.TabIndex = 6;
            this.lbl_ortalamasonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 340);
            this.Controls.Add(this.lbl_ortalamasonuc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_ortalamahesabla);
            this.Controls.Add(this.txt_ikincinot);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_birincinot);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_birincinot;
        private System.Windows.Forms.TextBox txt_ikincinot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_ortalamahesabla;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_ortalamasonuc;
    }
}

