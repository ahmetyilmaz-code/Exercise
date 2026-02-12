using System;
using System.Runtime.InteropServices;

namespace ConsoleAppDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan ürünün fiyatı kar oranı ve kdv oranını alarak ürünün karlı fiyatını ve kdvli fiyatını hesaplayan bir program yazınız.
            // Ürünün alış değeri kullanıcı tarafından verilecek
            // kar oranı kullanıcı tarafından verilecek
            // kdv oranı kullanıcı tarafından verilecek





            string alistxt, kartxt, kdvtxt;

            Console.Write("Alış Değerini Giriniz: ");
            alistxt = Console.ReadLine();
            double alis = Convert.ToInt32(alistxt);

            Console.Write("Kar değerini giriniz: ");
            kartxt = Console.ReadLine();
            double kar = Convert.ToInt32(kartxt);

            Console.Write("KDV miktarını giriniz yüzde kaç ? ");
            kdvtxt = Console.ReadLine();
            double kdv = Convert.ToDouble(kdvtxt);

            double aliskar, aliskdv;
            aliskar = alis + (alis * kar / 100);
            aliskdv = aliskar + (aliskar * kdv / 100);

            Console.WriteLine($"Alış Değerini Giriniz:{alis} \nÜrünün karlı fiyatı :{aliskar}\nÜrünün KDVli fiytı :{aliskdv}");
            Console.ReadLine();
        }
    }
}
