using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _3_Min_Max_Sum
{
    class _3_Min_Max_Sum
    {
        static void Main()
        {
            List<int> list1 = new List<int>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                list1.Add(int.Parse(Console.ReadLine()));
            }
            int max = list1.Max();
            int min = list1.Min();
            int sum = list1.Sum();
                       
            double count = list1.Count();
            double avrg = sum / count;
            Console.WriteLine("min = " + min);
            Console.WriteLine("max = " + max);
            Console.WriteLine("sum = " + sum);
            Console.WriteLine("avg = {0:F2}",avrg);

        }
    }
}
