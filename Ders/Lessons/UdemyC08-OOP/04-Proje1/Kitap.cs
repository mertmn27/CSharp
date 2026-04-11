using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Proje1
{
    internal class Kitap
    {
        //Erişim belirleyicileri
        /* Internal : Aynı namespace içerisinde erişilebilir.
         * Public: Bu uygulama bambaşka bir uygulama tarafından referans edilir ise bu nesneye diğer uygulamalar da erişebilir
         * Private: Sadece ilgili class ın içinde erişilebilir.
         */

        // Field: İlgili nesne içerisinde tutmak istediğimiz tanımlar ( değişkenler )

        internal int ID;
        internal string Ad;
        internal string Yazar;
        internal int sayfaSayisi;
        internal decimal fiyat;

        //Constructors
        public Kitap() { }

        public Kitap(int id, string ad, string yazar, int sayfaSayisi, decimal fiyat)
        {
            this.ID = id;
            this.Ad = ad;
            this.Yazar = yazar;
            this.sayfaSayisi = sayfaSayisi;
            this.fiyat = fiyat;

            // this demek aslında bu class içerisinde olan bir field a erişmek istiyorum ve ona değer atayacağım demek.
        }

        internal void bilgiYaz()
        {
            Console.WriteLine("ID: " + this.ID);
            Console.WriteLine($"Kitap : {this.Ad}");
            Console.WriteLine($"Yazar : {this.Yazar}");
            Console.WriteLine($"Sayfa Sayısı : {this.sayfaSayisi}");
            Console.WriteLine($"Fiyat : {this.fiyat}");
        }
    }
}
