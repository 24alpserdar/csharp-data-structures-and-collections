using System;
using System.Collections.Generic;
namespace Program 
{
    public class Program 
    {
        static void Main(string[] args)
        {
            // SortedSet Küme İşlemleri
            // var A = new SortedSet<int>() {1,2,3,4};
            var A = new SortedSet<int>(RastgeleSayiUret(10000));
            // var B = new SortedSet<int>() { 1, 2, 5, 6 };
            var B = new SortedSet<int>(RastgeleSayiUret(10000));

            #region yazdirma
            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (int s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            Console.WriteLine("B kümesi");
            foreach (int s in B)
            {
                Console.Write($"{s,5}");
            }
            #endregion

            // Union

            // A.UnionWith(B);
            // A.IntersectWith(B);
            // A.ExceptWith(B);
            A.SymmetricExceptWith(B);

            Console.WriteLine();
            Console.WriteLine("\n\nKesisim disindaki elemanlar");
            foreach (var s in A)
            {
                Console.Write($"{s,5}");
            }
            Console.WriteLine();
            Console.WriteLine("\nToplam sayisi : {0}",A.Count);

            Console.WriteLine();
            Console.ReadKey();
        }
        static List<int> RastgeleSayiUret(int n) 
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0,1000));
            }
            return list;
        }
    }
}
