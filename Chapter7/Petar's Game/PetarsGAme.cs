using System;
using System.Numerics;

namespace Petar_s_Game
{
    class PetarsGAme
    {
        static void Main()
        {
            ulong startNum = ulong.Parse(Console.ReadLine());
            ulong endNum = ulong.Parse(Console.ReadLine());
            string strReplace = Console.ReadLine();
            BigInteger sum = 0;
            for (ulong i = startNum; i < endNum; i++)
            {
                if(i%5==0)
                {
                    sum += i;
                }
                else
                {
                    sum = sum + i % 5;
                }
            }
            string str = Convert.ToString(sum);
            string letter;
            if(sum%2==0)
            {
                
                letter = Convert.ToString(str[0]);
                Console.WriteLine(str.Replace(letter, strReplace));    
                
            }
            if(sum%2==1)
            {
                
                letter = Convert.ToString(str[str.Length-1]);
                Console.WriteLine(str.Replace(letter, strReplace));    
            }
            
        }
    }
}
