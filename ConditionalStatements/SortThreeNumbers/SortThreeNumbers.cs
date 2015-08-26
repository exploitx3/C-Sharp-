using System;


namespace SortThreeNumbers
{
    class SortThreeNumbers
    {
        static void Main()
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double c = double.Parse(Console.ReadLine());
            double biggest = 0;
            double middle = b;
            double lowest = 0;


            if (a >= b)
            {
                if (a >= c)
                {
                    biggest = a;
                    if (b <= biggest && b >= c)
                    {
                        middle = b;
                        lowest = c;
                    }
                    else
                    {
                        middle = c;
                        lowest = b;
                    }
                }
            }
            if (b >= c)
            {
                if (b >= a)
                {
                    biggest = b;
                    if (c <= biggest && c >= a)
                    {
                        middle = c;
                        lowest = a;
                    }
                    else
                    {
                        middle = a;
                        lowest = c;
                    }
                }
            } if (c >= a)
            {
                if (c >= b)
                {
                    biggest = c;
                    if (a <= biggest && a >= b)
                    {
                        middle = a;
                        lowest = b;
                    }
                    else
                    {
                        middle = b;
                        lowest = a;
                    }
                }
            }

           
           

            Console.WriteLine(biggest + " " + middle + " " + lowest);
            Console.WriteLine();



        }
    }
}
