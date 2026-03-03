using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mart31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan gün sayıyısı alarak haftanın hang günü olduğunu bulan program.
            // bugün günlerden pazartesi. Kaç gün sonrasını merak ediyorsun?

            Console.Write("Bugün günlerden pazartesi. Kaç gün sonrasını merak ediyorsunuz? :");
            int gun = Convert.ToInt32(Console.ReadLine());
            string sonuc = $"{gun} sonra günlerden ";

            switch (gun % 7)
            {
                case 0:
                    sonuc += "Pazartesi";
                    break;
                case 1:
                    sonuc += "Salı";
                    break;
                case 2:
                    sonuc += "Çarşamba";
                    break;
                case 3:
                    sonuc += "Perşembe";
                    break;
                case 4:
                    sonuc += "Cuma";
                    break;
                case 5:
                    sonuc += "Cumartesi";
                    break;
                case 6:
                    sonuc += "Pazar";
                    break;
            }
            Console.WriteLine(sonuc);

        }
    }
}
