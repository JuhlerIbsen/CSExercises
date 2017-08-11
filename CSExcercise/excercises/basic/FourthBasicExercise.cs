using System;
using System.Collections.Generic;
using System.Text;

namespace CSExcercise.excercises.basic
{
    class FourthBasicExercise : Exercise
    {
        /**
         * FourthExercise Constructor.
         **/
        public FourthBasicExercise(string title) : base(title)
        {
        }

        /**
         * Write a C# Sharp program to print the result of the specified operations.
         **/
        public override void doExercise()
        {
            calculate(-1+4*6);
            calculate((35+5)%7);
            calculate(14 + (-4) * 6 / 11);
            calculate(2+15/6*1-7%2);
        }

        /**
         * Print calculation.
         **/
        private void calculate(int math)
        { 
            Console.WriteLine($"Value: { math }");
        }
    }
}
