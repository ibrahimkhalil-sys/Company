
namespace DLLkulanimi
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
            this.txt_sayibir = new System.Windows.Forms.TextBox();
            this.txt_sayiiki = new System.Windows.Forms.TextBox();
            this.lbl_sayi = new System.Windows.Forms.Label();
            this.btn_toplama = new System.Windows.Forms.Button();
            this.btn_bolma = new System.Windows.Forms.Button();
            this.btn_carpma = new System.Windows.Forms.Button();
            this.btn_cikma = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "1.sayiyi giriniz";
            // 
            // txt_sayibir
            // 
            this.txt_sayibir.Location = new System.Drawing.Point(176, 13);
            this.txt_sayibir.Name = "txt_sayibir";
            this.txt_sayibir.Size = new System.Drawing.Size(100, 19);
            this.txt_sayibir.TabIndex = 1;
            // 
            // txt_sayiiki
            // 
            this.txt_sayiiki.Location = new System.Drawing.Point(166, 50);
            this.txt_sayiiki.Name = "txt_sayiiki";
            this.txt_sayiiki.Size = new System.Drawing.Size(110, 19);
            this.txt_sayiiki.TabIndex = 3;
            this.txt_sayiiki.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // lbl_sayi
            // 
            this.lbl_sayi.AutoSize = true;
            this.lbl_sayi.Location = new System.Drawing.Point(65, 50);
            this.lbl_sayi.Name = "lbl_sayi";
            this.lbl_sayi.Size = new System.Drawing.Size(77, 12);
            this.lbl_sayi.TabIndex = 2;
            this.lbl_sayi.Text = "2.sayiyi giriniz";
            this.lbl_sayi.Click += new System.EventHandler(this.label2_Click);
            // 
            // btn_toplama
            // 
            this.btn_toplama.Location = new System.Drawing.Point(166, 97);
            this.btn_toplama.Name = "btn_toplama";
            this.btn_toplama.Size = new System.Drawing.Size(37, 23);
            this.btn_toplama.TabIndex = 4;
            this.btn_toplama.Text = "+";
            this.btn_toplama.UseVisualStyleBackColor = true;
            this.btn_toplama.Click += new System.EventHandler(this.btn_toplama_Click);
            // 
            // btn_bolma
            // 
            this.btn_bolma.Location = new System.Drawing.Point(353, 97);
            this.btn_bolma.Name = "btn_bolma";
            this.btn_bolma.Size = new System.Drawing.Size(37, 23);
            this.btn_bolma.TabIndex = 5;
            this.btn_bolma.Text = "/";
            this.btn_bolma.UseVisualStyleBackColor = true;
            this.btn_bolma.Click += new System.EventHandler(this.btn_bolma_Click);
            // 
            // btn_carpma
            // 
            this.btn_carpma.Location = new System.Drawing.Point(287, 97);
            this.btn_carpma.Name = "btn_carpma";
            this.btn_carpma.Size = new System.Drawing.Size(37, 23);
            this.btn_carpma.TabIndex = 6;
            this.btn_carpma.Text = "x";
            this.btn_carpma.UseVisualStyleBackColor = true;
            this.btn_carpma.Click += new System.EventHandler(this.btn_carpma_Click);
            // 
            // btn_cikma
            // 
            this.btn_cikma.Location = new System.Drawing.Point(226, 97);
            this.btn_cikma.Name = "btn_cikma";
            this.btn_cikma.Size = new System.Drawing.Size(37, 23);
            this.btn_cikma.TabIndex = 7;
            this.btn_cikma.Text = "-";
            this.btn_cikma.UseVisualStyleBackColor = true;
            this.btn_cikma.Click += new System.EventHandler(this.btn_cikma_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(76, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "sonuc";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(152, 77);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(11, 12);
            this.lbl_sonuc.TabIndex = 8;
            this.lbl_sonuc.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_sonuc);
            this.Controls.Add(this.btn_cikma);
            this.Controls.Add(this.btn_carpma);
            this.Controls.Add(this.btn_bolma);
            this.Controls.Add(this.btn_toplama);
            this.Controls.Add(this.txt_sayiiki);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_sayi);
            this.Controls.Add(this.txt_sayibir);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_sayibir;
        private System.Windows.Forms.TextBox txt_sayiiki;
        private System.Windows.Forms.Label lbl_sayi;
        private System.Windows.Forms.Button btn_toplama;
        private System.Windows.Forms.Button btn_bolma;
        private System.Windows.Forms.Button btn_carpma;
        private System.Windows.Forms.Button btn_cikma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

