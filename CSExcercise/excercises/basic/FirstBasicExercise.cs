﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CSExcercise.excercises.basic
{
    class FirstBasicExercise : Exercise
    {

        /**
         * FirstExercise Constructor.
         **/
        public FirstBasicExercise(string title) : base(title)
        {
        }

        /**
         * Write a C# Sharp program to print Hello and your name in a separate line. Go to the editor
         * Expected Output : Hello: Alexandra Abramov
         **/
        public override void DoExercise()
        {

            // My name.
            string myName = "Michael Ibsen";

            Console.WriteLine($"Hello: \n { myName }");

            
        }
    }
}
