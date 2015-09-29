using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> myStack = new Stack<int>();
            myStack.Push(5);
            myStack.Push(8);
            myStack.Push(6);
            while (myStack.Count>0)
            {
                Console.WriteLine(myStack.Pop());
            }
            

            //var arr = new[]
            //{
            //    new { Name="Tosho",Age=17},
            //    new { Name="Gosho",Age=18},
            //    new { Name="Pesho",Age=29}
            //};
            //Array.Sort(arr, (a, b) => a.Name.CompareTo(b.Name));
            //List<int> items = new List<int>() { 1, 2, 3, 4, 5 };
            //string itemsString = "1 2 3 4 5 2";
            //int count = itemsString.ToList().Count(p => p == '2');
            
            //itemsString.Split(new string[]{" "},System.StringSplitOptions.RemoveEmptyEntries).ToList().ForEach(c => Console.WriteLine(c));
            //Console.ReadLine().Split(new string[] { " " }, System.StringSplitOptions.RemoveEmptyEntries).ToList().Select(p => int.Parse(p)).OrderBy(p => p).ToList().ForEach(p => Console.WriteLine(p));
            //Console.WriteLine(count);
        }
    }
}
