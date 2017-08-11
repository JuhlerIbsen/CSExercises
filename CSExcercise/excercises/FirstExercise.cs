using System;
using System.Collections.Generic;
using System.Text;

namespace CSExcercise.excercises
{
    class FirstExercise : Exercise
    {

        /**
         * FirstExercise Constructor.
         **/
        public FirstExercise(string title) : base(title)
        {
        }

        /**
         * Write a C# Sharp program to print Hello and your name in a separate line. Go to the editor
         * Expected Output : Hello: Alexandra Abramov
         **/
        public override void doExercise()
        {

            // My name.
            string myName = "Michael Ibsen";

            Console.WriteLine($"Hello: { myName }");

            
        }
    }
}
