using System;
using System.Collections.Generic;
using System.Text;

namespace Deneme
{
    internal class Operations
    {
        public int[] sayilarAl(int adet)
        {
            int[] kullaniciDizi = new int[adet];

            for(int i = 0; i < adet; i++)
            {
                Console.WriteLine($"Enter {i+1}. number : ");
                kullaniciDizi[i] = Convert.ToInt32(Console.ReadLine());
            }

            return kullaniciDizi;
        }

        public void ortalamaHesapla(int[] kullaniciDizi)
        {
            int sum = 0;

            for (int i = 0; i < kullaniciDizi.Length; i++)
            {
                sum += kullaniciDizi[i];
            }

            Console.WriteLine($"Sayıların Ortalaması : {sum/kullaniciDizi.Length}");
        }

        public void toplamHesapla(int[] kullaniciDizi)
        {
            int sum = 0;

            for(int i = 0; i < kullaniciDizi.Length; i++)
            {
                sum += kullaniciDizi[i];
            }

            Console.WriteLine($"Sayıların Toplamı : {sum}");
        }
    }
}
