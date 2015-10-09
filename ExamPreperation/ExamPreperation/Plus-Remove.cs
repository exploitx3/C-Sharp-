using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExamPreperation
{
    internal class Program
    {
        private static void Main()
        {
            List<string> inputs = new List<string>();
            List<string> results = new List<string>();

            while (true)
            {
                string input = Console.ReadLine();
                if (input != "END")
                {
                    inputs.Add(input);
                    results.Add(input);
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < inputs.Count - 2; i++)
            {
                string first = inputs[i];
                string second = inputs[i + 1];
                string third = inputs[i + 2];

                for (int j = 1;j < Math.Min(first.Length, Math.Min(second.Length, third.Length)) && j < second.Length - 1;
                    j++)
                {
                    string up = first.Substring(j, 1).ToLower();
                    string middle = second.Substring(j - 1, 3).ToLower();
                    string down = third.Substring(j, 1).ToLower();
                    if (up == down && middle == new string(up[0], 3))
                    {
                        results[i] = results[i].Remove(j, 1).Insert(j, "G");
                        results[i + 1] = results[i + 1].Remove(j - 1, 3).Insert(j - 1, new string('G', 3));
                        results[i + 2] = results[i + 2].Remove(j, 1).Insert(j, "G");
                    }
                }
            }
            for (int i = 0; i < results.Count; i++)
            {
                results[i] = results[i].Replace("G", "");
                Console.WriteLine(results[i]);
            }

        }
    }
}

