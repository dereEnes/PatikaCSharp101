using System;

namespace array_methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayi = {2,54,3,122,-5,0,76};

            print(sayi);

            Array.Sort(sayi); //diziyi küçükten büyüğe sıralamak için
            Array.Reverse(sayi);//diziyi ters çevirir
            Array.Clear(sayi,0,2);//verilen index den başlayarak verilen miktarda dizinin elmanını 0 yapar
            Array.IndexOf(sayi,76);//verilen elemanının index numarasını bulmaya çalışır. 
            Array.Resize<int>(ref sayi,10); // diziyi yeniden boyutlandırır boşlukları 0 ile doldurur
            print(sayi);

        }
        static void print(int[] dizi){
            Console.WriteLine("*****************");
            foreach (var item in dizi)
            {
                Console.WriteLine(item);
            }
        }
    }
}