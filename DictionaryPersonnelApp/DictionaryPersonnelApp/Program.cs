using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Runtime;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;

namespace Giris
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Dictionary
            var personelListesi = new Dictionary<int, Personel>() 
            {
                {110,new Personel("Mehmet","Sonsoz",75000)},
                {120,new Personel("Ahmet","Can",90000)}
            };
            personelListesi.Add(100,new Personel("Zeynep","Coskun",50000));

            foreach (var p in personelListesi)
            {
                Console.WriteLine(p);
            }
            Console.ReadKey();

        }
    }
}
