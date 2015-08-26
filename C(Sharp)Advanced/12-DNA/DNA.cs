using System;


namespace _12_DNA
{
    class DNA
    {
        static void Main()
        {
            int height = int.Parse(Console.ReadLine());
            char ch = char.Parse(Console.ReadLine());
            int diff = 0;
            int middle = 3;
            int diffCounter = 0;
                    
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                   if(j <= middle + diff && j >= middle - diff)
                   {
                       Console.Write(ch);
                       if(ch == 'G')
                       {
                           ch = 'A';

                       }
                       else
                       {
                           ch++;
                       }
                   }
                   else
                   {
                       Console.Write('.');
                   }
                    
                }
                Console.WriteLine();
                
                if (diffCounter < 3)
                {
                    diff++;
                }
                else
                {
                    diff--;
                }
                diffCounter++;
                if(diffCounter == 7)
                {
                    diffCounter = 0;
                    diff++;
                }
            }
        }
        
    }

}
