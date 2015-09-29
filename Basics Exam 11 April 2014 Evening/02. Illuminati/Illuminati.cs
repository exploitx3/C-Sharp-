using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Illuminati
{
    class Illuminati
    {
        static void Main(string[] args)
        {
            string inputText = Console.ReadLine();
            int countVowels = 0;
            int sum = 0;
            for (int i = 0; i < inputText.Length; i++)
            {
                if (char.ToLower(inputText[i]) == 'a' || char.ToLower(inputText[i]) == 'e' ||
                    char.ToLower(inputText[i]) == 'i' || char.ToLower(inputText[i]) == 'o' ||
                    char.ToLower(inputText[i]) == 'u')
                {
                    switch (char.ToLower(inputText[i]))
                    {
                        case 'a':
                            sum += 65;
                            break;
                        case 'e':
                            sum += 69;
                            break;
                        case 'i':
                            sum += 73;
                            break;
                        case 'o':
                            sum += 79;
                            break;
                        case 'u':
                            sum += 85;
                            break;
                        default:
                            break;
                    }
                    countVowels++;
                }
            }
            Console.WriteLine(countVowels);
            Console.WriteLine(sum);
        }
    }
}
