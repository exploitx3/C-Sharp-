using System;


namespace CirclePerimeterAndArea
{
    class CirclePerimeterAndArea
    {
        static void Main()
        {
            Console.Write("r= ");
            double r = double.Parse(Console.ReadLine());
            double pi = 3.14159265359;
            Console.WriteLine("Perimiter = {0:F2}", (2 * pi * r));
            Console.WriteLine("Area = {0:F2}", (pi*(r*r)));
        }
    }
}
