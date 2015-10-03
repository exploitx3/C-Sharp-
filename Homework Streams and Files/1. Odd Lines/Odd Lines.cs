using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _1.Odd_Lines
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader sr = new StreamReader("../../newTextFile.txt"))
            {
                int counter = 1;
                string line = sr.ReadLine();
                while (line != null)
                {
                    
                    if (counter%2 == 1)
                    {
                        Console.WriteLine(line);
                    }
                    counter++;
                    line = sr.ReadLine();

                }
            }

        }
    }
}
