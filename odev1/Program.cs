using System;

namespace odev1
{
    class Program
    {
        static void Main(string[] args)
        {
            //soru1();
            //soru2();
            //soru3();
            //soru4();
        }
        static void soru1(){
            Console.Write("Miktar giriniz : ");
            int count = Convert.ToInt32(Console.ReadLine().Trim());

            int[] dizi = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write("\n{0}. sayıyı giriniz : ",(i+1));
                dizi[i] = Convert.ToInt32(Console.ReadLine().Trim());
            }
            Console.WriteLine("********** Çift olanlar ********");
            foreach (var item in dizi)
            {
                if(item % 2 == 0){
                    Console.WriteLine(item);
                }
            }
        }
        static void soru2(){
            Console.Write("miktarı giriniz");
            int count = Convert.ToInt32(Console.ReadLine().Trim());

            Console.Write("2. sayıyı giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine().Trim());

            int[] dizi = new int[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write("\n{0}. pozitif sayıyı giriniz : ",(i+1));
                dizi[i] = Convert.ToInt32(Console.ReadLine().Trim());
                if(dizi[i] < 0){
                    Console.WriteLine("Pozitif sayı girdiğinizden emin olunuz");
                    i--;
                }
            }
            foreach (var item in dizi)
            {
                if(item % sayi == 0 || sayi == item){
                    Console.WriteLine(item);
                }
            }

        }
        static void soru3(){
            Console.Write("Miktar giriniz : ");
            int count = Convert.ToInt32(Console.ReadLine().Trim());
            string[] dizi = new string[count];
            for (int i = 0; i < count; i++)
            {
                Console.Write("\n{0}. Kelimeyi giriniz : ",(i+1));
                dizi[i] = Console.ReadLine().Trim();
            }
            Array.Reverse(dizi);
            foreach (var item in dizi)
            {
                Console.Write(item+" ");
            }
        }
        static void soru4()
        {
            Console.Write("Cümleyi giriniz => ");
            string cumle = Console.ReadLine();
            string[] kelimler = cumle.Split(" ");
            char[] harfler = string.Join("",kelimler).ToCharArray();
            Console.WriteLine("Kelime sayısı = {0}",kelimler.Length);
            Console.WriteLine("harf sayısı = {0}", harfler.Length);
        }
    }
}
