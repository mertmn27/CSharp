using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.Java;
using System.Text;

namespace _16_Proje4.Model
{
    internal sealed class Bilgisayar:Urun
    {
        public string Islemci { get; set; }
        public int Ram { get; set; }
        public Bilgisayar()
        {
            
        }
        public Bilgisayar(string marka, string model, string islemci, int ram):base(marka,model)
        {
            this.Islemci = islemci;
            this.Ram = ram;
        }

        internal override void BilgiVer()
        {
            Console.WriteLine($"Marka : {Marka} - Model : {Model} - İşlemci : {Islemci} - Ram : {Ram}");
        }
    }
}
