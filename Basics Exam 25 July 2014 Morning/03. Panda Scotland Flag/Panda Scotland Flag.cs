using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Panda_Scotland_Flag
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = n;
            int width = n;
            int leftCounter = 0;
            int rightCounter = width - 1;
            char[] alphabetArray = new char[26];
            int counter = 0;
            for (int i = 0; i < alphabetArray.Length; i++)
            {
                alphabetArray[i] = (char)(i + 65);
            }
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (j == leftCounter || j == rightCounter)
                    {
                        Console.Write(alphabetArray[counter]);
                        counter++;
                        if (counter == 26)
                        {
                            counter = 0;
                        }
                    }else if (i < n/2 && (j > leftCounter && j < rightCounter))
                    {
                        Console.Write('#');
                    }else if (i > n/2 && (j > rightCounter && j < leftCounter))
                    {
                        Console.Write('#');
                    }else if (i == n/2 && j != n/2)
                    {
                        Console.Write('-');
                    }
                    else
                    {
                        Console.Write('~');
                    }
                }
                Console.WriteLine();
                leftCounter++;
                rightCounter--;
            }
        }
    }
}
