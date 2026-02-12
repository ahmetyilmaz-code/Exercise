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

            int s1 = 10, s2 = 20;
            s1 = s1 + s2; //s1 = 10 + 20 = 30
            s1 = 10, s2 = 20;
            s1 += s2; // s1 = s1 + s2; // s1 = 10 + 20 = 30 += operatörünün kısaltılmış haliyle yazılmıştır.

            s1 = 10, s2 = 20;
            s2 = s2 - s1; // s2 = 20 - 10 = 10
            s1 = 10, s2 = 20;
            s2 -= s1; // s2 = s2 - s1; // s2 = 20 - 10 = 10 -= operatörünün kısaltılmış haliyle yazılmıştır.

            s1 = 10, s2 = 20;
            s1 = s1 * s2; // s1 = 10 * 20 = 200
            s1 = 10, s2 = 20;
            s1 *= s2; // s1 = s1 * s2; // s1 = 10 * 20 = 200 *= operatörünün kısaltılmış haliyle yazılmıştır.

            s1 = 10, s2 = 20;
            s1 = s1 / s2; // s1 = 10 / 20 = 0.5
            s1 = 10 s2 = 20;
            s1 /= s2; // s1 = s1 / s2; // s1 = 10 / 20 = 0.5 /= operatörünün kısaltılmış haliyle yazılmıştır.

            s1 = 10 s2 = 20;
            s1 = s1 % s2; // s1 = 10 % 20 = 10
            s1 = 10 s2 = 20;
            s1 %= s2; // s1 = s1 % s2; // s1 = 10 % 20 = 10 %= operatörünün kısaltılmış haliyle yazılmıştır.




        }
    }
}
