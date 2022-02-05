using System;

namespace Overload
{
    class Program
    {
        static void Main(string[] args)
        {
            double num;
            double area;

            Console.Write("Please Enter Dimension In Feet: ");
            num = Convert.ToDouble(Console.ReadLine());

            area = computeArea(num);
            Console.WriteLine("\nCircle:\t\tArea = " + area + " sq.ft.");

            area = computeArea(num, num);
            Console.WriteLine("Square:\t\tArea = " + area + " sq.ft.");
            area = computeArea(num, num, 'T');
            Console.WriteLine("Triangle:\tArea = " + area + " sq.ft.");
            Console.ReadKey();

        }

        static double computeArea(double width)
        {
            double radius = width / 2;
            return ((radius * radius) * 3.142593);
        }

        static double computeArea(double width, double height)
        {
            return (width * height);
        }

        static double computeArea(double width, double height, char letter)
        {
            return ((width / 2) * height);
        }
    }
}
