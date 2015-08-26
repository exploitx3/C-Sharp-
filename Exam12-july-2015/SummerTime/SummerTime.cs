using System;

namespace SummerTime
{
    class SummerTime
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int widthBottom = n * 2;
            int widthTop = n + 1;
            int height = (3 * n) + 1;
            int diagnLeft = n / 2 ;
            int diagnRight = widthBottom - n / 2 - 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < widthBottom; j++)
                {
                    if(i==0 &&j>=n/2 && j < widthBottom - n/2)
                    {
                        Console.Write('*');
                    }
                    else if(i>0 && i<n/2+1 && (j==n/2 || j == widthBottom - n/2 -1))
                    {
                        Console.Write('*');
                    }
                    else if(i>=n/2+1 && i<=n && (j==diagnLeft || j==diagnRight))
                    {
                        Console.Write('*');
                    }else if(i>n && (j==0 || j == widthBottom-1))
                    {
                        Console.Write('*');
                    }else if(i>=n && i<n*2 && j>0 && j<widthBottom-1)
                    {
                        Console.Write('.');
                    }
                    else if(i>=n*2 && i < height-1 && j>0 && j <widthBottom-1)
                    {
                        Console.Write('@');
                    }
                    else if(i==height-1)
                    {
                        Console.Write('*');
                    }else
                    {
                        Console.Write(' ');
                    }
                }
                if(i>=n/2+1 && i <= n)
                {
                    diagnLeft--;
                    diagnRight++;
                }
                Console.WriteLine();
            }
        }
    }
}
