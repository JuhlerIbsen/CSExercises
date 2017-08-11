using System;
using System.Collections.Generic;
using System.Text;

namespace CSExcercise
{
    abstract class Exercise
    {

        /**
         * Exercise Constructor.
         **/
        public Exercise(string title)
        {
            // Print title of the exercise.
            Console.WriteLine($"--- { title } --- \n");
        }

        /**
         * Print out the exercise that the teachers made us do.
         **/
        public void runExercise()
        {
            doExercise();
        }

        /**
         * Whatever in this exercise will be ran.
         **/
        public abstract void doExercise();
    }
}
