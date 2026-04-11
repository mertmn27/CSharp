using _14_Inheritance.Model;

namespace _14_Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            Personel P1 = new Personel();
            Urun U1 = new Urun();

            //Boxing
            Base B1 = new Base();
            B1 = M1;

            //Unboxing

            Musteri M2 = (Musteri)B1;
        }
    }
}
