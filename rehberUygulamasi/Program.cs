using System;
using System.Collections.Generic;
using System.Linq;
namespace rehberUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kisi kisi1 = new Kisi("enes", "dere", "123");
            Rehber.Ekle(kisi1);
            Sor();
            

        }
        public static void Sor(){
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :)");
            Console.WriteLine("************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek \n(2) Varolan Numarayı Silmek\n(3) Varolan Numarayı Güncelleme \n(4) Rehberi Listelemek \n(5) Rehberde Arama Yapmak");
            byte islem =Convert.ToByte(Console.ReadLine().Trim());
            switch (islem)
            {
                case 1:
                    NumaraEkle();
                    break;
                case 2:
                    Delete();
                    break;
                case 3:
                    Update();
                    break;
                case 4:
                    Listele(Rehber.GetAll(),"Telefon Rehberi");
                    break;
                case 5:
                    RehberdeAra();
                    break;
                default:
                    break;
            }
        }
        public static void NumaraEkle(){
            string isim,soyisim,telNo;
            
            Console.Write("Lütfen isim giriniz ");
            isim = Console.ReadLine().Trim();
            Console.Write("Lütfen soyisim giriniz ");
            soyisim = Console.ReadLine().Trim();
            Console.Write("Lütfen telNo giriniz ");
            telNo = Console.ReadLine().Trim();

            Rehber.Ekle(new Kisi(isim,soyisim,telNo));
            Sor();
        }
        public static void Delete(){
            Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
            string value = Console.ReadLine().Trim();
            var result = Rehber.Getir(value);
            if(result is null){
                Console.Write("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int tercih = Convert.ToInt32(Console.ReadLine().Trim());
                if(tercih == 1) Sor();
                else Delete();

            }else{
                Console.WriteLine("{0} isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)",result.Isim);
                string cevap = Console.ReadLine().Trim();
                if (cevap == "y")
                {
                    Rehber.Sil(result);
                }
                else if (cevap == "n")
                {
                    Sor();
                }

            }
        }
        public static void Update()
        {
            Console.Write("Lütfen güncellemek istediğiniz kişinin adını veya soyadını giriniz :");
            string value = Console.ReadLine().Trim();
            var kisi = Rehber.Getir(value);
            if (kisi is null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Güncellemeyi sonlandırmak için    : (1)");
                Console.WriteLine(" * Yeniden denemek için             : (2)");
                string secim = Console.ReadLine().Trim();
                if (secim == "1") Sor();
                else if (secim == "2") Update();
            }
            else
            {
                Rehber.Sil(kisi);
                string isim, soyisim, telNo;

                Console.Write("Lütfen yeni isim giriniz ");
                isim = Console.ReadLine().Trim();
                Console.Write("Lütfen yeni soyisim giriniz ");
                soyisim = Console.ReadLine().Trim();
                Console.Write("Lütfen yeni telNo giriniz ");
                telNo = Console.ReadLine().Trim();

                Rehber.Ekle(new Kisi(isim, soyisim, telNo));
                Sor();

            }

        }
        public static void Listele(List<Kisi> liste,string yazi){
            Console.WriteLine("{0} \n ***************************************************",yazi);
            foreach (Kisi kisi in liste)
            {
                Console.WriteLine("isim : {0}",kisi.Isim);
                Console.WriteLine("soyisim : {0}",kisi.Soyisim);
                Console.WriteLine("Telefon Numarası : {0}",kisi.TelNo);
                Console.WriteLine("-");
            }
            Sor();
        }
        public static void RehberdeAra()
        {
            Console.WriteLine(" Arama yapmak istediğiniz tipi seçiniz. \n **********************************************");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int secim = Convert.ToInt32(Console.ReadLine().Trim());
            if(secim == 1)
            {
                Console.Write("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
                string value = Console.ReadLine().Trim();
                Listele(Rehber.GetByNameOrSurname(value), "Arama Sonuçlarınız");
            }
            if (secim == 2)
            {
                Console.Write("Telefon numarasını giriniz : ");
                string telNo = Console.ReadLine().Trim();
                Listele(Rehber.GetByTelNo(telNo),"Arama Sonuçlarınız");
            }
            Sor();
        }
    }
    
}
