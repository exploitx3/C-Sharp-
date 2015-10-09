using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace String_Matrix_Rotation
{
    class Program
    {
        static void Main()
        {
            List<string> inputs = new List<string>();
            string rotateStr = Console.ReadLine();
            int roatateDegree = int.Parse(Regex.Match(rotateStr, @"[0-9]+").Value)/90;
            string input;
            while((input = Console.ReadLine()) != "END")
            {
                inputs.Add(input);
            }
            int maxLength = int.MinValue;
            for (int i = 0; i < inputs.Count-1; i++)
            {
                int currentMaxLength = Math.Max(inputs[i].Length, inputs[i + 1].Length);
                if (currentMaxLength > maxLength)
                {
                    maxLength = currentMaxLength;
                }
            }
            for (int i = 0; i < inputs.Count; i++)
            {
                while (inputs[i].Length < maxLength)
                {
                    inputs[i] += " ";
                }
            }
            switch (roatateDegree%4)
            {
                case 1:
                    for (int row = 0; row < maxLength; row++)
                    {
                        for (int col = inputs.Count - 1; col >= 0; col--)
                        {
                            Console.Write(inputs[col][row]);
                        }
                        Console.WriteLine();
                    }
                    break;
                case 2:
                    inputs.Reverse();
                    for (int i = 0; i < inputs.Count; i++)
                    {
                        Console.WriteLine(new string(inputs[i].Reverse().ToArray()));
                    }
                    break;
                case 3:
                    for (int row = maxLength-1; row >= 0; row--)
                    {
                        for (int col = 0; col < inputs.Count; col++)
                        {
                            Console.Write(inputs[col][row]);
                        }
                        Console.WriteLine();
                    }
                    break;
                default:
                    for (int i = 0; i < inputs.Count; i++)
                    {
                        Console.WriteLine(inputs[i]);
                    }
                    break;
            }
        }
    }
}
