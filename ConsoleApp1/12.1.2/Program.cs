using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Pritisni neku tipku za pocetak mjerenja");
            Console.ReadKey();
            Console.Clear();
            DateTime start = DateTime.Now;
            Console.Write("Pritisni neku tipku za kraj mjerenja");
            Console.ReadKey();
            Console.Clear();
            DateTime kraj = DateTime.Now;
            TimeSpan vrijeme = kraj - start;
            Console.Write($"Proslo je {vrijeme} sec");
            Console.ReadKey();
        }
    }
}
