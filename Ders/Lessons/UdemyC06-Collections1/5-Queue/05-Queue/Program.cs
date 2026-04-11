using System.Collections;

namespace Udemy048_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // FIFO mantığı ile çalışır ilk giren ilk çıkar.
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);

            queue.Dequeue();
            queue.Dequeue();
        }
    }
}
