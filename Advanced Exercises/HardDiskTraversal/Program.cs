using System;
using System.IO;

namespace HardDiskTraversal
{
    class Program
    {
        static void TraverseDirs(DirectoryInfo dir)
        {
            foreach (DirectoryInfo dInfo in dir.GetDirectories())
            {
                Console.WriteLine("Found Dir: " + dInfo.FullName);
                //TraverseDirs(dInfo);
            }
            foreach (FileInfo fInfo in dir.GetFiles())
            {
                Console.Write("Found a File: " + fInfo.FullName);
                
            }
        }
        static void Main()
        {
            string dirPath = Console.ReadLine();
            TraverseDirs(new DirectoryInfo(dirPath));
            Console.WriteLine();
        }
    }
}
