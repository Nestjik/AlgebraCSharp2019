using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._1
{
    internal static class Static
    {
        public static double Zbroj(double broj1, double broj2)
        {
            return broj1 + broj2;
        }

        public static double Kub(double broj)
        {
            return Math.Pow(broj, 3);
        }

        public static double Udaljenost(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static int CtoF(int c)
        {
            return Convert.ToInt32(c * 1.8 + 32);
        }
    }
}
