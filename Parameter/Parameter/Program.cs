using System;

namespace Parameter
{
    class Program
    {
        static void Main(string[] args)
        {
            double weight;
            string num;

            num = getWeight(out weight);
            Console.WriteLine(num + " lb = " + IbToKg(weight) + " kg");
            kgToLb(ref weight);
            Console.WriteLine(num + " kg = " + weight + " lb");
            Console.ReadKey();
        }

        static string getWeight(out double theWeight)
        {
            theWeight = 10;
            return "Ten";
        }

        static double IbToKg(double pounds = 5)
        {
            return (pounds * 0.45359237);
        }

        static void kgToLb(ref double weight)
        {
            weight = (weight / 0.45359237);
        }
    }
}
