// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Shape_Area_Calculator
{
    class App
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Shape Area Calculator App");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Press 'C' for Circle or 'T' for Triangle or 'R' for Rectangle");
            char shape = Console.ReadKey().KeyChar;
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        switch (shape)
        {
            case 'C':
                Console.WriteLine("Enter the radius of the circle");
                double radius = Convert.ToDouble(Console.ReadLine());
                double area = Math.PI * radius * radius;
                Console.WriteLine("The area of the circle is " + area);
                break;
            case 'T':
                Console.WriteLine("Enter the base of the triangle");
                double baseT = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the height of the triangle");
                double height = Convert.ToDouble(Console.ReadLine());
                double areaT = 0.5 * baseT * height;
                Console.WriteLine("The area of the triangle is " + areaT);
                break;
            case 'R':
                Console.WriteLine("Enter the length of the rectangle");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle");
                double width = Convert.ToDouble(Console.ReadLine());
                double areaR = length * width;
                Console.WriteLine("The area of the rectangle is " + areaR);
                break;
            default:
                Console.WriteLine("Invalid input");
                break;




        }
    }
}
}