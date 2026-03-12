using System.Collections;

namespace Udemy044_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList isimler = new ArrayList();
            isimler.Add("Mert");
            isimler.Add("Ahmet");
            isimler.Add("Osman");

            Console.WriteLine($"İsimler adlı listenin içindeki eleman sayısı: {isimler.Count}");
            Console.WriteLine($"İsimler adlı listenin maksimum eleman sayısı: {isimler.Capacity}");

            isimler.Remove("Mert"); // içindekini siler
            isimler.RemoveRange(2, 4); // 2 den 4 tane siler

            isimler.Insert(2, "Yeni Değer"); // 2. indexe yeni değer ekler
            isimler[2] = "Yeni Değer";

            isimler.Clear(); // temizler
            isimler.TrimToSize();
        }
    }
}
