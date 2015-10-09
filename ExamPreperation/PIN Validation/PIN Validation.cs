using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PIN_Validation
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] checkSumNumbers = { 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            string firstName = "";
            string secondName = "";
            bool hasIncorrectDate = false;
            string[] firstLine = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string gender = Console.ReadLine().ToLower();
            int genderValue = 3;
            if (gender == "male")
            {
                genderValue = 0;
            }
            else
            {
                genderValue = 1;
            }
            string pin = Console.ReadLine();

            if (firstLine.GetLength(0) != 2)
            {
                hasIncorrectDate = true;
            }
            else
            {
                if (!char.IsUpper(firstLine[0][0]) || !char.IsUpper(firstLine[1][0]))
                {
                    hasIncorrectDate = true;

                }
                else
                {


                    if (genderValue == 3)
                    {
                        hasIncorrectDate = true;
                    }
                    else
                    {


                        firstName = firstLine[0];
                        secondName = firstLine[1];



                        if (pin.Length != 10)
                        {
                            hasIncorrectDate = true;
                        }
                        else
                        {
                            int checkSum = int.Parse(pin[9].ToString());
                            int month = int.Parse(pin.Substring(2, 2));
                            if (
                                !(((month > 20 && month <= 32) || (month > 40 && month <= 52)) ||
                                  (month > 0 && month <= 12)))
                            {
                                hasIncorrectDate = true;
                            }
                            else
                            {
                                int day = int.Parse(pin.Substring(4, 2));
                                if (!(day > 0 && day <= 31))
                                {
                                    hasIncorrectDate = true;
                                }
                                else
                                {


                                    if (int.Parse(pin.Substring(6, 3))%2 != genderValue)
                                    {
                                        hasIncorrectDate = true;
                                    }
                                    else
                                    {
                                        for (int i = 0; i < pin.Length - 1; i++)
                                        {
                                            checkSumNumbers[i] = checkSumNumbers[i]*int.Parse(pin[i].ToString());
                                        }
                                        int remainder = checkSumNumbers.Sum()%11;
                                        if (remainder != checkSum)
                                        {
                                            if (!(remainder == 10 && checkSum == 0))
                                            {
                                                hasIncorrectDate = true;
                                            }

                                        }
                                    }
                                }
                            }
                        }

                    }
                }
            }
            if (hasIncorrectDate)
            {
                Console.WriteLine("<h2>Incorrect data</h2>");
            }
            else
            {
                Console.WriteLine(@"{{""name"":""{0}"",""gender"":""{1}"",""pin"":""{2}""}}", firstName+" "+secondName, gender, pin);
            }


        }
    }
}
