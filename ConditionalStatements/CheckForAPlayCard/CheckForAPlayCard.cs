using System;

namespace CheckForAPlayCard
{
    class CheckForAPlayCard
    {
        static void Main()
        {

            bool valid;
            string choice = Console.ReadLine();
            switch(choice)
            {
                case "2":
                    valid = true;
                    break;

                case "3":
                    valid = true;
                    break;

                case "4":
                    valid = true;
                    break;

                case "5":
                    valid = true;
                    break;

                case "6":
                    valid = true;
                    break;

                case "7":
                    valid = true;
                    break;

                case "8":
                    valid = true;
                    break;

                case "9":
                    valid = true;
                    break;

                case "10":
                    valid = true;
                    break;

                case "J":
                    valid = true;
                    break;

                case "Q":
                    valid = true;
                    break;

                case "K":
                    valid = true;
                    break;

                case "A":
                    valid = true;
                    break;
                default:
                    valid = false;
                    break;

            }
            if(valid)
            {
                Console.WriteLine("Yes");

            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
