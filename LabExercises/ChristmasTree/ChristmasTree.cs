using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChristmasTree
{
    class ChristmasTree
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int height = 0;
            
            
            height = n+1+((n/2)+2);
            int width = n * 2 + 1;
            int leftLeaf = n - 1;
            int rightLeaf = n + 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if(i==0 && j == n)
                    {
                        Console.Write('^');
                    }else if(i>0 && i<=n && (j>=leftLeaf && j<=rightLeaf))
                    {
                        Console.Write('^');
                    }else if(i>n && i < height-1 && j == n)
                    {
                        Console.Write(' ');
                    }else if(i>n && i < height-1 && ( j == n-1 || j == n+1))
                    {
                        Console.Write('|');
                    }
                    else if (i == height - 1)
                    {
                        Console.Write('-');
                    }
                    else
                    {
                        Console.Write('\'');
                    }
                }
                if(i>0 && i < n/2)
                {
                    leftLeaf--;
                    rightLeaf++;
                }else if(i==n/2)
                {
                    leftLeaf = n - 1;
                    rightLeaf = n + 1;
                }
                if(i>n/2 && i <= n )
                {
                    leftLeaf--;
                    rightLeaf++;
                }
                Console.WriteLine();
            }
        }
    }
}
