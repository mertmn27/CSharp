namespace Udemy39_ArithmeticOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Aritmetiksel Operatorler
            /*
            + Toplama
            - Çıkartma
            / Bölme
            * Çarpma
            % Mod Alma
            */

            // Toplama
            int sayi1 = 100;
            int sayi2 = 50;

            int toplam = sayi1 + sayi2;

            // Çıkarma

            int cikarma = sayi1 - sayi2;
            cikarma = sayi2 - sayi1;

            // Bölme

            decimal sayi3 = 10;
            decimal sayi4 = 3;
            decimal bolme = sayi3 / sayi4;

            // Çarpma

            decimal sayi5 = 10;
            decimal sayi6 = 5;
            decimal carpma = sayi5 * sayi6;

            // Mod Alma

            int sayi7 = 12;
            int sayi8 = 5;
            int modAlma = sayi7 % sayi8;
        }
    }
}
