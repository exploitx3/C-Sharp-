using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Magic_Strings
{
    class MagicStrings
    {
        static int CalculateWeight(char character)
        {
            switch (character)
            {
                case 'k':
                    return 1;
                case 'n':
                    return 4;
                case 'p':
                    return 5;
                case 's':
                    return 3;
                default:
                    return 0;
            }
        }
        static void Main(string[] args)
        {
            int diff = int.Parse(Console.ReadLine());
            
            char[] lettersArray = new char[4];
            lettersArray[0] = 'k';
            lettersArray[1] = 'n';
            lettersArray[2] = 'p';
            lettersArray[3] = 's';
            bool foundMagicNumber = false;
            for (int i = 0; i < lettersArray.Length; i++)
            {
                for (int j = 0; j < lettersArray.Length; j++)
                {
                    for (int k = 0; k < lettersArray.Length; k++)
                    {
                        for (int l = 0; l < lettersArray.Length; l++)
                        {
                            for (int m = 0; m < lettersArray.Length; m++)
                            {
                                for (int n = 0; n < lettersArray.Length; n++)
                                {
                                    for (int o = 0; o < lettersArray.Length; o++)
                                    {
                                        for (int p = 0; p < lettersArray.Length; p++)
                                        {
                                            int sumLeft = CalculateWeight(lettersArray[i]) +
                                                          CalculateWeight(lettersArray[j]) +
                                                          CalculateWeight(lettersArray[k]) +
                                                          CalculateWeight(lettersArray[l]);
                                            int sumRight = CalculateWeight(lettersArray[m]) +
                                                           CalculateWeight(lettersArray[n]) +
                                                           CalculateWeight(lettersArray[o]) +
                                                           CalculateWeight(lettersArray[p]);
                                            if (Math.Abs(sumLeft - sumRight) == diff)
                                            {
                                                string magicNumbers = new string(new char[]{lettersArray[i] , lettersArray[j] ,
                                                                      lettersArray[k] , lettersArray[l] ,
                                                                      lettersArray[m] , lettersArray[n] ,
                                                                      lettersArray[o] , lettersArray[p]});
                                                Console.WriteLine(magicNumbers);
                                                foundMagicNumber = true;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (!foundMagicNumber)
            {
                Console.WriteLine("No");
            }
        }
    }
}
