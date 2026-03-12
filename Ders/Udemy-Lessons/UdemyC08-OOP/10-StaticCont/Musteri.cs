using System;
using System.Collections.Generic;
using System.Text;

namespace _10_StaticCont
{
    static class Musteri
    {
        //Eğer bir class static olarak işaretlenmiş ise bu class örneklenemez.
        //Eğer bir class static olarak işaretlenmiş ise nesne örneği alınarak kullanılan hiçbir şey yapılamaz. Constructor dahil.

        static Musteri()
        {
            Console.WriteLine("Static constructor çalıştı.");
            TamAd = "İmparator";
        }

        internal static string TamAd { get; set; }
        internal static void Selamla()
        {
            Console.WriteLine("Selamla metodu çalıştı.");
            Console.WriteLine($"Selam sana {TamAd}");
        }
    }
}
