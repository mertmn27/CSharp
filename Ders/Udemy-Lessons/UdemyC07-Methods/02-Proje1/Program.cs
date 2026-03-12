namespace _02_Proje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç adet sayı toplamak istersiniz: ");
            int adet = Convert.ToInt32(Console.ReadLine());

            Operations operations = new Operations();

            int[] kullaniciDizi = operations.SayilarAl(adet);

            int toplam = operations.toplamHesapla(kullaniciDizi);
            decimal ortalama = operations.ortalamaHesapla(kullaniciDizi,adet);

            Console.WriteLine("Sayıların toplamı: "+ toplam);
            Console.WriteLine("Sayıların ortalaması: "+ ortalama);
        }
    }
}
