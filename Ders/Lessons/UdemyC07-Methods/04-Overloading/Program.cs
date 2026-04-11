namespace _04_Overloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operations operations = new Operations();

            int toplam1 = operations.Topla(5, 2);

            int toplam2 = operations.Topla(5, 1,3);

            decimal toplam3 = operations.Topla(5m,6m);
        }
    }
}
