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
            // Break alıştırma
            // kullanıcıdan en fazla 10 sayı alarak toplam yapan program.
            // kullanıcı negatif değer girdiği an program biter
            int toplam = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{i}.Sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 0)
                {
                    Console.WriteLine("Negatif değer girdiğiniz için program sonlandırıldı.");
                    break;
                }
                toplam += sayi;
            }
            Console.WriteLine($"Toplam: {toplam}");
        }
    }
}
