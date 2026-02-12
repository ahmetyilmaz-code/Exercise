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

            //kullanıcıdan aldığı sayının 100 den büyük olup olmadığını kontrol eden program
            Console.WriteLine("Lütfen bir sayı giriniz:");
            Console.Write("Sayı: ");
            string inputTxt = Console.ReadLine();
            int input = Convert.ToInt32(inputTxt);

            string sonuc = input > 100 ? "sayı 100den büyüktür" : "sayı 100den büyük değildir";
            Console.WriteLine(sonuc);



        }
    }
}
