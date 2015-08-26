using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessBoardGame
{
    class ChessBoardGame
    {
        static void Main(string[] args)
        {
            int sizeN = int.Parse(Console.ReadLine());
            string inputString = Console.ReadLine();
            int chessBoardSize = sizeN * sizeN;
            int sumBlackEven = 0;
            int sumWhiteOdd = 0;
            
            if(inputString.Length > chessBoardSize)
            {
                
                inputString = inputString.Substring(0,chessBoardSize);
                
            }
            
            
            for (int i = 0; i < inputString.Length; i+=2)
            {
                if (inputString[i] < (char)91 && inputString[i] > (char)64)
                {
                    sumWhiteOdd += (int)inputString[i];
                    
                }
                else
                {
                    if ((inputString[i] >= 97 && inputString[i] <= 122))
                    {
                        sumBlackEven += (int)inputString[i];
                        
                    }
                    if((inputString[i] >= 48 && inputString[i] <= 57))
                    {
                        sumBlackEven += (int)inputString[i];
                    }
                }
               

            }
            for (int i = 1; i < inputString.Length; i+=2)
            {
                if (inputString[i] < (char)91 && inputString[i] > (char)64)
                {
                    sumBlackEven += (int)inputString[i];
                    
                }
                else
                {
                    if ((inputString[i] >= 97 && inputString[i] <= 122))
                    {
                        sumWhiteOdd += (int)inputString[i];
                        
                    }
                    if((inputString[i] >= 48 && inputString[i] <= 57))
                    {
                        sumWhiteOdd += (int)inputString[i];
                    }
                }
                

            }
            if(sumWhiteOdd>sumBlackEven)
            {
                Console.WriteLine("The winner is: white team\n{0}",Math.Abs(sumWhiteOdd-sumBlackEven));
            }else if(sumBlackEven > sumWhiteOdd)
            {
                Console.WriteLine("The winner is: black team\n{0}", Math.Abs(sumBlackEven - sumWhiteOdd));
            }else
            {
                Console.WriteLine("Equal result: {0}",sumWhiteOdd);
            }

        }
    }
}
