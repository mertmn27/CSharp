using _04_Proje1.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace _04_Proje1.Operations
{
    internal class Repository<T> where T : BaseEntity
    {
        private List<T> Items;

        public Repository()
        {
            Items = new List<T>();
        }

        internal void Add(T item) 
        {
            if(item != null) Items.Add(item);
        }

        internal List<T> GetItems() { return Items; }
    }
}
