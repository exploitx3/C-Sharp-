using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DrunkAni
{
    class DrunkAni
    {
        static void Main(string[] args)
        {
            long numberOfCabins = long.Parse(Console.ReadLine());
            string nextCommand = Console.ReadLine();
            long oldPosition = 0;
            long currentPosition = 0;
            long[] difference = new long[20000];
            long iCount = 0;

            try
            {
                while (nextCommand != "Found a free one!")
                {
                    long stepsPosition;
                    bool parsePos = long.TryParse(nextCommand, out stepsPosition);
                    if (parsePos)
                    {

                        oldPosition = currentPosition;
                        currentPosition = (currentPosition + stepsPosition) % numberOfCabins;
                        difference[iCount] = currentPosition - oldPosition;
                        iCount++;
                    }
                    
                        nextCommand = Console.ReadLine();
                    
                    

                }
                long totalSteps = 0;
                for (long i = 0; i < iCount; i++)
                {
                    if (difference[i] > 0)
                    {
                        Console.WriteLine("Go {0} steps to the right, Ani.", Math.Abs(difference[i]));
                    }
                    if (difference[i] < 0)
                    {
                        Console.WriteLine("Go {0} steps to the left, Ani.", Math.Abs(difference[i]));
                    }
                    if (difference[i] == 0)
                    {
                        Console.WriteLine("Stay there, Ani.");

                    }
                    totalSteps += Math.Abs(difference[i]);
                }
                Console.WriteLine("Moved a total of {0} steps.", totalSteps);

            }catch(Exception)
            {

            }
        }
    }
}
