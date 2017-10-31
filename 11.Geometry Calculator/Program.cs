using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Geometry_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();

            switch (type)
            {
                case "triangle":
                    double side = double.Parse(Console.ReadLine());
                    double height = double.Parse(Console.ReadLine());
                    CetTriangleArea(side, height);
                    break;
                case "square":
                    double sideSquare = double.Parse(Console.ReadLine());
                    GetSquareArea(sideSquare);
                    break;
                case "rectangle":
                    double widthRectangle = double.Parse(Console.ReadLine());
                    double heightRectangle = double.Parse(Console.ReadLine());
                    GetRectangleArea(widthRectangle, heightRectangle);
                    break;
                case "circle":
                    double radius = double.Parse(Console.ReadLine());
                    GetCircleArea(radius);
                    break;
            }

        }

        private static void GetCircleArea(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"{area:f2}");
        }

        private static void GetRectangleArea(double widthRectangle, double heightRectangle)
        {
            double area = widthRectangle * heightRectangle;
            Console.WriteLine($"{area:f2}");
        }

        private static void GetSquareArea(double sideSquare)
        {
            double area = Math.Pow(sideSquare, 2);
            Console.WriteLine($"{area:f2}");
        }

        private static void CetTriangleArea(double side, double height)
        {
            double area = (side * height) / 2;
            Console.WriteLine($"{area:f2}");
        }
    }
}
