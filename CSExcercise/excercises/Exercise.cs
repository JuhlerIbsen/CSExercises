using System;
using System.Collections.Generic;
using System.Text;

namespace CSExcercise
{
    abstract class Exercise
    {
        // I want propertise to start with a capital letter.
        public string Title { get; set; }

        /**
         * Exercise Constructor.
         **/ 
        public Exercise(string title)
        {
            Title = title;
        }

        /**
         * Print out the exercise that the teachers made us do.
         **/
        public void RunExercise()
        {
            // Show title of exercise.
            Console.WriteLine($"--- { Title } --- \n");

            // Do the exercise.
            DoExercise();

            // Show end of exercise.
            Console.WriteLine("\n --- END --- \n");
        }

        /**
         * Whatever in this exercise will be ran.
         **/
        public abstract void DoExercise();
    }
}
