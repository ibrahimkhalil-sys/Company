
namespace CheckBoxkullanimi
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
            this.checkBox_cay = new System.Windows.Forms.CheckBox();
            this.checkBox_kahve = new System.Windows.Forms.CheckBox();
            this.checkBox_hamburger = new System.Windows.Forms.CheckBox();
            this.checkBox_pizza = new System.Windows.Forms.CheckBox();
            this.lbl_tutar = new System.Windows.Forms.Label();
            this.lbl_tutarlar = new System.Windows.Forms.Label();
            this.btn_hesap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkBox_cay
            // 
            this.checkBox_cay.AutoSize = true;
            this.checkBox_cay.Location = new System.Drawing.Point(85, 55);
            this.checkBox_cay.Name = "checkBox_cay";
            this.checkBox_cay.Size = new System.Drawing.Size(59, 16);
            this.checkBox_cay.TabIndex = 0;
            this.checkBox_cay.Text = "cay 1tl";
            this.checkBox_cay.UseVisualStyleBackColor = true;
            // 
            // checkBox_kahve
            // 
            this.checkBox_kahve.AutoSize = true;
            this.checkBox_kahve.Location = new System.Drawing.Point(85, 77);
            this.checkBox_kahve.Name = "checkBox_kahve";
            this.checkBox_kahve.Size = new System.Drawing.Size(71, 16);
            this.checkBox_kahve.TabIndex = 0;
            this.checkBox_kahve.Text = "kahve 3tl";
            this.checkBox_kahve.UseVisualStyleBackColor = true;
            // 
            // checkBox_hamburger
            // 
            this.checkBox_hamburger.AutoSize = true;
            this.checkBox_hamburger.Location = new System.Drawing.Point(85, 99);
            this.checkBox_hamburger.Name = "checkBox_hamburger";
            this.checkBox_hamburger.Size = new System.Drawing.Size(100, 16);
            this.checkBox_hamburger.TabIndex = 0;
            this.checkBox_hamburger.Text = "hamburger 10tl";
            this.checkBox_hamburger.UseVisualStyleBackColor = true;
            // 
            // checkBox_pizza
            // 
            this.checkBox_pizza.AutoSize = true;
            this.checkBox_pizza.Location = new System.Drawing.Point(85, 121);
            this.checkBox_pizza.Name = "checkBox_pizza";
            this.checkBox_pizza.Size = new System.Drawing.Size(72, 16);
            this.checkBox_pizza.TabIndex = 0;
            this.checkBox_pizza.Text = "pizza 20tl";
            this.checkBox_pizza.UseVisualStyleBackColor = true;
            this.checkBox_pizza.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // lbl_tutar
            // 
            this.lbl_tutar.AutoSize = true;
            this.lbl_tutar.Location = new System.Drawing.Point(213, 45);
            this.lbl_tutar.Name = "lbl_tutar";
            this.lbl_tutar.Size = new System.Drawing.Size(29, 12);
            this.lbl_tutar.TabIndex = 1;
            this.lbl_tutar.Text = "tutar";
            // 
            // lbl_tutarlar
            // 
            this.lbl_tutarlar.AutoSize = true;
            this.lbl_tutarlar.Location = new System.Drawing.Point(259, 45);
            this.lbl_tutarlar.Name = "lbl_tutarlar";
            this.lbl_tutarlar.Size = new System.Drawing.Size(18, 12);
            this.lbl_tutarlar.TabIndex = 1;
            this.lbl_tutarlar.Text = "0tl";
            // 
            // btn_hesap
            // 
            this.btn_hesap.Location = new System.Drawing.Point(85, 157);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(75, 23);
            this.btn_hesap.TabIndex = 2;
            this.btn_hesap.Text = "hesap";
            this.btn_hesap.UseVisualStyleBackColor = true;
            this.btn_hesap.Click += new System.EventHandler(this.btn_hesap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_hesap);
            this.Controls.Add(this.lbl_tutarlar);
            this.Controls.Add(this.lbl_tutar);
            this.Controls.Add(this.checkBox_pizza);
            this.Controls.Add(this.checkBox_hamburger);
            this.Controls.Add(this.checkBox_kahve);
            this.Controls.Add(this.checkBox_cay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_cay;
        private System.Windows.Forms.CheckBox checkBox_kahve;
        private System.Windows.Forms.CheckBox checkBox_hamburger;
        private System.Windows.Forms.CheckBox checkBox_pizza;
        private System.Windows.Forms.Label lbl_tutar;
        private System.Windows.Forms.Label lbl_tutarlar;
        private System.Windows.Forms.Button btn_hesap;
    }
}

