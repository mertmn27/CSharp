using _04_Proje1.Models;
using _04_Proje1.Operations;

namespace _04_Proje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Repository<Musteri> musteriRepository = new Repository<Musteri>();
            Repository<Urun> urunRepository = new Repository<Urun>();

            Console.WriteLine("Hoşgeldiniz");
            while (true)
            {
                Console.WriteLine("----- Menu -----");
                Console.WriteLine("1 - Musteri Ekle");
                Console.WriteLine("2 - Urun Ekle");
                Console.WriteLine("3 - Müşteri Liste");
                Console.WriteLine("4 - Urun Liste");
                Console.Write("Seçiminiz : ");
                string kullaniciSecim = Console.ReadLine();

                switch(kullaniciSecim)
                {
                    case "1":
                        Musteri M1 = new Musteri();
                        Console.Write("ID Değerini Girin : ");
                        M1.ID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Isim : ");
                        M1.Isim = Console.ReadLine();

                        Console.Write("Soyisim : ");
                        M1.Soyisim = Console.ReadLine();

                        musteriRepository.Add(M1);

                        break;
                    case "2":
                        Urun U1 = new Urun();
                        Console.Write("ID Değerini Girin : ");
                        U1.ID = Convert.ToInt32(Console.ReadLine());

                        Console.Write("Urun Adını Girin : ");
                        U1.Tanim = Console.ReadLine();

                        urunRepository.Add(U1);

                        break;
                    case "3":
                        List<Musteri> musteriItems = musteriRepository.GetItems();
                        foreach(Musteri m in musteriItems)
                        {
                            Console.WriteLine(m.Isim);
                        }
                        break;
                    case "4":
                        List<Urun> urunItems = urunRepository.GetItems();
                        foreach(Urun u in urunItems)
                        {
                            Console.WriteLine(u.ID);
                        }
                        break;
                    default:
                        return;
                }
            }
        }
    }
}
