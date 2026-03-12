using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Params
{
    internal class Operasyon
    {
        public void kisiTani(string isim, string soyisim, params string[] kitaplar)
        {
            Console.WriteLine("İşlemler...");
        }
    }
}
