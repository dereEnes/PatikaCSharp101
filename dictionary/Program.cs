using System;
using System.Collections.Generic;
namespace dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int,string> kullanıcılar = new Dictionary<int, string>();
            kullanıcılar.Add(1,"enes");
            kullanıcılar.Add(2,"dere");
            kullanıcılar.Add(3,"ayşe");
            
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(kullanıcılar[2]);
            
            Console.WriteLine(kullanıcılar.Count);
            Console.WriteLine(kullanıcılar.ContainsKey(3));
            Console.WriteLine(kullanıcılar.ContainsValue("dere"));
            kullanıcılar.Remove(3);
            //keys
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item.Key);
            }
            //values
            foreach (var item in kullanıcılar)
            {
                Console.WriteLine(item.Value);
            }
        }
    }
}
