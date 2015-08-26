using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Demo
{
    class Program
    {
        private static bool Remove(int x)
        {
            return (x == 0);
        }
        static void Main(string[] args)
        {
            int[] intArr = new int[5];
            Random generator = new Random();
            List<List<int>> ArrLIst = new List<List<int>>();
            ArrLIst.Add(new List<int>());
            for (int i = 0; i < 5; i++)
            {
                ArrLIst.Add(new List<int>());
                for (int j = 0; j < 5; j++)
                {
                    ArrLIst[i].Add(j);    
                }         
            }
            ArrLIst[0].Add(5);
            Predicate<int> predict = Remove;
            ArrLIst[0].RemoveAll(predict);
            List<int> newList = ArrLIst.Where(l => l > 3).ToList();

            for (int i = 0; i < ArrLIst.Count; i++)
            {
                for (int j = 0; j < ArrLIst[i].Count; j++)
                {
                    Console.Write(ArrLIst[i][j]);
                }
                Console.WriteLine();
            }
        }
    }
}
