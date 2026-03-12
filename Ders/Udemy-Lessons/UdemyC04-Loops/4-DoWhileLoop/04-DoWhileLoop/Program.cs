namespace Udemy030_DoWhileLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //do
            //{

            //} while (true);

            string kullaniciDeger = "";
            do
            {
                Console.WriteLine("Döngüden çıkmak için 1 tuşuna basınız.");
                kullaniciDeger = Console.ReadLine();
            } while (kullaniciDeger != "1");
        }
    }
}
