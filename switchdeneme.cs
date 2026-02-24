using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // case alıştırma
            Console.WriteLine("Evet mi hayır mı? (E/H)");
            string cevap = Console.ReadLine();
            Console.WriteLine("İf ile kontrol");
            if (cevap == "E" || cevap == "e")
            {
                Console.WriteLine("Evet dediniz.");
            }
            else if (cevap == "H" || cevap == "h")
            {
                Console.WriteLine("Hayır dediniz.");
            }
            else
            {
                Console.WriteLine("Geçersiz cevap.");
            }
            Console.WriteLine("--------------------");
            Console.WriteLine("switch case ile kontrol"); // switch ife göre daha hızlı çalışır. çunku tek blokta çalışır. if ise her koşulu tek tek kontrol eder.
            switch (cevap)
            {
                case "E":
                    Console.WriteLine("Evet dediniz.");
                    break;
                case "H":
                    Console.WriteLine("Hayır dediniz.");
                    break;
                default:
                    Console.WriteLine("Geçersiz cevap.");
                    break;



            }
        }

    }