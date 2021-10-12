using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kadın ayse = new Kadın("fatma", "veli");
            ayse.Adı = "ayşe";
            IInsan bebek = ayse.KızDogur("zeliha");

            Console.WriteLine(bebek.Adı);
            Console.WriteLine(bebek.AnneAdı);
            Console.WriteLine("Hello World!");
        }
    }
}
