using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextBombardment
{
    class TextBombardment
    {
        static void Main(string[] args)
        {
            
            string inputStr = Console.ReadLine();
            StringBuilder inputString = new StringBuilder();
            inputString.Append(inputStr);
            inputString.Append('@', 1000);            
            int length = int.Parse(Console.ReadLine());
            string[] bombNums = Console.ReadLine().Split(' ');
            int[] bombNumsArr = Array.ConvertAll(bombNums,int.Parse);                    
            int bombCounter = 0;
            int rows = (int)Math.Ceiling((double)inputStr.Length / length);
                        
                for (bombCounter = 0; bombCounter < bombNumsArr.Length; bombCounter++)
                {
                    
                        for (int k = 0; k < rows; k++)
                        {
                            if (inputString[bombNumsArr[bombCounter] + (length * k)] == ' ')
                            {
                                k++;
                            }
                            if (inputString[bombNumsArr[bombCounter] + (length * k)] != ' ')
                            {
                                inputString[bombNumsArr[bombCounter] + (length * k)] = ' ';
                                if (inputString[bombNumsArr[bombCounter] + (length * (k + 1))] == ' ')
                                {                                    
                                    break;
                                }
                            }
                        }                                   
                }        
            Console.Write(Convert.ToString(inputString).Substring(0,inputStr.Length));
            Console.WriteLine();         
        }
    }
}
