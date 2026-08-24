using System;
using System.Collections.Generic;

namespace SortedSetUniqueRandom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedSet
            var sayilar = new List<int>();
            var r = new Random();
            Console.WriteLine();

            for (int i = 0; i < 1000; i++)
            {
                sayilar.Add(r.Next(5, 15));
                Console.Write($"{sayilar[i],-3}");
            }
            Console.WriteLine();

            // Listedeki benzersiz elemanlari bulmak
            var benzersizSayiListesi = new SortedSet<int>(sayilar);

            Console.WriteLine();
            Console.WriteLine("\nBenzersiz sayilarin listesi\n");
            foreach (int sayi in benzersizSayiListesi)
            {
                Console.Write($"{sayi,-3}");
            }
            Console.WriteLine("\nBenzersiz {0} sayı var", benzersizSayiListesi.Count);

            Console.ReadKey();
        }
    }
}
