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

            //kullanının girdiği sayı kadar ekrana virül ise sayıları yazan program
            // 5
            // 1, 2, 3, 4, 5

            Console.WriteLine("Girilen sayıya kadar sayıları yazan program");            
            Console.Write("Kaça kadar sayıları yazayım :");
            int adet = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= adet; i++)
            {
                if (i < adet)
                {
                    Console.Write($"{i},");
                }
                else
                {
                    Console.Write(i);
                }

            }

        }
    }
}