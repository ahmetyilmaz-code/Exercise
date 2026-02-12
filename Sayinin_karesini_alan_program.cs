using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10subat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan sayı istenilerek istenilen sayının karesini hesaplayan program

            string sayiTxt;
            Console.Write("Bir Sayi Giriniz :");
            sayiTxt = Console.ReadLine();
            int sayi = Convert.ToInt32(sayiTxt);

            int karesi = sayi * sayi;
            Console.WriteLine($"Girdiniz sayı  :{sayi} \nSayının Karesi :{karesi}");





        }
    }
}
