namespace _07_Params
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operasyon operasyon = new Operasyon();
            operasyon.kisiTani("Mert", "Arslan", "A Kitabı");
            operasyon.kisiTani("Mert", "Arslan", "A Kitabı", "B", "C");
        }
    }
}
