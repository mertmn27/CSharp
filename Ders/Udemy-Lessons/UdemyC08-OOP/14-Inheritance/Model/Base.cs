using System;
using System.Collections.Generic;
using System.Text;

namespace _14_Inheritance.Model
{
    internal class Base
    {
        public Base()
        {
            Console.WriteLine("Ben hepsinden önce çalıştım.");
        }
        public int ID { get; set; }
        public DateTime OlusturmaTarihi { get; set; }

    }
}
