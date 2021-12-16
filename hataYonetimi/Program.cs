using System;

namespace hataYonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Bir sayi giriniz : ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Girmiş olduğunuz sayi : "+sayi);
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp.Message.ToString());
                throw;
            }finally{
                Console.WriteLine("finally çalıştı");
            }
            
             // try 
            // {
            //     // int a = int.Parse(null);
            //     // int a = int.Parse("test");
            //     int a = int.Parse("-200000000000"); 
            // }

            //  catch (ArgumentNullException ex)
            // {
            //     Console.WriteLine("Boş değer girdiniz.");
            //     Console.WriteLine(ex);
            // }

            // catch (FormatException ex)
            //  {
            //      Console.WriteLine("Veri tipi uygun değil.");
            //      Console.WriteLine(ex);
            //  }

            // catch (OverflowException ex)
            // {
            //     Console.WriteLine("Çok küçük ya da çok büyük bir değer girdiniz");
            //     Console.WriteLine(ex);
            // }

            // finally
            // {
               //  Console.WriteLine("işlem gerçekleştirildi.");
            // }
        }
    }
}
