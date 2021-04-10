using KutubhaneOtamasyonu.empty;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutubhaneOtamasyonu
{
    public partial class adminsayfasi : Form
    {
        List<kisi> kisilerim;
        public adminsayfasi(List<kisi>kisilerim)
        {
            InitializeComponent();
            this.kisilerim = kisilerim;
        }
      
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox_uyeislemleri_Enter(object sender, EventArgs e)
        {

        }

        private void adminsayfasi_Load(object sender, EventArgs e)
        {
            foreach (kisi kisi in kisilerim)
            {
                dataGridView1.Rows.Add(kisi.getid(), kisi.getisim(), kisi.getsoyisim(), kisi.getolusturmatarihi(), kisi.getkullanciadi(), kisi.getsifre(), kisi.getyetki());
            }
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add(Convert.ToInt32(txtb_id.Text), txt_isim.Text, txt_soyisim.Text,maskedTextBox1.Text, txt_kullanciadi.Text, txt_sifre.Text, txt_yetki.Text);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);

        }
        public void textleridoldur()
        {

            txtb_id.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txt_isim.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_soyisim.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_kullanciadi.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_sifre.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_yetki.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textleridoldur();
        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            string id = txtb_id.Text;
            string isim = txt_isim.Text;
            string soyisim = txt_soyisim.Text;
            string tarih = maskedTextBox1.Text;
            string kullanciadi = txt_kullanciadi.Text;
            string sifre = txt_sifre.Text;
            string yetki = txt_yetki.Text;

            dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            dataGridView1.Rows.Add(id,isim,soyisim,tarih,kullanciadi,sifre,yetki);
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < groupBox_uyeislemleri.Controls.Count; i++)
            {
                if (groupBox_uyeislemleri.Controls[i]is TextBox || groupBox_uyeislemleri.Controls[i]is MaskedTextBox)
                {
                    groupBox_uyeislemleri.Controls[i].Text = string.Empty;
                }
            }
        }

        private void lbl_id_Click(object sender, EventArgs e)
        {

        }
    }
}
