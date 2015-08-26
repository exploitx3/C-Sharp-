using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star
{
    class Star
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 2 * n + 1;
            int height = (n * 2 - (n / 2 - 1));
            int leftCounter = n;
            int rightCounter = n;
            int secLeftCounter = n/2;
            int secRightCounter = width - n/2-1;
            int thirdLeftCounter = n;
            int thirdRightCounter = n;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(i==0 && j==n)
                    {
                        Console.Write('*');
                    }else if(i>0 && i<=n/2 &&  (j==leftCounter||j==rightCounter))
                    {
                        Console.Write('*');
                    }else if(i==n/2 && ((j>=0 && j<=leftCounter) || (j>=rightCounter && j<=width-1)))
                    {
                        Console.Write('*');
                    }else if(i>=n/2 && (j==secLeftCounter || j==secRightCounter))
                    {
                        Console.Write('*');
                    }
                    else if (i >= n && (j == thirdLeftCounter || j == thirdRightCounter))
                    {
                        Console.Write('*');
                    }else if(i==height-1 && ((j>=0 && j<=secLeftCounter+n/2) || (j>=secRightCounter-n/2 && j<=width-1)))
                    {
                        Console.Write('*');
                    }

                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                if(i>=0 && i<=n/2)
                {
                    leftCounter--;
                    rightCounter++;
                }
                if(i>=n/2 && i<n)
                {
                    secLeftCounter++;
                    secRightCounter--;
                }else
                {
                    secLeftCounter--;
                    secRightCounter++;
                }
                if(i>=n)
                {
                    thirdLeftCounter--;
                    thirdRightCounter++;
                }
            }
        }
    }
}
