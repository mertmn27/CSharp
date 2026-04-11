namespace _06_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap1 = new Kitap()
            {
                PriceII = 100M
            };
            kitap1.ID = 1;
            kitap1.Name = "Kitap Adı 1";
            // kitap1.PriceII = 100M;
        }
    }
}
