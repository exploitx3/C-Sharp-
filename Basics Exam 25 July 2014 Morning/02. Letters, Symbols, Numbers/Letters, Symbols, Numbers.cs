using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Letters__Symbols__Numbers
{
    class Program
    {
        static long CalculateLetters(string inputStr)
        {
            long result = 0;
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (char.ToLower(inputStr[i]) >= 'a' && char.ToLower(inputStr[i]) <= 'z')
                {
                    result += ((long) char.ToLower(inputStr[i]) - 96)*10;
                }
            }
            return result;
        }
        static long CalculateNumbers(string inputStr)
        {
            long result = 0;
            for (int i = 0; i < inputStr.Length; i++)
            {
                if ((inputStr[i]) >= '0' && (inputStr[i]) <= '9')
                {
                    result += ((long)char.ToLower(inputStr[i]) - 48) * 20;
                }
            }
            return result;
        }
       
        static long CalculateSymbols(string inputStr)
        {
            long result = 0;
            for (int i = 0; i < inputStr.Length; i++)
            {
                if (!(char.ToLower(inputStr[i]) >= 'a' && char.ToLower(inputStr[i]) <= 'z') && !((inputStr[i]) >= '0' && (inputStr[i]) <= '9') && inputStr[i] != ' ' && inputStr[i] != '\t' && inputStr[i]!= '\n' && inputStr[i] != '\r')
                {
                    result += 200;
                }
            }
            return result;
        }
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string strInput = "";
            for (int i = 0; i < n; i++)
            {
                string tempString = Console.ReadLine();
                strInput += tempString;
            }
            
            Console.WriteLine(CalculateLetters(strInput));
            Console.WriteLine(CalculateNumbers(strInput));
            Console.WriteLine(CalculateSymbols(strInput));
        }
    }
}
