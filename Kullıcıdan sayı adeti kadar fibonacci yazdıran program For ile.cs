using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart1701
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Fibonacci 
            // 1 1 2 3 5 8 ....

            // Kullıcıdan sayı adeti kadar fibonacci yazdıran program
            // Fibonacci Sayı Adeti : 5
            // 1 1 2 3 5 
            // Fibonacci Sayı Adeti : 7
            // 1 1 2 3 5 8 ...
            // 0 ve 0dan küçük sayılar için hata mesajı verelim



            Console.Write("Fibonacci dizisini kaç sayı yazayım : ");
            int hedef = Convert.ToInt32(Console.ReadLine());
            int s1 = 1, s2 = 1; hedef = 0;
            while (hedef <= 0)
            {
                Console.Write("Lütfen 0 ve 0'dan küçük olmayan bir sayı giriniz : ");
                hedef = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < hedef; i++)
            {
                Console.Write($"{s1} ");
                int s3 = s1 + s2;

                s1 = s2;
                s2 = s3;
            }



        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart1701
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Fibonacci 
            // 1 1 2 3 5 8 ....

            // Kullıcıdan sayı adeti kadar fibonacci yazdıran program
            // Fibonacci Sayı Adeti : 5
            // 1 1 2 3 5 
            // Fibonacci Sayı Adeti : 7
            // 1 1 2 3 5 8 ...
            // 0 ve 0dan küçük sayılar için hata mesajı verelim



            Console.Write("Fibonacci dizisini kaç sayı yazayım : ");
            int hedef = Convert.ToInt32(Console.ReadLine());
            int s1 = 1, s2 = 1; hedef = 0;
            while (hedef <= 0)
            {
                Console.Write("Lütfen 0 ve 0'dan küçük olmayan bir sayı giriniz : ");
                hedef = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < hedef; i++)
            {
                Console.Write($"{s1} ");
                int s3 = s1 + s2;

                s1 = s2;
                s2 = s3;
            }



        }
    }
}
