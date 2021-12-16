using System;

namespace encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci("enes","dere",120,3);
            
            ogrenci.SinifAtlat();
            ogrenci.OgrenciBİlgileriniGetir();
        }
    }
    class Ogrenci{
        private string isim;
        private string soyisim;
        private int ogrenciNo;
        private int sinif;

        public Ogrenci(){

        }
        public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
        {
            this.isim = isim;
            this.soyisim = soyisim;
            this.ogrenciNo = ogrenciNo;
            this.sinif = sinif;
        }
        public string Isim { get => isim; set => isim = value; }
        public string Soyisim { get => soyisim; set => soyisim = value; }
        public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
        public int Sinif { 
            get { return sinif; } 
            set
             { 
                 if(value < 0  || value > 4 ) Console.WriteLine("1-4 arası değer giriniz!");
                 else{ this.sinif = value ; }
             }
        }
        public void OgrenciBİlgileriniGetir(){
            Console.WriteLine("*******************");
            System.Console.WriteLine("Adı : "+this.isim);
            System.Console.WriteLine("Soyisim : "+this.soyisim);
            System.Console.WriteLine("OgrenciNo : "+this.ogrenciNo);
            System.Console.WriteLine("Sinif : "+this.sinif);
        }
        public void SinifAtlat(){
            this.sinif++;
        }
        public void SinifDusur(){
            if(this.sinif == 1)
                Console.WriteLine("Ogrenci zaten 1. sınıfta");
        }
    }
}
