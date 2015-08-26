using System;


namespace Basket_Ball
{
    class Program
    {
        static void Main()
        {
            string nameFirst = Console.ReadLine();
            string nameSecond = "";
            if(nameFirst=="Nakov")
            {
                 nameSecond = "Simeon";
            }
            else
            {
                 nameSecond = "Nakov";
            }
            int numRounds = int.Parse(Console.ReadLine())*2;
            int firstScore = 0;
            int secondScore = 0;
            bool isWinnerFirst = false;
            bool isThereAWinner = false;
            double winningRound = 0;
            double roundCounter = 1;
            
            
          
         
            for (int i = 0; i < numRounds; i++)
            {
                
                int points = int.Parse(Console.ReadLine());
                string condition = Console.ReadLine();
                if(i%4==1||i%4==2)
                {
                    if (condition == "success")
                    {
                        if (secondScore + points <= 500)
                        {
                            secondScore += points;
                            if (secondScore == 500)
                            {
                                isWinnerFirst = false;
                                isThereAWinner = true;
                                winningRound = roundCounter;
                                break;
                            }
                        }
                    }
                    
                }
                else
                {
                    if (condition == "success")
                    {
                        if (firstScore + points <= 500)
                        {
                            firstScore += points;
                            if (firstScore == 500)
                            {
                                isWinnerFirst = true;
                                isThereAWinner = true;
                                winningRound = roundCounter;
                                break;
                            }
                        }
                    }
                }
                if(i%2==1)
                {
                    roundCounter++;
                }
            }
            if (isThereAWinner)
            {
                if (isWinnerFirst)
                {
                    Console.WriteLine(nameFirst);
                    Console.WriteLine((int)winningRound);
                    Console.WriteLine(secondScore);
                }
                else
                {

                    Console.WriteLine(nameSecond);
                    Console.WriteLine((int)winningRound);
                    Console.WriteLine(firstScore);
                }
            }
            else
            {
                if (firstScore == secondScore)
                {
                    Console.WriteLine("DRAW");
                    Console.WriteLine(firstScore);
                }
                else
                {
                    if (firstScore > secondScore)
                    {
                        Console.WriteLine(nameFirst);
                        Console.WriteLine(firstScore - secondScore);
                    }
                    else
                    {
                        Console.WriteLine(nameSecond);
                        Console.WriteLine(secondScore - firstScore);
                    }
                }
            }
            
        }
    }
}
