using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10._1_datoteke
{
    class Program
    {
        static void Main(string[] args)
        {
            string upis = Console.ReadLine();
            FileStream fs1 = new FileStream("Proba.txt", FileMode.Create);

            StreamWriter sw1 = new StreamWriter(fs1);

            sw1.WriteLine(upis);

            sw1.Flush();

            sw1.Close();
            fs1.Close();

            FileStream fs2 = new FileStream("Proba.txt", FileMode.Open);
            StreamReader sr1 = new StreamReader(fs2);

            string procitano = sr1.ReadToEnd();
            Console.WriteLine("Ispis iz datetoke Proba.txt \n" + procitano);

            Console.Read();
        }
    }
}
