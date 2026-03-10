using System;
using System.Security.Cryptography;

namespace ConsoleAppDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // While ile kullınıcı negatif değere girene kadar kullanıcının girdiği tüm satıları toplayan program
            Console.WriteLine("Negatif bir sayı girene kadar girdiğiniz tüm sayıları toplayan program");
            int sayi = 0;
            int toplam = 0;
            while (sayi >= 0)
            {
                toplam += sayi;
                Console.Write("Lütfen bir sayı giriniz :");
                sayi = Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine($"Toplam : {toplam}");
            Console.ReadKey();
        }
    }
}
