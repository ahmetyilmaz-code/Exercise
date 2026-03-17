using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart1701
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int sayi = -1;
            int toplam = 0;

            while (sayi > 0) // ilk döngü negatif olduğu için hiç çalışmaz
            {
                Console.Write("Sayı Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;

            }
            Console.WriteLine($"Toplam: {toplam}");


            do
            {
                Console.Write("Sayı Giriniz: ");
                sayi = Convert.ToInt32(Console.ReadLine());
                toplam += sayi;

            } while (sayi > 0);
            Console.WriteLine($"Toplam: {toplam}");

        }
    }
}
