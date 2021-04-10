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
    public partial class Form1 : Form
    {
        List<kisi> kisilerim = new List<kisi>();
        List<kitab> kitablarim = new List<kitab>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_temizle_Click(object sender, EventArgs e)
        {
            txt_kullanciadi.Text = string.Empty;
            txt_sifre.Text = string.Empty;
        }

        private void btn_giris_Click(object sender, EventArgs e)
        {
            string kullaniciadi, sifre = "";
            kullaniciadi = txt_kullanciadi.Text;
            sifre = txt_sifre.Text;

            bool control = false;

            foreach (kisi kisi in kisilerim)
            {
                if (kullaniciadi.ToLower()==kisi.getkullanciadi() && sifre.ToLower()==kisi.getsifre() && kisi.getyetki()=="admin")
                {
                    //admin sayfasina yonlendir
                    adminsayfasi adminsayfa = new adminsayfasi(kisilerim);
                    adminsayfa.Show();
                    this.Hide();
                    control = true;
                    break;
                }
                else if (kullaniciadi.ToLower() == kisi.getkullanciadi() && sifre.ToLower() == kisi.getsifre() && kisi.getyetki() == "uye")
                {

                    uye uyesayfa = new uye();
                    uyesayfa.Show();
                    this.Hide();
                    control = true;
                    break;
                }
               

            }
            if (control==false)
            {
                MessageBox.Show("hatali giris", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            kisilerim.Add(new kisi(1, "ibo", "osmanov", DateTime.Now, "ibo", "1234", "admin"));

            kisilerim.Add(new kisi(2, "husnu", "semed", DateTime.Now, "husnu", "2", "uye"));
            kisilerim.Add(new kisi(3, "kamo", "haci", DateTime.Now, "kamo", "3", "uye"));
            kisilerim.Add(new kisi(4, "abdul", "mamed", DateTime.Now, "abdul", "4", "uye"));
        }
    }
}
