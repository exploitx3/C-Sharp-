using System;


namespace PlayWith
{
    class PlayWith
    {
        static void Main()
        {
           
            Console.WriteLine("Please choose a type:");
            Console.WriteLine("1 --> int");
            Console.WriteLine("2 --> double");
            Console.WriteLine("3 --> string");
            int choice = int.Parse(Console.ReadLine());
            
            switch(choice)
            {
                case 1:
                    Console.Write("Please enter a integer: ");
                    int intVar = int.Parse(Console.ReadLine());
                    Console.WriteLine(intVar + 1);
                    break;
                case 2:
                    Console.Write("Please enter a double: ");
                     double doubleVar = double.Parse(Console.ReadLine());
                    Console.WriteLine(doubleVar + 1);
                    break;
                case 3:
                    Console.Write("Please enter a string: ");
                     string strVar = Console.ReadLine();
                    Console.WriteLine(strVar + "*");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }
}
