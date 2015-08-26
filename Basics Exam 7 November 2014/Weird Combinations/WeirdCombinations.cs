using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Weird_Combinations
{
    class WeirdCombinations
    {
        static void Main(string[] args)
        {
            char[] chArr = Console.ReadLine().ToCharArray();
            int number = int.Parse(Console.ReadLine());
            int counter = 0;
            string currentCombination = "";
            string nString = "";
            for (int i = 0; i < chArr.Length; i++)
            {
                for (int j = 0; j < chArr.Length; j++)
                {
                    for (int k = 0; k < chArr.Length; k++)
                    {
                        for (int l = 0; l < chArr.Length; l++)
                        {
                            for (int m = 0; m < chArr.Length; m++)
                            {
                                currentCombination = chArr[i] + "" + chArr[j] + "" + chArr[k]+ "" + chArr[l]+ "" + chArr[m];
                                if (counter == number)
                                {
                                    nString = currentCombination;
                                }
                                counter++;
                              
                            }
                        }
                    }
                }
            }

            if(nString!="")
            {
                Console.WriteLine(nString);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
