using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockLq
{
    class RockLq
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n * 2;
            int width = n * 3;
            int leftCounter = n;
            int rightCounter = width - n - 1;
            int secLeftCounter = n - 1;
            int secRightCounter = n * 2;
            int thirdLeftCounter = n - 1;
            int thirdRightCounter = n * 2;


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && (j >= leftCounter && j <= rightCounter))
                    {
                        Console.Write('*');
                    }
                    else if(i>0 && i<n && (j==leftCounter || j==rightCounter))
                    {
                        Console.Write('*');
                    }else if(i>n/2 && i<n && (j==secLeftCounter || j == secRightCounter))
                    {
                        Console.Write('*');
                    }else if(i>n/2 && i <= n && (j==n-1 || j==n*2))
                    {
                        Console.Write('*');
                    }else if(i>n && (j==thirdLeftCounter || j == thirdRightCounter))
                    {
                        Console.Write('*');
                    }else if(i==height-1)
                    {
                        Console.Write('*');
                    }

                    else

                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                if(i>=0 && i <= n/2)
                {
                    leftCounter-=2;
                    rightCounter+=2;
                    leftCounter = Math.Max(0, leftCounter);
                    rightCounter = Math.Min(width-1, rightCounter);
                }
                if(i>n/2 && i<n)
                {
                    secLeftCounter-=2;
                    secRightCounter+=2;
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
