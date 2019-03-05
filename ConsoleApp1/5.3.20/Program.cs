using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._20
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int parni = 0;
                int neparni = 0;
                while (true)
                {
                    Console.Write("Unesi brojeve (prekini unos sa 0): ");
                    int num = int.Parse(Console.ReadLine());
                    if (num != 0)
                    {
                        if (num % 2 == 0)
                        {
                            parni++;
                        }
                        else
                        {
                            neparni++;
                        }
                    }
                }
                Console.WriteLine("Parnih je: " + parni);
                Console.WriteLine("Neparnih je: " + neparni);
            }
            catch (FormatException m)
            {
                Console.WriteLine(m);
            }
            Console.Read();
        }
    }
}
