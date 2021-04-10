using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PictureBoxnesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = "";
            kullaniciadi = textBox_ad.Text;
            sifre = textBox_sifre.Text;
            if (kullaniciadi.ToLower()=="ibo" && sifre=="1234")
            {
                anasayfa ana = new anasayfa();
                ana.lbl_deger.Text = kullaniciadi.ToUpper();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("hatali giris", "error" , MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
