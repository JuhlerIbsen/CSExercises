using CSExcercise.excercises;
using System;
using System.Collections.Generic;

namespace CSExcercise
{
    class Program
    {

        // List of exercises.
        private static List<Exercise> exercises = new List<Exercise>();

        /**
         * All the magic happens here.
         **/
        static void Main(string[] args)
        {
            // Initialize all the exercises.
            initializeExercises();

            // Run all the initialized exercises.
            runAllExercises();

            // Pause the application.
            Console.ReadLine();
        }

        /**
         * Initialize the exercises, as requested by the teacher.
         **/
        private static void initializeExercises()
        {
            exercises.Add(new FirstExercise("PrintName"));
        }

        /**
         * Run all the initialized exercises.
         **/
        private static void runAllExercises()
        {
            foreach (Exercise excercise in exercises)
            {
                // Run the exercise.
                excercise.doExercise();

                // Indicate end of exercise.
                Console.WriteLine("\n --- END --- \n");
            }
        }
    }
}