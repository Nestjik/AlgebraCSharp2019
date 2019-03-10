using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadaca
{
    class Program
    {
        static void Main(string[] args)
        {
            Ucenik u1 = new Ucenik("Marko", "Markic");
            Ucenik u2 = new Ucenik("Ivan", "Ivancic", 12345678910);
            Ucenik u3 = new Ucenik("Fdgra", "Dhrtse", 10987654321, 8000);

            List<Ucenik> listaUcenik = new List<Ucenik> { u1, u2, u3 };

            int i = 1;
            listaUcenik.ForEach(u => Ispis(u, i++));

            listaUcenik.ForEach(delegate (Ucenik u)
            {
                u.Racun -= 1000;
            });

            i = 1;
            Console.WriteLine();
            listaUcenik.ForEach(u => Ispis(u, i++));

            Console.ReadKey();
        }

        private static void Ispis(Ucenik u, int i)
        {
            Console.WriteLine($"{i}. {u}");
        }
    }
}
