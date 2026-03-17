using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart1701
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // kullanıcıdan bir sayı alarak sayının basamaklarıyla işlem yapan program
            // Girilen sayının basamaklarını tersi ile toplama ++
            // Sayı : 1234
            // Örneğin: 1234 -> 4321 -> 1234 + 4321 = 5555

            // Girilen sayınının rakamlarının toplamı ++
            // Örneğin: 1234 -> 1 + 2 + 3 + 4 = 10

            // Girilen sayının basamak adeti ++
            // Örneğin: 1234 -> 4 basamak

            // Girilen sayının rakamlarında kaç tane çift ve kaç tane tek rakam olduğunu bulma ++
            // Sayı : 1234
            // Çift rakamlar: 2, 4 -> 2 adet
            // Tek rakamlar: 1, 3 -> 2 adet

            // 123 % 10 = 3
            // 123 / 10 = 12

            Console.Write("Lütfen bir sayı giriniz: ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int rakamlarToplami = 0;
            string tersSayi = "";
            int tempSayi2 = sayi; // geçici sayı, sayının orjinal değerini korumak için kullanılır
            string tekRakamlar = "";
            string ciftRakamlar = "";
            int i = 0, j = 0, k = 0; // i: basamak adeti, j: çift rakam adeti, k: tek rakam adeti

            while (tempSayi2 > 0)
            {
                int rakam2 = tempSayi2 % 10; // son basamağı alır
                rakamlarToplami += rakam2; // basamağı rakmlar toplamına ekle
                if (rakam2 % 2 == 0)
                {
                    ciftRakamlar += rakam2.ToString() + " "; // çift rakamları ciftRakamlar stringine ekle
                    j++; // çift rakam adeti
                }
                else
                {
                    tekRakamlar += rakam2.ToString() + " "; // tek rakamları tekRakamlar stringine ekle
                    k++; // tek rakam adeti
                }
                tempSayi2 /= 10; // son basamağı at
                tersSayi += rakam2.ToString(); // basamağı ters sırayla stringe ekle
                i++; // basamak adeti
            }
            Console.WriteLine($"Girilen sayı ile sayının tersinin toplamı: {sayi} + {tersSayi} = {sayi + Convert.ToInt32(tersSayi)}");
            Console.WriteLine($"Girilen sayının rakamlarının toplamı: {rakamlarToplami}");
            Console.WriteLine($"Girilen sayının basamak adeti: {i} basamak");
            Console.WriteLine($"Çift rakamlar: {ciftRakamlar}, Çift Rakam Adeti :{j}");
            Console.WriteLine($"Tek rakamlar: {tekRakamlar}, Tek Rakam Adeti :{k}");
        }
    }
}
