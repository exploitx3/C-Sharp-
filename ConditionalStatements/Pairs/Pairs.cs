using System;


namespace Pairs
{
    class Pairs
    {
        static void Main()
        {
            Console.Write("n= ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("numbers= ");
            string[] strNumbers = Console.ReadLine().Split(' ');

            int[] numbers = new int[1000];
            int[] pairs = new int[500];
            for (int i = 0; i < n * 2; i++)
            {
                numbers[i] = int.Parse(strNumbers[i]);
            }
            
            int j = 0;
            for (int i = 0; i < n; i++, j += 2)
            {
                pairs[i] = numbers[j] + numbers[j + 1];

            }
           
            bool equal = false;
            for (int i = 0; i < n-1; i++)
            {
                if (pairs[i] == pairs[i + 1])
                {
                    equal = true;
                }
                else
                {
                    equal = false;
                    break;
                }
            }
            int maxDif = pairs[0]-pairs[1];
            if(n==1)
            {
                if(numbers[0] == numbers[1])
                {
                    Console.WriteLine("Yes, value={0}", pairs[0]);
                }
                else
                {
                    Console.WriteLine("No,maxdiff={0}", Math.Abs(numbers[0]-numbers[1]));
                }
            }else if(!equal)
            {
                for (int i = 2; i < n; i++)
                {
                    if(maxDif >= pairs[i+1]-pairs[i])
                    {
                        maxDif = pairs[i+1] - pairs[i];
                    }
                }
                Console.WriteLine("No,maxdiff={0}",Math.Abs(maxDif));
						 
			}
            else
            {
                Console.WriteLine("Yes, value={0}", pairs[0]);
            }

            



        }
    }
}
    

