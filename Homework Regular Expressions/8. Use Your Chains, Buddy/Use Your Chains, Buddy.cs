using System;
using System.Text.RegularExpressions;


namespace _8.Use_Your_Chains__Buddy
{
    class UseYourChainsBuddy
    {
        static void Main()
        {
            string inputStr = Console.ReadLine();
            string pattern = @"<p>(.+?)<\/p>";
            MatchCollection matches = Regex.Matches(inputStr, pattern);
            string strResult = "";
            foreach (Match pair in matches)
            {
                strResult += pair.Groups[1].Value;
            }
            strResult = Regex.Replace(strResult, @"[^a-z\d]+"," ");
            char[] chArr = strResult.ToCharArray();
            for (int i = 0; i < chArr.Length; i++)
            {
                if (chArr[i] >= 'a' && chArr[i] <= 'm')
                {
                    chArr[i] = (char)(chArr[i] + 13);
                }
                else if (chArr[i] >= 'n' && chArr[i] <= 'z')
                {
                    chArr[i] = (char)(chArr[i] - 13);
                }
            }
            Console.WriteLine(new string(chArr).Trim());
        }
    }
}
