using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace _04.Hayvan_Numbers
{
    class HayvanNuebers
    {
        static bool IsNumberValid(int num)
        {
            string tempString = num.ToString();
            for (int i = 0; i < tempString.Length; i++)
            {
                if (tempString[i] < '5' || tempString[i] > '9')
                {
                    return false;
                }
            }
            return true;
        }

        static int CalculateSum(int num)
        {
            int result = 0;
            int number = num;
            while (number > 0)
            {
                result += number%10;
                number /= 10;
            }
            return result;
        }
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            int diff = int.Parse(Console.ReadLine());
            bool hasFound = false;
            for (int abc = 555; abc <= 999; abc++)
            {
                int def = abc + diff;
                int ghi = def + diff;
                if (IsNumberValid(abc) && IsNumberValid(def) && IsNumberValid(ghi) && ghi <= 999 &&
                    (CalculateSum(abc) + CalculateSum(def) + CalculateSum(ghi)) == sum)
                {
                    Console.WriteLine(abc + "" + def + "" + ghi);
                    hasFound = true;
                }
            }
            if (!hasFound)
            {
                Console.WriteLine("No");
            }
















            //uint sumInput = uint.Parse(Console.ReadLine());
            //uint diff = uint.Parse(Console.ReadLine());
            //int[] arrayNumbers = new int[125];
            //int counter = 0;
            //List<string> tempStringList = new List<string>();
            //for (int i = 5; i < 10; i++)
            //{
            //    for (int j = 5; j < 10; j++)
            //    {
            //        for (int k = 5; k < 10; k++)
            //        {
            //            arrayNumbers[counter] = i * 100 + j * 10 + k;
            //            counter++;
            //        }
            //    }
            //}
            //bool notFound = true;

            //for (int abc = 0; abc < 125; abc++)
            //{
            //    for (int def = 0; def < 125; def++)
            //    {
            //        for (int ghi = 0; ghi < 125; ghi++)
            //        {
            //            int a = (arrayNumbers[abc] / 100) % 10;
            //            int b = (arrayNumbers[abc] / 10) % 10;
            //            int c = (arrayNumbers[abc]) % 10;
            //            int d = (arrayNumbers[def] / 100) % 10;
            //            int e = (arrayNumbers[def] / 10) % 10;
            //            int f = (arrayNumbers[def]) % 10;
            //            int g = (arrayNumbers[ghi] / 100) % 10;
            //            int h = (arrayNumbers[ghi] / 10) % 10;
            //            int i = (arrayNumbers[ghi]) % 10;
            //            long sum = a + b + c + d + e + f + g + h + i;
            //            if ((abc < def && def < ghi))
            //            {
            //                if ((arrayNumbers[ghi] - arrayNumbers[def] == diff && arrayNumbers[def] - arrayNumbers[abc] == diff) && sum == sumInput)
            //                {
            //                    tempStringList.Add(arrayNumbers[abc] + "" + arrayNumbers[def] + "" + arrayNumbers[ghi]);
            //                    notFound = false;
            //                }
            //            }

            //        }
            //    }
            //}
            //if (notFound)
            //{
            //    Console.WriteLine("No");
            //}
            //else
            //{
            //    tempStringList.Sort();
            //    for (int i = 0; i < tempStringList.Count; i++)
            //    {
            //        Console.WriteLine(tempStringList[i]);
            //    }
            //}
        }
    }
}

