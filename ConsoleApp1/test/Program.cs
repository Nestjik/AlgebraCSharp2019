using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nesto = new List<string>();
            nesto.Add("fds");
            nesto.Add("fgf");
            nesto.ForEach(delegate(string n){
                Console.WriteLine(n);
            });
            Console.Read();
        }
    }
}
