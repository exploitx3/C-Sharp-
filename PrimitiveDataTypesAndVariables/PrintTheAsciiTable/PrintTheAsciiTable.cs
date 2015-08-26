using System;


namespace PrintTheAsciiTable
{
    class PrintTheAsciiTable
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            int ch = 0;
            for(int i = 0; i<256;i++)
                {
                    char symbol = (char)i;
                    Console.WriteLine(symbol);
                }
        }
    }
}
