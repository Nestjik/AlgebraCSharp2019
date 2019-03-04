using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._11
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            while (start < 1001)
            {
                int sum = 0;
                for (int i = 1; i < start; i++)
                {
                    if (start % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == start)
                {
                    Console.WriteLine(start);
                }
                start++;
            }
            Console.Read();
        }
    }
}
