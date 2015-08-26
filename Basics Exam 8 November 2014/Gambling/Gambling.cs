using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling
{
    class Gambling
    {
        static int GetCardValue(string letter)
        {
            if (letter == "10")
            {
                return 10;
            }
            else if (letter == "J")
            {
                return 11;
            }
            else if (letter == "Q")
            {
                return 12;
            }
            else if (letter == "K")
            {
                return 13;
            }
            else if (letter == "A")
            {
                return 14;
            }
            if (char.Parse(letter) >= '2' && char.Parse(letter) <= '9')
            {
                return char.Parse(letter) - '0';
            }
            else
            {
                return 0;
            }
        }
        static void Main(string[] args)
        {
            double cash = double.Parse(Console.ReadLine());
            string[] houseHand = Console.ReadLine().Split(' ');
            int houseHandStrength = 0;
            int possibleStrongerHands = 0;           
            for (int i = 0; i < houseHand.Length; i++)
            {
                houseHandStrength += GetCardValue(houseHand[i]);    
            }
            
            
            
            
            for (int i = 2; i < 15; i++)
            {
                for (int j = 2; j < 15; j++)
                {
                    for (int k = 2; k < 15; k++)
                    {
                        for (int l = 2; l < 15; l++)
                        {
                            int tempSum=i+j+k+l;
                            if(tempSum>houseHandStrength)
                            {
                                possibleStrongerHands++;
                            }
                        }
                    }   
                }
            }
            
            double percent = (possibleStrongerHands / 28561.00);
            if (percent*100 >= 50)
            {
                Console.WriteLine("DRAW");
            }
            else
            {
                Console.WriteLine("FOLD");
            }
            Console.WriteLine("{0:F2}",(cash*percent)*2);
            

        }
    }
}
