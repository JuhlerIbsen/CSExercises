﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSExcercise.excercises
{
    class ThirdExercise : Exercise
    {
        /**
         * ThirdExercise Constructor.
         **/
        public ThirdExercise(string title) : base(title)
        {
        }

        /**
         * Write a C# Sharp program to print the result of dividing two numbers.
         **/
        public override void doExercise()
        {
            Console.WriteLine($"5 / 3 = { divide(5, 3) }");
        }

        /**
         * Divide two integers.
         **/ 
        private double divide(double x, double y)
        {
            return x / y;
        }
    }
}