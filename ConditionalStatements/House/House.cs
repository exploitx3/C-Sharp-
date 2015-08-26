using System;


namespace House
{
    class House
    {
        static void Main()
        {
            int num;
            do
            {
                num = int.Parse(Console.ReadLine());
                if(num < 5 || num > 49 || num % 2 == 0)
                {
                    Console.WriteLine("N must be an odd number between 5 and 49");
                }
            } while (num < 5 || num > 49 || num % 2 == 0);
           
            int width = num;
            int height = width;
            int roofVal1 = num/2;
            int roofVal2 = num/2;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 && j == num / 2)
                    {
                        Console.Write('*');
                    }
                    else if (i > 0 && j == roofVal1)
                    {
                        Console.Write('*');
                    }
                    else if (i > 0 && j == roofVal2)
                    {
                        Console.Write('*');
                    }else if(i==num/2)
                    {
                        Console.Write('*');
                    }
                    else if(i>num/2 && j==num/4)
                    {
                        Console.Write('*');
                    }else if(i>num/2 && j==(num-(num/4))-1)
                    {
                        Console.Write('*');

                    }else if(i==num-1 && j>=num/4 && j<=(num-(num/4)-1))
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                    
                }
                Console.WriteLine();
                if (i <= num / 2)
                {
                    roofVal1--;
                    roofVal2++;
                }
            }
            Console.WriteLine();
        }
    }
}
