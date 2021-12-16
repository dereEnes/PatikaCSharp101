using System;

namespace staticClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan = new Calisan("enes","dere","ik");
            Console.WriteLine("Çalışan sayısı {0}",Calisan.CalisanSayisi);
            Console.WriteLine(Islemler.Topla(5,22));
            Console.WriteLine(Islemler.Cikar(522,22));
        }
    }
   
    class Calisan{
        private static int calisanSayisi;
        private string isim;
        private string soyisim;
        private string departman;
        static Calisan(){
            calisanSayisi = 0;
        }
        public Calisan(string isim, string soyisim, string departman)
        {
            this.isim = isim;
            this.departman = departman;
            this.soyisim = soyisim;
            calisanSayisi++;
        }
        public static int CalisanSayisi { get => calisanSayisi; set => calisanSayisi = value; }
    }
    static class Islemler{
        public static long Topla(int sayi1, int sayi2){
            return sayi1 + sayi2;
        }
        public static long Cikar(int sayi1, int sayi2){
            return sayi1 - sayi2;
        }
    }
}
