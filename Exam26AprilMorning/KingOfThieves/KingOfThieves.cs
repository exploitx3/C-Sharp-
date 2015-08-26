using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KingOfThieves
{
    class KingOfThieves
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char symbol = char.Parse(Console.ReadLine());
            int height = n;
            int width = n;
            int leftCounter = n / 2 - 1;
            int rightCounter = n / 2 + 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && j == n/2)
                    {
                        Console.Write(symbol);
                    }else if(i>0 && j > leftCounter && j < rightCounter)
                    {
                        Console.Write(symbol);
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                if(i>=n/2)
                {
                    leftCounter++;
                    rightCounter--;
                }
                else
                {
                    leftCounter--;
                    rightCounter++;
                }
                Console.WriteLine();
            }
        }
    }
}
