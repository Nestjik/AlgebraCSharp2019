using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._3_zz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listBrojevi = new List<int>();
            int br;
            Console.WriteLine("unesi brojeve (prekid sa 0):");

            while (true)
            {
                br = int.Parse(Console.ReadLine());
                if (br == 0)
                {
                    break;
                }
                listBrojevi.Add(br);
            }
            listBrojevi.Sort();

            Console.WriteLine("\nBrojevi su: ");
            foreach (int item in listBrojevi)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
