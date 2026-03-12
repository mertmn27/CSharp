using System.Collections;

namespace _02_GenericHashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add(1, "A");
            hashtable.Add("B", 2);

            //Dictionary<key,value>
            Dictionary<int,string> map = new Dictionary<int,string>();
            map.Add(1, "A");
            map.Add("B", 2);

            // HashSet<T>

            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(2); // hata almıyoruz ama aynı değer gelirse bir daha almıyor.

            HashSet<string> set2 = new HashSet<string>();
            set2.Add("A");
            set2.Add("B");
            set2.Add("B");

            Queue queueObject = new Queue();
            queueObject.Enqueue(1);
            queueObject.Enqueue(2);
            queueObject.Enqueue(3);

            object objectValue = queueObject.Dequeue();
            object peekObject = queueObject.Peek();

            Queue<string> strings = new Queue<string>();

            strings.Enqueue("A");
            strings.Enqueue("B");
            strings.Enqueue("C");
            strings.Enqueue("D");

            string StrValue = strings.Dequeue();
            string StrPeek = strings.Peek();

            Stack stackObject = new Stack();

            stackObject.Push(1);
            stackObject.Push(2);
            stackObject.Push("3");
            
            object O1 = stackObject.Pop();
            object O2 = stackObject.Peek();

            Stack<string> stackGeneric = new Stack<string>();

            stackGeneric.Push("A");
            stackGeneric.Push("B");
            stackGeneric.Push("C");
            stackGeneric.Push("D");

            string strVal = stackGeneric.Pop();
            string strPeek = stackGeneric.Peek();

            SortedList sortedListObject = new SortedList();
            sortedListObject.Add(100, "Yüz");
            sortedListObject.Add(200, "İkiyüz");
            sortedListObject.Add(300, "Üçyüz");
            sortedListObject.Add(50, "Elli");

            SortedList<int,string> sortedListGeneric = new SortedList<int,string>();

            sortedListGeneric.Add(10, "On");
            sortedListGeneric.Add(5, "Beş");
            sortedListGeneric.Add(100, "Yüz");
        }
    }
}
