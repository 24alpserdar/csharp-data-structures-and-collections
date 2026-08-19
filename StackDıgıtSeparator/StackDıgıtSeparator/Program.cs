using System;
using System.Collections.Generic;
namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            var sayiYigini = new Stack<int>();
            while (sayi > 0)
            {
                int k = sayi % 10;
                sayiYigini.Push(k);
                sayi = sayi / 10;

            }
            int i = 0;
            int n = sayiYigini.Count - 1;
            foreach (var s in sayiYigini)
            {
                Console.WriteLine($"\t{s,7} x " +
                    $"{Math.Pow(10, n - i),7}\t = " +
                    $"{s * Math.Pow(10, n - i),7}");
                i++;
            }

            Console.ReadKey();
        }
    }
}
