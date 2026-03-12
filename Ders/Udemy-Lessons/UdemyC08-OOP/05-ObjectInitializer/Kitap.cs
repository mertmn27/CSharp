using System;
using System.Collections.Generic;
using System.Text;

namespace _05_ObjectInitializer
{
    internal class Kitap
    {
        public int ID;
        public string Name;
        public string Description;
        public decimal Price;

        public Kitap() { }

        public Kitap(int id, string name)
        {
            this.ID = id;
            this.Name = name;
        }

        public Kitap(int id, string name, string description) : this(id,name)
        {
            this.Description = description;
        }
    }
}
