internal class Program
{
    private static void Main(string[] args)
    {
        int[] sayilar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
        Array.Sort(sayilar);

        foreach (var item in sayilar)
        {
            Console.WriteLine(item);
        }

        Array.Reverse(sayilar); // Ters çevirir.

        foreach (var item in sayilar)
        {
            Console.WriteLine(item);
        }

        int bulunanIndex = Array.IndexOf(sayilar, 10); // 10 sayısının indexini bulur.

        Console.WriteLine(bulunanIndex);

        int sonIndex = Array.LastIndexOf(sayilar, 12); // 12 sayısının son indexini bulur

        bool exists = Array.Exists(sayilar, I => I == 4); // içeride 4 var mı diye kontrol eder true false döner.
    }
}