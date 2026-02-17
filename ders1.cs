using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcdan bi sayı alarak bu sayının tek mi çift mi olduğunu ekrana yazdıran program
            Console.Write("Lütfen bir sayı giriniz: ");

            string sayiTxt = Console.ReadLine();
            Console.WriteLine($"Girilen sayı: {sayiTxt}");
            int sayi=Convert.ToInt32(sayiTxt);

           Console.WriteLine($"Bu {sayi} tek mi çift mi? " );
            string sonuc = sayi % 2 == 0 ? "Çift" : "Tek";

            Console.WriteLine(sonuc);
            



        }
    }
}
