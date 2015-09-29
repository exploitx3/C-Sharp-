using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessQueens
{
    class ChessQueens
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int distance = int.Parse(Console.ReadLine());
            distance = distance + 1;
            bool hasFound = false;
            for (char i = 'a'; i < 'a'+n; i++)
            {
                
                for (int j = 1; j <= n; j++)
                {
                    bool leftHorizontal = j - distance >= 1;
                    bool rightHorizontal = j + distance <= n;
                    bool downVertical = i + distance <= 'a' + n-1;
                    bool upVertical = i - distance >= 'a';
                    bool downLeft = i + distance <= 'a' + n - 1 && j - distance >= 1;
                    bool downRight = i + distance <= 'a' + n - 1 && j + distance <= n;
                    bool upLeft = i - distance >= 'a' && j - distance >= 1;
                    bool upRight = i - distance >= 'a' && j + distance <= n;
                    if (upLeft)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", i, j, (char)(i - distance), j - distance);
                        hasFound = true;
                    }

                    if (upVertical)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", i, j, (char)(i - distance), j);
                        hasFound = true;
                    }
                    if (upRight)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", i, j, (char)(i - distance), j + distance);
                        hasFound = true;
                    }

                    if (rightHorizontal)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", i, j, i, j + distance);
                        hasFound = true;
                    }
                    if (leftHorizontal)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", i, j, i, j - distance);
                        hasFound = true;
                    }
                    if (downLeft)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", i, j, (char)(i + distance), j - distance);
                        hasFound = true;
                    }

                    if (downVertical)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", i, j, (char)(i + distance), j);
                        hasFound = true;
                    }
                   
                    if (downRight)
                    {
                        Console.WriteLine("{0}{1} - {2}{3}", i, j, (char)(i + distance), j + distance);
                        hasFound = true;
                    }
                }
            }
            if(!hasFound)
            {
                Console.WriteLine("No valid positions");
            }
        }
    }
}

                   
                   
                   
                   


                    
                   
                   
                  
                   
                  

                   
                    
                   
                  
                    
                   
                  
                    
                   
                   
                   
                   
                  
                   
                  
                  
                  
                   
                   
                   
                   
                   
   