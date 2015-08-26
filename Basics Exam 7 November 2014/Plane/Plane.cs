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
            int height = ((n * 3) - (n / 2));
            int width = n * 3;
            int leftCounter = (n+n/2);
            int rightCounter = (n + n / 2);
            int secLeftCounter = n-1;
            int secRightCounter = width-n;
            int thirdLeftCounter = n - 1;
            int thirdRightCounter = width -n;


            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && j == n + n / 2)
                    {
                        Console.Write('*');
                    }
                    else if (i > 0 && i <= n + n / 2 && (j == leftCounter || j == rightCounter))
                    {
                        Console.Write('*');
                    }
                    else if (i > n && i <= n + n / 2 && (j == secLeftCounter || j == secRightCounter))
                    {
                        Console.Write('*');
                    }else if(i>n && i<=n+n/2 && (j == n-1 || j == width-n))
                    {
                        Console.Write('*');
                    }else if(i>n+n/2 && (j==thirdLeftCounter || j==thirdRightCounter))
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
                if (i >= 0 && i < n/2+2)
                {
                    leftCounter -= 1;
                    rightCounter += 1;
                    
                }
                if(i>= n/2+2 && i < n+n/2)
                {
                    leftCounter -= 2;
                    rightCounter += 2;
                    leftCounter = Math.Max(0, leftCounter);
                    rightCounter = Math.Min(width - 1, rightCounter);
                }
                if (i > n && i < n + n / 2)
                {
                    secLeftCounter -= 2;
                    secRightCounter += 2;
                }
                if (i >n+n/2)
                {
                    thirdLeftCounter--;
                    thirdRightCounter++;
                }
            }
        }
    }
}
