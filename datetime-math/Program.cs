using System;

namespace datetime_math
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); //saatle beraber tarihi
            Console.WriteLine(DateTime.Now.Date); 
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Month); //1-12
            Console.WriteLine(DateTime.Now.Year); 
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second+"\n");

            Console.WriteLine(DateTime.Now.DayOfWeek);
            Console.WriteLine(DateTime.Now.DayOfYear);

            Console.WriteLine(DateTime.Now.ToLongDateString());
            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.WriteLine(DateTime.Now.ToLongTimeString());
            Console.WriteLine(DateTime.Now.ToShortTimeString());

            Console.WriteLine(DateTime.Now.AddDays(12));
            Console.WriteLine(DateTime.Now.AddYears(2));

            //Format

            Console.WriteLine(DateTime.Now.ToString("dd")); //24
            Console.WriteLine(DateTime.Now.ToString("ddd")); //sat
            Console.WriteLine(DateTime.Now.ToString("ddd")); //saturday

            Console.WriteLine(DateTime.Now.ToString("MM")); //04 
            Console.WriteLine(DateTime.Now.ToString("MMM")); //Apr
            Console.WriteLine(DateTime.Now.ToString("MMMM")); //April

            Console.WriteLine(DateTime.Now.ToString("yy")); //21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); //2021
        }
    }
}
