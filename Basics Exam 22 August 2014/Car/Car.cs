using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    class Car
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int width = 3 * n;
            int height = (3*(n/2))-1;
            int leftCounter = n;
            int rightCounter = width - n - 1;
            
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(i==0 && (j>=leftCounter && j<=rightCounter))
                    {
                        Console.Write('*');
                    }else if(i>0 && i < n/2 &&(j==leftCounter || j==rightCounter))
                    {
                        Console.Write('*');
                    }else if(i==n/2 && ((j>=0 && j<=leftCounter) ||(j>=rightCounter && j<=width-1)))
                    {
                        Console.Write('*');
                    }else if(i>n/2 && i<n-1 && (j==0 || j==width-1))
                    {
                        Console.Write('*');
                    }else if(i==n-1)
                    {
                        Console.Write('*');
                    }else if(i>n-1 && (j==n/2 || j == width-n/2-1 || j==n || j== width - n -1))
                    {
                        Console.Write('*');
                    }else if(i==height-1 && ((j>n/2 && j<n) || (j>width-n-1 && j < width-n/2-1)))
                    {
                        Console.Write('*');
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
            }
        }
    }
}
