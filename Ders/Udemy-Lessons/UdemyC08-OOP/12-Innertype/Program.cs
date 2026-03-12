using _12_Innertype.Model;

namespace _12_Innertype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();

            //İhtiyacımız olduğu anda ilgili alt tipleri örnekleme ve tanımlama senaryosu.
            M1.iletisimBilgi = new IletisimBilgi();
            M1.iletisimBilgi.Tanim = "Tanimssssssss";

            Console.WriteLine(M1.iletisimBilgi.Tanim);
            Console.WriteLine("");

        }
    }
}
