using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Morse_Code_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberInput = int.Parse(Console.ReadLine());
            int numberSum = ((numberInput/1000)%10) + ((numberInput/100)%10) + ((numberInput/10)%10) +((numberInput)%10);
            string[] morseCodes = new string[6]
            {
               "-----",
               ".----",
               "..---",
               "...--",
               "....-",
               "....."
            };
            bool hasFound = false;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    for (int k = 0; k < 6; k++)
                    {
                        for (int l = 0; l < 6; l++)
                        {
                            for (int m = 0; m < 6; m++)
                            {
                                for (int n = 0; n < 6; n++)
                                {
                                    int sumNumbers = i * j * k * l * m * n;
                                    if (sumNumbers == numberSum)
                                    {
                                        Console.WriteLine(morseCodes[i] + "|" + 
                                                          morseCodes[j] + "|" + 
                                                          morseCodes[k] + "|" + 
                                                          morseCodes[l] + "|" + 
                                                          morseCodes[m] + "|" + 
                                                          morseCodes[n] + "|");
                                        hasFound = true;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!hasFound)
            {
                Console.WriteLine("No");
            }
        }
    }
}
