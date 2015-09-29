using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teleport_Points
{
    class TeleportPoints
    {
        static void Main(string[] args)
        {
            double[,] cordinatesArr = new double[4,2];
            for (int i = 0; i < 4; i++)
            {
                string[] tempStr = Console.ReadLine().Split(' ');
                cordinatesArr[i, 0] = double.Parse(tempStr[0]);
                cordinatesArr[i, 1] = double.Parse(tempStr[1]);
            }
            double aX = cordinatesArr[0, 0];
            double aY = cordinatesArr[0, 1];
            double bX = cordinatesArr[1, 0];
            double bY = cordinatesArr[1, 1];
            double cX = cordinatesArr[2, 0];
            double cY = cordinatesArr[2, 1];
            double dX = cordinatesArr[3, 0];
            double dY = cordinatesArr[3, 1];


            double radiusR = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());
            double width = Math.Abs(cordinatesArr[0, 0]) + Math.Abs(cordinatesArr[1, 0]);
            double height = Math.Abs(cordinatesArr[3, 1]) + Math.Abs(cordinatesArr[2, 1]);
            double radius = radiusR;
            
            double heightCenterRadius = height/2;
            double weightCenterRadius =  width/2;
            double ignoreRadius = step;
            if (step == 1.00)
            {
                ignoreRadius = 0;
            }

            int count = 0;
            for (double i = 0; i < height; i+=step)
            {
                for (double j = 0; j < width; j+=step)
                {//((x*x) + (y*y)) <= 2*2
                   //  bool fromDeathPoolPosition = (i > heightCenterRadius - step && i < heightCenterRadius + step) &&(j > weightCenterRadius - step && j < weightCenterRadius + step);
                    bool ignorePositions = (Math.Pow(i - heightCenterRadius, 2) + Math.Pow(j - weightCenterRadius, 2)) >= ignoreRadius*ignoreRadius;
                        if ((Math.Pow(i - heightCenterRadius, 2) + Math.Pow(j - weightCenterRadius, 2)) <= radius*radius)
                        {
                            if (ignorePositions)
                            {
                                count++;

                            }
                        }
                    
                }
            }
            Console.WriteLine(count);
           
        }
    }
}
/*
-20 -3
20 -3
20 3
-20 3
10
0.4
 * 
-7.2 -8.8
10.4 -8.8
10.4 9.1
-7.2 9.1
30.5
1
*/