using System;

namespace ConsoleAppDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for döngsü ile aşağıdaki gibi bir dik üçgen çizen program yazınız.
            /* 

             *
             * 
             **
             ***
             ****

             */
            Console.Write("Lütfen üçgenin yüksekliğini giriniz: ");
            int yukseklik = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= yukseklik; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.ReadKey();
        }
    }
}