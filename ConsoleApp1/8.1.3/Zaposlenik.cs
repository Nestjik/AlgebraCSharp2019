using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._1._3
{
    internal class Zaposlenik
    {
        public Zaposlenik()
        {
        }

        public Zaposlenik(string i, string p)
        {
            this.Ime = i;
            this.Prezime = p;
        }

        public Zaposlenik(string i, string p, int jmbg)
        {
            this.Ime = i;
            this.Prezime = p;
            this.JMBG = jmbg;
        }

        public string Ime;
        public string Prezime;
        public int JMBG;
        public int BrojBodova;
        public int VrijednostBoda;
        public double Porez;

        public int NetoIzracunPlace()
        {
            return BrojBodova * VrijednostBoda;
        }

        public double BrutoIzracunPlace()
        {
            return NetoIzracunPlace() + Porez;
        }
    }
}
