namespace User_Login_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            while(true)
            {
                if(counter >= 3)
                {
                    Console.WriteLine("Account Locked");
                    break;
                }
                string username = GetUsername();
                string password = GetPassword();
                if(CheckLogin(username,password))
                {
                    Console.WriteLine("Login Successful");
                    break;
                }
                else
                {
                    Console.WriteLine($"Wrong username or password {2 - counter} attempts left.");
                    counter++;
                }
            }
        }

        static string GetUsername()
        {
            Console.Write("Username: ");
            string username = Console.ReadLine();
            return username;
        }

        static string GetPassword()
        {
            Console.Write("Password: ");
            string password = Console.ReadLine();
            return password;
        }

        static bool CheckLogin(string username, string password)
        {
            string correctUsername = "mert";
            string correctPassword = "1234";

            return username == correctUsername && password == correctPassword;
        }
    }
}
