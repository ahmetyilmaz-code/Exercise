using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart032
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("A,B,C,D Hangisi:");
            string harf = Console.ReadLine();
            switch (harf)
            {
                case "A":
                case "a":
                    Console.WriteLine("A seçtiniz");
                    break;
                case "B":
                case "b":
                    Console.WriteLine("B seçtiniz");
                    break;
                case "C":
                case "c":
                    Console.WriteLine("C seçtiniz");
                    goto case "A";
                case "D":
                case "d":
                    Console.WriteLine("D seçtiniz");
                    goto case "B";
                default:
                    Console.WriteLine("Geçersiz harf girdiniz.");
                    break;







            }
        }
    }
}