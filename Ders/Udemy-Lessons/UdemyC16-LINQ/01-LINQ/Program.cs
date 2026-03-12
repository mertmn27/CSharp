namespace _01_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dataSource ds = new dataSource();
            List<Musteri> musteriListe = ds.MusteriListesi();
            Console.WriteLine(musteriListe.Count);

            int bulunanToplam = 0;
            for (int i = 0; i < musteriListe.Count; i++)
            {
                if (musteriListe[i].Isim[0] == 'A')
                {
                    bulunanToplam++;
                }
            }

            Console.WriteLine($"Kayıt syısı {bulunanToplam}");

            bulunanToplam = 0;

            bulunanToplam = musteriListe.Where(I => I.Isim.StartsWith("A")).Count();
            Console.WriteLine($"Kayıt sayısı {bulunanToplam}");
        }
    }
}
