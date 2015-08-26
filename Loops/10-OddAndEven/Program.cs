using System;


namespace _10_OddAndEven
{
    class Program
    {
        static void Main()
        {
            string[] line = Console.ReadLine().Split(' ');
            int oddProduct = 1;
            int evenProduct = 1;

            int[] nums = new int[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                nums[i] = int.Parse(line[i]);
            }
            for (int i = 0; i < line.Length; i++)
            {
                
                if((i+1)%2==0)
                {
                    evenProduct *= nums[i];
                }
                else
                {
                    oddProduct *= nums[i];
                }
            }
            if(oddProduct == evenProduct)
            {
                Console.WriteLine("yes\nproduct = {0}",oddProduct);
            }
            else
            {
                Console.WriteLine("no\nodd_product = {0}\neven_product = {1}",oddProduct,evenProduct);
            }
        }
    }
}
