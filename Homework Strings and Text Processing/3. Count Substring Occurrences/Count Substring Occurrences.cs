using System;

namespace _3.Count_Substring_Occurrences
{
    class CountSubstringOccurrences
    {
        static void Main()
        {
            string strText = Console.ReadLine().ToLower();
            string searchInput = Console.ReadLine().ToLower();
            int equalCount = 0;
            for (int i = 0; i < strText.Length-searchInput.Length+1; i++)
            {
                bool foundEqual = false;
                int count = i;
                for (int j = 0; j < searchInput.Length; j++)
                {
                    if (strText[count] == searchInput[j])
                    {
                        count++;
                        foundEqual = true;
                    }
                    else
                    {
                        foundEqual = false;
                        break;
                    }
                }
                if (foundEqual)
                {
                    equalCount++;
                }
            }
            Console.WriteLine(equalCount);
        }
    }
}
