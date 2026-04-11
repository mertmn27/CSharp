using System;
using System.Collections.Generic;
using System.Text;

namespace _16_Proje4.Model
{
    internal sealed class Telefon:Urun
    {
        public int Hafiza { get; init; }
        public bool CiftSim { get; set; }

        public Telefon()
        {
            
        }

        public Telefon(string marka, string model, int hafiza, bool ciftSim):base(marka,model)
        {
            this.Hafiza = hafiza;
            this.CiftSim = ciftSim;
        }

        internal override void BilgiVer()
        {
            Console.WriteLine($"Marka : {Marka} - Model : {Model} - Hafıza : {Hafiza} - Çift Sim : {CiftSim}");
        }

    }
}
