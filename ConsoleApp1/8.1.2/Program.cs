using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi marku automobila: ");
            Automobil a = new Automobil(Console.ReadLine());
            Console.Write("Unesi KS: ");
            a.ks = double.Parse(Console.ReadLine());
            Console.Write("Unesi osnovnu cijenu: ");
            a.osnovnaCijena = double.Parse(Console.ReadLine());

            Console.Write("Porez na {0} iznosi {1}%, a ukupna cijena je {2}", a.markaAutomobila, a.IsnosPoreza()*100, a.UkupnaCijena());
            Console.Read();
        }
    }
}
