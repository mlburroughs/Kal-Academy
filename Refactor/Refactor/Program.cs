using System;

namespace Refactor
{
    class Program
    {
        static void Main(string[] args)
        {
            computeFactorials(1, 8);
            Console.ReadKey();
        }

        static int factorial(int num)
        {
            int result;
            if( num == 1 )
            {
                result = 1;
            }
            else
            {
                result = (factorial(num - 1) * num);
            }
            return result;
        }

        static void computeFactorials(int num, int max)
        {
            while(num <= max)
            {
                Console.Write("Factorial Of " + num + " : ");
                Console.WriteLine(factorial(num));
                num++;
            }
        }
    }
}
