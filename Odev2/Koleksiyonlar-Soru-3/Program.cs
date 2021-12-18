using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<char> sesliHarfler = new List<char>();
            sesliHarfler.Add('a');
            sesliHarfler.Add('e');
            sesliHarfler.Add('i');
            sesliHarfler.Add('ı');
            sesliHarfler.Add('o');
            sesliHarfler.Add('ö');
            sesliHarfler.Add('u');
            sesliHarfler.Add('ü');

            List<char> cumledekiSesliHarfler = new List<char>();
            Console.WriteLine("Lütfen Cümlenizi Giriniz!");
            string sentence = Console.ReadLine().Trim();

            for (int i = 0; i < sentence.Length; i++)
            {
                if (sesliHarfler.Contains(sentence[i]))
                {
                    cumledekiSesliHarfler.Add(sentence[i]);
                }
            }
            cumledekiSesliHarfler.ForEach(harf => Console.WriteLine(harf));
        }
    }
}
