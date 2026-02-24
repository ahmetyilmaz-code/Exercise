using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat24
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Basit hesap makinesi
            // Kullanıcıdan iki sayı ve bir işlem türü alarak sonucu hesaplayan bir program yazınız.
            // Sayı 1 : 20
            // Sayı 2 : 40
            // İşlem Türü : (+,-,*,/) : +
            // 20 + 40 = 60
            Console.WriteLine("Basit Hesap Makinesi");
            Console.WriteLine("Lütfen iki sayı ve bir işlem türü giriniz.");
            Console.Write("Sayı 1 : ");
            double sayi1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Sayı 2 : ");
            double sayi2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İşlem Türü : (+,-,*,/) : ");
            string islemTuru = Console.ReadLine();
            Console.Write($"{sayi1} {islemTuru} {sayi2} = ");

            ;
            if (islemTuru == "+")
            {
                Console.Write(sayi1 + sayi2);
            }
            else if (islemTuru == "-")
            {
                Console.Write(sayi1 - sayi2);
            }
            else if (islemTuru == "*")
            {
                Console.Write(sayi1 * sayi2);
            }
            else if (islemTuru == "/")
            {
                if (sayi2 != 0)
                {
                    Console.Write(sayi1 / sayi2);
                }
                else
                {
                    Console.WriteLine("Sıfıra bölme hatası!");
                }
            }
            else
            {
                Console.WriteLine("Geçersiz işlem türü");
            }









        }
    }

}