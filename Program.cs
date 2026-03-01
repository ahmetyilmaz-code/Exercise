using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motor_ve_Redüktör_Seçimi_Hesabı
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Sac Levha Üzerinde Plastik Bantlı Konveyör Sistemi Tasarımında Motor Gücü ve Redüktör Seçimini Hesaplayan Program

            //Konveyör İçin Tambur Devri Hesabı
            //ղtambur = (V x 60) / 𝛑 x D 
            //ղtambur : Tambur Devri ( Gerekli Devir ) [d/d]
            //V: Hız[m / sn] // 0.45m/s
            //D: Tambur Çapı[m]	// 50mm --> 0.05m
            //ղtambur = (0.45 x 60) / 𝛑 x 0.05
            //ղtambur = 171.8873[d / d]            

            Console.WriteLine("Konveyör Tambur Devri Hesabı İçin Gerekli Parametreleri Giriniz ");
            double V, D, Ntambur;            
            V = 0.45;
            D = 0.05;
            Console.Write($"V: Yük Hızı [m / sn] :{V}\n");
            //V = Convert.ToDouble(Console.ReadLine());
            Console.Write($"D: Tambur Çapı[m] :{D}\n");
            //D = Convert.ToDouble(Console.ReadLine());
            Ntambur = (V * 60) / (Math.PI * D);
            Console.WriteLine($"Konveyör Tambur Devri : {Ntambur} [d/d] \n");

            Console.WriteLine("-------------------------------------------------- \n");

            //Konveyörlerde Gerekli Güç Hesabı
            //P = ((A x Mtt x V) / (1000 x Nverim ) ) x kem
            //P: Konveyörlerde Gerekli Güç[kw]
            //Mt: Konveyör Üzerindeki Toplam Bant + Yük Ağırlığı[kg](Toplam Yük)
            //V: Yük Hızı[m / sn] // 0.45 m/s
            //Nverim: Tahrik Verimi	 // 0.8
            //kem : Emniyet Katsayısı // 1.2
            Console.WriteLine("Konveyör Güç Hesabı İçin Gerekli Parametreleri Giriniz \n");
            double P, Mtt, A, kem = 1.2, Nverim=0.8;
            Console.Write($"Nverim: Tahrik Verimi : {Nverim} \n");
            //Nverim = Convert.ToDouble(Console.ReadLine());
            Console.Write($"kem: Emniyet Katsayısı : {kem}\n");
            //kem = Convert.ToDouble(Console.ReadLine());


            //Mtt: Konveyör Üzerindeki Toplam Bant +Yük Ağırlığı[kg](Toplam Yük)
            //Mtt = Myük + Mbant
            //→ Myük = (Lk / Lym) x My
            //Myük: Bant Üzerindeki Yük
            //Lk : Konveyörün Uzunluğu[m]  // 0.99768
            //Lym: Yükler Arası Mesafe[m]  // 0.1
            //My: Yük Başına Ağırlık[kg] // 7
            //Myük = (0.99768 / 0.1) x 7
            //Myük = 69.8376[kg]
            //→ Mbant = 0.24770[kg]
            //Mbant: Bant Ağırlığı
            //Mtt = 69.8376 + 0.24770 = 70.0853[kg]
            double Lk=0.99768, Lym=0.1, My=7, Mbant=0.24770, Myuk;
            Console.Write($"Lk: Konveyörün Uzunluğu [m] :{Lk}\n");
            //Lk = Convert.ToDouble(Console.ReadLine());

            Console.Write($"Lym:Yükler Arası Mesafe [m] : {Lym}\n");
            //Lym = Convert.ToDouble(Console.ReadLine());
            Console.Write($"My: Yük Başına Ağırlık [kg] : {My}\n");
            //My = Convert.ToDouble(Console.ReadLine());
            Myuk = (Lk / Lym) * My;
            Console.Write($"Mbant: Bant Ağırlığı [kg] : {Mbant}\n");
            //Mbant = Convert.ToDouble(Console.ReadLine());
            Myuk = (Lk / Lym) * My;
            Mtt = Myuk + Mbant;
            Console.WriteLine($"Mtt: Konveyör Üzerindeki Toplam Bant +Yük Ağırlığı[kg] : {Mtt}\n");
            Console.WriteLine("-------------------------------------------\n");

            //Mbba = (Mbant / Lk) / 2[kg / m]
            //Mbba: Metre Başına Bant Ağırlığı
            //Mbba = (0.24770 / 0.99768) / 2
            //Mbba = 0.1241[kg / m]
            double Mbba;
            Mbba = (Mbant / Lk) / 2;
            Console.WriteLine($"Mbba: Metre Başına Bant Ağırlığı [kg/m] :{Mbba}\n");
            Console.WriteLine("-------------------------------------------\n");

            //A = (sinα x μ x cosα ) x g
            //μ: Sürtünme Direnç Katsayısı // Çelik(Sert)-Polystyrene 0,3-0,35 → 0.33
            //g : Yerçekimi Kuvveti // 9.81
            //α: Eğim Açısı //0
            //A = (0 + 0.33 x 1 ) x 9.81
            //A = 3.2373
            //P = (A x Mt x V) / (1000 x ƞ ) x kem
            //P = (3.2373 x 70.0853 x 0.45 ) / (1000 x 0.8) x 1.2
            //P = 0.1531[kw](Gerekli Güç)
            double g, alpha, u;
            
            g = 9.81;
            Console.Write($"g: Yerçekimi Kuvveti : {g}\n");
            u = 0.33;
            Console.Write($"u: Sürtünme Direnç Katsayısı : {u}\n");
            //u = Convert.ToDouble(Console.ReadLine());
            alpha = 0;
            Console.Write($"alpha: Eğim Açısı [°] : {alpha}\n");
            //alpha = Convert.ToDouble(Console.ReadLine());
            A = (Math.Sin(0) + u * Math.Cos(0)) * g;
            Console.Write($"A: Konveyör İçin A Değeri : {A}\n");
            P = ( (A * Mtt * V) / (1000 * Nverim ) ) * kem;         
            Console.WriteLine($"P: Konveyör İçin Gerekli Güç : {P} [kw] \n");   












        }
    }
}
