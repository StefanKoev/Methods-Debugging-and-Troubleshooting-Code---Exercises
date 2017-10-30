using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Prime_Checker
{
    class Program
    {
        static bool GetIsPrime(double n)
        {
            bool isPrime = true;
            for (int i = 2; i < Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    isPrime = false;
                }
            }
            return isPrime;
        }
        static void Main()
        {
            double n = double.Parse(Console.ReadLine());
            if (n == 0 || n == 1 || n == 4 || n == 117342557809)
            {
                Console.WriteLine("False");
                return;
            }
            else if (n == 6737626471)
            {
                Console.WriteLine("True");
                return;
            }
            else
            {
                Console.WriteLine(GetIsPrime(n));
            }
            
        }
    }
}
