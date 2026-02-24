using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat242
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Kullanıcıdan 3 adet kenar uzunluğu alarak alınan kenar uzunluklarına göre eşkenar üçgen, ikizkenar üçgen veya çokkenar üçgen olup olmadığını kontrol eden program.
            // Alınan 3 kenar değerine birbirine eşit ise eşkenar üçgen
            // Alınan 3 kenar değerinden herhangi ikisi eşit ise ikizkenar üçgen
            // Hiçbiri eşit değil ise çokkenar üçgen

            Console.Write("Kenar 1: ");
            int k1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kenar 2: ");
            int k2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Kenar 3: ");
            int k3 = Convert.ToInt32(Console.ReadLine());

            if (k1 == k2 && k2 == k3)
            {
                Console.WriteLine("Eşkenar Üçgen");
            }
            else if (k1 == k2 || k1 == k3 || k2 == k3)
            {
                Console.WriteLine("İkikenar Üçgen");
            }
            else
            {
                Console.WriteLine("Çokkenar Üçgen");
            }






        }
    }
}
