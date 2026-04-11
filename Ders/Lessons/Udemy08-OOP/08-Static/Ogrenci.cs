using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Static
{
    internal class Ogrenci
    {
        public static int Sayac = 0;
        public int ID { get; set; }
        public string Isim { get; set; }
        public string Soyisim { get; set; }

        // Her nesne örneği alındığı zaman tekrar tekrar çağırılır.
        public Ogrenci() 
        {
            Console.WriteLine("Nesne örneği alındı.");
        }

        // Static constructor sadece 1 kere çalışır.
        static Ogrenci()
        {
            Console.WriteLine("Static constructor.");
        }

        internal void BilgiVer()
        {
            //Static olmayan yerler static olanları görebilir. Ancak static olanlar olmayanları göremez.
            Console.WriteLine($"Tam Ad : {Isim} {Soyisim}");
        }
    }
}
