using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitLock
{
    class BitLock
    {
        static void Main(string[] args)
        {
            string[] numbers = Console.ReadLine().Split(' ');
            int[] checkedOnes = new int[100];
            for (int i = 0; i < numbers.Length; i++)
            {
                int temp = int.Parse(numbers[i]);
                numbers[i] = Convert.ToString(temp, 2).PadLeft(12, '0');
            }
            StringBuilder[] numbersStr = new StringBuilder[numbers.Length];
            
            for (int i = 0; i < numbers.Length; i++)
            {
                
                    
                    numbersStr[i] = new StringBuilder();
                    numbersStr[i].Append(numbers[i]);
                
            }
            int checkedCounter = 0;
            string[] command = Console.ReadLine().Split(' ');
            while (command[0]!="end")
            {
                if(command[0] == "check")
                {
                   int onesCounter = 0;
                    for (int i = 0; i < 8; i++)
                    {
                        if(numbersStr[i][11-(int.Parse(command[1]))] == '1')
                        {
                            onesCounter++;
                        }
                    }
                    checkedOnes[checkedCounter] = onesCounter;
                    checkedCounter++;
                }
                if (command.Length == 3)
                {

                    if (command[1] == "left")
                    {
                        int move = int.Parse(command[2]) % 12;
                        string temp = numbersStr[int.Parse(command[0])].ToString().Substring(0, move);
                        string body = numbersStr[int.Parse(command[0])].ToString().Substring(move, (int)(numbersStr[int.Parse(command[0])].Length - move));
                        numbersStr[int.Parse(command[0])].Clear();
                        numbersStr[int.Parse(command[0])].Append(body + temp);

                    }
                    if (command[1] == "right")
                    {
                        int move = int.Parse(command[2])%12;
                        string temp = numbersStr[int.Parse(command[0])].ToString().Substring(numbersStr[int.Parse(command[0])].Length - move, move);
                        string body = numbersStr[int.Parse(command[0])].ToString().Substring(0, numbersStr[int.Parse(command[0])].Length - move);
                        numbersStr[int.Parse(command[0])].Clear();
                        numbersStr[int.Parse(command[0])].Append(temp + body);

                    }
                }
                command = Console.ReadLine().Split(' ');
            }
            for (int i = 0; i < checkedCounter; i++)
            {
                Console.WriteLine(checkedOnes[i]);
            }
            for (int i = 0; i < numbersStr.Length; i++)
            {
                string temp = numbersStr[i].ToString();
                
                Console.Write(Convert.ToInt32(temp,2) + " ");
            }
            Console.WriteLine();
        }
    }
}
