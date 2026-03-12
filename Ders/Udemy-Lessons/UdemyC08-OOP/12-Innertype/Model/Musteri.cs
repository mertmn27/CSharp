using System;
using System.Collections.Generic;
using System.Text;

namespace _12_Innertype.Model
{
    internal class Musteri
    {
        public static int musteriTakipID { get; set; }
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public IletisimBilgi iletisimBilgi { get; set; }

        public Musteri()
        {
            ID = musteriTakipID;
            musteriTakipID++;
        }

        public Musteri(string ad, string soyad) : this()
        {
            this.Ad = ad;
            this.Soyad = soyad;
        }
    }
}
