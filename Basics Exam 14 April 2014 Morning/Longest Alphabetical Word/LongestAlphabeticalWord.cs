using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longest_Alphabetical_Word
{
    class LongestAlphabeticalWord
    {
        static void Main(string[] args)
        {
            string strInput = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            char[,] chArr = new char[n, n];
            int counter = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    chArr[i,j] = strInput[counter];
                    counter++;
                    counter %= strInput.Length;
                }
            }
            string maxCurrentSequence = "";
            
            int counterr = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    int counterCol = j;
                    int counterRow = i;
                    string currentSequence = chArr[i,j].ToString();
                    for (int k = i; k >= 1; k--)
                    {
                        if (chArr[k, j] < chArr[k - 1, j])
                        {
                            currentSequence += chArr[k - 1, j];
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currentSequence.Length >= maxCurrentSequence.Length)
                    {
                        if (currentSequence.Length == maxCurrentSequence.Length)
                        {
                            if (currentSequence.CompareTo(maxCurrentSequence) == -1)
                            {
                                maxCurrentSequence = currentSequence;
                            }
                        }
                        else
                        {
                            maxCurrentSequence = currentSequence;
                        }
                    }
                    currentSequence = chArr[i, j].ToString();
                    for (int k = i; k < n-1; k++)
                    {
                        if (chArr[k, j] < chArr[k + 1, j])
                        {
                            currentSequence += chArr[k + 1, j];
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currentSequence.Length >= maxCurrentSequence.Length)
                    {
                        if (currentSequence.Length == maxCurrentSequence.Length)
                        {
                            if (currentSequence.CompareTo(maxCurrentSequence) == -1)
                            {
                                maxCurrentSequence = currentSequence;
                            }
                        }
                        else
                        {
                            maxCurrentSequence = currentSequence;
                        }
                    }
                    currentSequence = chArr[i, j].ToString();
                    for (int k = j; k < n - 1; k++)
                    {
                        if (chArr[i, k] < chArr[i, k+1])
                        {
                            currentSequence += chArr[i, k+1];
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currentSequence.Length >= maxCurrentSequence.Length)
                    {
                        if (currentSequence.Length == maxCurrentSequence.Length)
                        {
                            if (currentSequence.CompareTo(maxCurrentSequence) == -1)
                            {
                                maxCurrentSequence = currentSequence;
                            }
                        }
                        else
                        {
                            maxCurrentSequence = currentSequence;
                        }
                    }
                    currentSequence = chArr[i, j].ToString();
                    for (int k = j; k >=  1; k--)
                    {
                        if (chArr[i, k] < chArr[i, k - 1])
                        {
                            currentSequence += chArr[i, k - 1];
                        }
                        else
                        {
                            break;
                        }
                    }
                    if (currentSequence.Length >= maxCurrentSequence.Length)
                    {
                        if (currentSequence.Length == maxCurrentSequence.Length)
                        {
                            if (currentSequence.CompareTo(maxCurrentSequence) == -1)
                            {
                                maxCurrentSequence = currentSequence;
                            }
                        }
                        else
                        {
                            maxCurrentSequence = currentSequence;
                        }
                    }
                   
                }
                
            }
          
            Console.WriteLine(maxCurrentSequence);
        }
    }
}
