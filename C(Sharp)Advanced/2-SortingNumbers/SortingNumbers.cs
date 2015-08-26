using System;


namespace _2_SortingNumbers
{
    class SortingNumbers
    {
        static void Main()
        {
            int nNumbers = int.Parse(Console.ReadLine());
            int[] numbers = new int[nNumbers];
            int temp = 0;
            for (int i = 0; i < nNumbers; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
               
            }
            for (int i = 0; i < nNumbers; i++)
            {
                for (int j = 0; j < nNumbers-1; j++)
                {
                    if (numbers[j] > numbers[j + 1])
                    {
                        temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                    
                }
            }
            for (int i = 0; i < nNumbers; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
