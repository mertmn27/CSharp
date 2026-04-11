namespace _03_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun;
            urun = new Urun(1,"A","Beyaz");
            urun.bilgileriYaz();
        }
    }
}
