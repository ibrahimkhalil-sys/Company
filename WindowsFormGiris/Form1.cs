using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btn_ortalamahesabla_Click(object sender, EventArgs e)
        {
            double ortalama = (Convert.ToDouble(txt_birincinot.Text) + Convert.ToDouble(txt_ikincinot.Text))/2;
            lbl_ortalamasonuc.Text = ortalama.ToString();
        }
    }
}
