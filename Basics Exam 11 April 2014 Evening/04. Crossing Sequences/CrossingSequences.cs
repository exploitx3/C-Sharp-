using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace _04.Crossing_Sequences
{
    class CrossingSequences
    {
        private const int MAX = 1000000; 
        static void Main(string[] args)
        {
            
            int firstTribNumber = int.Parse(Console.ReadLine());
            int SecondTribNumber = int.Parse(Console.ReadLine());
            int ThirdTribNumber = int.Parse(Console.ReadLine());
            int nextTribNumber =  firstTribNumber + SecondTribNumber + ThirdTribNumber;

            bool[] TribonaciiSequence = new bool[MAX+1];

            TribonaciiSequence[firstTribNumber] = true;
            TribonaciiSequence[SecondTribNumber] = true;
            TribonaciiSequence[ThirdTribNumber] = true;
            while (nextTribNumber <= MAX)
            {
                TribonaciiSequence[nextTribNumber] = true;
                firstTribNumber = SecondTribNumber;
                SecondTribNumber = ThirdTribNumber;
                ThirdTribNumber = nextTribNumber;
                nextTribNumber = firstTribNumber + SecondTribNumber + ThirdTribNumber;
            }
            bool[] spiralArr = new bool[MAX+1];
            int corner = int.Parse(Console.ReadLine());
            int spiralStep = int.Parse(Console.ReadLine());
            int side = 0;
            bool isCornerOdd = true;
            while (corner <= MAX)
            {
                spiralArr[corner] = true;
                if (isCornerOdd)
                {
                    side++;
                }
                corner += side*spiralStep;
                isCornerOdd = !isCornerOdd;
            }
            for (int i = 0; i < MAX+1; i++)
            {
                if (spiralArr[i] && TribonaciiSequence[i])
                {
                    Console.WriteLine(i);
                    return;
                }
            }
            Console.WriteLine("No");


        }
    }
}
