using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter A Number: ");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.Write("Now Enter Another Numeber: ");
            double sum = num + Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Total = " + sum);
            Console.ReadKey();
        }
    }
}
