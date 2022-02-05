﻿using System;

namespace Format
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 2500;
            Console.WriteLine("Currentcy String: " + sum.ToString("C"));

            Console.Write(String.Format("\nGeneral:\t {0:G}", sum));
            Console.Write(String.Format("\nFixed Point:\t {0:F}", sum));
            Console.Write(String.Format("\nNumber:\t\t {0:N}", sum));
            Console.Write(String.Format("\nCurrency:\t {0:C}", sum));

            sum /= 1000;
            Console.Write(String.Format("\nPercentage:\t {0:P}", sum));
            Console.Write(String.Format("\nZero Padded:\t {0:00.0000} \n", sum));

            string data = "Mike,McGrath,Author";
            string[] items = data.Split(',');
            foreach (string item in items)
            {
                Console.Write(String.Format("\n* {0}", item));
            }
            Console.ReadKey();
        }
    }
}
