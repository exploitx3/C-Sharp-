using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dumbbell
{
    class Dumbbell
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;
            int width = n * 3;
            int leftCounter = n / 2;
            int rightCounter = (width - n / 2) - 1;
            int leftRightColon = n-1;
            int rightLeftColon = (width - n);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(i==0 && ((j>=leftCounter && j<=leftRightColon ) ||(j>=rightLeftColon && j<=rightCounter)))
                    {
                        Console.Write('&');
                    }
                    else if(i>0 && (j == leftCounter || j == rightCounter || j == leftRightColon || j == rightLeftColon))
                    {
                        Console.Write('&');
                    }else if(i>0 && i<height-1 && ((j>leftCounter && j<leftRightColon) || (j>rightLeftColon && j<rightCounter)))
                    {
                        Console.Write('*');
                    }else if(i == n/2 && (j>leftRightColon && j<rightLeftColon))
                    {
                        Console.Write('=');
                    }else if(i==height-1 && ((j>leftCounter && j<leftRightColon) || (j>rightLeftColon && j<rightCounter)))
                    {
                        Console.Write('&');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }

                Console.WriteLine();

                if(i>=0 && i<n/2)
                {
                    leftCounter--;
                    rightCounter++;
                }
                if(i>= n/2)
                {
                    leftCounter++;
                    rightCounter--;
                }
            }
        }
    }
}
