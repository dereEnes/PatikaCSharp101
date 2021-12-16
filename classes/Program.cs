using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan calisan1 = new Calisan();
            calisan1.Ad = "Enes";
            calisan1.Soyad = "Dere";
            calisan1.No = 23232;
            calisan1.Departman = "IT";
            calisan1.CalisanBilgileri();
            System.Console.WriteLine("***********");
            calisan1.Ad = "Ayşe";
            calisan1.Soyad = "Kara";
            calisan1.No = 22333;
            calisan1.Departman = "Human resources";
            calisan1.CalisanBilgileri();
        }
    }
    class Calisan{
        public string Ad;
        public string Soyad;
        public int No;
        public string Departman;
        public void CalisanBilgileri(){
            System.Console.WriteLine("Adı : {0}",this.Ad);
            System.Console.WriteLine("Soyad : {0}",this.Soyad);
            System.Console.WriteLine("No : {0}",this.No);
            System.Console.WriteLine("Departman : {0}",this.Departman);
        }
    }
}
