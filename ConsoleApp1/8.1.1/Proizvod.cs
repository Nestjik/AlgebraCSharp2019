using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._1
{
    internal class Proizvod
    {
        public Proizvod(string n)
        {
            naziv = n;
        }
        public string naziv;
        public double cijena;
        public double marza;
        public double porez;

        public double Mpc()
        {
            return cijena + marza + porez;
        }
    }
}
