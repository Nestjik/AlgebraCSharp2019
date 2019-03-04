using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi brojeve (prekini unos sa 0): ");
            int num = int.Parse(Console.ReadLine());
            int sum = 0 + num;
            while (num != 0)
            {
                Console.Write("Unesi brojeve (prekini unos sa 0): ");
                num = int.Parse(Console.ReadLine());
                sum += num;
            }
            Console.WriteLine("Suma je: " + sum);
            Console.Read();
        }
    }
}
