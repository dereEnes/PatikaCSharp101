using System;
using System.Collections.Generic;
namespace generic_list
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayiListesi = new List<int>();
            sayiListesi.Add(23);
            sayiListesi.Add(223);
            sayiListesi.Add(63);
            sayiListesi.Add(92);
            sayiListesi.Add(6);
            //listedeki eleman sayısı
            Console.WriteLine(sayiListesi.Count);

            sayiListesi.ForEach(sayi=> Console.WriteLine(sayi));
            
            //eleman çıkarma
            sayiListesi.Remove(6);
            
            //0.indexdeki elemanı çıkar
            sayiListesi.RemoveAt(0);
            
            //Listede arama
            if(sayiListesi.Contains(4)){
                Console.WriteLine("Liste içerisinde 4 var");
            }


            //Diziyi list e çevirme
            string[] hayvanlar = {"kedi","köpek","fil"};
            List<String> animals = new List<string>(hayvanlar);

            //Listeyi temizlemek
            animals.Clear();

            //Class tipli list
            List<Insan> insanlar = new List<Insan>();
            insanlar.Add(new Insan(){Name = "enes", Age =24});
        }
    }
    public class Insan{
        private string name;
        private int age;

        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }
    }
}
