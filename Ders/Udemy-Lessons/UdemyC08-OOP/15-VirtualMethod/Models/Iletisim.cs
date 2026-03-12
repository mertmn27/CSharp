using System;
using System.Collections.Generic;
using System.Text;

namespace _15_VirtualMethod.Models
{
    internal class Iletisim
    {
        public string IletisimTip { get; set; }
        public string IletisimDegeri { get; set; }
        public Iletisim()
        {
            
        }

        internal virtual void BilgiVer()
        {
            Console.WriteLine("Bu mesaj iletişim class'ı içerisinden gelmiştir.");
        }
    }
}
