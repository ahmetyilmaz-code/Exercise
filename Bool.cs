using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat122
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // bool değişkenler 2 farklı değer alabilirler. true ve false.
            // bool türünde bir değişken tanımlarken bu iki değerden birini atamak gerekir.
            // bool türü genellikle koşul ifadelerinde kullanılır ve
            // programın akışını kontrol etmek için önemli bir rol oynar.
            bool a = true;
            bool b = false;

            int a1 = 10, a2 = 20;
            bool sonuc = a1 < a2; // sonuc değişkeni true değerini alır çünkü 10, 20'den küçüktür.
            Console.WriteLine(sonuc); // true  

            a1 = 10; a2 = 20;
            bool sonuc2 = a1 == a2; // sonuc2 değişkeni false değerini alır çünkü 10, 20'ye eşit değildir.
            Console.WriteLine(sonuc2);

            a1 = 20; a2 = 20;
            bool sonuc3 = a1 == a2; // sonuc3 değişkeni true değerini alır çünkü 20, 20'ye eşittir.
            Console.WriteLine(sonuc3);

            a1 = 10; a2 = 20;
            bool sonuc4 = a1 != a2; // sonuc4 değişkeni true değerini alır çünkü 10, 20'ye eşit değildir.
            Console.WriteLine(sonuc4);

            a1 = 20; a2 = 20;
            bool sonuc5 = a1 != a2; // sonuc5 değişkeni false değerini alır çünkü 20, 20'ye eşittir.
            Console.WriteLine(sonuc5);

            a1 = 10; a2 = 20;
            bool sonuc6 = a1 >= a2; // sonuc6 değişkeni false değerini alır çünkü 10, 20'den büyük veya eşit değildir.
            Console.WriteLine(sonuc6);

            a1 = 10; a2 = 20;
            bool sonuc7 = a1 <= a2; // sonuc7 değişkeni true değerini alır çünkü 10, 20'den küçük veya eşittir.
            Console.WriteLine(sonuc7);

            a1 = 10; a2 = 20;
            int a3 = 30;
            bool sonuc8 = a1 != a2 && a2 < a3; // sonuc8 değişkeni true değerini alır çünkü 10, 20'ye eşit değildir
                                               // ve 20, 30'dan küçüktür
            Console.WriteLine(sonuc8);

            a1 = 10; a2 = 20; a3 = 30;
            bool sonuc9 = a1 != a2 || a2 > a3; // sonuc9 değişkeni true değerini alır çünkü 10, 20'ye eşit değildir
                                               // veya 20, 30'dan büyük değildir.
            Console.WriteLine(sonuc9);




        }
    }
}
