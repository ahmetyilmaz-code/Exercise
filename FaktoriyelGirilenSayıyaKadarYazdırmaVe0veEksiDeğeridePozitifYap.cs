using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Faktoriyel hesaplayan program
            // bir tam sayının 1 den başlayarak üst üste çarpılması
            // 5! = 1 * 2 * 3 * 4 * 5 = 120
            // faktoriyeli hesaplanacak sayıyı kullanıcıdan alalım

            // girilen sayuya kadar olan sayıların faktoriyelini ekrana yazdıralım

            // kullanıcı negatif değer girerse onun pozitifi ile 0 ise 0! = 1 olarak hesaplayalım
            // bu işlem daha az iş ile nasıl yapılır ??

            Console.Write("Faktoriyeli Hesaplanacak Sayıyı Giriniz: ");
            double sayi = Convert.ToInt32(Console.ReadLine());

            if (sayi < 0)
            {
                sayi = -sayi;
            }
            else if (sayi == 0)
            {
                Console.WriteLine("0! = 1");
                return;
            }

            double faktoriyel = 1;
            string a = "";

            for (int i = 1; i <= sayi; i++)
            {
                faktoriyel *= (i);
                a = ($"{i}! = ");

                for (int j = 1; j <= i; j++)
                {
                    if (j < i)
                    {
                        a += $"{j}*";
                    }
                    else
                    {
                        a += $"{j} ";
                    }
                }

                a += $"= {faktoriyel}\n";
                Console.Write(a);
            }

            Console.ReadKey();
        }
    }
}
