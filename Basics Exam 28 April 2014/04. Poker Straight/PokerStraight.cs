using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Poker_Straight
{
    class PokerStraight
    {
        private static void Main(string[] args)
        {
            int magicWeight = int.Parse(Console.ReadLine());
            int magicWeightCounter = 0;
            for (int i = 1; i < 11; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    for (int k = 1; k <= 4; k++)
                    {
                        for (int l = 1; l <= 4; l++)
                        {
                            for (int m = 1; m <= 4; m++)
                            {
                                for (int n = 1; n <= 4; n++)
                                {
                                    int sumWeight = (10*(i) + j) +
                                                    (20*(i + 1) + k) +
                                                    (30*(i + 2) + l) +
                                                    (40*(i + 3) + m) +
                                                    (50*(i + 4) + n);
                                    if (sumWeight == magicWeight)
                                    {
                                        magicWeightCounter++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            Console.WriteLine(magicWeightCounter);
        }
    }
}
