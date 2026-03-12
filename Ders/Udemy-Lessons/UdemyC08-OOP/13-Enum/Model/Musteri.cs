using System;
using System.Collections.Generic;
using System.Text;

namespace _13_Enum.Model
{
    internal class Musteri
    {
        public int ID { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public MusteriDurum Durum { get; set; }
    }
}
