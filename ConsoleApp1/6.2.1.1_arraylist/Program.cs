using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._1._1_arraylist
{
    class Program
    {
        static void Main(string[] args)
        {
            int broj = -1;
            ArrayList arr = new ArrayList();

            while (broj != 0)
            {
                broj = int.Parse(Console.ReadLine());
                arr.Add(broj);
            }

            foreach (var b in arr)
            {
                Console.WriteLine(b);
            }
            Console.Read();
        }
    }
}
