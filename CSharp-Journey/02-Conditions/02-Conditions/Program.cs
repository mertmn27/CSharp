namespace _02_Conditions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int n3 = int.Parse(Console.ReadLine());

            double average = (n1 + n2 + n3) / 3.0;

            Console.WriteLine($"Average: {average}");

            if (average < 50)
                Console.WriteLine("Failed");
            else if (average < 70)
                Console.WriteLine("Average");
            else if (average < 90)
                Console.WriteLine("Good");
            else
                Console.WriteLine("Excellent");

            int max = n1;
            if (n2 > max) max = n2;
            if (n3 > max) max = n3;

            int min = n1;
            if (n2 < min) min = n2;
            if (n3 < min) min = n3;

            Console.WriteLine($"Max: {max}");
            Console.WriteLine($"Min: {min}");
        }
    }
}
