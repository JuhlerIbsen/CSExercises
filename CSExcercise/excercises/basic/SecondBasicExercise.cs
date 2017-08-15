using System;
using System.Collections.Generic;
using System.Text;

namespace CSExcercise.excercises.basic
{
    class SecondBasicExercise : Exercise
    {

        /**
         * SecondExercise Constructor.
         **/
        public SecondBasicExercise(string title) : base(title)
        {
        }


        /**
         * Write a C# Sharp program to print the sum of two numbers.
         **/
        public override void DoExercise()
        {
            Console.WriteLine($"5 + 3 = { Sum(5, 3) }");
        }

        /**
         * Returns the sum of two integers.
         **/ 
        private int Sum(int x, int y)
        {
            return x + y;
        }
    }
}
