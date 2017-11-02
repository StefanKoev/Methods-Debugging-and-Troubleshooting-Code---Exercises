using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12.Mater_Numbers
{
    class Program
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool symmetric = IsPalindrome(i);
                bool divisibleBySeven = SumOfDigits(i);
                bool even = ContainEvenDigit(i);

                if (symmetric && divisibleBySeven && even)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool ContainEvenDigit(int i)
        {
            while (i > 0)
            {
                int digit = i % 10;
                if (digit % 2 == 0)
                {
                    return true;
                }
                i /= 10;
            }
            return false;
        }

        private static bool SumOfDigits(int i)
        {
            int sum = 0;
            while (i > 0)
            {
                sum += i % 10;
                i /= 10;
            }
            if (sum % 7 == 0)
            {
                return true;
            }
            return false;
        }

        private static bool IsPalindrome(int i)
        {
            var numter = i;
            var reversedNumber = 0;

            while (i > 0)
            {
                int lastDigit = i % 10;
                reversedNumber = reversedNumber * 10 + lastDigit;

                i /= 10;
            }
            if (numter == reversedNumber)
            {
                return true;
            }
            return false;
        }
    }
}
