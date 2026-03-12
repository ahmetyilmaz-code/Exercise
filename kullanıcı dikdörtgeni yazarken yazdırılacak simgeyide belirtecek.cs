using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart1201
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            kullanıcıdan taban ve yükseklik alarak dötgen çizen programı yazınız 
            kullanıcı yazdırılacak simgeyide belirtecek
            Taban : 3
            Yükseklik : 4
            * * *
            * * *
            * * *
            * * *
             */

            Console.Write("Taban : ");
            int taban = Convert.ToInt32(Console.ReadLine());
            Console.Write("Yükseklik : ");
            int yukseklik = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bastıralacak Simge : ");
            char simge = Console.ReadKey().KeyChar;
            Console.WriteLine();

            string tabanYıldız = "";
            for (int i = 0; i < taban; i++)
            {
                tabanYıldız += $"{simge} ";
            }
            for (int i = 0; i < yukseklik; i++)
            {
                Console.WriteLine(tabanYıldız);
            }



        }
    }
}
