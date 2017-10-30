using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Fibonacci_numbers
{
    class Program
    {
        static void Fib(int n)
        {
            int f0 = 0;
            int f1 = 1;
            int fn = 1;
            for (int i = 0; i < n; i++)
            {
                fn = f1 + f0;
                f0 = f1;
                f1 = fn;
            }
            Console.WriteLine(fn);
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Fib(n);

        }
    }
}