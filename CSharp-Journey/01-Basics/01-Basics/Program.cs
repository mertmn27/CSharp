namespace _01_Basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Hello {name}, you are {age} years old.");

            if (age >= 18)
            {
                Console.WriteLine("You are an adult.");
            }
            else
            {
                Console.WriteLine("You are not an adult yet.");
            }
        }
    }
}
