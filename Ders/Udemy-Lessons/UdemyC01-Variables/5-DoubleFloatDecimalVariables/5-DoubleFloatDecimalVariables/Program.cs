namespace Udemy24_DoubleFloatDecimalVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ondalıklı işlemler için double,float ve decimal kullanabiliriz.
            float odaSicakligi = 30.2f; // Performans öncelikli işlemlerde kullanılır 4 byte yer kaplar.
            double pi = 3.14; // Ondalık işlemler için genel olarak kullanılır 8 byte yer kaplar
            decimal urunFiyati = 300.12m; // Çok ince detay gerektiren işlemlerde kullanılır 16 byte yer kaplar.

            Console.WriteLine(odaSicakligi);
            Console.WriteLine(pi);
            Console.WriteLine(urunFiyati);
        }
    }
}
