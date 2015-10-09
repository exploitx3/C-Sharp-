using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IT_Village
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inputBoard = Console.ReadLine().Split(new char[] { '|' }, StringSplitOptions.RemoveEmptyEntries);
            string[] firstLineBoard = inputBoard[0].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] secondLineBoard = inputBoard[1].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] thirdLineBoard = inputBoard[2].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] fourthLineBoard = inputBoard[3].Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] board = new string[4];
            string boardMap = firstLineBoard[0] + firstLineBoard[1] + firstLineBoard[2] + firstLineBoard[3] +
                              secondLineBoard[3] + thirdLineBoard[3] + fourthLineBoard[3] + fourthLineBoard[2] +
                              fourthLineBoard[1] + fourthLineBoard[0] + thirdLineBoard[0] + secondLineBoard[0];
            string[] startPosStr = Console.ReadLine().Split(' ');
            int startPosRow = int.Parse(startPosStr[0]);
            int startPosCol = int.Parse(startPosStr[1]);
            int currentPos = 0;
            if (startPosRow == 1)
            {
                currentPos = startPosCol - 1;
            }
            else
            {
                if (startPosRow == 2)
                {
                    if (startPosCol == 1)
                    {
                        currentPos = 11;
                    }
                    else
                    {
                        currentPos = 4;
                    }
                }
                if (startPosRow == 3)
                {
                    if (startPosCol == 1)
                    {
                        currentPos = 10;

                    }
                    else
                    {
                        currentPos = 5;
                    }
                }
                if (startPosRow == 4)
                {
                    switch (startPosCol)
                    {
                        case 1:
                            currentPos = 9;
                            break;

                        case 2:
                            currentPos = 8;
                            break;

                        case 3:
                            currentPos = 7;
                            break;

                        case 4:
                            currentPos = 6;
                            break;
                    }
                }
            }
            string[] diceStr = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int playerCoins = 50;
            int innsCount = 0;
            int allInnsCount = 0;
            for (int i = 0; i < boardMap.Length; i++)
            {
                if (boardMap[i] == 'I')
                {
                    allInnsCount++;
                }
            }
            List<int> diceNumbers = new List<int>();
            foreach (string str in diceStr)
            {
                diceNumbers.Add(int.Parse(str));
            }
            bool hasEnded = false;
            bool hasWon = false;
            bool hasWonNakov = false;
           
                for (int i = 0; i < diceNumbers.Count; i++)
                {
                   
                        playerCoins += innsCount*20;
                        
                    
                    int diceCount = diceNumbers[i];
                    currentPos += diceCount;
                    currentPos%=12;
                   switch(boardMap[currentPos])
                    {
                       case 'S':
                        i += 2;
                            break;
                       case 'P':
                            playerCoins -= 5;
                            if (playerCoins < 0)
                            {
                                hasEnded = true;
                            }
                           break;
                       case 'F':
                            playerCoins += 20;
                            break;
                       case 'V':
                            playerCoins *= 10;
                            break;
                       case 'N':
                            hasEnded = true;
                            hasWonNakov = true;
                            break;
                       case 'I':
                            if (playerCoins >= 100)
                            {
                                playerCoins -= 100;
                                innsCount++;
                            }
                            else
                            {
                                playerCoins -= 10;
                                if (playerCoins < 0)
                                {
                                    hasEnded = true;
                                }
                            }
                            break;
                    }
                    if (innsCount == allInnsCount)
                    {
                        hasEnded = true;
                        hasWon = true;
                    }
                    if ((hasEnded == true) || (hasWon == true || hasWonNakov == true))
                    {
                        break;
                    }
                    }
            

            if (hasEnded == false && hasWon == false && hasWonNakov == false)
            {
                Console.WriteLine("<p>You lost! No more moves! You have {0} coins!<p>",playerCoins);
            }
            else
            {
                if (hasWonNakov)
                {
                    Console.WriteLine("<p>You won! Nakov's force was with you!<p>",playerCoins);
                }
                else
                {
                    if (hasWon == true && hasWonNakov == false)
                    {
                        Console.WriteLine("<p>You won! You own the village now! You have {0} coins!<p>",playerCoins);
                    }
                    else
                    {
                        Console.WriteLine("<p>You lost! You ran out of money!<p>");
                    }
                }
            }
            

        }
    }
}