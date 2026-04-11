using _11_OtoparkUygulaması.Model;
using System.Security.Cryptography;

namespace _11_OtoparkUygulaması
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Otopark otopark = new Otopark(18);

            otopark.tamAd = "Düzce Otopark";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("-------------------------");
                Console.WriteLine("1 -> Araç Ekle \n2 -> Araç Çıkar \n3 -> Araç Liste \n0 -> Çıkış");
                string secim = Console.ReadLine();

                switch (secim)
                {
                    case "1":
                        otopark.AracEkle();
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
                        Console.ReadLine();
                        break;
                    case "2":
                        otopark.otoparkListe();
                        otopark.AracCikart();
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
                        Console.ReadLine();
                        break;
                    case "3":
                        otopark.otoparkListe();
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
                        Console.ReadLine();
                        break;
                    case "0":
                        Console.WriteLine("Uygulamadan çıkılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz Seçim yaptınız.");
                        Console.WriteLine("Ana menüye dönmek için bir tuşa basınız.");
                        Console.ReadLine();
                        break;
                }
            }
        }
    }
}
