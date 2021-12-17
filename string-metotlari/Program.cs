using System;

namespace string_metotlari
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "Dersimiz CSharp, Hoşgeldiniz!";

            //length
            Console.WriteLine(degisken.Length); //uzunluk
            
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());

            //concet
            Console.WriteLine(string.Concat(degisken,"concet uygulandı"));

            //iki stringi karşılaştırmak
            Console.WriteLine(degisken.CompareTo("deneme")); // 0,1,-1

            //Compare
            Console.WriteLine(string.Compare(degisken,"deneme",true)); //iki string aynı mı diye bakar true ise case sensivite devre dışı olur 0,1 döner

            //Contain - içeriyor mu diye bakar
            Console.WriteLine(degisken.Contains("CSharp"));

            //EndsWith - ile bitiyor mu
            Console.WriteLine(degisken.EndsWith("!"));

            //StartsWith - ile başlıyor mu
            Console.WriteLine(degisken.StartsWith("Ders"));

            //IndexOf - bir değeri bir değişken içierisinde ara ilk bulduğunu döner (başlangıç adresi)
            Console.WriteLine(degisken.IndexOf("geldi"));

            //Insert - girilen index den başlayarak değeri ekler
            Console.WriteLine(degisken.Insert(0,"buraya"));

            //LastIndexOf(value) - value değerinin son bulunan index değerini getir

            //PadLeft,PadRight sağa sola dayalı şekilde string i doldurur
            Console.WriteLine("degisken".PadLeft(10,'-'));

            //Remove
            Console.WriteLine(degisken.Remove(10));
            Console.WriteLine(degisken.Remove(10,5));

            //Repalce
            Console.WriteLine(degisken.Replace("CSharp","Java"));

            //Split(value) değere göre parçalama yapar ve yeni bir dizi oluşturur 

            //SubString 
            Console.WriteLine(degisken.Substring(4));
            Console.WriteLine(degisken.Substring(4,10));
        }
    }
}
