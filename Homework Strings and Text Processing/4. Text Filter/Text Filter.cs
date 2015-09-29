using System;


namespace _4.Text_Filter
{
    class TextFilter
    {
        static void Main()
        {
            string[] banWords = Console.ReadLine().Split(new [] {", "}, StringSplitOptions.RemoveEmptyEntries);
            string inputText = Console.ReadLine();
            for (int i = 0; i < banWords.GetLength(0); i++)
            {
                inputText = inputText.Replace(banWords[i], new string('*', banWords[i].Length));
            }
            Console.WriteLine(inputText);
        }
    }
}
