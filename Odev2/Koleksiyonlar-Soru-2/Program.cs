using System;

namespace Koleksiyonlar_Soru_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Array array = new int[20];
            int entry = 0;
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("{0}.sayıyı giriniz.", i + 1);
                try
                {
                    entry = Convert.ToInt32(Console.ReadLine().Trim());
                    array.SetValue(entry,i);

                }
                catch (Exception e)
                {
                    Console.WriteLine("Lütfen sayı giriniz!");
                    i--;
                }
            }

            Array.Sort(array);
            Console.WriteLine("En küçük 3 lü {0}, {1}, {2} ",array.GetValue(0), array.GetValue(1), array.GetValue(2));
            double AvarageOfLowest = (Convert.ToDouble(array.GetValue(0)) + Convert.ToDouble(array.GetValue(1)) + Convert.ToDouble(array.GetValue(2)))
                / 3;
            Console.WriteLine("En küçük 3 lü ortalaması : {0}",AvarageOfLowest);

            Array.Reverse(array);
            Console.WriteLine("En büyük 3 lü {0}, {1}, {2} ", array.GetValue(0), array.GetValue(1), array.GetValue(2));
            double AvarageOfHighest = (Convert.ToDouble(array.GetValue(0)) + Convert.ToDouble(array.GetValue(1)) + Convert.ToDouble(array.GetValue(2)))
                / 3;
            Console.WriteLine("En büyük 3 lü ortalaması : {0}", AvarageOfHighest);

            Console.WriteLine("Ortalamalarının toplamı : {0}",(AvarageOfLowest+AvarageOfHighest) /2 );
        }
    }
}
