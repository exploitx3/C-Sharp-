using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            
            StringBuilder strBuild = new StringBuilder();

            strBuild.AppendLine("Hello World!");
            string[] myStr = strBuild.ToString().Split(' ');
            Console.WriteLine(myStr[1].StartsWith("W"));
        }
    }
}
