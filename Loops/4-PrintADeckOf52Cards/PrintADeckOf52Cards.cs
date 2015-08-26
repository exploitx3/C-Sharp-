using System;

namespace _4_PrintADeckOf52Cards
{
    class PrintADeckOf52Cards
    {
        static void Main()
        {
            char[] symbol = new char[5];
            string[] cards = new string[14];
            cards[0] = "2";
            cards[1] = "3";
            cards[2] = "4";
            cards[3] = "5";
            cards[4] = "6";
            cards[5] = "7";
            cards[6] = "8";
            cards[7] = "9";
            cards[8] = "10";
            cards[9] = "J";
            cards[10] = "Q";
            cards[11] = "K";
            cards[12] = "A";
           
            symbol[0] = '♣';
            symbol[1] = '♦';
            symbol[2] = '♥';
            symbol[3] = '♠';
            for (int i = 0; i < 13; i++)
			{
			    for (int j = 0; j < 4; j++)
			    {
                    			Console.Write(cards[i] + symbol[j] + " "); 
			    }
                Console.WriteLine();
			}
        }
    }
}
