using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Swapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numbersArr = new string[4];
            for (int i = 0; i < 4; i++)
            {
                numbersArr[i] = Console.ReadLine();
                long temp = long.Parse(numbersArr[i]);
                numbersArr[i] = Convert.ToString(temp, 2).PadLeft(64, '0');
            }
            string[] command = Console.ReadLine().Split(' ');
            while(command[0]!="End")
            {
                int numPos = int.Parse(command[0]);
                int nybblePos = Math.Abs(int.Parse(command[1])-15);
                string firstNybble = numbersArr[numPos].Substring(nybblePos*4, 4);
                string leftBody = numbersArr[numPos].Substring(0, nybblePos * 4);
                string rightBody = numbersArr[numPos].Substring((nybblePos + 1) * 4, 64 - ((nybblePos + 1) * 4));
                command = Console.ReadLine().Split(' ');
                if (command[0] == "End")
                {
                    break;
                }
                
                    int numPos2 = int.Parse(command[0]);
                    int nybblePos2 = Math.Abs(int.Parse(command[1]) - 15);
                    string secondNybble = numbersArr[numPos2].Substring(nybblePos2 * 4, 4);
                    string leftBody2 = numbersArr[numPos2].Substring(0, nybblePos2 * 4);
                    string rightBody2 = numbersArr[numPos2].Substring((nybblePos2 + 1) * 4, 64 - ((nybblePos2 + 1) * 4));
                    //SWAP

                    if (numPos == numPos2)
                    {
                        if (nybblePos != nybblePos2)
                        {
                            string middleBody = "";

                            if (nybblePos2 < nybblePos)
                            {
                                middleBody = numbersArr[numPos].Substring((nybblePos2 + 1) * 4, (Math.Abs(nybblePos - nybblePos2) - 1) * 4);
                                numbersArr[numPos] = leftBody2 + firstNybble + middleBody + secondNybble + rightBody;
                            }
                            else
                            {
                                middleBody = numbersArr[numPos].Substring((nybblePos + 1) * 4, (Math.Abs(nybblePos - nybblePos2) - 1) * 4);
                                numbersArr[numPos] = leftBody + secondNybble + middleBody + firstNybble + rightBody2;                                
                            }                            
                        }
                    }
                    else
                    {
                        numbersArr[numPos] = leftBody + secondNybble + rightBody;
                        numbersArr[numPos2] = leftBody2 + firstNybble + rightBody2;
                    }
                    command = Console.ReadLine().Split(' ');                
            }
            for (int i = 0; i < 4; i++)
            {                
                Console.WriteLine(Convert.ToUInt64(numbersArr[i],2));
            }
        }
    }
}
