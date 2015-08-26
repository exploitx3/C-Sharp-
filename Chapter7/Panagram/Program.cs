using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Panagram
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = Console.ReadLine();
            bool panagram = true;
            char[] alphabet = {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
       
            for (int i = 0; i < alphabet.Length; i++)
            {
                
                    if (!sentence.ToLower().Contains(alphabet[i]))
                    {
                        panagram = false;
                    }
                
            }
            if(panagram)
            {
                Console.WriteLine("pangram");
            }
            else
            {
                Console.WriteLine("not pangram");
            }
        }
    }
}
