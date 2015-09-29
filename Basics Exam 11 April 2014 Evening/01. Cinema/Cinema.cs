using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            double projectionCost = 0d;
            string projectionType = Console.ReadLine();
            switch (projectionType)
            {
                case "Premiere":
                    projectionCost = 12.00;
                    break;
                case "Normal":
                    projectionCost = 7.50;
                    break;
                case "Discount":
                    projectionCost = 5.00;
                    break;
                default:
                    break;
            }
            int numRows = int.Parse(Console.ReadLine());
            int numCols = int.Parse(Console.ReadLine());
            double income = (numCols*numRows)*projectionCost;
            Console.WriteLine("{0:F2} leva",income);
        }
    }
}
