namespace _01_DirectoryExists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string root = "C:\\SystemIOInceleme";
            bool check = Directory.Exists(root);

            if (check)
            {
                //DirectoryInfo D1 = Directory.CreateDirectory(root + "\\Customer");
                //Directory.Delete(root + "\\Customer",true);
                //List<string> fileList = Directory.GetDirectories(root).ToList();
                //List<string> Items = Directory.GetFiles(root).ToList();

                //string varsayilanYol = Directory.GetCurrentDirectory();
                //Directory.SetCurrentDirectory(root);
                //varsayilanYol = Directory.GetCurrentDirectory();

                //bool fileCheck = File.Exists(root + "\\Logs.txt");

                //FileStream fs = File.Create(root + "\\abc.txt");
                //fs.Close();
                //File.Create("").Close();

                //StreamWriter sw = File.CreateText(root + "\\test1.txt");
                //sw.WriteLine("Merhaba ");
                //sw.Write("Dünya");
                //sw.Close();

                //File.Delete(root + "\\test1.txt");

            }
            else
            {
                Console.WriteLine("Yok");
            }
        }
    }
}
