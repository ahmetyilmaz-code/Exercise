using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart1001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan alınan sayı aralığındaki tek ve çift sayıların toplamanı bulan program
            // tek sayıların toplamı :
            // çift sayıların toplamı :

            Console.Write("Başlangıç: ");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş: ");
            int bit = Convert.ToInt32(Console.ReadLine());

            if (bas > bit)
            {
                int baslangic = bas;
                bas = bit;
                bit = baslangic;
            }
            int tekToplam = 0;
            int ciftToplam = 0;

            for (int i = bas; i <= bit; i++)
            {
                Console.WriteLine($"İncelenen sayı: {i}");
                if (i % 2 == 1)
                {
                    tekToplam += i;
                    Console.WriteLine($"Tek sayıların ara toplamı: {tekToplam}");
                }
                else
                {
                    ciftToplam += i;
                    Console.WriteLine($"Çift sayıların ara toplamı: {ciftToplam}");
                }
                Console.WriteLine("-----------------------------");

            }
            Console.WriteLine($"Tek sayıların toplamı: {tekToplam}");
            Console.WriteLine($"Çift sayıların toplamı: {ciftToplam}");
        }
    }
}
