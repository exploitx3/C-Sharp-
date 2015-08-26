using System;


namespace _13_BinaryToDecimalNumber
{
    class BinaryToDecimal
    {
        static void Main()
        {
            string numBin = Console.ReadLine();
            char[] charArr = numBin.ToCharArray();
            long numDecimal = 0;            
            long[] binary = new long[charArr.Length+1];
            for (long i = 0; i < charArr.Length; i++)
            {
                binary[i] = (long)Math.Pow(2, i);
            }
          
            for (long i = 0; i < charArr.Length; i++)
            {
                charArr[i] = (char)(charArr[i] - '0');
            }
            for (long i = 0; i < charArr.Length; i++)
            {

                numDecimal += ((charArr[charArr.Length-1-i]) * binary[i]);
               
            }
            Console.WriteLine(numDecimal);
            
                     
            
            //string numBin = Console.ReadLine();
            //int num = Convert.ToInt32(numBin,2);           
            //Console.WriteLine(num);
        }
    }
}
