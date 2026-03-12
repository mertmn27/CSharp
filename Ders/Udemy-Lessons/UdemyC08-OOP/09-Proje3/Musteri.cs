using System;
using System.Collections.Generic;
using System.Text;

namespace _09_Proje3
{
    internal class Musteri
    {
        public static int Sayac;

        static Musteri()
        {
            Sayac = 1;
        }

        public int ID { get; init; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        public Musteri()
        {
            ID = Musteri.Sayac;
            Musteri.Sayac += 1;
        }

        public void ekranaYaz()
        {
            Console.WriteLine($"ID : {ID} - Tam Adı : {Isim} {Soyisim}");
        }
    }
}
