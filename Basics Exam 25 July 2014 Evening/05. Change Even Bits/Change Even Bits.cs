using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Change_Even_Bits
{
    class Program
    {
        static int GetLengthBits(int number)
        {
            int counter = 0;
            while (number > 0)
            {
                counter++;
                number /= 2;
            }
            return counter;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] numArray = new int[n];
            for (int i = 0; i < numArray.Length; i++)
            {
                numArray[i] = int.Parse(Console.ReadLine());
            }
            int InputNumber = int.Parse(Console.ReadLine());
            int changedCounter = 0;
            for (int i = 0; i < numArray.Length; i++)
            {
                int length = GetLengthBits(numArray[i])*2;
                for (int j = 0; j < length; j+=2)
                {
                    int currentBit = (InputNumber >> j) & 1;
                    if (currentBit == 0)
                    {
                        InputNumber |= 1 << j;
                        changedCounter++;
                    }
                }
            }
            Console.WriteLine(InputNumber);
            Console.WriteLine(changedCounter);
        }
    }
}
