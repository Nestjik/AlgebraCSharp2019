using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._2
{
    internal class Automobil
    {
        public Automobil(string m)
        {
            markaAutomobila = m;
        }

        public string markaAutomobila;
        public double ks;
        public double osnovnaCijena;

        public double IsnosPoreza()
        {
            double porez = 0;
            if (ks < 50)
            {
                porez = 0.05;
            }
            else if (ks < 150)
            {
                porez = 0.1;
            }
            else if (ks >= 150)
            {
                porez = 0.15;
            }
            return porez;
        }

        public double UkupnaCijena()
        {
            return osnovnaCijena + osnovnaCijena * IsnosPoreza();
        }
    }
}
