namespace Udemy43_IncreaseDecreaseOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 100;
            // Artırma operatoru ++
            sayi = sayi + 1;
            sayi++;

            // Eksiltme operatoru --

            sayi = sayi - 1;
            sayi--;
            //Koşul operatoru

            string durum = (sayi > 105) ? "Sayi degeri 105 degerinden buyuk" : "Sayi degeri 105 degerinden kucuk";
            Console.WriteLine(durum);
        }
    }
}
