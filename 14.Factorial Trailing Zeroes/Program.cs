using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13.Factorial
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            BigInteger factorial = 1;
            int zeroes = 0;
            for (int i = 1; i <= n; i++)
            {
                factorial = factorial * i;
            }
            while (factorial % 10 == 0)
            {
                factorial /= 10;
                zeroes++;
            }
            Console.WriteLine(zeroes);
        }
    }
}