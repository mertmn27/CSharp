using System;
using System.Collections.Generic;
using System.Text;

namespace _15_VirtualMethod.Models
{
    internal class Telefon:Iletisim
    {
        internal override void BilgiVer()
        {
            Console.WriteLine("Telefon class'ı içerisinden çalıştım.");
            //base.BilgiVer(); //Temel tipte olan bilgiver metotunu çalıştırmak için buraya otomatik olarak bırakıldı.
        }
    }
}
