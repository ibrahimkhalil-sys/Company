
namespace GroupBoxnesnesi
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
            this.groupBox_kayit = new System.Windows.Forms.GroupBox();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.textBox_isim = new System.Windows.Forms.TextBox();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.textBox_soyisim = new System.Windows.Forms.TextBox();
            this.lbl_telnom = new System.Windows.Forms.Label();
            this.textBox_tel = new System.Windows.Forms.TextBox();
            this.lbl_emeil = new System.Windows.Forms.Label();
            this.textBox_emeil = new System.Windows.Forms.TextBox();
            this.radioButton_erkek = new System.Windows.Forms.RadioButton();
            this.radioButton_kadin = new System.Windows.Forms.RadioButton();
            this.lbl_hobi = new System.Windows.Forms.Label();
            this.checkBox_kiab = new System.Windows.Forms.CheckBox();
            this.checkBox_yuzmek = new System.Windows.Forms.CheckBox();
            this.checkBox_ucurtma = new System.Windows.Forms.CheckBox();
            this.button_ekle = new System.Windows.Forms.Button();
            this.groupBox_kayit.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox_kayit
            // 
            this.groupBox_kayit.Controls.Add(this.button_ekle);
            this.groupBox_kayit.Controls.Add(this.checkBox_ucurtma);
            this.groupBox_kayit.Controls.Add(this.checkBox_yuzmek);
            this.groupBox_kayit.Controls.Add(this.checkBox_kiab);
            this.groupBox_kayit.Controls.Add(this.radioButton_kadin);
            this.groupBox_kayit.Controls.Add(this.radioButton_erkek);
            this.groupBox_kayit.Controls.Add(this.textBox_emeil);
            this.groupBox_kayit.Controls.Add(this.textBox_tel);
            this.groupBox_kayit.Controls.Add(this.textBox_soyisim);
            this.groupBox_kayit.Controls.Add(this.lbl_hobi);
            this.groupBox_kayit.Controls.Add(this.lbl_emeil);
            this.groupBox_kayit.Controls.Add(this.lbl_telnom);
            this.groupBox_kayit.Controls.Add(this.lbl_soyisim);
            this.groupBox_kayit.Controls.Add(this.textBox_isim);
            this.groupBox_kayit.Controls.Add(this.lbl_isim);
            this.groupBox_kayit.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox_kayit.Location = new System.Drawing.Point(116, 62);
            this.groupBox_kayit.Name = "groupBox_kayit";
            this.groupBox_kayit.Size = new System.Drawing.Size(268, 347);
            this.groupBox_kayit.TabIndex = 0;
            this.groupBox_kayit.TabStop = false;
            this.groupBox_kayit.Text = "yeni kayit";
            this.groupBox_kayit.Enter += new System.EventHandler(this.groupBox_kayit_Enter);
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(17, 38);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(37, 16);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "isim";
            this.lbl_isim.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_isim
            // 
            this.textBox_isim.Location = new System.Drawing.Point(78, 35);
            this.textBox_isim.Name = "textBox_isim";
            this.textBox_isim.Size = new System.Drawing.Size(100, 23);
            this.textBox_isim.TabIndex = 1;
            this.textBox_isim.TextChanged += new System.EventHandler(this.textBox_isim_TextChanged);
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(17, 67);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(63, 16);
            this.lbl_soyisim.TabIndex = 0;
            this.lbl_soyisim.Text = "soyisim";
            this.lbl_soyisim.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_soyisim
            // 
            this.textBox_soyisim.Location = new System.Drawing.Point(78, 64);
            this.textBox_soyisim.Name = "textBox_soyisim";
            this.textBox_soyisim.Size = new System.Drawing.Size(100, 23);
            this.textBox_soyisim.TabIndex = 1;
            // 
            // lbl_telnom
            // 
            this.lbl_telnom.AutoSize = true;
            this.lbl_telnom.Location = new System.Drawing.Point(17, 99);
            this.lbl_telnom.Name = "lbl_telnom";
            this.lbl_telnom.Size = new System.Drawing.Size(65, 16);
            this.lbl_telnom.TabIndex = 0;
            this.lbl_telnom.Text = "tel nom";
            this.lbl_telnom.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_tel
            // 
            this.textBox_tel.Location = new System.Drawing.Point(78, 96);
            this.textBox_tel.Name = "textBox_tel";
            this.textBox_tel.Size = new System.Drawing.Size(100, 23);
            this.textBox_tel.TabIndex = 1;
            // 
            // lbl_emeil
            // 
            this.lbl_emeil.AutoSize = true;
            this.lbl_emeil.Location = new System.Drawing.Point(17, 134);
            this.lbl_emeil.Name = "lbl_emeil";
            this.lbl_emeil.Size = new System.Drawing.Size(47, 16);
            this.lbl_emeil.TabIndex = 0;
            this.lbl_emeil.Text = "email";
            this.lbl_emeil.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox_emeil
            // 
            this.textBox_emeil.Location = new System.Drawing.Point(78, 131);
            this.textBox_emeil.Name = "textBox_emeil";
            this.textBox_emeil.Size = new System.Drawing.Size(100, 23);
            this.textBox_emeil.TabIndex = 1;
            // 
            // radioButton_erkek
            // 
            this.radioButton_erkek.AutoSize = true;
            this.radioButton_erkek.Location = new System.Drawing.Point(23, 251);
            this.radioButton_erkek.Name = "radioButton_erkek";
            this.radioButton_erkek.Size = new System.Drawing.Size(67, 20);
            this.radioButton_erkek.TabIndex = 2;
            this.radioButton_erkek.TabStop = true;
            this.radioButton_erkek.Text = "erkek";
            this.radioButton_erkek.UseVisualStyleBackColor = true;
            // 
            // radioButton_kadin
            // 
            this.radioButton_kadin.AutoSize = true;
            this.radioButton_kadin.Location = new System.Drawing.Point(96, 251);
            this.radioButton_kadin.Name = "radioButton_kadin";
            this.radioButton_kadin.Size = new System.Drawing.Size(65, 20);
            this.radioButton_kadin.TabIndex = 2;
            this.radioButton_kadin.TabStop = true;
            this.radioButton_kadin.Text = "kadin";
            this.radioButton_kadin.UseVisualStyleBackColor = true;
            // 
            // lbl_hobi
            // 
            this.lbl_hobi.AutoSize = true;
            this.lbl_hobi.Location = new System.Drawing.Point(17, 172);
            this.lbl_hobi.Name = "lbl_hobi";
            this.lbl_hobi.Size = new System.Drawing.Size(59, 16);
            this.lbl_hobi.TabIndex = 0;
            this.lbl_hobi.Text = "hobiler";
            this.lbl_hobi.Click += new System.EventHandler(this.label1_Click);
            // 
            // checkBox_kiab
            // 
            this.checkBox_kiab.AutoSize = true;
            this.checkBox_kiab.Location = new System.Drawing.Point(78, 168);
            this.checkBox_kiab.Name = "checkBox_kiab";
            this.checkBox_kiab.Size = new System.Drawing.Size(126, 20);
            this.checkBox_kiab.TabIndex = 3;
            this.checkBox_kiab.Text = "kitab okumak";
            this.checkBox_kiab.UseVisualStyleBackColor = true;
            this.checkBox_kiab.CheckedChanged += new System.EventHandler(this.checkBox_kiab_CheckedChanged);
            // 
            // checkBox_yuzmek
            // 
            this.checkBox_yuzmek.AutoSize = true;
            this.checkBox_yuzmek.Location = new System.Drawing.Point(78, 199);
            this.checkBox_yuzmek.Name = "checkBox_yuzmek";
            this.checkBox_yuzmek.Size = new System.Drawing.Size(83, 20);
            this.checkBox_yuzmek.TabIndex = 3;
            this.checkBox_yuzmek.Text = "yuzmek";
            this.checkBox_yuzmek.UseVisualStyleBackColor = true;
            this.checkBox_yuzmek.CheckedChanged += new System.EventHandler(this.checkBox_kiab_CheckedChanged);
            // 
            // checkBox_ucurtma
            // 
            this.checkBox_ucurtma.AutoSize = true;
            this.checkBox_ucurtma.Location = new System.Drawing.Point(78, 225);
            this.checkBox_ucurtma.Name = "checkBox_ucurtma";
            this.checkBox_ucurtma.Size = new System.Drawing.Size(167, 20);
            this.checkBox_ucurtma.TabIndex = 3;
            this.checkBox_ucurtma.Text = "ucurtma ucurtmak";
            this.checkBox_ucurtma.UseVisualStyleBackColor = true;
            this.checkBox_ucurtma.CheckedChanged += new System.EventHandler(this.checkBox_kiab_CheckedChanged);
            // 
            // button_ekle
            // 
            this.button_ekle.Location = new System.Drawing.Point(44, 302);
            this.button_ekle.Name = "button_ekle";
            this.button_ekle.Size = new System.Drawing.Size(146, 29);
            this.button_ekle.TabIndex = 5;
            this.button_ekle.Text = "ekle";
            this.button_ekle.UseVisualStyleBackColor = true;
            this.button_ekle.Click += new System.EventHandler(this.button_ekle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 432);
            this.Controls.Add(this.groupBox_kayit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.groupBox_kayit.ResumeLayout(false);
            this.groupBox_kayit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_kayit;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox textBox_emeil;
        private System.Windows.Forms.TextBox textBox_tel;
        private System.Windows.Forms.TextBox textBox_soyisim;
        private System.Windows.Forms.Label lbl_emeil;
        private System.Windows.Forms.Label lbl_telnom;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.TextBox textBox_isim;
        private System.Windows.Forms.RadioButton radioButton_kadin;
        private System.Windows.Forms.RadioButton radioButton_erkek;
        private System.Windows.Forms.CheckBox checkBox_kiab;
        private System.Windows.Forms.Label lbl_hobi;
        private System.Windows.Forms.CheckBox checkBox_yuzmek;
        private System.Windows.Forms.CheckBox checkBox_ucurtma;
        private System.Windows.Forms.Button button_ekle;
    }
}

