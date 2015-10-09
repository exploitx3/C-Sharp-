using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace X_Removal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputList = new List<string>();
            List<string> resultList = new List<string>();
            string input;
            while ((input = Console.ReadLine()) != "END")
            {
                inputList.Add(input);
                resultList.Add(input);
            }
            for (int i = 1; i < inputList.Count-1; i++)
            {
                string first = inputList[i-1];
                string second = inputList[i];
                string third = inputList[i + 1];
                for (int j = 1; j < Math.Min(first.Length,Math.Min(second.Length,third.Length)) && (j < first.Length-1 && j<third.Length-1); j++)
                {
                    char charX = char.ToLower(inputList[i][j]);
                    bool firstX = char.ToLower(inputList[i-1][j-1]) == charX && char.ToLower(inputList[i-1][j + 1]) == charX;
                    bool secondX = char.ToLower(inputList[i][j]) == charX;
                    bool thirdX = char.ToLower(inputList[i + 1][j-1]) == charX && char.ToLower(inputList[i + 1][j + 1]) == charX;
                    if (firstX && secondX && thirdX)
                    {
                        resultList[i-1] = resultList[i-1].Remove(j-1, 1).Insert(j-1, "X");
                        resultList[i-1] = resultList[i-1].Remove(j+1, 1).Insert(j+1, "X");
                        resultList[i] = resultList[i].Remove(j, 1).Insert(j, "X");
                        resultList[i + 1] = resultList[i + 1].Remove(j-1, 1).Insert(j-1, "X");
                        resultList[i + 1] = resultList[i + 1].Remove(j + 1, 1).Insert(j+1, "X");
                    }
                }
            }
            for (int i = 0; i < resultList.Count; i++)
            {
                resultList[i] = resultList[i].Replace("X","");
                Console.WriteLine(resultList[i]);
            }
        }
          
    }
}
