using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._15
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
