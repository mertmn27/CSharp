using _01_JsonInceleme.Models;
using Newtonsoft.Json;

namespace _01_JsonInceleme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person P1 = new Person()
            {
                ID = 1,
                FirstName = "Mert",
                LastName = "Arslan",
                Age = 1,
            };
            Person P2 = new Person()
            {
                ID = 2,
                FirstName = "Osman",
                LastName = "Arslanss",
                Age = 2,
            };
            
            List<Person> persons = new List<Person>() { P1, P2 };

            string jsonData = JsonConvert.SerializeObject(persons);
            Console.WriteLine(jsonData);

            Directory.CreateDirectory(@"C:\JSON\Liste");
            StreamWriter sw = File.CreateText(@"C:\JSON\Liste\Data.json");
            sw.Write(jsonData);
            sw.Close();
        }
    }
}
