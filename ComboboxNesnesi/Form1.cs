using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComboboxNesnesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             combo_gunler.Items.Add("cuma");
             combo_gunler.Items.Add("cumaertesi");
             combo_gunler.Items.Add("pazar");
            //combo_gunler.Items.RemoveAt(0);

           // MessageBox.Show("ibo osman");
        }

        private void btn_gunsec_Click(object sender, EventArgs e)
        {
            string secilengun = combo_gunler.SelectedItem.ToString();
            MessageBox.Show("sectiyiniz gun :" + secilengun);
        }
    }
}
