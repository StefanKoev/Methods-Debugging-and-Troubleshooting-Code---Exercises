using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello_Name
{
    class Program
    {
        static void PrintHelloName(string name)
        {
            Console.WriteLine("Hello, {0}!", name);
        }
        static void Main()
        {
            string name = Console.ReadLine();
            PrintHelloName(name);
        }
    }
}
