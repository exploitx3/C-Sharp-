using System;


namespace BitsUp
{
    class BitsUp
    {
        static void Main()
        {
            int n = 0;
            int step = 0;
            
            do
            {
                Console.Write("n= ");
                n = int.Parse(Console.ReadLine());
                Console.Write("step= ");
                step = int.Parse(Console.ReadLine());
            } while (n < 1 || n > 100 || step < 1 || step > 20);
            int[] numbers = new int[n];
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
                for (int bit = 7; bit >= 0; bit--)
                     {
                       if ((count % step == 1 ) || (step == 1 && count > 0))
                        numbers[i] = numbers[i] | (1 << bit);
                       count++;
                      }
                        
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(numbers[i]);
            }
          
			}
        }
    }

