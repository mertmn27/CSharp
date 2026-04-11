namespace Udemy42_LogicalOperators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 20;
            bool a = true;
            bool b = false;

            // && operatoru
            bool veKontrol1 = a == true && b == false;
            // True + True = True
            // False + True = False
            // False + False = False

            // || operatoru

            bool veyaKontrol1 = a == true || b == false;
            // True + True = True
            // False + True = True
            // False + False = False
        }
    }
}
