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
            /*             1. yöntem
             for (int i = 0; i < yukseklik; i++)
            {
                for (int j = 0; j < taban; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            } 
             */
            for (int i = 0; i < yukseklik; i++)
            {
                for (int j = 0; j < taban; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }         
           
            string tabanYıldız = "";
            for (int i = 0; i < taban; i++)
            {
                tabanYıldız += "* ";
            }
            for (int i = 0; i < yukseklik; i++)
            {
                Console.WriteLine(tabanYıldız);

            }
        }
    }
