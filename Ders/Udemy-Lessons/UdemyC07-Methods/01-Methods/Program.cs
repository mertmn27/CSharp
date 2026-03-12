namespace _01_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MetotInceleme metot = new MetotInceleme();
            metot.Selamla();

            string tamAd = metot.Karsila("Mert", "Arslan");
            Console.WriteLine(tamAd);

            metot.topla(5, 12);

            Console.WriteLine(metot.SayiUret());
        }
    }
}
