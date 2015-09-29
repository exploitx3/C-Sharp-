using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace _05.Catch_The_Bits
{
    class Program
    {
        static void Main(string[] args)
        {
            uint numNumbers = uint.Parse(Console.ReadLine());
            uint step = uint.Parse(Console.ReadLine());
            uint[] numArray = new uint[numNumbers];
            for (uint i = 0; i < numNumbers; i++)
            {
                numArray[i] = uint.Parse(Console.ReadLine());
            }
            string strNumber = "";
            for (uint i = 0; i < numNumbers; i++)
            {
                strNumber += Convert.ToString(numArray[i], 2).PadLeft(8, '0');
            }
            
            
            uint size = numNumbers*8;
            string strResult = "";
            uint resultCounter = 0;
            uint secondCounter = 1;
            
            
            for (int i = 0; i < size; i++)
            {
                
                if (i%step == 1 || (step == 1 && i > 0))
                {
                    secondCounter++;
                    strResult += strNumber[i];
                }
               
            }
            string temp = "";
            for (int i = 1; i <= strResult.Length; i++)
            {
                
                temp += strResult[i-1];
                if (i%8 == 0 || i == (uint)strResult.Length)
                {
                    Console.WriteLine(Convert.ToUInt64(temp.PadRight(8,'0'),2));
                    temp = "";
                }
            }
            
        }
    }
}
