using System;

namespace enums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Gunler.Pazar);
            Console.WriteLine((int)Gunler.Pazar);
            int sicaklik = 32;
            if(sicaklik <= (int)HavaDurumu.Normal){
                Console.WriteLine("Isınmasını bekleyelim");
            }else if(sicaklik <= (int)HavaDurumu.Sıcak){
                Console.WriteLine("Sıcak bir gün");
            }
            deneme dfd= new deneme();
        }

    }
    public class deneme{
        public const double sayi = 5;
        static deneme(){
            Console.Write("wadawdawdalkwhudjalwdkjna");
        }
        public deneme(){

        }

    }
    enum Gunler{
        Pazartesi = 1,
        Salı,
        Çarşamba,
        Perşembe,
        Cuma,
        Cumartesi,
        Pazar
    }
    enum HavaDurumu{
        Soguk = 5,
        Normal = 20,

        Sıcak = 25,
        ÇokSıcak = 30
    }
    
}
