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

        static bool predicateDelegateMethod(Musteri m)
        {
            if(m.DogumTarihi.Year > 1990)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        static void MusteriListele(Musteri m)
        {
            Console.WriteLine(m.Isim + " " + m.Soyisim);
        }
        static void Main(string[] args)
        {
            dataSource ds = new dataSource();
            List<Musteri> musteriListe = ds.MusteriListesi();

            #region LINQ Uygulama

            var odevAlistirma1 = from I in musteriListe
                                 where I.Isim.StartsWith("A") && I.Soyisim.Contains("e") && I.DogumTarihi.Year > 1985
                                 select I;

            var odevAlistirma2 = musteriListe.Where(I => I.Isim.StartsWith("A") && I.Soyisim.Contains("e") && I.DogumTarihi.Year > 1985).Select(I => I);

            #endregion

            #region LINQ Sorgularında Action Delegate Kullanımı =>

            Action < Musteri > actionMusteri = new Action<Musteri>(MusteriListele);
            musteriListe.ForEach(actionMusteri);

            musteriListe.ForEach(new Action<Musteri>(MusteriListele));

            musteriListe.ForEach(delegate (Musteri m) { Console.WriteLine(m.Isim + " " + m.Soyisim); });

            musteriListe.ForEach((Musteri m) => { Console.WriteLine(m.Isim + " " + m.Soyisim); });

            musteriListe.ForEach((m) => { Console.WriteLine(m.Isim + " " + m.Soyisim); });
            #endregion

            #region LINQ Sorgularında Predicate Delegate Kullanımı =>
            // Func delegate sadece boolean değer dönmez herhangi bir değer dönebilir ancak predicate delegate sadece bool döner.
            Predicate<Musteri> Predicate = new Predicate<Musteri>(predicateDelegateMethod);

            var DelegateKullanimiPredicate1 = musteriListe.FindAll(Predicate);

            var DelegateKullanimiPredicate2 = musteriListe.FindAll(new Predicate<Musteri>(predicateDelegateMethod));

            var DelegateKullanimiPredicate3 = musteriListe.FindAll(delegate (Musteri m) { return m.DogumTarihi.Year > 1990; });

            var DelegateKullanimiPredicate4 = musteriListe.FindAll((Musteri m) => { return m.DogumTarihi.Year > 1990; });

            var DelegateKullanimiPredicate5 = musteriListe.FindAll((m) => { return m.DogumTarihi.Year > 1990; });

            var DelegateKullanimiPredicate6 = musteriListe.FindAll((m) => m.DogumTarihi.Year > 1990);
            #endregion

            #region LINQ sorgularında Func Delegate kullanımı =>

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
