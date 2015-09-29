using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Fit_Box_in_Box
{
    class FitBoxInBox
    {
        static void Main(string[] args)
        {
            int[] firstBox = new int[3];
            for (int i = 0; i < firstBox.Length; i++)
            {
                firstBox[i] = int.Parse(Console.ReadLine());
            }
            int[] secondBox = new int[3];
            for (int i = 0; i < secondBox.Length; i++)
            {
                secondBox[i] = int.Parse(Console.ReadLine());
            }
            int[] tempBox = new int[3];
            if (firstBox.Sum() > secondBox.Sum())
            {
                tempBox = firstBox;
                firstBox = secondBox;
                secondBox = tempBox;
            }
            if (firstBox.Sum() < secondBox.Sum())
            {

                bool less =       firstBox[0] < secondBox[0] && firstBox[1] < secondBox[1] && firstBox[2] < secondBox[2];
                bool lessRotate = firstBox[0] < secondBox[2] && firstBox[1] < secondBox[1] && firstBox[2] < secondBox[0];
                bool lessRotate2 = firstBox[0] < secondBox[2] && firstBox[1] < secondBox[0] && firstBox[2] < secondBox[1];
                bool lessRotate3 = firstBox[0] < secondBox[1] && firstBox[1] < secondBox[2] && firstBox[2] < secondBox[0];
                bool lessRotate4 = firstBox[0] < secondBox[0] && firstBox[1] < secondBox[2] && firstBox[2] < secondBox[1];
                bool lessRotate5 = firstBox[0] < secondBox[1] && firstBox[1] < secondBox[0] && firstBox[2] < secondBox[2];
                if (less)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", firstBox[0], firstBox[1], firstBox[2], secondBox[0], secondBox[1], secondBox[2]);
                }
              
                if (lessRotate4)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", firstBox[0], firstBox[1], firstBox[2], secondBox[0], secondBox[2], secondBox[1]);
                }
                if (lessRotate5)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", firstBox[0], firstBox[1], firstBox[2], secondBox[1], secondBox[0], secondBox[2]);
                }
                if (lessRotate3)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", firstBox[0], firstBox[1], firstBox[2], secondBox[1], secondBox[2], secondBox[0]);
                }
                if (lessRotate2)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", firstBox[0], firstBox[1], firstBox[2], secondBox[2], secondBox[0], secondBox[1]);
                }
              
                if (lessRotate)
                {
                    Console.WriteLine("({0}, {1}, {2}) < ({3}, {4}, {5})", firstBox[0], firstBox[1], firstBox[2], secondBox[2], secondBox[1], secondBox[0]);
                }
               
               
               
               
               
              
             




            }
        }
    }
}
