using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat261
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullancının girdiği tek basamaklı 3 sayının toplamını bulan program
            // girilen sayıların tek basamaklı olup olmadığıda kontrol edilsin
            // Sayı 1:5
            // Sayı 2:6
            // Sayı 3:2
            // 5 + 6  +2 = 13

            char _sayi1, _sayi2, _sayi3;

            Console.WriteLine("Lütfen TEK basamaklı 3 sayı giriniz.");
            Console.Write("Sayı 1: ");
            _sayi1 = Console.ReadKey().KeyChar;

            Console.Write("\nSayı 2: ");
            _sayi2 = Console.ReadKey().KeyChar;

            Console.Write("\nSayı 3: ");
            _sayi3 = Console.ReadKey().KeyChar;
            // Console.ReadKey() metodu, kullanıcıdan bir tuşa basmasını bekler ve basılan tuşun bilgilerini içeren bir ConsoleKeyInfo nesnesi döndürür.
            // KeyChar özelliği ise basılan tuşun karakter temsilini verir.


            // char türündeki sayıları string türüne dönüştürmek için ToString() metodunu kullanıyoruz.
            string sayi1 = _sayi1.ToString(); 
            string sayi2 = _sayi2.ToString();
            string sayi3 = _sayi3.ToString();
                        
            if (_sayi1 < '0' || _sayi1 > '9' || _sayi2 < '0' || _sayi2 > '9' || _sayi3 < '0' || _sayi3 > '9') 
            // if (_sayi1 < '0' || _sayi1 > '9' || _sayi2 < '0' || _sayi2 > '9' || _sayi3 < '0' || _sayi3 > '9')
            // tek basamaklı sayıların karakter aralığı 0-9 olduğu için bu şekilde kontrol edebiliriz.
            {
                Console.WriteLine("\nLütfen tek basamaklı sayılar girdiğinizden emin olunuz.");
            }
            else
            {
                int __sayi1, __sayi2, __sayi3;


                // Convert.ToInt32() metodu, string ifadeyi int türüne dönüştürür. Eğer string ifade geçerli bir sayı değilse, bir FormatException hatası fırlatır.
                __sayi1 = Convert.ToInt32(sayi1);
                __sayi2 = Convert.ToInt32(sayi2);
                __sayi3 = Convert.ToInt32(sayi3);

                Console.WriteLine($"\n{sayi1} + {sayi2} + {sayi3} = {__sayi1 + __sayi2 + __sayi3}");
                //Console.WriteLine($"\n{sayi1} + {sayi2} + {sayi3} = {_sayi1 - '0' + _sayi2 - 48  + __sayi3} "); 
                // üst satır ile aynı sonucu verir.                                                                                                                              
                // char türündeki sayıları int türüne dönüştürmek için '0' karakterini çıkarmamız yeterlidir.
                // Çünkü '0' karakterinin ASCII değeri 48'dir, bu nedenle 48 çıkararak da aynı sonucu elde edebiliriz.
            }

        }
    }
}
