namespace _02_ByValueByReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();

            urun1.urunId = 1;
            urun1.urunAd = "A";
            urun1.urunRenk = "Beyaz";
            urun1.urunFiyat = 30000M;

            //Atama olursa bu şekilde ikisi de aynı yeri pointler.
            Urun urun2 = urun1;

            urun2.urunId = 2;

            Console.WriteLine(urun1.urunId);

            //Değer tipli davranış modeli : Her değişken ( tanım ) kendi üzerindeki değerden sorumludur.

            int sayi1 = 10;
            int sayi2 = 20;

            sayi2 = sayi1;
            sayi2 = 90;
        }
    }
}
