using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GroupBoxnesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox_isim_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox_kayit_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox_kiab_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_ekle_Click(object sender, EventArgs e)
        {
            MessageBox.Show("kayit eklendi");
            /*  textBox_isim.Text = string.Empty;
              textBox_soyisim.Text = string.Empty;
              textBox_tel.Text = string.Empty;
              textBox_emeil.Text = string.Empty;*/

            for (int i = 0; i < groupBox_kayit.Controls.Count; i++)
            {
                if (groupBox_kayit.Controls[i]is TextBox)
                {
                    groupBox_kayit.Controls[i].Text = string.Empty;
                }
            }
        }
    }
}
