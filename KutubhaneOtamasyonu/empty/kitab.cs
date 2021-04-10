using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KutubhaneOtamasyonu.empty
{
   public class kitab
    {
        public int kitabid { get; set; }
        public string kitabisim { get; set; }
        public string kitabyazari { get; set; }
        public string kitabdili { get; set; }
        public string yayinevi { get; set; }
        public string tur { get; set; }
        public int adet { get; set; }
        public int sayfasayisi { get; set; }
        public int basimyil { get; set; }

        public kitab()
        {

        }

        public kitab(int kitabid,string kitabisim,string kitabyazari,string kitabdili,string yayinevi,string tur,int adet,int sayfasayisi,int basimyil )
        {
            this.kitabid = kitabid;
            this.kitabisim = kitabisim;
            this.kitabyazari = kitabyazari;
            this.kitabdili = kitabdili;
            this.yayinevi = yayinevi;
            this.tur = tur;
            this.adet = adet;
            this.sayfasayisi = sayfasayisi;
            this.basimyil = basimyil;

        }
        public int getkitabid()
        {
            return this.kitabid;
        }
        public string getkitabisim()
        {
            return this.kitabisim;
        }
        public string getkitabyazari()
        {
            return this.kitabyazari;
        }
        public string getkitabdili()
        {
            return this.kitabdili;
        }
        public string getyayinevi()
        {
            return this.yayinevi;
        }
        public string gettur()
        {
            return this.tur;
        }
        public int getadet()
        {
            return this.adet;
        }
        public int getsayfasayisi()
        {
            return this.sayfasayisi;
        }
        public int getbasimyili()
        {
            return this.basimyil;
        }
    }
}
