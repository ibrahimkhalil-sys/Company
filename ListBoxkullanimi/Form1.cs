using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBoxkullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listBox1.Items.Add("carsanba");
            listBox1.Items.Add("cuma");
        }

        private void btn_ekle_Click(object sender, EventArgs e)
        {
            string gun = txt_ekle.Text;
            listBox1.Items.Add(gun);
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            string silinecekgun = listBox1.SelectedItem.ToString();
            listBox1.Items.Remove(silinecekgun);
        }

        private void btn_countbul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("listbox count degeri:" + listBox1.Items.Count.ToString());
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            MessageBox.Show("listbox temizlendi:");
        }
    }
}
