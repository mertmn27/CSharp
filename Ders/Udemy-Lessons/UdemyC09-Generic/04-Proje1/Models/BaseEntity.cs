using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Proje1.Models
{
    internal class BaseEntity
    {
        public int ID { get; set; }
        public DateTime OlusturmaTarihi { get; private set; }

        public BaseEntity()
        {
            OlusturmaTarihi = DateTime.Now;
        }
    }
}
