using System;

namespace metot_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            //out parametreler
            string sayi = "999a";

            bool sonuc = int.TryParse(sayi, out int outSayi);
            if(sonuc){
                Console.WriteLine("Başarılı");
                Console.WriteLine(outSayi);
            }else
            {
                Console.WriteLine("Başarısız");
            }

            Metotlar.Topla(2,3,out int toplamSonucu);
            Console.WriteLine(toplamSonucu);
            //overloading

            int ifade = 999;
            Metotlar.EkranaYazdir(ifade);

            // metot imzası
            //metot Adı + paremetre sayisi + parametre Tipi
        }
    }
    class Metotlar{
        public static void Topla(int a , int b , out int toplam){
            toplam = a + b;
        }
        public static void EkranaYazdir(string veri){
            Console.WriteLine(veri);
        }
        public static void EkranaYazdir(int veri){
            Console.WriteLine(veri);
        }
    }
}
