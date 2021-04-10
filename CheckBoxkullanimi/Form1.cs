using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBoxkullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_hesap_Click(object sender, EventArgs e)
        {
            int tutar = 0;
            if (checkBox_cay.Checked)
            {
                tutar += 1;
            }
            if (checkBox_kahve.Checked)
            {
                tutar += 3;
            }
            if (checkBox_hamburger.Checked)
            {
                tutar += 10;
            }
            if (checkBox_pizza.Checked)
            {
                tutar += 20;
            }
            lbl_tutarlar.Text = tutar.ToString();
            
        }
    }
}
