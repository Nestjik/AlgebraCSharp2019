using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi prirodni broj: ");
            try
            {
                int num = int.Parse(Console.ReadLine());
                if (num <= 0)
                {
                    throw new Exception("Broje treba biti veci od 0");
                }
                int sum = 0;
                for (int i = 1; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        sum += i;
                    }
                }
                if (sum == num)
                {
                    Console.WriteLine("Broj je savrsen");
                }
                else
                {
                    Console.WriteLine("Broj nije savrsen");
                }
            }
            catch (Exception m)
            {
                Console.Write("GRESKA: " + m);
            }
            Console.Read();
        }
    }
}
