using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MyMethodForMenu
{
    internal class Menu
    {
        private static void Main()
        {
            string[] menu = { "New game", "Show controls", "High score", "Exit" };
            int i = 0;

            ConsoleKey keyInfo;

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}", menu[0]);
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("{0}\n{1}\n{2}", menu[1], menu[2], menu[3]);



            while (true)
            {
                keyInfo = Console.ReadKey().Key;
                if (keyInfo == ConsoleKey.UpArrow || keyInfo == ConsoleKey.DownArrow)
                {
                    if (keyInfo == ConsoleKey.UpArrow)
                    {
                        if (i < 0)
                        {
                            i = 3;
                        }
                        else
                        {
                            --i;
                        }

                    }
                    if (keyInfo == ConsoleKey.DownArrow)
                    {
                        if (i > 3)
                        {
                            i = 0;
                        }
                        else
                        {
                            ++i;
                        }
                    }
                    Console.Clear();
                }
                if (keyInfo == ConsoleKey.Enter)
                {
                    switch (i)
                    {
                        case 0:
                            Console.Clear();
                            //Console.WriteLine("NEW GAME");
                            //NewGame();
                            break;

                        case 1:

                            while (keyInfo != ConsoleKey.Backspace)
                            {
                                Console.Clear();
                                Console.WriteLine(ShowControls());
                                keyInfo = Console.ReadKey().Key;
                            }
                            Console.Clear();
                            break;
                        case 2:
                        //HighSore();
                        //break;
                        case 3:
                            Environment.Exit(1);
                            break;

                        default:
                            Console.Clear();
                            break;
                    }

                }
                for (int j = 0; j < menu.Length; j++)
                {

                    if (j == i)
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(menu[i]);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine(menu[j]);
                    }
                }
            }
        }

        static string ShowControls()
        {
            string controls = @"
            While in Main menu controls are:
            Z - start new game
            X - Highscore Table
            C - How to play
            V - Exit game/back button
 
            Press BackSpace to go the previous menu ! ";

            return controls;
        }
    }
}