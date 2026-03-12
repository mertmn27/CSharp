namespace _02_İsimsizMetotKullanımı
{
    internal class Program
    {
        delegate void EkranaYaz(string isim, string soyisim);
        static void Main(string[] args)
        {
            // Var olan bir metodu kullanarak delegate içine ekleme
            EkranaYaz Test1 = new EkranaYaz(Test1Metot);
            EkranaYaz Test2 = new EkranaYaz(delegate (string isim, string soyisim)
            {
                Console.WriteLine(isim + " " + soyisim);
            });

            EkranaYaz Test3 = (isim, soyisim) =>
            {
                Console.WriteLine(isim + " " + soyisim);
            };

            Test1("Mert", "Arslan");
            Test2("Osman", "Arslan");
            Test3("Arslan", "Arslan");
        }

        static void Test1Metot(string isim, string soyisim)
        {
            Console.WriteLine(isim + " " + soyisim);
        }
    }
}
