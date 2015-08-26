using System;


namespace _13_MagicCarNumbers
{
    class MagicCarNumbers
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());
            int sumResult = 0;
            char[] letters = new char[10];
            letters[0] = 'A';
            letters[1] = 'B';
            letters[2] = 'C';
            letters[3] = 'E';
            letters[4] = 'H';
            letters[5] = 'K';
            letters[6] = 'M';
            letters[7] = 'p';
            letters[8] = 'T';
            letters[9] = 'X';
            int sumOfMagicNumbers = 0;
           
                    for (int i = 0; i <= 9; i++)
                    {
                        for (int j = 0; j <= 9; j++)
                        {
                            for (int k = 0; k <= 9; k++)
                            {
                                for (int p = 0; p <= 9; p++)
                                {
                                    foreach (char ch3 in letters)
                                    {
                                        foreach(char ch4 in letters)
                                        {
                                            sumOfMagicNumbers = 40 + i + j + k + p + Letters(ch3) + Letters(ch4);
                                              if(sumOfMagicNumbers == number) 
                                            {
                                                if ((i == j && j == k && k == p) || (j == k && k == p) || (i == j && j == k) || (i == j && k == p) || (i == k && j == p) || (i == p && j == k))
                                                {
                                                    sumResult++;
                                                }
                                                
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
            Console.WriteLine(sumResult);

                }
            
            
        

        
        static int Letters(char c)
        {
            switch(c)
            {
                case 'A': return 10;
                case 'B': return 20;
                case 'C': return 30;
                case 'E': return 50;
                case 'H': return 80;
                case 'K': return 110;
                case 'M': return 130;
                case 'p': return 160;
                case 'T': return 200;
                case 'X': return 240;
            }
            return 0;
        }
    }
}
