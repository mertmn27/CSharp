using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Proje2
{
    internal class Class
    {
        public int SayiUret()
        {
            Random rnd = new Random();
            return rnd.Next(1,101);
        }

        public int[] DegerAl(int hak)
        {
            int[] kullaniciDizi = new int[hak];

            for (int i = 0; i < hak; i++)
            {
                Console.Write("Bir sayi giriniz: ");
                int kullanici_tahmin = Convert.ToInt32(Console.ReadLine());

                bool kontrol = Array.Exists(kullaniciDizi, I => I == kullanici_tahmin);
                if(!kontrol)
                {
                    Console.WriteLine("Değer eklendi");
                    kullaniciDizi[i] = kullanici_tahmin;
                }
                else
                {
                    Console.WriteLine("Var olan bir değer girdiniz: ");
                    i--;
                }
            }
            return kullaniciDizi;
        }

        public void kontrolEt(int[] kullaniciDizi, int uretilenDeger)
        {
            Console.WriteLine("Sistemin üretmiş olduğu değer: " + uretilenDeger);
            
            bool sonucKontrol = Array.Exists(kullaniciDizi, I => I == uretilenDeger);

            if(sonucKontrol)
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }
        }
    }
}
