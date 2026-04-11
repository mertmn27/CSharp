using _03_GenericClasses.Models;
using _03_GenericClasses.Operations;

namespace _03_GenericClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.ID = 1;
            M1.Isim = "Mert";
            M1.Soyisim = "Arslan";

            Repository<Musteri> repositoryMusteri = new Repository<Musteri>();
            repositoryMusteri.Add(M1);

            Urun U1 = new Urun()
            {
                ID = 1,
                Name = "Telefon"
            };

            Repository<Urun> repositoryUrun = new Repository<Urun>();
            repositoryUrun.Add(U1);
        }
    }
}
