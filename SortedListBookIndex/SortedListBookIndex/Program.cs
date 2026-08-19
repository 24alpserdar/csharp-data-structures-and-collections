using System;
using System.Collections;
namespace SortedListUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // SortedList
            var kitapIcerigi = new SortedList();
            kitapIcerigi.Add(1, "Önsöz");
            kitapIcerigi.Add(50, "Degiskenler");
            kitapIcerigi.Add(40, "Operatörler");
            kitapIcerigi.Add(60, "Döngüler");
            kitapIcerigi.Add(45, "Ilişkisel Operatörler");

            Console.WriteLine("İçindekiler");
            Console.WriteLine($"{"Konular",-33} {"Sayfalar",-5}");
            Console.WriteLine(new string('-', 25));
            foreach (DictionaryEntry item in kitapIcerigi)
            {
                Console.WriteLine($"{item.Value,-33} {item.Key,-5}");
            }
            Console.ReadKey();
        }
    }
}