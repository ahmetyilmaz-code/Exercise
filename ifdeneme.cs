using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat172
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if blokları
            // if bloğu herhangi bir koşul kontrolü yapmak için kullanılır.
            // Eğer koşul doğru ise if bloğu içindeki kod çalışır, yanlış ise çalışmaz.

            Console.WriteLine("Bir sayı giriniz:");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi) //if sadece true ise çalışır.
            {
                Console.WriteLine("Sayı 10'dan büyüktür.");

            }

            else
            {
                Console.WriteLine("Sayı 10'dan küçük veya eşittir.");
            }
        }
    }
}
