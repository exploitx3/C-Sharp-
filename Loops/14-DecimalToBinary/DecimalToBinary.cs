using System;


namespace _14_DecimalToBinary
{
    class DecimalToBinary
    {
        static void Main()
        {
            long num = long.Parse(Console.ReadLine());
            long ncounter = num;
            string container = "";
            if (ncounter == 0)
            {
                container = "0";
            }
            
            while (ncounter != 0)
            {
                if (ncounter % 2 == 1)
                {
                    container += "1";
                    ncounter = ncounter / 2;
                }else if (ncounter % 2 == 0)
                {
                    container += "0";
                    ncounter = ncounter / 2;
                }
            }
            
            char[] charArr = container.ToCharArray();
            Array.Reverse(charArr);
            string container2 = new string(charArr);
            Console.WriteLine(container2);
        }
    }
}
