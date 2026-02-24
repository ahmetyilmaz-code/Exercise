using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat244
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Kullanıcı admin girişi örneği
            // Kullanıcı adı ve şifreyi sabit bir değer olarak bir değişken içinde tutalım
            // Kullacı Adı: 
            // Şifre :
            // Kullanıcı bilgileri yanlış
            // Hatalı şifre
            // Kullanıcı adı hatalı
            // Hoşgeldiniz...
            const string kullanıcıAdi = "admin";
            const string sifre = "1234";

            Console.Write("Kullanıcı Adı: ");
            string KullanıcıAdi = Console.ReadLine();
            Console.Write("Şifre: ");
            string Sifre = Console.ReadLine();

            if (KullanıcıAdi == kullanıcıAdi && Sifre == sifre)
            {

                Console.WriteLine("Hoş geldiniz");

            }
            else if (KullanıcıAdi != kullanıcıAdi && Sifre == sifre)
            {

                Console.WriteLine("Kullanıcı adınız hatalı");

            }
            else if (KullanıcıAdi == kullanıcıAdi && Sifre != sifre)
            {

                Console.WriteLine("Şifreniz hatalı");

            }
            else
            {

                Console.WriteLine("Kullanıcı bilgileriniz yanlış.");

            }







        }
    }
}
