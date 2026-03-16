namespace _01_LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dataSource ds = new dataSource();
            List<Musteri> musteriListe = ds.MusteriListesi();

            #region LINQ sorgularında Delegate kullanımı =>

            #endregion

            #region Alistirma

            IEnumerable<Musteri> musteriListeAlistirma1 = musteriListe.Where(I => I.Ulke.StartsWith("A"));
            int musteriAdetAlistirma1 = musteriListeAlistirma1.Count();


            var musteriListeAlistirma2 = musteriListe.Where(I => I.Isim.Contains("b") && I.Ulke.Contains("a"));

            var musteriListeAListirma3 = from I in musteriListe where I.DogumTarihi.Year > 1990 && I.Isim.Contains("a") select I;

            var musteriListeAListirma3 = from I in musteriListe where I.DogumTarihi.Year > 1990 || I.Isim.Contains("a") select I;
            #endregion

            int toplamMusteriAdet1 = musteriListe.Where(I => I.Isim.StartsWith("A")).Count();

            var toplamMusteriBulunan = from I in musteriListe where I.Isim.StartsWith("A") select I;

            int toplamMusteriAdet2 = toplamMusteriBulunan.Count();

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
