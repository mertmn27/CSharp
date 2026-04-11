namespace Udemy27_VariableScopes
{
    internal class Program
    {
        static int yas = 0;
        static void Main(string[] args)
        {
            string meslek = "Avukat";

            yas = 40;

            meslek = "Doktor";

            {
                meslek = " ";
                yas = 30;
                bool urunAktif = true;
            }
        }
    }
}
