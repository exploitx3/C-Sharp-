using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Url
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "http://notebook1.ru/forma1/download/file.php?id=";
            StreamWriter writer = new StreamWriter("E:\\Program Files (x86)\\GnuWin32\\bin\\url.txt");
            for (int i = 30000; i < 99999; i++)
            {
                writer.WriteLine(url+i+".pdf");
            }
            writer.Close();
            writer.Dispose();
        }
    }
}
