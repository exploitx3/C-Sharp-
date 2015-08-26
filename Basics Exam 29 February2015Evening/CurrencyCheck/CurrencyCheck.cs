using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CurrencyCheck
{
    class CurrencyCheck
    {
        static void Main(string[] args)
        {
            uint rublesPay = uint.Parse(Console.ReadLine());
            uint dolarsPay = uint.Parse(Console.ReadLine());
            uint euroPay = uint.Parse(Console.ReadLine());
            uint levaPayB = uint.Parse(Console.ReadLine());
            uint levaPayM = uint.Parse(Console.ReadLine());
            double rublesGame = ((double)rublesPay / 100) * 3.5;
            double dolarsGame = dolarsPay * 1.5;
            double euroGame = euroPay * 1.95;
            double levaGameB = (double)levaPayB / 2;
            double levaGameM = levaPayM;
            Console.WriteLine("{0:F2}",(Math.Min(Math.Min(Math.Min(rublesGame,dolarsGame),Math.Min(euroGame,levaGameB)),levaGameM)));
        }
    }
}
