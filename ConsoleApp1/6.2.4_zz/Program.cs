using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6._2._4_zz
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listBrojevi = new List<int>();
            Console.Write("unesi broj: ");
            string br = Console.ReadLine();

            char[] charArray = br.ToCharArray();
            Array.Reverse(charArray);
            Console.WriteLine(charArray);
            Console.Read();
        }
    }
}
