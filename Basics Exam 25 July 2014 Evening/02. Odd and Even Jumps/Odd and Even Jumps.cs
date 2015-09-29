using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Odd_and_Even_Jumps
{
    class Program                                                               
    {                                                                           
        static void Main(string[] args)                                         
        {                                                                       
            StringBuilder inputStringT = new StringBuilder(Console.ReadLine());
            string inputString = "";
            for (int i = 0; i < inputStringT.Length; i++)
            {
                if (inputStringT[i] != ' ')
                {
                    inputString += inputStringT[i];
                }
            }
            int oddJump = int.Parse(Console.ReadLine());                        
            int evenJump = int.Parse(Console.ReadLine());                       
            int counterEven = 1;                                                
            int counterOdd = 1;                                                 
            ulong oddResult = 0UL;
            ulong evenResult = 0UL;
            for (int i = 0; i < inputString.Length; i++)
            {
                if (i%2 == 1)
                {
                    if (counterEven%evenJump == 0)
                    {
                        evenResult *= char.ToLower(inputString[i]);
                    }
                    else
                    {
                        evenResult += char.ToLower(inputString[i]);
                    }
                    counterEven++;
                }
                else
                {
                    if (counterEven % oddJump == 0)
                    {
                        oddResult *= char.ToLower(inputString[i]);
                    }
                    else
                    {
                        oddResult += char.ToLower(inputString[i]);
                    }
                    counterOdd++;
                }
            }
            Console.WriteLine("Odd: {0:X}",oddResult);
            Console.WriteLine("Even: {0:X}",evenResult);
        }
    }
}
