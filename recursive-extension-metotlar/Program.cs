using System;

namespace recursive_extension_metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Islemler.Expo(2,1));
            string ifade = "enes dere abc";
            Console.WriteLine(ifade.CheckSpaces());
            bool dasdf = "aesflkjasdf".CheckSpaces();
        }
    }
    public class Islemler{
        public static int Expo(int sayi, int us){
            if(us <= 1){
                return sayi;
            }else{
                return sayi*Expo(sayi,us-1);
            }
            
        }
    }
    public static class Extension{

        public static bool CheckSpaces(this string param){
            return param.Contains(" ");
        }
        public static string RemoveWhiteSpaces(this string param){
            string[] value = param.Split(" ");
            return string.Join("",value);

        }
        public static string ToUpper(this string param){
            return param.ToUpper();
        }
    }
}
