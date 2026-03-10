using System;

namespace ConsoleAppDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While ile 1 ile 5 arasındaki sayıları ekrana yazdıran bir program yazınız.
            int sayi = 1;
            while (sayi < 6)
            {
                Console.WriteLine(sayi);
                sayi++;
            }


            Console.ReadKey();
        }
    }
}
