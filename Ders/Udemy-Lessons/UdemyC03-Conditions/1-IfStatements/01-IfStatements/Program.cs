namespace Udemy021_IfStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double urunFiyati = 2000;

            string kullaniciMesaj = (urunFiyati >= 3000) ? "Ürün fiyatı 3000'den büyük" : "Ürün fiyatı 3000'den küçük";

            Console.WriteLine(kullaniciMesaj);

            /*
            if(koşul veya koşullar) True
            {
                işlemler yapılır
            }
             */

            if (urunFiyati >= 3000) // Doğru ise
            {
                Console.WriteLine("Kod1");
                Console.WriteLine("Kod2");
                Console.WriteLine("Kod3");
            }
            else if (urunFiyati >= 2000)
            {
                Console.WriteLine("Urun fiyati 2000 den buyuk");
            }
            else
            {
                Console.WriteLine("Kod X");
                Console.WriteLine("Kod Y");
            }
        }
    }
}
