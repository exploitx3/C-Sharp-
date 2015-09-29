using System;

namespace _7.Letters_Change_Numbers
{
    
    class LettersChangeNumbers
    {
        static int GetLetterNumber(char ch)
        {
            char letter = char.ToLower(ch);
            return letter - 96;
        }

        static void Main()
        {
            string[] inputStrings = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            double sum = 0;
            for (int i = 0; i < inputStrings.GetLength(0); i++)
            {
                int number = int.Parse(inputStrings[i].Substring(1, inputStrings[i].Length - 2));
                double currentCalculation = 0;

                if (char.IsUpper(inputStrings[i][0]))
                {
                    currentCalculation += (double)number/GetLetterNumber(inputStrings[i][0]);
                }
                else
                {
                    currentCalculation += number*GetLetterNumber(inputStrings[i][0]);
                }

                if (char.IsUpper(inputStrings[i][inputStrings[i].Length - 1]))
                {
                    currentCalculation -= GetLetterNumber(inputStrings[i][inputStrings[i].Length - 1]);
                }
                else
                {
                    currentCalculation += GetLetterNumber(inputStrings[i][inputStrings[i].Length - 1]);
                }
                sum += currentCalculation;
            }
            Console.WriteLine("{0:F2}",sum);
        }
    }
}
