using System;


namespace NumberAsWords
{
    class NumberAsWords
    {
        static string Digits(int digit)
        {
            switch (digit)
            {
                case 0:
                    return "Zero";
                case 1:
                    return "One";

                case 2:
                    return "Two";

                case 3:
                    return "Three";

                case 4:
                    return "Four";

                case 5:
                    return "Five";

                case 6:
                    return "Six";
                    
                case 7:
                    return "Seven";

                case 8:
                    return "Eight";

                case 9:
                    return "Nine";
                case 10:
                    return "Ten";
                case 11:
                    return "Eleven";
                case 12:
                    return "Twelve";

                default:
                    return " ";

            }
        }
        static string DigitsLow(int digit)
        {
            switch (digit)
            {
                
                case 1:
                    return "one";

                case 2:
                    return "two";

                case 3:
                    return "three";

                case 4:
                    return "four";

                case 5:
                    return "five";

                case 6:
                    return "six";

                case 7:
                    return "seven";

                case 8:
                    return "eight";

                case 9:
                    return "nine";
                case 10:
                    return "ten";
                case 11:
                    return "eleven";
                case 12:
                    return "twelve";

                default:
                    return " ";

            }
        }
        static string Tens(int digit)
        {
            switch (digit)
            {
                

                case 2:
                    return "Twenty";

                case 3:
                    return "thirty";

                case 4:
                    return "Fourty";

                case 5:
                    return "Fifty";

                case 6:
                    return "Sixty";
                    
                case 7:
                    return "Seventy";

                case 8:
                    return "Eighty";

                case 9:
                    return "Ninety";
            

                default:
                    return " ";

            }
        }
        static string TensLow(int digit)
        {
            switch (digit)
            {


                case 2:
                    return "twenty";

                case 3:
                    return "thirty";

                case 4:
                    return "fourty";

                case 5:
                    return "fifty";

                case 6:
                    return "sixty";

                case 7:
                    return "seventy";

                case 8:
                    return "eighty";

                case 9:
                    return "ninety";


                default:
                    return " ";

            }
        }
        static string Teens(int digit)
        {
            switch (digit)
            {                             
                case 3:
                    return "third";
                    
                case 4:
                    return "Four";
                    
                case 5:
                    return "Fifth";
                    
                case 6:
                    return "Six";
                   
                case 7:
                    return "Seven";
                   
                case 8:
                    return "Eight";
                    
                case 9:
                    return "Nine";
                    
                default:
                    return " ";
                    
            }
        }
        static string TeensLow(int digit)
        {
            switch (digit)
            {
                case 3:
                    return "third";

                case 4:
                    return "four";

                case 5:
                    return "fifth";

                case 6:
                    return "fix";
                   
                case 7:
                    return "seven";

                case 8:
                    return "eight";

                case 9:
                    return "nine";

                default:
                    return " ";

            }
        }
        static void Main()
        {
            string str;
            int number = int.Parse(Console.ReadLine());
            if(number<=12)
            {
                Console.WriteLine(Digits(number));
            }else if(number>12 && number < 20)
            {
                Console.WriteLine(Teens(number%10) + "teen");
            }else if(number >=20 && number <=99)
            {
                Console.WriteLine(Tens((number/10)%10) + " " + DigitsLow(number%10));
            }else if(number >=100 && number <=999)
            {
                Console.Write(Digits((number/100)%10) + " hundred");
                if(number%100 != 0)
                {
                    Console.Write(" and ");
                }
                if(number%100 <= 12)
                {
                    Console.Write(DigitsLow(number%100));
                }else if(number%100 > 12 && number%100 < 20)
                {
                    Console.Write(TeensLow(number%10) + "teen");
                
                }else if(number%100 >=20 && number%100 <= 99)
                {
                    Console.Write(TensLow((((number)/10)%10)) + " " + DigitsLow(number%10));
                }

              
            }
            Console.WriteLine();
        }
    }
}
