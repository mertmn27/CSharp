using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Overloading
{
    internal class Operations
    {
        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }

        public int Topla(int sayi1, int sayi2, int sayi3)
        {
            return sayi1 + sayi2 + sayi3;
        }

        public decimal Topla(decimal sayi1, decimal sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
