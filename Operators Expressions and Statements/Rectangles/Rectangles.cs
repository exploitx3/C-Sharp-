using System;


namespace Rectangles
{
    class Rectangles
    {
        static void Main()
        {
            Console.Write("Width: ");
            double width = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Rectangle's perimeter is " + (width*2+height*2) + " and it's area is " + width*height +".");
        }
    }
}
