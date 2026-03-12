using System;
using System.Collections.Generic;
using System.Text;

namespace _01_LINQ
{
    public class dataSource
    {
        List<Musteri> musteriler;

        public dataSource()
        {
            musteriler = new List<Musteri>();
        }

        public List<Musteri> MusteriListesi()
        {
            for(int i = 1; i <= 1000; i++)
            {
                Musteri m = new Musteri();
                m.MusteriNumara = i++;
                m.Isim = FakeData.NameData.GetFirstName();
                m.Soyisim = FakeData.NameData.GetSurname();

                musteriler.Add(m);
            }
            return musteriler;
        }
    }
}
