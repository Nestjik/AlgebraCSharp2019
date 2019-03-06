using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._5_zz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("unesi broj: ");
            int br = int.Parse(Console.ReadLine());
            int i = 2;
            while (br > 1)
            {
                if (br % i == 0)
                {
                    br = br / i;
                    Console.WriteLine(i);
                }
                else
                {
                    i++;
                }
            }
            Console.Read();
        }
    }
}
