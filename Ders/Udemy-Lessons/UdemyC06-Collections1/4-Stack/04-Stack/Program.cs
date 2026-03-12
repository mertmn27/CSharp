using System.Collections;

namespace Udemy047_Stack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // LIFO mantığı ile çıkartır.

            Stack stack = new Stack();

            stack.Push("A");
            stack.Push("B");
            stack.Push("C");
            stack.Push("D");
            stack.Push("E");
            stack.Push("F");

            object pop1 = stack.Pop();
            object pop2 = stack.Pop();
        }
    }
}
