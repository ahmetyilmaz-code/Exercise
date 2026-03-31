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
            // Kullanıcıdan D ve d tuşuna bastığı sürece sayı alalım ve
            //aldığı sayılardan en büyük tek ve çift sayıyı en küçük tek ve çift sayıyı bulan 
            // ve büyük olanı küçükten çıkartan programı yazalım.
            // büyükçift-büyüktek , küçükçift-küçüktek 

            char Dongu = 'd';
            int BuyukTekSayi = 1, KucukTekSayi = 1, BuyukCiftSayi = 0, KucukCiftSayi = 0, BuyukSonuc = 0, KucukSonuc = 0, sayi;

            Console.Write("İlk Sayıyı Giriniz Tek olsun: ");
            while (true)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 1)
                {
                    KucukTekSayi = sayi;
                    BuyukTekSayi = sayi;
                    break;
                }
                else
                {
                    Console.Write("İlk Sayıyı Tek Giriniz: ");
                }

            }

            Console.Write("İkinici Sayıyı Giriniz Çift Giriniz: ");
            while (true)
            {
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    BuyukCiftSayi = sayi;
                    KucukCiftSayi = sayi;
                    break;
                }
                else
                {
                    Console.Write("İkinici Sayıyı Çift Giriniz: ");
                }
            }

            while (Dongu == 'D' || Dongu == 'd')
            {
                Console.Write("Diğer Sayıları giriniz :");
                sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi % 2 == 0)
                {
                    if (sayi > BuyukCiftSayi)
                    {
                        BuyukCiftSayi = sayi;
                    }
                    else if (sayi < KucukCiftSayi)
                    {
                        KucukCiftSayi = sayi;
                    }
                }
                else
                {
                    if (sayi > BuyukTekSayi)
                    {
                        BuyukTekSayi = sayi;
                    }
                    else if (sayi < KucukTekSayi)
                    {
                        KucukTekSayi = sayi;
                    }
                }
                Console.WriteLine("Devam etmek istiyor musunuz? D/d");
                Dongu = Console.ReadKey().KeyChar;
            }

            if (BuyukCiftSayi > BuyukTekSayi)
            {
                BuyukSonuc = BuyukCiftSayi - BuyukTekSayi;
            }
            else
            {
                BuyukSonuc = BuyukTekSayi - BuyukCiftSayi;
            }

            if (KucukCiftSayi > KucukTekSayi)
            {
                KucukSonuc = KucukCiftSayi - KucukTekSayi;
            }
            else
            {
                KucukSonuc = KucukTekSayi - KucukCiftSayi;
            }
            Console.WriteLine($"En Büyük Çift :{BuyukCiftSayi}\nEn Büyük Tek :{BuyukTekSayi}\nEn Küçük Çift :{KucukCiftSayi}\nEn Küçük Tek :{KucukTekSayi}");
            Console.WriteLine($"En Büyük Çift ve Tek Sayıların Farkı = {BuyukSonuc}\nEn Küyük Çift ve Tek Sayıların Farkı = {KucukSonuc}");
        }
    }
}
