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
                m.DogumTarihi = FakeData.DateTimeData.GetDatetime(new DateTime(1984,01,01),new DateTime(1999,01,01));

                m.Ulke = FakeData.PlaceData.GetCountry();
                m.Il = FakeData.PlaceData.GetCity();
                m.Ilce = FakeData.PlaceData.GetCountry();

                m.Email = $"{m.Isim.ToLower()}.{m.Soyisim.ToLower()}@{FakeData.NetworkData.GetDomain()}";
                m.TelefonNumarası = FakeData.PhoneNumberData.GetPhoneNumber();

                musteriler.Add(m);
            }
            return musteriler;
        }
    }
}
