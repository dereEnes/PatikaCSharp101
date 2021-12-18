using System;
using System.Collections;

namespace Koleksiyonlar_Soru_1
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList listOfPrime = new ArrayList();
            ArrayList listOfNonPrime = new ArrayList();
            int entry = 0;
            double sumOfPrime = 0, sumOfNonPrime = 0;

            //kullaıcıdan değerleri alma
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}.sayıyı giriniz.",i+1);
                try
                {
                    entry = Convert.ToInt32(Console.ReadLine().Trim());
                    if (entry < 0) throw new Exception();
                    if (AsalMi(entry))
                    {
                        listOfPrime.Add(entry);
                    }
                    else
                    {
                        listOfNonPrime.Add(entry);
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine("Lütfen 0 dan büyük bir sayı girdiğinize emin olunuz!");
                    i--;
                }
            }

            //sıralama
            listOfNonPrime.Sort();
            listOfNonPrime.Reverse();

            listOfPrime.Sort();
            listOfPrime.Reverse();

            //Ekrana yazdıkmak
            Console.WriteLine("Prime sayılar");
            foreach (var item in listOfPrime)
            {
                sumOfPrime += Convert.ToDouble(item);
                Console.WriteLine(item);
            }

            Console.WriteLine("Prime olmayan sayılar");
            foreach (var item in listOfNonPrime)
            {
                sumOfNonPrime += Convert.ToDouble(item);
                Console.WriteLine(item);
            }
            Console.WriteLine("Asal sayıların miktarı : {0}  Ortalaması : {1}",listOfPrime.Count,(sumOfPrime/ listOfPrime.Count));
            Console.WriteLine("Asal Olmayan  sayıların miktarı : {0}  Ortalaması : {1}", listOfNonPrime.Count, (sumOfNonPrime / listOfNonPrime.Count));

        }
        static bool AsalMi(int sayi)
        {
            if (sayi < 2) return false;
            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0) return false;
            }
            return true;
        }

    }
}
