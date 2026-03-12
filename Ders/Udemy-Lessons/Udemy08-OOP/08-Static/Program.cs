namespace _08_Static
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci O1 = new Ogrenci();
            Ogrenci O2 = new Ogrenci();
            Ogrenci O3 = new Ogrenci();
            O1.ID = 1;
            O1.Isim = "Mert";
            O1.Soyisim = "Arslan";

            O1.BilgiVer();

            Console.WriteLine(Ogrenci.Sayac);
            Ogrenci.Sayac = 1;
            Console.WriteLine(Ogrenci.Sayac);
        }
    }
}
