using System;
using System.Collections.Generic;
using System.Text;

namespace CSExcercise.excercises.basic
{
    class ThirdBasicExercise : Exercise
    {
        /**
         * ThirdExercise Constructor.
         **/
        public ThirdBasicExercise(string title) : base(title)
        {
        }

        /**
         * Write a C# Sharp program to print the result of dividing two numbers.
         **/
        public override void DoExercise()
        {
            Console.WriteLine($"5 / 3 = { Divide(5, 3) }");
        }

        /**
         * Divide two integers.
         **/ 
        private double Divide(double x, double y)
        {
            return x / y;
        }
    }
}
