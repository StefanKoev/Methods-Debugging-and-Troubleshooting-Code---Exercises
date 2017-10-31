using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Cube_Properties
{
    class Program
    {
        static void Main(string[] args)
        {
            double site = double.Parse(Console.ReadLine());
            string type = Console.ReadLine();

            switch (type)
            {
                case "face":
                    GetFace(site);
                    break;
                case "space":
                    GetSpace(site);
                    break;
                case "volume":
                    GetVolume(site);
                    break;
                case "area":
                    GetArea(site);
                    break;
            }
        }

            private static void GetArea(double site)
        {
            double area = 6 * Math.Pow(site, 2);
            Console.WriteLine($"{area:f2}");
        }

        private static void GetVolume(double site)
        {
            double volume = Math.Pow(site, 3);
            Console.WriteLine($"{volume:f2}");
        }

        private static void GetSpace(double site)
        {
            double spaceDiagonal = Math.Sqrt(3 * Math.Pow(site, 2));
            Console.WriteLine($"{spaceDiagonal:f2}");
        }

        private static void GetFace(double site)
        {
            double faceDiagonal = Math.Sqrt(2 * Math.Pow(site, 2));
            Console.WriteLine($"{faceDiagonal:f2}");
        }
    }
}
