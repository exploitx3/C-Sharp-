using System;
using System.Runtime.ConstrainedExecution;

namespace IterativeNestedLoops
{
    internal class IterativeNestedLoops
    {
        private static int numberOfLoops;
        private static int numberOfIterations;
        private static int[] loops;

        

        private static void Initialize()
        {
            for (int i = 0; i < loops.Length; i++)
            {
                loops[i] = 1;
            }
        }

        private static void Print()
        {
            for (int i = 0; i < loops.Length; i++)
            {
                Console.Write(loops[i]);
            }
            Console.WriteLine();
        }

        private static void NestedLoops()
        {
            while (true)
            {
                Print();
                int currentLoop = numberOfLoops - 1;
                loops[currentLoop]++;
                while (loops[currentLoop] > numberOfIterations)
                {
                    loops[currentLoop] = 1;
                    currentLoop--;
                    if (currentLoop < 0)
                    {
                        return;
                    }
                    loops[currentLoop]++;
                }
            }
        }

        private static void Main()
        {
            Console.Write("Number of loops: ");
            numberOfLoops = int.Parse(Console.ReadLine());
            Console.Write("Number of Iterations: ");
            numberOfIterations = int.Parse(Console.ReadLine());
            loops = new int[numberOfLoops];
            Initialize();
            NestedLoops();
        }
    }
}

