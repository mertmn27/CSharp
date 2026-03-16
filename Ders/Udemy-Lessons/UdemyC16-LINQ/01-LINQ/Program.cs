using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;

namespace _01_LINQ
{
    internal class Program
    {
        static bool funcDelegateKullanimi1(Musteri m)
        {
            if (m.Isim[0] == 'A')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            dataSource ds = new dataSource();
            List<Musteri> musteriListe = ds.MusteriListesi();

            #region LINQ sorgularında Delegate kullanımı =>

            var delegateKullanimi1 = musteriListe.Where(I => I.Isim.StartsWith("A"));

            Func<Musteri, bool> funcDelegate1 = new Func<Musteri, bool>(funcDelegateKullanimi1);

            var delegateKullanimi2 = musteriListe.Where(funcDelegate1);

            var delegateKullanimi3 = musteriListe.Where(new Func<Musteri, bool>(funcDelegateKullanimi1));

            var delegateKullanimi4 = musteriListe.Where(delegate(Musteri m) { return m.Isim[0] == 'A' ? true : false; });

            var delegateKullanimi5 = musteriListe.Where((Musteri m) => { return m.Isim[0] == 'A' ? true : false; });

            var delegateKullanimi6 = musteriListe.Where((m) => { return m.Isim[0] == 'A' ? true : false; });

            var delegateKullanimi7 = musteriListe.Where(m => m.Isim[0] == 'A');
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
