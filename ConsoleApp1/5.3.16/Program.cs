using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._16
{
    class Program
    {
        static void Main(string[] args)
        {
            double potencija = 2;
            for (int i = 2; potencija < 1000; i++)
            {
                Console.WriteLine(potencija);
                potencija = Math.Pow(2, i);
            }
            Console.Read();
        }
    }
}
