using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadPhones
{
    class HeadPhones
    {
        
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n * 2;
            int width = n * 2 + 1;
            int leftCounter = n / 2 - 1;
            int rightCounter = n / 2 + 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(i==0 && j >= n/2 && j <=width-n/2-1)
                    {
                        Console.Write('*');
                    }
                    else if(i>0 && i <=n && (j== n/2 || j == width-n/2-1))
                    {
                        Console.Write('*');
                    }
                    else if (i > n && (j >= leftCounter && j <= rightCounter || j >= leftCounter+n+1 && j<=rightCounter+n+1))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
                if(i>n && i<height-1-n/2)
                {
                    leftCounter--;
                    rightCounter++;
                }
                else if(i>=height-1-n/2)
                {
                    leftCounter++;
                    rightCounter--;
                }
            }
        }
    }
}
