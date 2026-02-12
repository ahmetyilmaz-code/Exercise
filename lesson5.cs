using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat122
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //kullanıcıdan 3 not alarak ortalama hesaplayan ve ortalaması 45 ten büyük yada 
            //eşit olma durumuna göre geçtiniz kaldınız yazan programı yazınız

            Console.WriteLine("Lütfen 3 adet not giriniz: ");

            Console.Write("1. Not: ");
            string not1Txt = Console.ReadLine();
            double not1 = Convert.ToDouble(not1Txt);

            Console.Write("2. Not: ");
            string not2Txt = Console.ReadLine();
            double not2 = Convert.ToDouble(not2Txt);

            Console.Write("3. Not: ");
            string not3Txt = Console.ReadLine();
            double not3 = Convert.ToDouble(not3Txt);

            double ortalama = (not1 + not2 + not3) / 3;
            Console.WriteLine("Ortalamanız: " + ortalama);

            string sonuc = ortalama >= 45 ? "Geçtiniz" : "Kaldınız";
            Console.WriteLine("Durumunuz: " + sonuc);






        }
    }
}
