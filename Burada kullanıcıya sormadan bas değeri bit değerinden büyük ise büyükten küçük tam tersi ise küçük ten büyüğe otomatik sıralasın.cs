using System;

namespace ConsoleAppDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Başlangıç: ");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş: ");
            int bit = Convert.ToInt32(Console.ReadLine());
            // Alıştırma: Burada kullanıcıya sormadan bas değeri bit değerinden büyük ise büyükten küçük
            // tam tersi ise küçük ten büyüğe otomatik sıralasın          

            bool sonuc = bas > bit;

            if (bas > bit)
            {
                int baslangic = bas;
                bas = bit;
                bit = baslangic;
            }

            if (bas % 2 != 0)
            {
                bas++;
            }

            if (bit % 2 != 0)
            {
                bit--;
            }

            if (sonuc)
            {
                for (int i = bit; i >= bas; i -= 2)
                {
                    Console.Write(i == bas ? i.ToString() : $"{i},");
                }
            }
            else
            {
                for (int i = bas; i <= bit; i += 2)
                {
                    Console.Write(i == bit ? i.ToString() : $"{i},");
                }
            }

            Console.ReadKey();
        }
    }
}
