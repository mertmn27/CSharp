namespace _04_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;
            double average = 0;
            while(true)
            {
                int num = GetNumber();
                if(num == 0)
                {
                    average = CalculateAverage(sum, count);
                    PrintResult(sum, count, average);
                    break;
                }
                count++;
                sum += num;
            }
        }

        static int GetNumber()
        {
            Console.Write("Enter a number:");
            int num = int.Parse(Console.ReadLine());
            return num;
        }

        static double CalculateAverage(int sum, int count)
        {
            if(count == 0)
            {
                return 0;
            }
            return (double)sum / count;
        }

        static void PrintResult(int sum, int count, int average)
        {
            Console.WriteLine($"Sum of the numbers : {sum}");
            Console.WriteLine($"Count of the numbers : {count}");
            Console.WriteLine($"Average of the numbers : {average}");
        }
    }
}
