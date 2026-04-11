namespace Deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            int adet;

            Console.Write("Kaç adet sayı toplamak istersiniz: ");
            adet = Convert.ToInt32(Console.ReadLine());

            int[] kullaniciDizi = operations.sayilarAl(adet);

            operations.toplamHesapla(kullaniciDizi);
            operations.ortalamaHesapla(kullaniciDizi);
        }
    }
}
