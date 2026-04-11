namespace _05_OptionalParameter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            operations.Selamla("");

            operations.SelamlaOpsiyonel();
            operations.SelamlaOpsiyonel(isimSoyisim: "Mert Arslan");
            operations.SelamlaOpsiyonel("Mert Arslan");
        }
    }
}
