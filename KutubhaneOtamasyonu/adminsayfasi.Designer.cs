
namespace KutubhaneOtamasyonu
{
    partial class adminsayfasi
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
            this.groupBox_uyeislemleri = new System.Windows.Forms.GroupBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_guncelle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.txt_yetki = new System.Windows.Forms.TextBox();
            this.lbl_yetki = new System.Windows.Forms.Label();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_kullanciadi = new System.Windows.Forms.TextBox();
            this.lbl_kullanciadi = new System.Windows.Forms.Label();
            this.lbl_olusturmatarihi = new System.Windows.Forms.Label();
            this.txt_soyisim = new System.Windows.Forms.TextBox();
            this.lbl_soyisim = new System.Windows.Forms.Label();
            this.txt_isim = new System.Windows.Forms.TextBox();
            this.lbl_isim = new System.Windows.Forms.Label();
            this.txtb_id = new System.Windows.Forms.TextBox();
            this.lbl_id = new System.Windows.Forms.Label();
            this.lbl_uyeler = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyisim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.olusturmatarihi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kullanciadi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yetki = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox_uyeislemleri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox_uyeislemleri
            // 
            this.groupBox_uyeislemleri.Controls.Add(this.maskedTextBox1);
            this.groupBox_uyeislemleri.Controls.Add(this.btn_temizle);
            this.groupBox_uyeislemleri.Controls.Add(this.btn_guncelle);
            this.groupBox_uyeislemleri.Controls.Add(this.btn_sil);
            this.groupBox_uyeislemleri.Controls.Add(this.btn_ekle);
            this.groupBox_uyeislemleri.Controls.Add(this.txt_yetki);
            this.groupBox_uyeislemleri.Controls.Add(this.lbl_yetki);
            this.groupBox_uyeislemleri.Controls.Add(this.txt_sifre);
            this.groupBox_uyeislemleri.Controls.Add(this.lbl_sifre);
            this.groupBox_uyeislemleri.Controls.Add(this.txt_kullanciadi);
            this.groupBox_uyeislemleri.Controls.Add(this.lbl_kullanciadi);
            this.groupBox_uyeislemleri.Controls.Add(this.lbl_olusturmatarihi);
            this.groupBox_uyeislemleri.Controls.Add(this.txt_soyisim);
            this.groupBox_uyeislemleri.Controls.Add(this.lbl_soyisim);
            this.groupBox_uyeislemleri.Controls.Add(this.txt_isim);
            this.groupBox_uyeislemleri.Controls.Add(this.lbl_isim);
            this.groupBox_uyeislemleri.Controls.Add(this.txtb_id);
            this.groupBox_uyeislemleri.Controls.Add(this.lbl_id);
            this.groupBox_uyeislemleri.Location = new System.Drawing.Point(27, 12);
            this.groupBox_uyeislemleri.Name = "groupBox_uyeislemleri";
            this.groupBox_uyeislemleri.Size = new System.Drawing.Size(235, 385);
            this.groupBox_uyeislemleri.TabIndex = 0;
            this.groupBox_uyeislemleri.TabStop = false;
            this.groupBox_uyeislemleri.Text = "uye islemleri";
            this.groupBox_uyeislemleri.Enter += new System.EventHandler(this.groupBox_uyeislemleri_Enter);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(78, 100);
            this.maskedTextBox1.Mask = "00/00/0000 90:0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 19);
            this.maskedTextBox1.TabIndex = 3;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(18, 299);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(190, 23);
            this.btn_temizle.TabIndex = 2;
            this.btn_temizle.Text = "temizle";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_guncelle
            // 
            this.btn_guncelle.Location = new System.Drawing.Point(18, 270);
            this.btn_guncelle.Name = "btn_guncelle";
            this.btn_guncelle.Size = new System.Drawing.Size(190, 23);
            this.btn_guncelle.TabIndex = 2;
            this.btn_guncelle.Text = "guncelle";
            this.btn_guncelle.UseVisualStyleBackColor = true;
            this.btn_guncelle.Click += new System.EventHandler(this.btn_guncelle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.Location = new System.Drawing.Point(18, 241);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(190, 23);
            this.btn_sil.TabIndex = 2;
            this.btn_sil.Text = "sil";
            this.btn_sil.UseVisualStyleBackColor = true;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // btn_ekle
            // 
            this.btn_ekle.Location = new System.Drawing.Point(18, 212);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(190, 23);
            this.btn_ekle.TabIndex = 2;
            this.btn_ekle.Text = "ekle";
            this.btn_ekle.UseVisualStyleBackColor = true;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // txt_yetki
            // 
            this.txt_yetki.Location = new System.Drawing.Point(78, 172);
            this.txt_yetki.Name = "txt_yetki";
            this.txt_yetki.Size = new System.Drawing.Size(100, 19);
            this.txt_yetki.TabIndex = 1;
            // 
            // lbl_yetki
            // 
            this.lbl_yetki.AutoSize = true;
            this.lbl_yetki.Location = new System.Drawing.Point(16, 179);
            this.lbl_yetki.Name = "lbl_yetki";
            this.lbl_yetki.Size = new System.Drawing.Size(32, 12);
            this.lbl_yetki.TabIndex = 0;
            this.lbl_yetki.Text = "yetki:";
            // 
            // txt_sifre
            // 
            this.txt_sifre.Location = new System.Drawing.Point(78, 147);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(100, 19);
            this.txt_sifre.TabIndex = 1;
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Location = new System.Drawing.Point(16, 154);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(30, 12);
            this.lbl_sifre.TabIndex = 0;
            this.lbl_sifre.Text = "sifre:";
            // 
            // txt_kullanciadi
            // 
            this.txt_kullanciadi.Location = new System.Drawing.Point(78, 122);
            this.txt_kullanciadi.Name = "txt_kullanciadi";
            this.txt_kullanciadi.Size = new System.Drawing.Size(100, 19);
            this.txt_kullanciadi.TabIndex = 1;
            // 
            // lbl_kullanciadi
            // 
            this.lbl_kullanciadi.AutoSize = true;
            this.lbl_kullanciadi.Location = new System.Drawing.Point(16, 125);
            this.lbl_kullanciadi.Name = "lbl_kullanciadi";
            this.lbl_kullanciadi.Size = new System.Drawing.Size(59, 12);
            this.lbl_kullanciadi.TabIndex = 0;
            this.lbl_kullanciadi.Text = "kullanciadi";
            this.lbl_kullanciadi.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_olusturmatarihi
            // 
            this.lbl_olusturmatarihi.AutoSize = true;
            this.lbl_olusturmatarihi.Location = new System.Drawing.Point(16, 100);
            this.lbl_olusturmatarihi.Name = "lbl_olusturmatarihi";
            this.lbl_olusturmatarihi.Size = new System.Drawing.Size(50, 12);
            this.lbl_olusturmatarihi.TabIndex = 0;
            this.lbl_olusturmatarihi.Text = "olustur t:";
            this.lbl_olusturmatarihi.Click += new System.EventHandler(this.label3_Click);
            // 
            // txt_soyisim
            // 
            this.txt_soyisim.Location = new System.Drawing.Point(78, 72);
            this.txt_soyisim.Name = "txt_soyisim";
            this.txt_soyisim.Size = new System.Drawing.Size(100, 19);
            this.txt_soyisim.TabIndex = 1;
            // 
            // lbl_soyisim
            // 
            this.lbl_soyisim.AutoSize = true;
            this.lbl_soyisim.Location = new System.Drawing.Point(16, 75);
            this.lbl_soyisim.Name = "lbl_soyisim";
            this.lbl_soyisim.Size = new System.Drawing.Size(46, 12);
            this.lbl_soyisim.TabIndex = 0;
            this.lbl_soyisim.Text = "soyisim:";
            // 
            // txt_isim
            // 
            this.txt_isim.Location = new System.Drawing.Point(78, 47);
            this.txt_isim.Name = "txt_isim";
            this.txt_isim.Size = new System.Drawing.Size(100, 19);
            this.txt_isim.TabIndex = 1;
            // 
            // lbl_isim
            // 
            this.lbl_isim.AutoSize = true;
            this.lbl_isim.Location = new System.Drawing.Point(16, 50);
            this.lbl_isim.Name = "lbl_isim";
            this.lbl_isim.Size = new System.Drawing.Size(28, 12);
            this.lbl_isim.TabIndex = 0;
            this.lbl_isim.Text = "isim:";
            // 
            // txtb_id
            // 
            this.txtb_id.Location = new System.Drawing.Point(78, 22);
            this.txtb_id.Name = "txtb_id";
            this.txtb_id.Size = new System.Drawing.Size(100, 19);
            this.txtb_id.TabIndex = 1;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(16, 25);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(16, 12);
            this.lbl_id.TabIndex = 0;
            this.lbl_id.Text = "id:";
            this.lbl_id.Click += new System.EventHandler(this.lbl_id_Click);
            // 
            // lbl_uyeler
            // 
            this.lbl_uyeler.AutoSize = true;
            this.lbl_uyeler.Font = new System.Drawing.Font("MS UI Gothic", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lbl_uyeler.Location = new System.Drawing.Point(379, 12);
            this.lbl_uyeler.Name = "lbl_uyeler";
            this.lbl_uyeler.Size = new System.Drawing.Size(76, 19);
            this.lbl_uyeler.TabIndex = 1;
            this.lbl_uyeler.Text = "UYELER";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.isim,
            this.soyisim,
            this.olusturmatarihi,
            this.kullanciadi,
            this.sifre,
            this.yetki});
            this.dataGridView1.Location = new System.Drawing.Point(268, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 21;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(592, 189);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // isim
            // 
            this.isim.HeaderText = "isim";
            this.isim.Name = "isim";
            // 
            // soyisim
            // 
            this.soyisim.HeaderText = "soyisim";
            this.soyisim.Name = "soyisim";
            // 
            // olusturmatarihi
            // 
            this.olusturmatarihi.HeaderText = "olusturmatarihi";
            this.olusturmatarihi.Name = "olusturmatarihi";
            // 
            // kullanciadi
            // 
            this.kullanciadi.HeaderText = "kullanciadi";
            this.kullanciadi.Name = "kullanciadi";
            // 
            // sifre
            // 
            this.sifre.HeaderText = "sifre";
            this.sifre.Name = "sifre";
            // 
            // yetki
            // 
            this.yetki.HeaderText = "yetki";
            this.yetki.Name = "yetki";
            // 
            // adminsayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 497);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lbl_uyeler);
            this.Controls.Add(this.groupBox_uyeislemleri);
            this.Name = "adminsayfasi";
            this.Text = "adminsayfasi";
            this.Load += new System.EventHandler(this.adminsayfasi_Load);
            this.groupBox_uyeislemleri.ResumeLayout(false);
            this.groupBox_uyeislemleri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox_uyeislemleri;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_kullanciadi;
        private System.Windows.Forms.Label lbl_kullanciadi;
        private System.Windows.Forms.Label lbl_olusturmatarihi;
        private System.Windows.Forms.TextBox txt_soyisim;
        private System.Windows.Forms.Label lbl_soyisim;
        private System.Windows.Forms.TextBox txt_isim;
        private System.Windows.Forms.Label lbl_isim;
        private System.Windows.Forms.TextBox txtb_id;
        private System.Windows.Forms.Label lbl_id;
        private System.Windows.Forms.TextBox txt_yetki;
        private System.Windows.Forms.Label lbl_yetki;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_guncelle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.Label lbl_uyeler;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn isim;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyisim;
        private System.Windows.Forms.DataGridViewTextBoxColumn olusturmatarihi;
        private System.Windows.Forms.DataGridViewTextBoxColumn kullanciadi;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifre;
        private System.Windows.Forms.DataGridViewTextBoxColumn yetki;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}