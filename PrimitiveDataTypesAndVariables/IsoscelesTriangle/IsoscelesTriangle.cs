using System;

namespace IsoscelesTriangle
{
    class IsoscelesTriangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
           
            char ch = '\u00A9';
            Console.WriteLine("   "+ch);
            Console.WriteLine("  " + ch + " " + ch);
            Console.WriteLine(" "+ch + "   " + ch);
            Console.WriteLine(ch+" "+ch+" "+ch+" "+ch);
            
        }
    }
}
