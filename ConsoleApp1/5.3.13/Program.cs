using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._13
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = Int32.MaxValue;
            int max = 0;
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Unesi prirodan broj: ");
                int num = int.Parse(Console.ReadLine());
                if (num < min)
                {
                    min = num;
                }
                if (num > max)
                {
                    max = num;
                }
            }
            Console.WriteLine(min);
            Console.WriteLine(max);
            Console.Read();
        }
    }
}
