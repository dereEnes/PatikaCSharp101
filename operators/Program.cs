using System;

namespace operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***Atama ve İşlemli Atama Operatöleri ***");

            // Atama ve İşlemli Atama
            int x = 3;
            int y = 3;
            y = y+2;

            Console.WriteLine(y);
            y += 2;
            Console.WriteLine(y);
            y /= 1;
            Console.WriteLine(y);
            x *= 2 ;
            Console.WriteLine(x);

            Console.WriteLine("*** Mantıksal Operatöler ***");

            // Mantıksal Operatöler 
            // ||, &&, !

            bool isSuccess = true;
            bool isCompleted = false;

            if(isSuccess && isCompleted)
            {
                Console.WriteLine("Perfect");
            }
            if(isSuccess || isCompleted)
            {
                Console.WriteLine("Great");
            }
            if(isSuccess && !isCompleted)
            {
                Console.WriteLine("Fine");
            }

            Console.WriteLine("*** İlişkisel Operatöler ***");

            int a = 3;
            int b = 5;
            bool sonuc = a<b;

            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);

            Console.WriteLine("*** Aritmetik Operatörler ***");

            // /,*,+,-

            int num1 = 20;
            int num2 = 5;
            int result1 = num1/num2;
            Console.WriteLine(result1);
            result1 = num1*num2;
            Console.WriteLine(result1);
            result1 = num1+num2;
            Console.WriteLine(result1);
            result1 = num1+1;
            Console.WriteLine(result1);

            // % : mod alır
            
            int result2 = 20%3;
            Console.WriteLine(result2);
        }
    }
}
