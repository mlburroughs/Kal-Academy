﻿using System;

namespace Parts
{
    class Program
    {
        static void Main(string[] args)
        {
            Sailboat boat = new Sailboat("Laser", "Classic");
            boat.describe();
            Console.ReadKey();
        }

    }
    public partial class Sailboat
    {
        public void describe()
        {
            Console.WriteLine("Sailboat: {0) {1)", make, model);
        }
    }



}
