using System;

namespace variables
{
    class Program
    {
        static void Main(string[] args)
        {
            //
            byte not = 75;
            uint nufus = 83000000;
            long dunyaNufusu = 8000000000;
            bool isPass = true;

            char basHarfi = 'E';
            string name = "enes";

            float maas = 4000.00f;
            double birikim = 800000.00d;
            short distinct = 12000;

            DateTime date = DateTime.Now;
            Console.WriteLine(date.ToString());
            Console.WriteLine(date.ToString("dddd/MMMM/yyyy"));
            Console.WriteLine(date.ToString("dd/MM/yy"));
            Console.WriteLine(date.ToString("HH:mm"));

            object o = 'd';
            object o2 = 4;

            var deneme = "enes";
            

        }
    }
}
