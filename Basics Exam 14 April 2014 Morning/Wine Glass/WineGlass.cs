using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wine_Glass
{
    class WineGlass
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;
            int width = n;
            int leftCounter = 0;
            int rightCounter = width - 1;
            int countColons = (n/2) - 1;
            if (n >= 12)
            {
                countColons = (n/2) - 2;
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    
                     if (i >= 0 && i<= n/2 -2 && (j > leftCounter && j < rightCounter))
                    {
                        Console.Write('*');
                    }else if (i >= 0 && i<n/2 && j == leftCounter)
                    {
                        Console.Write('\\');
                    }else if (i >= 0 && i<n/2 && j == rightCounter)
                    {
                        Console.Write('/');
                    }else if (i >= n/2 && i < n/2 + countColons && (j == n/2 - 1 || j == n/2))
                    {
                        Console.Write('|');
                    }else if (i >= n/2 + countColons)
                    {
                        Console.Write('-');
                    }else 
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
                if (i >= 0 && i < n/2)
                {
                    leftCounter++;
                    rightCounter--;
                }
            }
        }
    }
}
