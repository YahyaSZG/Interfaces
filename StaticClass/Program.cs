using System;

namespace StaticClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilities.Deneme();
            Console.ReadLine();
        }
    }

    static class Utilities
    {
        static Utilities()
        {
            Console.WriteLine("Çalıştı");
        }

        public static void Deneme()
        {
            Console.WriteLine("Deneme çalıştı");
        }
    }
}
