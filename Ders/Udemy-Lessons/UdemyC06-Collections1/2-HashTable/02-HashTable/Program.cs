using System.Collections;

namespace Udemy045_HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hashtable hashtable = new Hashtable();
            hashtable.Add("C", "Cengiz");
            hashtable.Add("A", "Ahmet");
            hashtable.Add("N", "Nihat");
            hashtable.Add("Y", "Yakup");
            hashtable.Add("U", "Uğur");

            hashtable["N"] = "Nazmi";

            hashtable.Remove("N");

            bool keyControl = hashtable.ContainsKey("N");
            if (keyControl)
            {
                hashtable.Remove("N");
            }

            bool valueControl = hashtable.ContainsValue("Yakup");
        }
    }
}
