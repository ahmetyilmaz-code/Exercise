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
            // Kullanıcıdan 3 adet not alarak ortalama bulan ve bulduğu ortalamaya göre harf notu veren program
            // 90 büyük ve eşitse AA
            // 90 dan küçük 80 e büyük eşitse BA
            // 80 den küçük 70 e büyük eşitse BB
            // 70 den küçük  50 e büyük eşitse CC
            // 50 den küçükse DD kaldın

            Console.WriteLine("Lütfen 3 adet not giriniz:");
            Console.Write("1. Not:");
            int not1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2. Not:");
            int not2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("3. Not:");
            int not3 = Convert.ToInt32(Console.ReadLine());

            double ortalama = (not1 + not2 + not3) / 3d;
            if (ortalama >= 90)
            {
                 Console.WriteLine($"Ortalamanız: {ortalama} Harf Notunuz: AA");               
            }
            else if (ortalama >= 80)
            {
                Console.WriteLine($"Ortalamanız: {ortalama} Harf Notunuz: BA");
            }
            else if (ortalama >= 70)
            {
                Console.WriteLine($"Ortalamanız: {ortalama} Harf Notunuz: BB");
            }
            else if (ortalama >= 50)
            {
                Console.WriteLine($"Ortalamanız: {ortalama} Harf Notunuz: CC");
            }
            else
            {
                Console.WriteLine($"Ortalamanız: {ortalama} Harf Notunuz: DD Kaldınız");
            }











            }
    }
}

