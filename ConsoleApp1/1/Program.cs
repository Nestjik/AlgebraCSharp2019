using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            Brod brod = new Brod();
            brod.Promjena += new Brod.PromjenaDeleg(NaPromjenu);
            brod.Istisnina = 100;
            brod.Istisnina = 100;
            brod.Promjena -= new Brod.PromjenaDeleg(NaPromjenu);
            brod.Istisnina = 100;

            string s = "fdsjgkl rwse";

            Console.WriteLine(s.Replace(s[0], Char.ToUpper(s[0])));

            Console.Read();
        }
        static void NaPromjenu(object o, EventArgs e)
        {
            Brod b = (Brod)o;
            Console.WriteLine("Promjena");
            Console.WriteLine(b.Istisnina);
        }
    }
}
