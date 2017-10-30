using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Primes_in_Given_Range
{
    class Program
    {
        static void Main()
        {
            int startNum = int.Parse(Console.ReadLine());
            int endNum = int.Parse(Console.ReadLine());

            FindPrimesInRange(startNum, endNum);
        }
        private static void FindPrimesInRange(int startNum, int endNum)
        {
            List<int> numbers = new List<int>();
            if (startNum > endNum)
            {
                Console.WriteLine("(empty list)");
                return;
            }
            if (startNum <= 1 || endNum < 0)
            {
                startNum = 2;
            }
            for (int i = startNum; i <= endNum; i++)
            {
                bool isPrime = true;
                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
                if (isPrime)
                {
                    numbers.Add(i);
                }
            }
            print(numbers);
        }

        private static void print(List<int> numbers)
        {
            Console.WriteLine(String.Join(", ", numbers));
        }
    }
}
