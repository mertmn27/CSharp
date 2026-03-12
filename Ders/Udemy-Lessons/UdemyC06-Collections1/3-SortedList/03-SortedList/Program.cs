using System.Collections;

namespace Udemy046_SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // SortedList'in hashtable'dan farkı içeriye girdiğimiz key değerlerini kendisi otomatik sıralar.

            SortedList sortedList = new SortedList();

            sortedList.Add(0, "Sıfır");
            sortedList.Add(5, "Beş");
            sortedList.Add(3, "Üç");
            sortedList.Add(2, "İki");

            foreach (DictionaryEntry item in sortedList)
            {
                Console.WriteLine($"{item.Key} ve {item.Value}");
            }
        }
    }
}
