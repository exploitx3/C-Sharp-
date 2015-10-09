using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace Array_Slider
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arrayStr = Console.ReadLine().Split(new []{' '},StringSplitOptions.RemoveEmptyEntries);
            int[] array = new int[arrayStr.Length];
            for (int i = 0; i < arrayStr.Length; i++)
            {
                array[i] = int.Parse(arrayStr[i]);
            }
            string[] command;
            int currentIndex = 0;
            while ((command = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries))[0] != "stop")
            {
                int offset = int.Parse(command[0]);
                char operation = command[1][0];
                int operand = int.Parse(command[2]);
                currentIndex += offset;
                if (currentIndex < 0)
                {
                    currentIndex = array.Length + offset;
                }
                if (currentIndex > array.Length - 1)
                {
                    currentIndex = offset-1;
                }
                switch (operation)
                {
                         case '|':
                        array[currentIndex] = array[currentIndex] | operand;
                        break;
                          case '&':
                        array[currentIndex] = array[currentIndex] & operand;
                        break;
                          case '^':
                        array[currentIndex] = array[currentIndex] ^ operand;
                        break;
                          case '+':
                        array[currentIndex] = array[currentIndex] + operand;
                        break;
                          case '-':
                        array[currentIndex] = array[currentIndex] - operand;
                        break;
                             case '*':
                        array[currentIndex] = array[currentIndex] * operand;
                        break;
                          case '/':
                        array[currentIndex] = array[currentIndex] / operand;
                        break;
                }
            }
            Console.WriteLine("[ " + string.Join(", ",array) + " ]");
        }
    }
}
