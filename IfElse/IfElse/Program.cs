using System;

namespace IfElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please Enter A Number: ");
            double num = Convert.ToDouble(Console.ReadLine());

            Console.Write("Thanks. Now Enter A Letter: ");
            char letter = Convert.ToChar(Console.ReadLine());

            if (num >= 6)
            {
                Console.WriteLine("\nNumber Exceeds 5");

                if ( letter == 'C')
                {
                    Console.WriteLine("Letter is 'C'");
                }
            }
            else
            {
                Console.WriteLine("\nNumber Is 5 Or Less");

            }
            Console.ReadKey();
        }
    }
}
