using System;

namespace ConsoleAppDers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kullanıdan kullanıcının istediği adette not alarak ortalama hesaplayan program
            //kullanıcı 0 ile 100 aralığında bir değer girmezse hata vererek kullanıcıdan yine aynı sıradaki notu girmesini isteyin
            //3.Not : 200 
            //Not değeri 0 ile 100 arasında olmalıdır. Lütfen 3. notunuzu tekrar giriniz : 85

            Console.Write("Kaç adet notun ortalamasını istiyorsunuz :");
            int adet = Convert.ToInt32(Console.ReadLine());
            double toplam = 0;

            if (adet <= 0)
            {
                Console.WriteLine("Lütfen geçerli bir adet giriniz.");

            }
            else
            {
                for (int i = 1; i <= adet; i++)
                {
                    Console.Write($"{i}. Notunuzu giriniz :");
                    int not = Convert.ToInt32(Console.ReadLine());
                    if (not < 0 || not > 100)
                    {
                        Console.WriteLine($"Not değeri 0 ile 100 arasında olmalıdır. Lütfen {i}. notunuzu tekrar giriniz :");
                        i--;
                    }
                    else
                    {
                        toplam += not;
                    }
                }
                double ortalama = toplam / adet;
                Console.Write($"Ortalamanız : {ortalama}");
            }
            Console.ReadKey();
        }
    }
}