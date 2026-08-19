using System;
namespace LinkedListUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            // LinkedList<T> Temelleri
            // Tanımlama
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Ordu");
            sehirler.AddFirst("Trabzon");

            foreach (string s in sehirler)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();
        }
    }
}