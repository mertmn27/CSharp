namespace _03_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int count = 0;

            while(true)
            {
                Console.Write("Enter a number (0 to stop): ");
                int num = int.Parse(Console.ReadLine());

                if (num == 0) break;

                sum += num;
                count++;
            }

            if(count > 0 )
            {
                double average = sum / (double)count;
                Console.WriteLine($"Total: {sum}");
                Console.WriteLine($"Count: {count}");
                Console.WriteLine($"Average: {average}");
            }
            else
            {
                Console.WriteLine("No numbers entered.");
            }
        }
    }
}
