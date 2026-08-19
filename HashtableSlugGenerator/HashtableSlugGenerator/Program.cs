using System.Collections;

// Hashtable uygulamasi

// başlığı okuma

Console.WriteLine("Başlık giriniz: ");
string baslik = Console.ReadLine();

// kucultme
baslik = baslik.ToLower();

// Hashtable
var karakterseti = new Hashtable()
            {
                {"ç","c"},
                {"ı","i"},
                {"ö","o"},
                {"ü","u"},
                {" ","-"},
                {"'","-"},
                {"ğ","g"},
                {".","-"},
                {"?","-"}
            };

foreach (DictionaryEntry item in karakterseti)
{
    baslik = baslik.Replace(item.Key.ToString(), item.Value.ToString());
}

// Ekranda yazdir
Console.WriteLine(baslik);