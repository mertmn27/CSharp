using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OtoparkUygulaması.Model
{
    internal class OtoparkAlan
    {
        public string AlanNo { get; set; }
        public Arac aktifArac { get; set; }
        public DateTime girisSaati { get; set; }
        public DateTime cikisSaati { get; set; }
    }
}
