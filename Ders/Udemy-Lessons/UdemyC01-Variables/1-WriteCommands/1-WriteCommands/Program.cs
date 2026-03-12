internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Merhaba"); // Aynı satırda yazmaya devam eder.
        Console.Write("Dünya");
        Console.WriteLine("Merhaba");// Aynı satıra yazar sonuna endline çeker bir sonraki write komudu alt satırda başlar.
        Console.WriteLine("Dünya");
        Console.ReadLine();
    }
}