using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9._1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Unesi tekst: ");
            string text = Console.ReadLine();
            string textR = new string(text.Reverse().ToArray());

            if (text.Replace(" ", "").ToLower() == textR.Replace(" ", "").ToLower())
            {
                Console.WriteLine("Palindrom!");
            }
            else
            {
                Console.WriteLine("Nije palindrom!");
            }
            Console.Read();
        }
    }
}
