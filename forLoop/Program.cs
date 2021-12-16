using System;

namespace forLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen bir sayı giriniz:");
            int sayac = int.Parse(Console.ReadLine().Trim());
            for (int i = 0; i < sayac; i++)
            {
                if (i%2 == 1)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
