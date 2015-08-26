using System;
using System.Collections.Generic;
using System.IO;
class Solution
{
    static void Main(String[] args)
    {
        int n = int.Parse(Console.ReadLine());
        bool[] funnyArr = new bool[n];

        int counterFunny = 0;
        for (int strCount = 0; strCount < n; strCount++)
        {
            string str1 = Console.ReadLine();
            List<char> strRev = new List<char>();
            for (int i = 0; i < str1.Length; i++)
			    {
			      strRev.Add(str1[i]);
			    }
            strRev.Reverse();
            bool bVar = true;
            for (int i = 0; i < str1.Length-1; i++)
			    {
			        if(Math.Abs(str1[i] - str1[i+1]) != Math.Abs(strRev[i] - strRev[i+1]))
                {
                    bVar = false;
                    break;
                 
                 }
                   
                  
			}
            funnyArr[counterFunny] = bVar;
            counterFunny++;
        }
        for (int i = 0; i < counterFunny; i++)
		{
            if(funnyArr[i])
            {
			    Console.WriteLine("Funny");
            }
            else
            {
                Console.WriteLine("Not Funny");;
            }
        }
    }
}