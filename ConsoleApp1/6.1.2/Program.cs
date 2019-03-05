using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj;
            int[] niz = new int[5];
            for (int i = 0; i < 5; i++)
            {
                broj = int.Parse(Console.ReadLine());
                niz[i] = broj;
            }
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(niz.Max());
            Console.ForegroundColor = ConsoleColor.White;
            Console.Read();
        }
    }
}
