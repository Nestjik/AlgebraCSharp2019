using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8._2._2
{
    internal class NekiKlas
    {
        public static bool DalSiProst(int num)
        {
            if (num < 2)
            {
                return false;
            }
            int dj = 2;
            while (num > dj)
            {
                if (num % dj == 0)
                {
                    return false;
                }
                dj++;
            }
            return true;
        }

        public bool DalSiSavrsen(int num)
        {
            if (num <= 0)
            {
                return false;
            }
            int sum = 0;
            for (int i = 1; i < num; i++)
            {
                if (num % i == 0)
                {
                    sum += i;
                }
            }
            if (sum == num)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
