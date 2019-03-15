using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10._1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mapa u kojoj se izvrsava nas program: ");
            Console.WriteLine(Environment.CurrentDirectory);

            Console.Write("Postoji li file Proba.txt u izvrsnoj mapi: ");
            string mojaPutanja = Path.Combine(Environment.CurrentDirectory, "Proba.txt");

            Console.WriteLine(File.Exists(mojaPutanja));

            if (!Directory.Exists("Proba"))
            {
                Directory.CreateDirectory("Proba");
            }

            Console.WriteLine("Directori na C:");
            string[] sDirs = Directory.GetDirectories("C:\\");
            foreach (string sDir in sDirs)
            {
                Console.WriteLine(sDir);
            }

            Console.WriteLine("Datoteke na C:");
            string[] sFiles = Directory.GetFiles(@"C:\");
            foreach (string sFile in sFiles)
            {
                Console.WriteLine(Path.GetFileName(sFile));
            }
            Console.Read();
        }
    }
}
