using System;

namespace QuotesInStrings
{
    class QuotesInStrings
    {
        static void Main()
        {
            string Quote1 = @"The ""use"" of quotations causes difficulties.";
            string Quote2 ="The \"use\" of quotations causes difficulties.";
            Console.WriteLine(Quote1);
            Console.WriteLine(Quote2);
            
        }
    }
}
