using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _7_JoinLists
{
    class JoinLists
    {
        static void Main()
        {
            string[] list1 = Console.ReadLine().Split(' ');
            int[] intList1 = new int[list1.Length];
            string[] list2 = Console.ReadLine().Split(' ');
            int[] intList2 = new int[list2.Length];
            for (int i = 0; i < list1.Length; i++)
            {
                intList1[i] = int.Parse(list1[i]);
            }
            for (int i = 0; i < list2.Length; i++)
            {
                intList2[i] = int.Parse(list2[i]);
            }
            List<int> listL1 = new List<int>(intList1);
            List<int> listL2 = new List<int>(intList2);
            listL1.AddRange(listL2);
            listL1.Sort();
            for (int i = 0; i < listL1.Count; i++)
            {
                for (int j = i+1; j < listL1.Count; j++)
			{
			  if(listL1[i] == listL1[j])
              {
                  listL1[i] = 0;
              }
			}
               
            }
            for (int i = 0; i < listL1.Count; i++)
            {
                if (listL1[i] != 0)
                {
                    Console.Write(listL1[i] + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
