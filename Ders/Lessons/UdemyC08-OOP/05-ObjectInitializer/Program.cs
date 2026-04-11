namespace _05_ObjectInitializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap kitap = new Kitap();
            Kitap kitap2 = new Kitap()
            {
                ID = 1,
                Name = "test",
                Price = 100,
            };
        }
    }
}
