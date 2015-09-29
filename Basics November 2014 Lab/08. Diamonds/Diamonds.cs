using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Diamonds
{
    class Diamonds
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int leftCounter = n/2;
            int rightCounter = n/2;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j == leftCounter || j == rightCounter)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('-');
                    }
                }
                Console.WriteLine();
                if (i < n/2)
                {
                    leftCounter--;
                    rightCounter++;
                }
                else
                {
                    leftCounter++;
                    rightCounter--;
                }
            }
        }
    }
}
