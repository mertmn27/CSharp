using System;
using System.Collections.Generic;
using System.Text;

namespace _03_GenericClasses.Operations
{
    internal class Repository<T>
    {
        List<T> liste;

        public Repository()
        {
            liste = new List<T>();
        }

        internal void Add(T item) 
        { 
            liste.Add(item);
        }

    }
}
