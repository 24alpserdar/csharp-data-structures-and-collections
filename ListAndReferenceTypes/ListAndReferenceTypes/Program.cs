using System;
using System.Collections.Generic;
namespace ListeUygulamasi

{

    class Program

    {

        static void Main(string[] args)

        {

            List<string> sehirler = new List<string>()

{

"Ankara",

"İstanbul",

"Van",

"Samsun",

"Ordu"

};



            // Lambda expression =>

            sehirler.ForEach(s => Console.WriteLine(s));

            Console.WriteLine(new string('-', 50));



            var iller = sehirler;

            iller.ForEach(i => Console.WriteLine(i));

            Console.WriteLine();



            sehirler.Add("Sinop");

            sehirler.ForEach(s => Console.WriteLine(s));

            Console.WriteLine();



            iller.ForEach(i => Console.WriteLine(i));

            Console.WriteLine();

            iller.Remove("Ankara");

            iller.ForEach(i => Console.WriteLine(i));

            Console.WriteLine();

            sehirler.ForEach(s => Console.WriteLine(s));

        }

    }

}

