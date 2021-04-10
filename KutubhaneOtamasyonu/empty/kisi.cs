using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutubhaneOtamasyonu.empty
{
    public class kisi
    {
        public int id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public DateTime olusturmaTarihi { get; set; }
        public string kullaniciAdi { get; set; }
        public string sifre { get; set; }
        public string yetki { get; set; }


        public kisi()
        {

        }

        public kisi(int id, string isim,string soyisim,DateTime olusturmatarihi,string kullaniciadi,string sifre,string yetki)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.olusturmaTarihi = olusturmaTarihi;
            this.kullaniciAdi = kullaniciadi;
            this.sifre = sifre;
            this.yetki = yetki;
        }

        public void setid(int id)
        {
            this.id = id;
        }
        public int getid()
        {
            return this.id;
        }
        public void setisim(string isim)
        {
            this.isim = isim;
        }
        public string getisim()
        {
            return this.isim;
        }
        public void setsoyisim(string soyisim)
        {
            this.soyisim = soyisim;
        }
        public string getsoyisim()
        {
            return this.soyisim;
        }
        public void setolusturmatarihi(DateTime olusturmatarihi)
        {
            this.olusturmaTarihi = olusturmatarihi;
        }
        public DateTime getolusturmatarihi()
        {
            return this.olusturmaTarihi;
        }
        public void setkullanciadi(string kullanciadi)
        {
            this.kullaniciAdi = kullanciadi;
        }
        public string getkullanciadi()
        {
            return this.kullaniciAdi;
        }
        public void setsifre(string sifre)
        {
            this.sifre = sifre;
        }
        public string getsifre()
        {
            return this.sifre;
        }
        public void setyetki(string yetki)
        {
            this.yetki = yetki;
        }
        public string getyetki()
        {
            return this.yetki;
        }

        public override string ToString()
        {
            return "isim-soyisim :" + this.isim + "" + this.soyisim;
        }
    }
}
