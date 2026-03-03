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

            //kullanının girdiği ifadeyi kullanıcının girdiği sayı kadar yazdıran program

            Console.Write("Lütfen bir ifade giriniz: ");
            string ifade = Console.ReadLine();
            Console.Write("Bu ifadeyi kaç kere yazdırmak istiyorsunuz? :");
            int sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayi; i++)
            {
                Console.WriteLine(ifade);
            }

        }
    }
}