namespace Udemy037_NestedLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"{i}.{j} ");
                }
                Console.WriteLine("");
            }
        }
    }
}
