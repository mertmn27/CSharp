namespace _01_TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("İsminizi Girin: ");
            string isim = Console.ReadLine();

            try
            {
                Console.Write("Yaşınızı Giriniz: ");
                int yas = Convert.ToInt32(Console.ReadLine());
            }
            catch(Exception ex)
            {
                Console.WriteLine("Yaşınızı hatalı girdiniz");
            }
            finally
            {
                //Hata alınsa da alınmasa da çalışacak olan kod bloklarımız.
                Console.WriteLine("Ben hata alınsa da alınmasa da çalıştım.");
            }

            Console.ReadLine();
        }
    }
}
