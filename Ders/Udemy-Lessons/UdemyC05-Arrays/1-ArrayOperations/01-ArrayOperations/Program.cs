namespace Udemy038_ArrayOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string isim = "Mert";

            string[] isimler = new string[5];

            isimler[0] = "Mert";
            isimler[1] = "Osman";
            isimler[2] = "Arslan";
            isimler[3] = "Ahmet";
            isimler[4] = "Mehmet";

            string dizi_isim = isimler[1];
            isimler[2] = "Yakup";

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(isimler[i]);
            }

            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }
        }
    }
}
