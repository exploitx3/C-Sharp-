using System;


namespace PointInsideCircleAndOutside
{
    class PointInsideCircleAndOutside
    {
        static void Main()
        {
            double x, y;
            Console.Write("x= ");
            bool CheckX = double.TryParse(Console.ReadLine(),out x);
            Console.Write("y= ");
            bool CheckY = double.TryParse(Console.ReadLine(),out y);
            if(CheckX && CheckY)
            {
                if ((((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1.5 * 1.5) && ((x > 0.5 && y >= 0.5) && (x < 2.5 && y <= 2.5)))
                {
                    Console.WriteLine("Yes");
                }
                else
                {
                    Console.WriteLine("No");
                }
            }
         
        }
    }
}
