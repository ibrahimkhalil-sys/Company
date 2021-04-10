using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Matemetik;
namespace DLLkulanimi
{
    public partial class Form1 : Form
    {
        matematikislemleri islemler = new matematikislemleri();
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_toplama_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayibir.Text);
            int sayi2 = Convert.ToInt32(txt_sayiiki.Text);
           int toplam= islemler.topla(sayi1, sayi2);
            lbl_sonuc.Text = toplam.ToString();
        }

        private void btn_cikma_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayibir.Text);
            int sayi2 = Convert.ToInt32(txt_sayiiki.Text);
            int cikma = islemler.cikarma(sayi1, sayi2);
            lbl_sonuc.Text = cikma.ToString();
        }

        private void btn_carpma_Click(object sender, EventArgs e)
        {
            int sayi1 = Convert.ToInt32(txt_sayibir.Text);
            int sayi2 = Convert.ToInt32(txt_sayiiki.Text);
            int carpma = islemler.carpma(sayi1, sayi2);
            lbl_sonuc.Text = carpma.ToString();

        }

        private void btn_bolma_Click(object sender, EventArgs e)
        {
            double sayi1 = Convert.ToDouble(txt_sayibir.Text);
            double sayi2 = Convert.ToDouble(txt_sayiiki.Text);
            double bolme = islemler.bolme(sayi1, sayi2);
            lbl_sonuc.Text = bolme.ToString();
        }
    }
}
