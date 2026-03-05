using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace mart501
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcının girdiği aralıktaki sayıların içinden çift olanlarını ekrana yazan program
            // başlangıç : 1
            // bitiş : 6
            // çıktı : 2, 4, 6

            Console.WriteLine("Lütfen bir sayı aralığının başlangıç ve bitiş aralığını giriniz");
            Console.Write("Başlangıç : ");
            int baslangic = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bitiş : ");
            int bitis = Convert.ToInt32(Console.ReadLine());


            switch (baslangic <= bitis)
            {
                case true:
                    for (int i = baslangic; i <= bitis; i++)
                    {
                        if (i % 2 == 0)
                        {
                            Console.Write(i == bitis || i == bitis - 1 ? i.ToString() : $"{i} ");
                        }
                    }
                    break;
                case false:
                    {
                        int _baslangıc = baslangic;
                        baslangic = bitis;
                        bitis = _baslangıc;
                        goto case true;
                    }
            }

            Console.ReadKey();
        }
    }
}
