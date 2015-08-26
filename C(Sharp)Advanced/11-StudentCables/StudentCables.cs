using System;


namespace _11_StudentCables
{
    class StudentCables
    {
        static void Main()
        {
            int numOfCables = 0;
            int[] cables = new int[numOfCables];
            string type = null;
            int sumCables = 0;
            int fiveMeterCables = 0;
            int remainingCables = 0;
            int numCounter = 0;
            

            numOfCables = int.Parse(Console.ReadLine());
            numCounter = numOfCables;
            cables = new int[numOfCables];


            for (int i = 0; i < numOfCables; i++)
            {
                cables[i] = int.Parse(Console.ReadLine());

                type = Console.ReadLine();

                if (type == "meters")
                {
                    cables[i] *= 100;
                }
                else if (type == "centimeters")
                {
                    if (cables[i] < 20)
                    {
                        cables[i] = 0;
                        numCounter--;
                    }
                }


            }

            if (numCounter != 0)
            {
                for (int i = 0; i < numOfCables; i++)
                {
                    sumCables += cables[i];
                }
                fiveMeterCables = (sumCables - 3 * (numCounter - 1)) / 504;
                remainingCables = (sumCables - 3 * (numCounter - 1)) % 504;
                Console.WriteLine(fiveMeterCables);
                Console.WriteLine(remainingCables);
            }



        }
    }
}
