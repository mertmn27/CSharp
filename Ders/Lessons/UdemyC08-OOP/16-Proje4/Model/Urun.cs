using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Proje4.Model
{
    internal class Urun
    {
        public static int _sayac = 1;
        public int ID { get; private set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public DateTime OlusturmaTarih { get; set; }

        public Urun()
        {
            ID = _sayac;
            _sayac++;
            OlusturmaTarih = DateTime.Now;
        }
        public Urun(string marka, string model) : this()
        {
            this.Marka = marka;
            this.Model = model;
        }
        internal virtual void BilgiVer()
        {
            Console.WriteLine($"ID : {ID} - Marka : {Marka} - Model : {Model}");
        }
    }
}
