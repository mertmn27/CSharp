using System.Threading.Channels;

namespace Udemy23_ByteIntVariables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Byte ve Int :

            Byte yas = 25; // 0 ile 255 arasındaki değerleri byte ile taşıyabilirim.
            int seviye = 10000; // -2milyar ile +2milyar arasında değerleri int ile yaşıyabilirim.

            Console.WriteLine(yas);
            Console.WriteLine(seviye);
        }
    }
}
