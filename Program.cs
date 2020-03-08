using System;

namespace ConsoleAppDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Helena zegt: " +  (new Helena()).Tekst);
            Console.WriteLine("Levi zegt: " +  (new Levi()).Tekst);
            Console.WriteLine("Vera zegt: " +  (new Levi()).Tekst);

            Console.ReadKey();
        }
    }
}
