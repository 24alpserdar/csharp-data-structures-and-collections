using System;
using System.Collections;
using System.ComponentModel.Design;
namespace Program;

public class Program
{
    public static void Main(string[] args)
    {
        var sesliHarfler = new List<char>()
        {
            'a','e','ı','i','u','ü','o','ö',
        };

        ConsoleKeyInfo secim;
        var kuyruk = new Queue<char>();
        foreach (char k in sesliHarfler)
        {
            Console.WriteLine();
            Console.Write($"{k,-5} kuyruğa eklensin mi? [e/h] ");
            secim = Console.ReadKey();
            Console.WriteLine();
            if (secim.Key == ConsoleKey.E)
            {
                kuyruk.Enqueue(k);
                Console.WriteLine($"\n{k,-5} kuyruğa eklendi.");
                Console.WriteLine($"Kuyruktaki eleman sayisi : {kuyruk.Count}");
                Console.WriteLine();
            }
        }
        Console.WriteLine();
        Console.Write("Kuyruktan elemanlarin kaldırılması işlemi için Esc tuşuna basınız.");
        secim = Console.ReadKey();

        if (secim.Key == ConsoleKey.Escape)
        {
            Console.WriteLine();
            while (kuyruk.Count > 0)
            {
                Console.WriteLine();
                Console.WriteLine($"{kuyruk.Peek(),-5} kuyruktan çıkartılıyor.");
                Console.WriteLine($"{kuyruk.Dequeue()} kuyruktan çıkartıldı");
                Console.WriteLine($"Kuyruktaki eleman sayisi : {kuyruk.Count}");
            }
            Console.WriteLine("Kuyruktan çıkarma işlemi tamamlandı.");

        }
        Console.WriteLine("Program Bitti.");
        Console.ReadKey();
    }

}