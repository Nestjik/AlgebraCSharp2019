using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi ime proizvoda: ");
            Proizvod p = new Proizvod(Console.ReadLine());
            Console.Write("Unesi cijenu proizvoda: ");
            p.cijena = double.Parse(Console.ReadLine());
            Console.Write("Unesi marzu: ");
            p.marza = double.Parse(Console.ReadLine());
            Console.Write("Unesi porez: ");
            p.porez = double.Parse(Console.ReadLine());
            Console.Write("Maloprodajna cijena za {0} je: {1}", p.naziv, p.Mpc());
            Console.Read();
        }
    }
}
