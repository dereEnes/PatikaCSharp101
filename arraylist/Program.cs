using System;
using System.Collections;
namespace arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            //birder fazla veri tipini barındırabilir. dinamik büyür kücür System.Collections
            ArrayList liste = new ArrayList();
            liste.Add("Ayşe");
            liste.Add(2);
            liste.Add(false);
            
            //Toplu halde değerler ekleme
            ArrayList deneme = new ArrayList();
            deneme.Add('a');
            deneme.Add(5.6);
            liste.AddRange(deneme);

            // *Sıralama için tiplerin aynı olması gerek
            ArrayList deneme2 = new ArrayList();
            deneme2.Add(true);
            deneme2.Add(false);
            deneme2.Add(true);
            deneme2.Sort();

            liste.Reverse();
            
            liste.Clear();
        }
    }
}
