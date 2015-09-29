using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Bitwise_Operators
{
    class BitwiseOperators
    {
        static void Main(string[] args)
        {
            int numNumbers = int.Parse(Console.ReadLine());
            long[] transformedNumbers = new long[numNumbers];
            for (int i = 0; i < numNumbers; i++)
            {
                long tempNumber = long.Parse(Console.ReadLine());
                
                char[] tempChArr = Convert.ToString(tempNumber, 2).ToCharArray();
                Array.Reverse(tempChArr);
                tempNumber = (tempNumber ^ ~tempNumber) & Convert.ToInt64(new string(tempChArr), 2);
                transformedNumbers[i] = tempNumber;
            }
            for (int i = 0; i < transformedNumbers.Length; i++)
            {
                Console.WriteLine(transformedNumbers[i]);
            }
        }
    }
}
