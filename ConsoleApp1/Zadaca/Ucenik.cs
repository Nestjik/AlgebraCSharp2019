using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca
{
    internal class Ucenik
    {
        public Ucenik(string i, string p, long o=0, int? r=null)
        {
            this.ime = i;
            this.prezime = p;
            this.Oib = o;

            if (r == null)
            {
                this.Racun = rand.Next(2000, 6001);
            }
            else
            {
                this.Racun = (int)r;
            }
        }

        private string ime;
        public string Ime { get => ime; }

        private string prezime;
        public string Prezime { get => prezime; }

        private long oib;
        public long Oib { set => oib = value; }

        private int racun;
        public int Racun { get => racun; set => racun = value; }

        public string telefon;

        private static Random rand = new Random();

        public override string ToString()
        {
            return $"Pozdrav, {this.Ime} {this.Prezime}! Stanje vaseg racuna iznosi {this.Racun} kn.";
        }
    }
}
