using System;

public class FiveSpecialLetters
{
    public static void Main()
    {
        int start = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        string word;
        int weight;
        int counter = 0;
        for (char c1 = 'a'; c1 <= 'e' ; c1++)
        {
            for (char c2 = 'a'; c2 <= 'e'; c2++)
            {
                for (char c3 = 'a'; c3 <= 'e'; c3++)
                {
                    for (char c4 = 'a'; c4 <= 'e'; c4++)
                    {
                        for (char c5 = 'a'; c5 <= 'e'; c5++)
                        {
                            
                            word = string.Format("{0}{1}{2}{3}{4}",c1,c2,c3,c4,c5);
                            
                            weight = GetWeight(word);
                            if(weight >= start && weight <= end)
                            {
                                
                                if(counter > 0)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write(word);
                                counter++;
                            }
                            
                        }
                    }
                }
            }
        }
        if(counter == 0)
        {
            Console.Write("No");
        }
        Console.WriteLine();
    }
    static int GetWeight(string word)
    {
        bool[] used = new bool[(int)'e' + 1];
        int weight = 0;
        char letter;
        int counter = 1;
        for (int i = 0; i < word.Length; i++)
        {
            letter = word[i];
            if(!used[letter])
            {
                weight += counter * GetWeight(letter);
                counter++;
                used[letter] = true;
            }
        }
        return weight;

    }
    static int GetWeight(char c)
    {
        switch(c)
        {
            case 'a': return 5;
            case 'b': return -12;
            case 'c': return 47;
            case 'd': return 7;
            case 'e': return -32;
        }
        return 0;
    }
}