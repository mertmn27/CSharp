using System;
using System.Collections.Generic;
using System.Text;

namespace _05_OptionalParameter
{
    internal class Operations
    {
        public void Selamla(string isimSoyisim)
        {
            if(string.IsNullOrEmpty(isimSoyisim))
            {
                Console.WriteLine("Selam ziyaretçi");
            }
            else
            {
                Console.WriteLine("Selam "+ isimSoyisim);
            }
        }

        public void SelamlaOpsiyonel(string isimSoyisim = "Ziyaretçi")
        {
            Console.WriteLine("Selam "+ isimSoyisim);
        }
    }
}
