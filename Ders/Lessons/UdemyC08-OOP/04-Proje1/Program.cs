namespace _04_Proje1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kitap[] kutuphane = new Kitap[5];
            kutuphane[0] = new Kitap(1, "Simyacı", "Paulo Coelho", 184, 800);
            kutuphane[1] = new Kitap(2, "1984", "George Orwell", 328, 1000);
            kutuphane[2] = new Kitap(3, "Hayvan Çiftliği", "George Orwell", 152,1000);
            kutuphane[3] = new Kitap(4, "Sefiller", "Victor Hugo", 1463, 3000);
            kutuphane[4] = new Kitap(5, "Kürk Mantolu Madonna", "Sabahattin Ali", 160, 1200);

            for (int i = 0; i < kutuphane.Length; i++)
            {
                kutuphane[i].bilgiYaz();
                Console.WriteLine("=========================================");
            }

            Console.Write("Aranan Kitap ID: ");
            int kitapID = Convert.ToInt32(Console.ReadLine());

            Kitap bulunanKitap = kutuphane.LastOrDefault(I => I.kitapID == kitapID);

            if (bulunanKitap != null)
            {
                bulunanKitap.bilgiYaz();
            }
            else
            {
                Console.WriteLine("Kitap bulunamadı!");
            }
        }
    }
}
