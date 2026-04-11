namespace Udemy025_SwitchCaseStatements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            switch(deger)
            {
                case sabitdeger1:

                break;

                case sabitdeger2:

                break;

                default:

                break;
            }
            */

            Console.WriteLine("İçecek seçiniz\n1-Su\n2-Çay\n3-Türk Kahvesi\n4-Filtre Kahve\n5-Sütlü Filtre Kahve");
            string strDeger = Console.ReadLine();

            switch (strDeger)
            {
                case "1":
                    Console.WriteLine("Su içtiniz.");
                    break;
                case "2":
                    Console.WriteLine("Çay içtiniz.");
                    break;
                case "3":
                    Console.WriteLine("Türk Kahvesi içtiniz.");
                    break;
                case "4":
                case "5":
                    Console.WriteLine("Filtre Kahve içtiniz.");
                    break;
                default:
                    Console.WriteLine("Yanlış seçim yaptınız.");
                    break;

            }
        }
    }
}
