using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % 7 == 0 && i % 3 != 0)
                {
                    num++;
                }
            }
            Console.Write(num);
            Console.Read();
        }
    }
}
