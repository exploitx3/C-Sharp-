using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Friend_Bits
{
    class FriendBits
    {
        static void Main(string[] args)
        {
            uint number = uint.Parse(Console.ReadLine());
            List<int> friendsPositions = new List<int>();
            for (int i = 0; i < 32; i++)
            {
                uint currentBit = (number >> i) & 1;
                int friendCounter = 0;
                for (int j = i+1; j < 32; j++)
                {
                   
                    uint checkBit = (number >> j) & 1;
                    if (checkBit == currentBit)
                    {
                        friendCounter++;
                    }
                    else
                    {
                        break;
                    }
                }
                if (friendCounter != 0)
                {
                    for (int j = 0; j <= friendCounter; j++)
                    {
                        friendsPositions.Add(i+j);
                    }
                    i += friendCounter;
                }
            }
            uint friendsNumber = 0u;
            uint aloneNumber = 0u;
            int friendNumberCounter = 0;
            int aloneNumberCounter = 0;
            for (int i = 0; i < 32; i++)
            {
                uint currentBit = (number >> i) & 1;
                if (friendsPositions.Contains(i))
                {
                    friendsNumber |= currentBit << friendNumberCounter;
                    friendNumberCounter++;
                }
                else
                {
                    aloneNumber |= currentBit << aloneNumberCounter;

                }
            }
            Console.WriteLine(friendsNumber);
            Console.WriteLine(aloneNumber);
        }
    }
}
