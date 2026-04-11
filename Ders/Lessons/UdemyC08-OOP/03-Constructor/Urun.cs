using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Constructor
{
    internal class Urun
    {
        public int urunId;
        public string urunAd;
        public string urunRenk;
        public decimal urunFiyat;

        //Constructor

        public Urun() { }
        public Urun(int Id, string Ad, string Renk)
        {
            urunId = Id;
            urunFiyat = 1000M;
            urunRenk = Renk;
            urunAd = Ad;
        }

        public void bilgileriYaz()
        {
            Console.WriteLine(urunId);
            Console.WriteLine(urunAd);
            Console.WriteLine(urunFiyat);
            Console.WriteLine(urunRenk);
        }
    }
}
