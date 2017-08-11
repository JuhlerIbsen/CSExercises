using System;
using System.Collections.Generic;
using System.Text;

namespace CSExcercise.excercises
{
    class SecondExercise : Exercise
    {

        /**
         * SecondExercise Constructor.
         **/
        public SecondExercise(string title) : base(title)
        {
        }


        /**
         * Write a C# Sharp program to print the sum of two numbers.
         **/
        public override void doExercise()
        {
            Console.WriteLine($"5 + 3 = { sum(5, 3) }");
        }

        /**
         * Returns the sum of two integers.
         **/ 
        private int sum(int x, int y)
        {
            return x + y;
        }
    }
}
