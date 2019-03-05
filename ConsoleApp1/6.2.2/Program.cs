using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = -1;
            ArrayList arr = new ArrayList();

            arr.Add(3);
            arr.Add(4);
            arr.Add(6);
            arr.Add("jedanaest");
            arr.Add(6);

            foreach (var b in arr)
            {
                Console.WriteLine(b);
            }
            Console.Read();
        }
    }
}
