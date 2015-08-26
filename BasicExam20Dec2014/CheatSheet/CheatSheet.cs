using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheatSheet
{
    class CheatSheet
    {
        static void Main(string[] args)
        {
            long numRows = long.Parse(Console.ReadLine());
            long numCols = long.Parse(Console.ReadLine());
            long verticalNumber = long.Parse(Console.ReadLine());
            long horizontalNumber = long.Parse(Console.ReadLine());
            
            for (long i = verticalNumber; i < numRows + verticalNumber; i++)
            {
                for (long j = horizontalNumber; j < numCols + horizontalNumber; j++)
                {                   
                        Console.Write(j*i + " ");          
                }
                Console.WriteLine();
            }
        }
    }
}
