namespace Udemy29_TypeConversions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Konu 1 : Bilinçli Tür Dönüşümleri
            // Muhtemel değer kaybı olduğu için compiler parantez içinde yazmadan dönüştürmez.
            // Örnek 1 : Değerin küsüratı kaybolabilir.

            double doubleDeger1 = 56.90;
            int intDeger1 = (int)doubleDeger1;

            Console.WriteLine(doubleDeger1);
            Console.WriteLine(intDeger1);

            // Örnek 2 : Veri kaybı olur değer büyükken küçüğe dönüştürdüğümüz için.

            long longDeger1 = 1234567891011;
            int intDeger2 = (int)longDeger1;

            Console.WriteLine(longDeger1);
            Console.WriteLine(intDeger2);

            // Örnek 3 : object veri tipi her şeyi tutabileceği için herhangi bir değer kaybı yaşanmaz.

            object objectDeger1 = "Mert Osman";
            string metin1 = (string)objectDeger1;

            Console.WriteLine(objectDeger1);
            Console.WriteLine(metin1);

            // Konu 2 : Bilinçsiz Tür Dönüşümleri
            // Örnek 1 : Parantez içinde dönüştür dememe gerek kalmıyor onaya gerek kalmadan dönüştürülüyor.
            // Herhangi bir sorun çıkarmayacağı için compiler uyarı vermez.
            int intDeger3 = 9000;
            double doubleDeger2 = intDeger3;

            Console.WriteLine(intDeger3);
            Console.WriteLine(doubleDeger2);

            // Örnek 2 :
            byte byteDeger3 = 255;
            long longDeger3 = byteDeger3;

            Console.WriteLine(byteDeger3);
            Console.WriteLine(longDeger3);

            // Konu 3 : Parse İşlemleri

            string parseVeri1 = "45";
            // int parseInt1 = (int)parseVeri1; // string olan veriyi forcelayarak da çeviremeyiz.
            int parseInt1 = int.Parse(parseVeri1); // içinde string değer olmadığı sürece işe yarar.

            bool isOK = int.TryParse(parseVeri1, out parseInt1); // çevirilebiliyor mu diye kontrol eder.

            // Konu 4 : Convert İşlemleri

            //string convertMetin1 = null;
            //string convertMetin1 = "90A";
            string convertMetin1 = "90";
            int convertInt1 = Convert.ToInt32(convertMetin1);
            Console.WriteLine(convertInt1);
        }
    }
}
