using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;


namespace _5.Valid_Usernames
{
    class ValidUsernames
    {
        static void Main()
        {
            string inputUserNames = Console.ReadLine();
            List<string> lstUserNames = new List<string>();

            foreach (Match match in Regex.Matches(inputUserNames, @"\w+"))
            {
                lstUserNames.Add(match.Value);
            }
            string[] strResult = lstUserNames.ToArray();
            lstUserNames = new List<string>();
            for (int i = 0; i < strResult.Length; i++)
            {
                if (Regex.IsMatch(strResult[i], @"^\D"))
                {
                    if (Regex.IsMatch(strResult[i], @"^[\w]{3,25}$"))
                    {
                        lstUserNames.Add(strResult[i]);  
                    }
                    
                }
            }
            
            int posFirstPair = 0;
            int posSecondPair = 0;
            int biggestSum = Int32.MinValue;
            for (int i = 0; i < lstUserNames.Count-1; i++)
            {
                int sum = lstUserNames[i].Length + lstUserNames[i + 1].Length;
                if (biggestSum < sum)
                {
                    biggestSum = sum;
                    posFirstPair = i;
                    posSecondPair = i + 1;
                }
            }
            Console.WriteLine(lstUserNames[posFirstPair]);
            Console.WriteLine(lstUserNames[posSecondPair]);

        }
    }
}
