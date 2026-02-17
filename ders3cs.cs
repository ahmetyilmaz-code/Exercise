using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subat172
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan isim soy isim ve yaş bilgisini alarak ekrana 
            //çıktısı : Merhaba ahmet yılmaz 
            // yaşınız : 28 18 den büyük veya eşitsiniz
            // yaşınızı onaylıyormusunuz. (Evet: E)
            // Bilgiler onaylandı E ise değilse Bilgiler onaylanmadı, kayıt başarısız.

            Console.Write("İsminiz : ");
            string isim = Console.ReadLine();

            Console.Write("Soy isminiz :");
            string soyisim = Console.ReadLine();

            Console.Write("Yaşınız :");
            int yas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Merhaba {isim} {soyisim}");
            Console.WriteLine("Verileriz İşleniyor Lütfen bekleyiniz...\n\n");
            

            string yas2 = yas >= 18 ? "Yaşınız 18'e eşit veya büyüktür. " : "Yaşınız 18 den küçüktür.";
            Console.WriteLine(yas2);
            Console.WriteLine("Yaşınızı Onaylamak için  E'ye basınız. (Büyük Küçük Uyarlıdır!!!)");
            string onay = Console.ReadLine();   
            onay = onay == "E" ? "Bilgiler Onaylandı Kayıt Başarılı" : "Bilgiler Onaylanmadı Kayıt Başarısız";
            Console.WriteLine(onay);





        }
    }
}
