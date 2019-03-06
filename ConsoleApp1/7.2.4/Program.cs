using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7._2._4
{
    class Program
    {
        static double CtoF(double c)
        {
            return c * 1.8 + 32;
        }

        static void Main(string[] args)
        {
            Console.Write("Unesi Celzijeve: ");
            double c = double.Parse(Console.ReadLine());

            Console.Write("Fahrenheitovi: " + CtoF(c));
            Console.Read();
        }
    }
}
