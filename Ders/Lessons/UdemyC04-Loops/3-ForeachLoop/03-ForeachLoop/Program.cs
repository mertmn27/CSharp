namespace Udemy029_ForeachLoop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //foreach (var item in collection)
            //{
            //}

            string[] personeller = { "Hasan", "Mehmet", "Cengiz", "Ozkan" };
            foreach (string s in personeller)
            {
                Console.WriteLine(s);
            }
        }
    }
}
