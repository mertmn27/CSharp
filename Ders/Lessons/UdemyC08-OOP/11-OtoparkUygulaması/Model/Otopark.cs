using System;
using System.Collections.Generic;
using System.Text;

namespace _11_OtoparkUygulaması.Model
{
    internal class Otopark
    {
        public static double dakikaUcret { get; set; }

        static Otopark()
        {
            dakikaUcret = 2;
        }
        public string tamAd { get; set; }
        public OtoparkAlan[] otoparkAlanlar { get; set; }
        public Otopark(int alanBilgisi)
        {
            otoparkAlanlar = otoparkAlanOlustur(alanBilgisi);
        }

        private OtoparkAlan[] otoparkAlanOlustur(int alanBilgisi)
        {
            OtoparkAlan[] alan = new OtoparkAlan[alanBilgisi];
            char harf = 'A';
            int sayi = 1;

            for (int i = 0; i < alan.Length ; i++)
            {
                alan[i] = new OtoparkAlan() { AlanNo = $"{harf}{sayi}" };
                sayi++;

                if(sayi > 6)
                {
                    sayi = 1;
                    harf++;
                }
            }
            return alan;
        }

        internal void otoparkListe()
        {
            int kontrol = otoparkAlanlar.Count(I => I.aktifArac != null);
            if (kontrol > 0)
            {
                foreach (var item in otoparkAlanlar)
                {
                    if (item.aktifArac != null)
                    {
                        Console.WriteLine($"{item.AlanNo} - {item.aktifArac.plaka} - {item.girisSaati}");
                    }

                }
            }
            else
            {
                Console.WriteLine("Otopark boş.");
            }
        }

        internal void AracEkle()
        {
            Arac musteri = new Arac();

            Console.Write("Plaka : ");
            musteri.plaka = Console.ReadLine();

            Console.Write("Marka : ");
            musteri.marka = Console.ReadLine();

            Console.Write("Model : ");
            musteri.model = Console.ReadLine();

            foreach (var item in otoparkAlanlar)
            {
                if(item.aktifArac == null)
                {
                    item.aktifArac = musteri;
                    item.girisSaati = DateTime.Now;
                    Console.WriteLine($"{item.AlanNo} alanına aracınızı park edebilirsiniz.");
                    return; // Araç metotu içerisinden çıkar, break gibi döngüyü kırıp döngü sonunda olan kodlardan devam etmez.
                }
            }

            Console.WriteLine("Otopark dolu.");
        }

        internal void AracCikart()
        {
            Console.Write("Çıkmak isteyen aracın plakasını giriniz : ");
            string plaka = Console.ReadLine();

            bool plakaKontrol = false;

            foreach( var item in otoparkAlanlar)
            {
                if(item.aktifArac != null && item.aktifArac.plaka == plaka)
                {
                    plakaKontrol = true;
                    break;
                }
            }

            if(plakaKontrol)
            {
                foreach( var item in otoparkAlanlar)
                {
                    if(item.aktifArac != null && item.aktifArac.plaka == plaka)
                    {
                        item.cikisSaati = DateTime.Now;
                        var dakika = (item.cikisSaati - item.girisSaati).TotalMinutes;
                        var ucret = dakika * Otopark.dakikaUcret;
                        item.aktifArac = null;
                        item.girisSaati = DateTime.MinValue;
                        item.cikisSaati = DateTime.MinValue;

                        Console.WriteLine($"Toplam ücret {ucret} tl");
                    }
                }
                Console.WriteLine("Aracınızı otoparktan çıkarttınız.");
            }
            else
            {
                Console.WriteLine("Aranan araç bulunamadı");
            }
        }
    }
}
