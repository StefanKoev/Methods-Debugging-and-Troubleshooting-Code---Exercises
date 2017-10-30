using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Numbers_in_Reversed_Order
{
    class Program
    {
        static void GetReversedOrder(decimal n)
        {
            string number = n.ToString();
            char[] reverse = number.ToCharArray();
            Array.Reverse(reverse);
            string revNum = new string(reverse);
            decimal newNum = decimal.Parse(revNum);
            Console.WriteLine(newNum);
        }
        static void Main()
        {
            decimal n = decimal.Parse(Console.ReadLine());
            GetReversedOrder(n);
        }
    }
}
