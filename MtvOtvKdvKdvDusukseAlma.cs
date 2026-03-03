using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart032
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanucudan baz değer alarak vergili halini hesaplayan program
            // KDV oranı %18 , OTV oranı %20 , MTV oranı %10 olsun
            // KDV sadece KDV
            // ÖTV seçerse ÖTV sonra KDV
            // MTV önce MTV sonra ÖTV sonra KDV

            // hesaplama sonrasında KDV hesaplarken tutar 100 lira altında ise kdv hesaplamasın ötv mtv den sonrada 100 lira altında ise kdv hesaplamasın
            Console.Write("Tutar : ");
            double tutar = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vergi seçin KDV (1), ÖTV (2), MTV(3) :");
            int vergisecim = Convert.ToInt32(Console.ReadLine());
            double vergiliTutar = tutar;

            switch (vergisecim)
            {
                case 1:
                    Console.WriteLine($"KDV öncesi tutar : {vergiliTutar}");
                    vergiliTutar *= 1.18;
                    Console.WriteLine($"KDV eklenmiş tutarı : {vergiliTutar}");
                    break;
                case 2:
                    Console.WriteLine($"ÖTV öncesi tutar : {vergiliTutar}");
                    vergiliTutar *= 1.20;
                    Console.WriteLine($"ÖTV eklenmiş tutarı : {vergiliTutar}");
                    if (vergiliTutar < 100)
                    {
                        Console.WriteLine("100 lira altında KDV dahil edilmez");
                        break;
                    }
                    goto case 1;

                case 3:
                    Console.WriteLine($"MTV öncesi tutar : {vergiliTutar}");
                    vergiliTutar *= 1.10;
                    Console.WriteLine($"MTV eklenmiş tutarı : {vergiliTutar}");
                    goto case 2;
                default:
                    Console.WriteLine("Geçersiz seçim yaptınız.");
                    break;
            }
            Console.WriteLine($"Toplam Vergili Tutar : {vergiliTutar}");

        }
    }
}