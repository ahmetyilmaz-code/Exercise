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
            // Continue , Break Alıştırma         
            // kullanıcı negatif değer girene kadar sayıları toplayan ama çift sayıları toplama dahil etmeyen program.
            int toplam = 0, i = 1;
            while (true)
            {
                Console.Write($"{i}.Sayı giriniz: ");
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi < 0)
                {
                    Console.WriteLine("Negatif değer girdiğiniz için program sonlandırıldı.");
                    break; 
                }
                if (sayi % 2 == 0)
                {
                    Console.WriteLine("Çift sayı girdiğiniz için program bu değeri yok saydı.");
                    continue; 
                }
                else 
                { 
                    toplam += sayi; 
                }
                i++;
            }
            Console.WriteLine($"Girilen Sayıların Toplamı: {toplam}");
        }
    }
}
