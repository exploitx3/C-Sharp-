using System;


namespace _4_MatrixOfPalindromes
{
    class MatrixOfPalindromes
    {
        static void Main()
        {
            string str;
            int rows = int.Parse(Console.ReadLine());
            int columns = int.Parse(Console.ReadLine());
            for (char c1 = 'a'; c1 < 'a'+rows; c1++)
            {
                for (char c2 = c1; c2 < c1+columns; c2++)
                {
                    str = ""+ c1+ "" +c2+ ""+c1+" ";
                    Console.Write(str);
                }
                Console.WriteLine();
            }
        }
    }
}
