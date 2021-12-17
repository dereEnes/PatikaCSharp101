using System.Collections.Generic;
using System.Linq;
namespace rehberUygulamasi
{
    public static class Rehber{
        private static List<Kisi> kisiler;

        static Rehber(){
            kisiler = new List<Kisi>();
            kisiler.Add(new Kisi("oguz","yılmaz","124"));
            kisiler.Add(new Kisi("gokan","bolat","125"));
        }
        public static void Ekle(Kisi kisi){
            kisiler.Add(kisi);
        }
        public static void Sil(Kisi kisi){
            kisiler.Remove(kisi);
        }
        public static Kisi Getir(string value){
            return kisiler.FirstOrDefault(x =>x.Isim == value || x.Soyisim == value);
        }
        public static List<Kisi> GetAll(){
            return kisiler.OrderBy(x => x.Isim).ToList();
        }
        public static List<Kisi> GetByTelNo(string no)
        {
            return kisiler.Where(x => x.TelNo == no).ToList();
        }
        public static List<Kisi> GetByNameOrSurname(string value)
        {
            return kisiler.Where(x => x.Isim == value || x.Soyisim == value).ToList();
        }
    }
}