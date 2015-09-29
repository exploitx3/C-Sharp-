using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.New_House
{
    class NewHouse
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n + n/2+1;
            int width = n;
            int leftCounter = n / 2;
            int rightCounter = n / 2;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i <= n/2  && (j >= leftCounter && j <= rightCounter))
                    {
                        Console.Write('*');
                    }else if (i>n/2 && (j==0 || j==width-1))
                    {
                        Console.Write('|');
                    }else if (i > n/2 && (j > 0 && j < width - 1))
                    {
                        Console.Write('*');
                    }else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
                if (i < n/2 )
                {
                    leftCounter--;
                    rightCounter++;
                }
            }
        }
    }
}
