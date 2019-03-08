using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (NekiKlas.DalSiProst(5))
            {
                Console.WriteLine("Broj je prost");
            }
            else
            {
                Console.WriteLine("Broj nije prost");
            }

            NekiKlas sb = new NekiKlas();
            if (sb.DalSiSavrsen(6))
            {
                Console.WriteLine("Broj je savrsen");
            }
            else
            {
                Console.WriteLine("Broj nije savrsen");
            }
            Console.Read();
        }
    }
}
