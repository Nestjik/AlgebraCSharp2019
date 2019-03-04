using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._12
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int sum = 0;
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("Unesi prirodan broj: ");
                    int num = int.Parse(Console.ReadLine());
                    if (num <= 0)
                    {
                        throw new Exception("Broj mora biti veci od 0!");
                    }
                    sum += num;
                }
                Console.WriteLine("Njihova suma je: " + sum);
                Console.WriteLine("Njihov prosjek je: {0}", sum / 5);
            }
            catch(Exception m)
            {
                Console.Write("GRESKA: " + m);
            }
            Console.Read();
        }
    }
}
