using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Inheritance.Model
{
    internal class Musteri:Base
    {
        public Musteri()
        {
            Console.WriteLine("Ben müşteri sınıf örneğiyim");
        }
        public string Ad { get; set; }
        public string Soyad { get; set; }
    }
}
