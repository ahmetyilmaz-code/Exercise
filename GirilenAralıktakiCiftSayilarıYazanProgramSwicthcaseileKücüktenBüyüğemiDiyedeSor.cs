using System;

namespace ConsoleAppDers
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcının girdiği aralıktaki sayıların içinde çift olanlarını ekran yazan progra
            // büyükten küçüğe veya küçükten büyüğe sıralanmasını kullanıcı belirleyecek
            // Başlangıç: 1
            // Bitiş : 6
            // 2,4,6

            Console.Write("Başlangıç: ");
            int bas = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş: ");
            int bit = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sıralama (Büyükten küçüğe için 'b', küçükten büyüğe için 'k' yazınız): ");
            string siralama = Console.ReadLine();
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

            switch (siralama)
            {
                case "b":
                case "B":
                    {
                        for (int i = bit; i >= bas; i -= 2)
                        {
                            Console.Write(i == bas ? i.ToString() : $"{i},");
                        }
                        break;
                    }
                case "k":
                case "K":
                    {
                        for (int i = bas; i <= bit; i += 2)
                        {
                            Console.Write(i == bit ? i.ToString() : $"{i},");
                        }
                        break;
                    }
                default:
                    Console.WriteLine("Sıralama tercihi hatalı!");
                    break;
            }




            Console.ReadKey();
        }
    }
}