using System;


namespace ComparingFloats
{
    class ComparingFloats
    {
        static void Main()
        {
            double b = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double eps = 0.000001;
            bool equal = false;
            if((a-b)<eps)
                {
                    equal = true;

                }
            Console.WriteLine(equal);
        }
    }
}
