namespace _06_NamedArguments
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operasyon operasyon = new Operasyon();
            operasyon.kisiBilgileriAl("Mert", "Arslan", 20, "Düzce");
            //operasyon.kisiBilgileriAl("Mert", "Arslan", "Düzce", 20);
            operasyon.kisiBilgileriAl(isim: "Mert", soyisim: "Arslan", sehir: "Düzce", yas: 20);
        }
    }
}
