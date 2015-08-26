using System;

namespace Trapezoids
{
    class Trapezoids
    {
        static void Main()
        {
            Console.Write("a= ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b= ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("h= ");
            double h = double.Parse(Console.ReadLine());
            Console.WriteLine("The area of the Trapezoid is: " + ((a+b)/2)*h);
        }
    }
}
