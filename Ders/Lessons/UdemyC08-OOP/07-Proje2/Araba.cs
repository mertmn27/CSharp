using System;
using System.Collections.Generic;
using System.Text;

namespace _07_Proje2
{
    internal class Araba
    {

        public Araba()
        {
            this.ID = Guid.NewGuid();
        }
        public string Marka { get; private set; }
        public Araba(string marka)
        {
            this.Marka = marka;
        }
        public Guid ID { get; init; }
        private string _model;        
        public string Model
        {
            get
            {
                return _model; 
            }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _model = value;
                }
            }
        }

        private decimal _price;

        public int Year { get; init; }
        public decimal Price
        {
            get
            {
                return _price; 
            }
            set
            {
                if(value > 0)
                {
                    _price = value;
                }
            }
        }
    }
}
