using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.BitsUp
{
    class BitsUp
    {
        static void Main(string[] args)
        {
           
    
            long numNumbers = long.Parse(Console.ReadLine());
            long step = long.Parse(Console.ReadLine());
            long[] numArray = new long[numNumbers];
            //StringBuilder result = new StringBuilder();
            //for (int i = 0; i < numNumbers; i++)
            //{
            //    numArray[i] = long.Parse(Console.ReadLine());
            //    result.Append(Convert.ToString(numArray[i],2).PadLeft(8, '0'));
            //}
            //for (int i = 0; i < numNumbers*8; i++)
            //{
            //    if (i%step == 1 || (step == 1 && i > 0))
            //    {
            //        result[i] = '1';
            //    }
            //}
            //string resultFinal = "";
            //for (int i = 0,j = 0; i < numNumbers*8; i++,j++)
            //{
            //    j %= 8;
                
            //    resultFinal += result[i];
            //    if (j == 7)
            //    {
            //        Console.WriteLine(Convert.ToUInt32(resultFinal.PadLeft(8,'0'),2));
            //        resultFinal = "";
            //    }
            //}
            for (long i = 0; i < numNumbers; i++)
            {
                numArray[i] = long.Parse(Console.ReadLine());
            }
            int counter = 0;
            for (int i = 0,j=0; i < numNumbers*8; i++,j++)
            {
                if (j == 8)
                {
                    counter++;
                }
                j %= 8;
                if (i%step == 1 || (step==1 && i > 0))
                {
                    numArray[counter] |= (128U >> j);
                }

            }
            for (int i = 0; i < numArray.Length; i++)
            {
                Console.WriteLine(numArray[i]);
            }
        }
    }
}
