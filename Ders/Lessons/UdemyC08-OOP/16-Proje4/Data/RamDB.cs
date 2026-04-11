using _16_Proje4.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Proje4.Data
{
    internal static class RamDB
    {
        internal static Urun[] urunler;

        static RamDB()
        {
            urunler = new Urun[20];
        }
    }
}
