﻿using System;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Pigeon joey = new Pigeon();
            Chicken lola = new Chicken();
            Caller call = new Caller();

            call.describe(joey);
            call.describe(lola);
            Console.ReadKey();
        }


    }

    public abstract class Bird
    {
        public abstract void talk();

        public abstract void fly();
    }

    public sealed class Pigeon : Bird
    {
        public override void talk()
        {
            Console.WriteLine("Pigeon Says: Coo! Coo!");
        }

        public override void fly()
        {
            Console.WriteLine("A Pigeon Flies Away");
        }
    }

    public sealed class Chicken : Bird
    {
        public override void talk()
        {
            Console.WriteLine("Chicken Says: Cluck! Cluck!");
        }

        public override void fly()
        {
            Console.WriteLine("I'm A Chicken - I Can't Fly");
        }
    }

    public sealed class Caller
    {
        public void describe(Bird obj)
        {
            obj.talk();
            obj.fly();
        }
    }







    }


    


