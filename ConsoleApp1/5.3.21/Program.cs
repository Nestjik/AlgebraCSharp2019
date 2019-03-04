using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._3._21
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi broj predmeta: ");
            try
            {
                double numPredmeta = double.Parse(Console.ReadLine());
                double suma = 0;
                string pozitivan = "DA";
                for (int i = 0; i < numPredmeta; i++)
                {
                    Console.Write("Sad unesi ocijenu za {0}. predmet: ", i + 1);
                    int ocjena = int.Parse(Console.ReadLine());
                    if (ocjena == 1)
                    {
                        pozitivan = "NE";
                        Console.WriteLine("Uspijeh je nedovoljan!");
                        break;
                    }
                    suma += ocjena;
                }
                if (pozitivan == "DA")
                {
                    Console.WriteLine("Tvoj prosjek je: " + (suma / numPredmeta));
                }
            }
            catch (FormatException m)
            {
                Console.WriteLine(m);
            }
            Console.Read();
        }
    }
}
