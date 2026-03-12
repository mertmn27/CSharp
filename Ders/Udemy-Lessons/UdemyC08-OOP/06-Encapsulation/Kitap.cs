using System;
using System.Collections.Generic;
using System.Text;

namespace _06_Encapsulation
{
    internal class Kitap
    {
        private int _id; // İç kısımda korumak istediğimiz field.

        internal int ID // dış kısımda kullanıcıların göreceği property.
        {
            get
            {
                return _id;
            }
            set
            {
                if (value > 0)
                {
                    _id = value;
                }
            }
        }

        private string _name;

        internal string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                _name = value; 
            }
        }

        public decimal PriceII { get; init; } // Sadece nesne oluşturulurken değer verebilirsin sonradan değiştiremezsin.

    }
}
