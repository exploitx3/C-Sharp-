using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace WiggleWiggle
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            long[] longNumbers = new long[numbers.Length];
            for (long i = 0; i < (long)longNumbers.Length; i++)
            {
                longNumbers[i] = long.Parse(numbers[i]);
            }
            for (long i = 0; i < (long)numbers.Length; i++)
            {
                numbers[i] = Convert.ToString(longNumbers[i],2).PadLeft(63, '0');
            }
            string[] numbersReady = new string[numbers.Length];
            for (int num = 0; num < numbers.Length; num += 2)
            {
                char[] chArr = numbers[num].ToCharArray();
                char[] chArr1 = numbers[num + 1].ToCharArray();
                char[] chArr2 = numbers[num].ToCharArray();

                for (long i = 0; i < 63; i += 2)
                {
                    
                    chArr[i] = chArr1[i];
                    chArr1[i] = chArr2[i];
                    
                    
                }
                numbersReady[num] = new string(chArr);
                numbersReady[num + 1] = new string(chArr1);

            }
            for (int i = 0; i < numbersReady.Length; i++)
            {
                char[] tempArr = numbersReady[i].ToCharArray();
                for (int j = 0; j < 63; j++)
                {
                    if(tempArr[j] == '0')
                    {
                        tempArr[j] = '1';
                    }
                    else if(tempArr[j] == '1')
                    {
                        tempArr[j] = '0';
                    }
                }
                numbersReady[i] = new string(tempArr);
            }
            for (int i = 0; i < numbersReady.Length; i++)
            {
                Console.WriteLine("{0} {1}", Convert.ToInt64(numbersReady[i], 2), numbersReady[i]);
            }
          
        }
    }
}
