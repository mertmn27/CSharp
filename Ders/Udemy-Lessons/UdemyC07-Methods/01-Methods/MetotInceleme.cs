using System;
using System.Collections.Generic;
using System.Text;

namespace _01_Methods
{
    internal class MetotInceleme
    {
        // [erişim belirleyicisi] public ( her yerden erişilebilir )
        // [geri dönüş tipi] int,decimal,personel,void
        // [metot adı]
        // [parametre] Metot parametre alıyorsa => (parametre) Metot parametre almıyorsa => ()
        // 

        public void Selamla()
        {
            Console.WriteLine("Merhaba");
        }

        public string Karsila(string isim, string soyisim)
        {
            return isim + " " + soyisim;
        }

        public void topla(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine(toplam);
        }

        public int SayiUret()
        {
            Random random = new Random();
            int uretilenDeger = random.Next(1,101);
            return uretilenDeger;
        }
    }
}
