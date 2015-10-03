using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace _8.Full_Directory_Traversal
{
    class Program
    {
        static void DirTraverse(string dirPath)
        {
            DirectoryInfo dirPathInfo = new DirectoryInfo(dirPath);
            foreach (DirectoryInfo dir in dirPathInfo.GetDirectories())
            {

                foreach (FileInfo file in dir.GetFiles())
                {
                    Console.WriteLine(file.Name);
                    
                }
                foreach (FileInfo file in dirPathInfo.GetFiles())
                {
                    Console.WriteLine(file.Name);

                }
                DirTraverse(dir.FullName);
            }

        }
        static void Main(string[] args)
        {
            string strDir = Console.ReadLine();
            DirTraverse(strDir);
        }
    }
}
