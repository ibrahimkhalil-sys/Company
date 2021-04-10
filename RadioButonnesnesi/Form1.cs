using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButonnesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_yazdir_Click(object sender, EventArgs e)
        {
            string ad, soyad, cinsiyet = "";

            ad = txt_ad.Text;
            soyad = txt_soyad.Text;
            if (radioButton_erkek.Checked)
            {
                cinsiyet = "erkek";
            }
            else
            {
                cinsiyet = "kadin";
            }
            MessageBox.Show("adiniz soyadiniz:" + ad + "" + soyad + "\n" + "cinsiyet" + cinsiyet);
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
