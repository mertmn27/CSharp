namespace Udemy34_ObjectVariable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            object objectVariable1 = 10;
            object objectVariable2 = "Hello";
            object objectVariable3 = true;
            object objectVariable4 = 2.2323;

            //object objectVariable5 = (int)objectVariable3;
            int sayi1 = 100;
            object objectVariable6 = sayi1; // Boxing
            int sayi2 = (int)objectVariable6; // Unboxing

            var a = 100; // Değere göre a nın hangi veri tipinde olduğunu anlar.
            //a = "Merhaba"; // a yı başta integer olarak gördüğü için string yapamıyoruz

            dynamic b = "Hello World!"; // var dan farklı olarak uygulama çalışırken ne olduğunu tanımlar
            // farklı değerleri içinde saklayabilir dinamik olarak veri tipi değiştirilebilir.
            // Hata verirse runtime error alırız.
            Console.WriteLine(b);
            b = true;
            Console.WriteLine(b);
        }
    }
}
