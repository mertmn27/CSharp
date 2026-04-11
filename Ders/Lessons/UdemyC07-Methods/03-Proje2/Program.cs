namespace _03_Proje2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sayı tahmini uygulaması başlatıldı");
            Class newclass = new Class();
            
            int tahmin = newclass.SayiUret();
            Console.WriteLine("Sistem bir sayı üretti");

            int[] kullaniciDizi = newclass.DegerAl(3);
            Console.WriteLine("Değerlerinizi aldık kontrol ediyoruz...");

            newclass.kontrolEt(kullaniciDizi, tahmin);
        }
    }
}
