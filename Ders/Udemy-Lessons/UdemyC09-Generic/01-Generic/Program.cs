using System.Collections;

namespace _01_Generic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Musterilerimi bir koleksiyon içerisinde tutmak istiyorum.
            // 1: Dizi oluştur ve bunları sakla.
            // +: Tip güvenli olur içeride kesinlikle musteri nesnesi olduğunu bilirsin.
            // -: Vermiş olduğunuz adetten sonra yeniden boyutlandırma işlemi yapmanız gerekir.

            Musteri[] musteriler1 = new Musteri[5];

            musteriler1[0] = new Musteri() { ID = 1, Isim = "Mert", Soyisim = "Arslan" };
            musteriler1[1] = new Musteri() { ID = 2, Isim = "Ali", Soyisim = "Çelik" };

            // 2: Arraylist:
            // -: Her bir değeri object olarak saklar tip güvenli değildir.
            // +: Kendi kendine büyüyebilen bir yapıya sahiptir.
            ArrayList musteriler2 = new ArrayList();
            musteriler2.Add(new Musteri() { ID = 1, Isim = "Mert", Soyisim = "Arslan" });

            // ************** Generic : List<T> ****************

            List<int> sayilarKoleksiyon = new List<int>();

            sayilarKoleksiyon.Add(1);
            sayilarKoleksiyon.Add(10);
            sayilarKoleksiyon.Add(30);
            sayilarKoleksiyon.Add(50);
            sayilarKoleksiyon.Add(70);
            sayilarKoleksiyon.AddRange(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });

            int sayi1 = sayilarKoleksiyon[1];
            sayilarKoleksiyon.Remove(sayi1);

            // Musteri tipimiz ile alakalı olan kısım

            Musteri M1 = new Musteri() { ID = 1, Isim = "Mert", Soyisim = "Arslan" };
            List<Musteri> musteriler = new List<Musteri>();

            musteriler.Add(M1);

            musteriler.Add(new Musteri() { ID = 2, Isim = "Tolga", Soyisim = "Arslan" });

            for(int i = 0; i < musteriler.Count; i++)
            {
                Musteri item = musteriler[i];
                Console.WriteLine(item.ID + " " + item.Isim + " " + item.Soyisim);
            }

            // Musteriden kalıtılmışları da tutabilir.
        }
    }
}
