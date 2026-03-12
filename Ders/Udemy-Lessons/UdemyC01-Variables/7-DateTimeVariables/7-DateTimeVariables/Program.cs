namespace Udemy26_DateTimeVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime hazirlikZamani = DateTime.Now.AddDays(-1);
            DateTime olusturmaZamani = DateTime.Now;
            DateTime siparisZamani = DateTime.Now.AddDays(3);
            DateTime gonderimZamani = DateTime.Now.AddDays(10);
            DateTime ulasimZamani = DateTime.Now.AddYears(2);

            Console.WriteLine(hazirlikZamani);
            Console.WriteLine(olusturmaZamani);
            Console.WriteLine(siparisZamani);
            Console.WriteLine(gonderimZamani);
            Console.WriteLine(ulasimZamani);
        }
    }
}
