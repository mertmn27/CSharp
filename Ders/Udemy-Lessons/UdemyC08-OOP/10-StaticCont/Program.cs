namespace _10_StaticCont
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İsminizi giriniz: ");
            Musteri.TamAd = Convert.ToString(Console.ReadLine());
            Musteri.Selamla();
        }
    }
}
