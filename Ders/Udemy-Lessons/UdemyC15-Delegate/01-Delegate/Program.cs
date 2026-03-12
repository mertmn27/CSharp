namespace _01_Delegate
{
    internal class Program
    {
        delegate void MatematikselIslemler (int sayi1, int sayi2);
        static void Topla(int sayi1, int sayi2)
        {
            int sonuc = sayi1 + sayi2;
            Console.WriteLine($"Toplam işleminin sonucu {sonuc}");
        }
        static void Cikart(int sayi1, int sayi2)
        {
            int sonuc = sayi1 - sayi2;
            Console.WriteLine($"Çıkarma işleminin sonucu {sonuc}");
        }
        static void Carp(int sayi1, int sayi2)
        {
            int sonuc = sayi1 * sayi2;
            Console.WriteLine($"Çapma işleminin sonucu {sonuc}");
        }
        static void Main(string[] args)
        {
            MatematikselIslemler M1 = new MatematikselIslemler(Topla);
            M1 += Cikart;
            M1 += Carp;
            M1.Invoke(10, 20);

            Delegate[] IsaretEdilenMetotlar = M1.GetInvocationList();

            foreach(var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Cikart;

            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }

            M1 -= Carp;

            foreach (var item in M1.GetInvocationList())
            {
                Console.WriteLine(item.Method.Name);
            }
        }
    }
}
