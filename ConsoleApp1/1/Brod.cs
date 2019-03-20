using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Brod
    {
        public delegate void PromjenaDeleg(object o, EventArgs e);
        public event PromjenaDeleg Promjena;

        private double istisnina;
        public double Istisnina
        {
            get { return istisnina; }
            set
            {
                istisnina = value;
                if (Promjena != null)
                {
                    Promjena(this, new EventArgs());
                }
            }
        }
    }
}
