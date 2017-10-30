using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Max_Method
{
    class Program
    {
        static void GetMax(int a, int b, int c)
        {
            int d = 0;
            if (a > b)
            {
                d = a;
            }
            else
            {
                d = b;
            }
            if (d > c)
            {
                Console.WriteLine(d);
            }
            else
            {
                Console.WriteLine(c);
            }
        }
        static void Main()
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            GetMax(a, b, c);
        }
    }
}
