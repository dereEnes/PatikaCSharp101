using System;
using System.Collections.Generic;
using System.Linq;

namespace Proje_2
{
    class Program
    {
        static BoardManager manager = new BoardManager();
        static List<Person> persons = new List<Person>();
        static void Main(string[] args)
        {
            //Kişilerin oluşturulması
            
            
            Person person1 = new Person { Id = "123", Name = "enes" };
            Person person2 = new Person { Id = "456", Name = "oguzhan" };
            Person person3 = new Person { Id = "853", Name = "gökan" };
            Person person4 = new Person { Id = "324", Name = "ramazan" };

            persons.Add(person1);
            persons.Add(person2);
            persons.Add(person3);
            persons.Add(person4);

            //Card işlemlerini yapacak sınıfı üretiyorum
            
            manager.Add(
                new Card (){ Header="İş görüşmesi", Content="saat 12 de iş görüşmesi yapılacak",State=State.ToDo,Buyukluk=Buyukluk.XL,Person=person1});

            manager.Add(
                new Card(){ Header = "Oryantasyon", Content = "saat 09.00 oryantasyon programı başlayacak", State = State.ToDo, Buyukluk = Buyukluk.L, Person = person2 });

            manager.Add(
                new Card(){ Header = "Tanıtım", Content = "yeni gelecekler için tanıtım hazırlanması", State = State.InProgress, Buyukluk = Buyukluk.XL, Person = person3 });

            manager.Add(
                new Card(){ Header = "Panel", Content = "panel görüşmesi", State = State.InProgress, Buyukluk = Buyukluk.XL, Person = person1 });

            manager.Add(
                new Card(){ Header = "Service Eklenmesi", Content = "saat 12 de iş görüşmesi yapılacak", State = State.Done, Buyukluk = Buyukluk.XL, Person = person4 });

            manager.Add(
                new Card(){ Header = "Maaş Ödenmesi", Content = "saat 12 de iş görüşmesi yapılacak", State = State.Done, Buyukluk = Buyukluk.XL, Person = person3 });

            Menu();

        }
        public static void Menu()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Board Listelemek");
            Console.WriteLine("(2) Board'a Kart Eklemek");
            Console.WriteLine("(3) Board'dan Kart Silmek");
            Console.WriteLine("(4) Kart Taşımak");
            string secenek = "";
            
            secenek = Console.ReadLine();
            switch (secenek)
            {
                case "1":
                    Print();
                    break;
                case "2":
                    AddCard();
                    break;
                case "3":
                    break;
                case "4":
                    MoveToCard();
                    break;
                default:
                    break;
            }
        }
        public static void MoveToCard()
        {
            Console.WriteLine("Öncelikle taşımak istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:");
            string headerToMove = Console.ReadLine().Trim();
            var result = manager.GetCardByHeader(headerToMove);
            if (result is null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* İşlemi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                string choice = Console.ReadLine();
                if (choice == "1") Menu();
                else MoveToCard();
            }
            else
            {
                Console.WriteLine("Bulunan Kart Bilgileri:");
                Console.WriteLine("****************************************************");
                Console.WriteLine("Başlık".PadRight(15) + ": " + result.Header);
                Console.WriteLine("İçerik".PadRight(15) + ": " + result.Content);
                Console.WriteLine("Atalan Kişi".PadRight(15) + ": " + result.Person.Name);
                Console.WriteLine("Büyüklük".PadRight(15) + ": " + result.Buyukluk.ToString());
                Console.WriteLine("Line".PadRight(15) + ": "+ result.State.ToString());
                bool durum = true;
                int secim = 0;
                while (durum)
                {
                    Console.WriteLine("Lütfen Taşımak İstediğiniz Line'ı Seçiniz:");
                    Console.WriteLine("(1) TODO");
                    Console.WriteLine("(2) IN PROGRESS");
                    Console.WriteLine("(3) DONE");
                    secim = Convert.ToInt32(Console.ReadLine().Trim());
                    if (secim >= 1 && secim <= 3) durum = false;
                }
                manager.Update(secim,headerToMove);
                Console.WriteLine("Başarılı bir şekilde güncellendi.");
                Menu();
            }

        }

        public static void Delete()
        {
            Console.WriteLine("Öncelikle silmek istediğiniz kartı seçmeniz gerekiyor.");
            Console.Write("Lütfen kart başlığını yazınız:");
            string headerToFind = Console.ReadLine().Trim();
            var result = manager.GetCardByHeader(headerToFind);
            if (result is null)
            {
                Console.WriteLine("Aradığınız krtiterlere uygun kart board'da bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için : (2)");
                string choice = Console.ReadLine();
                if (choice == "1") Menu();
                else Delete();
            }
            else
            {
                manager.Delete(result);
            }
        }
        public static void AddCard()
        {
            
            Console.Write("Başlık Giriniz".PadRight(40)+" : " );
            string header = Console.ReadLine().Trim();
            Console.Write("İçerik Giriniz".PadRight(40) + " : ");
            string content = Console.ReadLine().Trim();
            Console.Write("Büyüklük Giriniz -> XS(1),S(2),M(3),L(4),XL(5)".PadRight(40) + " : ");
            int size = Convert.ToInt32(Console.ReadLine().Trim());
            Console.Write("Kişi Seçiniz".PadRight(40) + " : ");
            string id = Console.ReadLine().Trim();

            var result = persons.FirstOrDefault(person => person.Id == id);
            if(result is null)
            {
                Console.WriteLine("Böyle bir kisi yok. Lütfen tekrar deneyin!");
                AddCard();
            }

            Card newToAdd = new Card() { Header = header, Content = content, Buyukluk = (Buyukluk)size, Person = result, State = State.InProgress };
            manager.Add(newToAdd);
            Menu();
        }
        public static void Print()
        {
            Console.WriteLine("TODO Line\n ***********************");
            foreach (var item in InMemoryBoard.Cards.Where(card => card.State == State.ToDo))
            {
                Console.WriteLine("Başlık".PadRight(15)+": " + item.Header);
                Console.WriteLine("İçerik".PadRight(15) + ": " + item.Content);
                Console.WriteLine("Atalan Kişi".PadRight(15) + ": " + item.Person.Name);
                Console.WriteLine("Büyüklük".PadRight(15) + ": " + item.Buyukluk.ToString());
                Console.WriteLine("-");
            }

            Console.WriteLine("IN PROGRESS Line\n ***********************");
            foreach (var item in InMemoryBoard.Cards.Where(card => card.State == State.InProgress))
            {
                Console.WriteLine("Başlık".PadRight(15) + ": " + item.Header);
                Console.WriteLine("İçerik".PadRight(15) + ": " + item.Content);
                Console.WriteLine("Atalan Kişi".PadRight(15) + ": " + item.Person.Name);
                Console.WriteLine("Büyüklük".PadRight(15) + ": " + item.Buyukluk.ToString());
                Console.WriteLine("-");
            }

            Console.WriteLine("DONE Line\n ***********************");
            foreach (var item in InMemoryBoard.Cards.Where(card => card.State == State.Done))
            {
                Console.WriteLine("Başlık".PadRight(15) + ": " + item.Header);
                Console.WriteLine("İçerik".PadRight(15) + ": " + item.Content);
                Console.WriteLine("Atalan Kişi".PadRight(15) + ": " + item.Person.Name);
                Console.WriteLine("Büyüklük".PadRight(15) + ": " + item.Buyukluk.ToString());
                Console.WriteLine("-");
            }
            Menu();
        }
    }
}
