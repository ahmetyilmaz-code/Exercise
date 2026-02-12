using System;
using System.Runtime.InteropServices;

namespace ConsoleAppDers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // operatörler
            // + - * / % ++ --  
            double a = 10;
            double b = 20;
            Console.WriteLine(a + b);
            Console.WriteLine(a - b);
            Console.WriteLine(a * b);
            Console.WriteLine(a / b);
            Console.WriteLine(a % b);
            Console.WriteLine(a++);
            Console.WriteLine(++a);
            Console.WriteLine(a--);
            Console.WriteLine(--a);

            Console.WriteLine("********************");

            double c = 3 * 5 / 7d; // veya double c = 3 * 5 / 7.0; veya double c = 3 * 5 / (double)7;
            Console.WriteLine(c); // işlem önceliği 3 * 5 = 15 , 15 / 7 = 2.14

            int sayi1 = 10, sayi2 = 0, sayi3 = 5, sayi4 = 0;
            sayi2 = sayi1++; // sayi2 = 10 , sayi1 = 11
            sayi4 = ++sayi3; // sayi3 = 6 , sayi4 = 6
            Console.WriteLine("1.sayı : " + sayi1 + " 2.sayı : " + sayi2 + " 3.sayı : " + sayi3 + " 4.sayı : " + sayi4);






            Console.ReadLine();
        }
    }
}
