using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj: ");
            int num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.Read();
        }
    }
}
