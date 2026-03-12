using System;
using System.Collections.Generic;
using System.Text;

namespace _02_Proje1
{
    internal class Operations
    {
        public int[] SayilarAl(int adet)
        {
            int[] sayilar = new int[adet];
            for (int i = 0; i < adet; i++)
            {
                Console.Write("Sayı Giriniz: ");
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            return sayilar;
        }
        public int toplamHesapla(int[] dizi)
        {
            int toplam = 0;
            for(int i = 0; i < dizi.Length;i++)
            {
                toplam += dizi[i];
            }
            return toplam;
        }

        public decimal ortalamaHesapla(int[] dizi,int adet)
        {
            decimal toplam = 0;
            for(int i = 0; i < dizi.Length;i++)
            {
                toplam += dizi[i];
            }
            decimal ortalama = toplam / adet;
            return ortalama;
        }
    }
}
