using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.Nested_Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretNumberInput = Console.ReadLine();
            
            int bullsTarget = int.Parse(Console.ReadLine());
            int cowsTarget = int.Parse(Console.ReadLine());
            bool isSolutionFound = false;
            for (int i = 1; i <= 9999; i++)
            {
                string strI = i.ToString();
                
                    if (strI.Length == 4 && strI[0] > '0' && strI[1] > '0' && strI[2] > '0' && strI[3] > '0')
                    {
                        char[] digits = strI.ToCharArray();
                        char[] guessNum = secretNumberInput.ToCharArray();
                        int cows = 0;
                        int bulls = 0;
                        for (int k = 0; k < guessNum.Length; k++)
                        {
                            if (guessNum[k] == digits[k])
                            {
                                bulls++;
                                guessNum[k] = '*';
                                digits[k] = '@';
                            }
                        }
                        for (int k = 0; k < guessNum.Length; k++)
                        {
                            for (int l = 0; l < digits.Length; l++)
                            {
                                if (guessNum[k] == digits[l])
                                {
                                    cows++;
                                    guessNum[k] = '*';
                                    digits[l] = '@';
                                    
                                }
                            }
                        }
                        if (cows == cowsTarget && bulls == bullsTarget)
                        {
                            Console.Write(strI + " ");
                            isSolutionFound = true;
                        }
                    }
                
            }
            if (!isSolutionFound)
            {
                Console.WriteLine("No");
            }
            
            
        }
    }
}
