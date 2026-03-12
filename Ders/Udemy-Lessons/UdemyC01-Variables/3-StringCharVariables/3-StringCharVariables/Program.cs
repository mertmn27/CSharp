namespace Udemy22_StringCharVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // veriTipi degiskenAdi = Deger;

            string ad = "Mert";
            string soyad;
            soyad = "Arslan";

            Console.Write("Adinizi giriniz:");
            string kullaniciAdi = Console.ReadLine();
            Console.Write("Soyadinizi giriniz:");
            string kullaniciSoyad = Console.ReadLine();

            Console.WriteLine(kullaniciAdi);
            Console.WriteLine(kullaniciSoyad);

            char kullaniciSecim;
            kullaniciSecim = 'A';

            Console.WriteLine(kullaniciSecim);
        }
    }
}