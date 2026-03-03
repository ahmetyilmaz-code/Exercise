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

            //kullanının girdiği ifadeyi ekrana 10 defa yazdıran program

            Console.Write("Lütfen bir ifade giriniz: ");
            string ifade = Console.ReadLine();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(ifade);
            }

        }
    }
}