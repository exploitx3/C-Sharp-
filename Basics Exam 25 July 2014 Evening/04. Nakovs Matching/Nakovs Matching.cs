using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _04.Nakovs_Matching
{
    internal class Program
    {
        private static BigInteger CalculateWeight(string strInput)
        {
            BigInteger result = 0;
            for (int i = 0; i < strInput.Length; i++)
            {
                result += strInput[i];
            }
            return result;
        }

       
        private static void Main(string[] args)
        {
            string firstString = Console.ReadLine();
            string secondString = Console.ReadLine();
            BigInteger limitNumber = BigInteger.Parse(Console.ReadLine());
            bool hasFound = false;
            for (int i = 1; i < firstString.Length; i++)
            {
                string leftA = firstString.Substring(0, i);
                string rightA = firstString.Substring(i, firstString.Length - i);
                for (int j = 1; j < secondString.Length; j++)
                {
                    string leftB = secondString.Substring(0, j);
                    string rightB = secondString.Substring(j, secondString.Length - j);
                    BigInteger sum = BigInteger.Abs((CalculateWeight(leftA)*CalculateWeight(rightB)) -
                              (CalculateWeight(rightA)*CalculateWeight(leftB)));
                    
                    if (sum <= limitNumber)
                    {
                        Console.WriteLine("({0}|{1}) matches ({2}|{3}) by {4} nakovs"
                            , leftA, rightA, leftB, rightB, sum);
                        hasFound = true;
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

