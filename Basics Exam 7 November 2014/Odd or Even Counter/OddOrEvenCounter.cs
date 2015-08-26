using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_or_Even_Counter
{
    class OddOrEvenCounter
    {
        static string MakeOrdinal(int x)
        {
            switch(x)
            {
                case 1:
                    return "First";
                case 2:
                    return "Second";
                case 3:
                    return "Third";
                case 4:
                    return "Fourth";
                case 5:
                    return "Fifth";
                case 6:
                    return "Sixth";
                case 7:
                    return "Seventh";
                case 8:
                    return "Eighth";
                case 9:
                    return "Ninth";
                case 10:
                    return "Tenth";
                default:
                    return "";
            }
        }
        static void Main(string[] args)
        {
            int countOfSets = int.Parse(Console.ReadLine());
            int numInSet = int.Parse(Console.ReadLine());
            string oddOrEven = Console.ReadLine();
            int[,] numbers = new int[countOfSets, numInSet];
            bool isOdd = oddOrEven == "odd" ? true : false;
            int maxCount = 0;
            int rowWithMax = 0;
            for (int i = 0; i < countOfSets; i++)
            {
                int rowCount = 0;                
                for (int j = 0; j < numInSet; j++)
                {
                    
                    numbers[i, j] = int.Parse(Console.ReadLine());
                    if(isOdd)
                    {
                        if(numbers[i,j] % 2 == 1)
                        {
                            rowCount++;
                        }
                    }
                    if(!isOdd)
                    {
                        if(numbers[i,j] % 2 == 0)
                        {
                            rowCount++;
                        }
                    }
                }
                if(maxCount<rowCount)
                {
                    rowWithMax = i+1;
                    maxCount = rowCount;
                }
            }
            if (rowWithMax == 0)
            {
                Console.WriteLine("No");
            }
            else
            {
                Console.WriteLine("{0} set has the most {1} numbers: {2}", MakeOrdinal(rowWithMax), oddOrEven, maxCount);
            }

        }
    }
}
