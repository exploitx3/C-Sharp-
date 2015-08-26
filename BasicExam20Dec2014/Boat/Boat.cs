using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boat
{
    class Boat
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n + ((n - 1)) / 2;
            int width = n * 2;
            int leftCounter = n - 1;
            int bodyLeft = 0;
            int bodyRight = width - 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(i==0 && j==n-1)
                    {
                        Console.Write('*');
                    }else if(i>0 && (j>= leftCounter && j<=n-1))
                    {
                        Console.Write('*');
                    }else if(i>=n && (j>=bodyLeft && j <=bodyRight))
                    {
                        Console.Write('*');
                    }
                    
                    
                    else
                    {
                        Console.Write('.');
                    }


                    
                }
                Console.WriteLine();
                    if(i>=0 && i <n/2)
                    {
                        leftCounter-=2;
                    }
                    if(i>=n/2)
                    {
                        leftCounter+=2;
                    }
                    if (i>=n)
                    {
                        bodyLeft++;
                        bodyRight--;
                    }

            }
        }
    }
}
