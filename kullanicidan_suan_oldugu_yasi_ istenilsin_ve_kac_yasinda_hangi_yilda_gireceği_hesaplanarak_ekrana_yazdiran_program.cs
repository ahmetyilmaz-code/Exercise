using System;
using System.Runtime.InteropServices;

namespace ConsoleAppDers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //kullanıcıdan şuan olduğu yaşı istenilsin ve kaç yaşında hangi yılda gireceği hesaplanarak ekrana yazdıran program


            Console.Write("Yaşınızı giriniz :");
            string yastxt = Console.ReadLine();
            int yas = Convert.ToInt32(yastxt);  //veya int yas = Convert.ToInt32(Console.ReadLine());

            const short yil = 2026;  // veya int yil = DateTime.Now.Year;           

            Console.Write("Kaç yaşına hangi yılda gireceğinizi öğrenmek istediğiniz yaşı giriniz :");

            string hedefYastxt = Console.ReadLine();
            int hedefYas = Convert.ToInt32(hedefYastxt); //veya int hedefYas = Convert.ToInt32(Console.ReadLine());

            int hedefYil = yil + (hedefYas - yas);
            Console.Write($"Hedef yaşınız : {hedefYas} Hedef yılınız : {hedefYil}");
            Console.ReadLine();
        }
    }
}
