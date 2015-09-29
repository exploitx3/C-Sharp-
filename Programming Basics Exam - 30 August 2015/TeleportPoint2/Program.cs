using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeleportPoint2
{
    class Program
    {
        static void Main(string[] args)
        {
            double[,] cordinatesArr = new double[4, 2];
            for (int i = 0; i < 4; i++)
            {
                string[] tempStr = Console.ReadLine().Split(' ');
                cordinatesArr[i, 0] = double.Parse(tempStr[0]);
                cordinatesArr[i, 1] = double.Parse(tempStr[1]);
            }
            double radius = double.Parse(Console.ReadLine());
            double step = double.Parse(Console.ReadLine());

            double aX = cordinatesArr[0, 0];
            double aY = cordinatesArr[0, 1];
            double bX = cordinatesArr[1, 0];
            double bY = cordinatesArr[1, 1];
            double cX = cordinatesArr[2, 0];
            double cY = cordinatesArr[2, 1];
            double dX = cordinatesArr[3, 0];
            double dY = cordinatesArr[3, 1];
            int pointCounter = 0;
            //left
            for (double x = 0; x >= -radius; x -= step)
            {

                //up
                for (double y = 0; y <= radius; y += step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }
            }
            //lower
            for (double x = 0; x >= -radius; x -= step)
            {
                for (double y = -step; y >= -radius; y-=step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }
            }
            //right
            for (double x = step; x <= radius; x += step)
            {
                //up
                for (double y = 0; y <= radius; y += step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }
            }
            //lower
            for (double x = step; x <= radius; x += step)
            {
                for (double y = -step; y >= -radius; y -= step)
                {
                    if ((Math.Pow(x - 0, 2) + Math.Pow(y - 0, 2)) <= Math.Pow(radius, 2))
                    {
                        if ((x > aX && x < bX) && (y < cY && y > bY))
                        {
                            pointCounter++;
                        }
                    }
                }
            }
           
            Console.WriteLine(pointCounter);
        }
    }
}
