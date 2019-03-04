using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._6
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1900; i <= 2007; i++)
            {
                if (i % 4 == 0 && i % 100 != 0 || i % 400 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
