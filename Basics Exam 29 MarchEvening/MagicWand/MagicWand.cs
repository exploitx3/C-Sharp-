using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicWand
{
    class MagicWand
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n + 2;
            int height = 3 * n - (n / 2 - 3);
            int leftCounter = n + n / 2;
            int rightCounter = width - (n + n / 2 + 1);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(i==0 && j==width/2)
                    {
                        Console.Write('*');
                    }else if(i>0 && i< (n/2+2) && (j==leftCounter || j == rightCounter))
                    {
                        Console.Write('*');
                    }else if(i==(n/2+2) && (j<n || j >= width-n))
                    {
                        Console.Write('*');
                    }else if(i>(n/2+2) && i<=n+1 && (j==leftCounter || j ==rightCounter))
                    {
                        Console.Write('*');
                    }else if(i>n+1 && i<height-(n + 2 ) && (j==leftCounter || j == rightCounter || j==leftCounter + (n/2+1) || j == rightCounter - (n/2+1)) )
                    {
                        Console.Write('*');
                    }else if(i==height-(n+2) && (j<=leftCounter+(n/2+1) || j >= rightCounter - (n/2+1)))
                    {
                        Console.Write('*');
                    }else if(i>=n+2 && (j==n || j==width-n-1))
                    {
                        Console.Write('*');
                    }else if(i==height-1 &&(j>=n && j<=width-n-1))
                    {
                        Console.Write('*');
                    }

                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
                if(i>0 && i<=n/2+1)
                {
                    leftCounter--;
                    rightCounter++;
                }
                if(i==n/2+2)
                {
                    leftCounter = 0;
                    rightCounter = width - 1;
                }
                if(i>n/2+1 && i <n+1)
                {
                    leftCounter++;
                    rightCounter--;
                }
                if(i>=n+1 && i <=height-(n +  2))
                {
                    leftCounter--;
                    rightCounter++;
                }
            }
        }
    }
}
