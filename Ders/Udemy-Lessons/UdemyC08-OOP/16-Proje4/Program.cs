using _16_Proje4.Data;
using _16_Proje4.Model;

namespace _16_Proje4
{
    internal class Program
    {
        static int sayac = 0;
        static void Main(string[] args)
        {
            while(true)
            {
                Console.Clear();
                Console.WriteLine("Ürün Takip Sistemi");

                Console.WriteLine("1-Telefon Ekle\n2-Bilgisayar Ekle\n3-Listele( Telefon )\n4-Listele ( Bilgisayar )\n5-Listele" +
                    "\n6-Çıkış");
                Console.Write("Seçiminiz: ");
                string secim = Console.ReadLine();
                switch(secim)
                {
                    case "1":
                        TelefonEkle();
                        break;
                    case "2":
                        BilgisayarEkle();
                        break;
                    case "3":
                        TelefonListele();
                        break;
                    case "4":
                        BilgisayarListele();
                        break;
                    case "5":
                        Listele();
                        break;
                    case "6": return;
                    default:
                        Console.WriteLine("Yanlış seçim yaptınız.");
                        break;
                }
                Console.WriteLine("Devam etmek için bir tuşa basınız.");
                Console.ReadKey();
            }

        }

        static void TelefonEkle()
        {
            Console.Write("Marka :");
            string Marka = Console.ReadLine();

            Console.Write("Model :");
            string Model = Console.ReadLine();

            Console.Write("Hafıza GB :");
            int Hafiza = Convert.ToInt32(Console.ReadLine());

            Console.Write("Cift Sim :");
            bool ciftSim = Convert.ToBoolean(Console.ReadLine());

            Telefon telefon = new Telefon(Marka, Model, Hafiza, ciftSim);

            RamDB.urunler[sayac] = telefon;
            sayac++;
        }

        static void BilgisayarEkle()
        {
            Console.Write("Marka :");
            string Marka = Console.ReadLine();

            Console.Write("Model :");
            string Model = Console.ReadLine();

            Console.Write("Islemci :");
            string Islemci = Console.ReadLine();

            Console.Write("Ram :");
            int Ram = Convert.ToInt32(Console.ReadLine());

            Bilgisayar bilgisayar = new Bilgisayar(Marka, Model, Islemci, Ram);
            RamDB.urunler[sayac] = bilgisayar;
            sayac++;
        }

        static void TelefonListele()
        {
            foreach(Urun item in RamDB.urunler)
            {
                if(item != null && item.GetType().Name == "Telefon")
                {
                    Telefon telefonItem = (Telefon)item;
                    telefonItem.BilgiVer();
                }
            }
        }

        static void BilgisayarListele()
        {
            foreach(Urun item in RamDB.urunler)
            {
                if(item != null && item.GetType().Name == "Bilgisayar")
                {
                    Bilgisayar bilgisayarItem = (Bilgisayar)item;
                    bilgisayarItem.BilgiVer();
                }
            }
        }

        static void Listele()
        {
            foreach(Urun item in RamDB.urunler)
            {
                if(item != null && item.GetType().Name == "Telefon")
                {
                    Telefon telefonItem = (Telefon)item;
                    telefonItem.BilgiVer();
                }
                else if (item != null && item.GetType().Name == "Bilgisayar")
                {
                    Bilgisayar bilgisayarItem = (Bilgisayar)item;
                    bilgisayarItem.BilgiVer();
                }
            }
        }

    }
}
