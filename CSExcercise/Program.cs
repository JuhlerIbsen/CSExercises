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
            // 1. on the list for the CS program.
            exercises.Add(new FirstExercise("PrintName"));

            // 2. on the list for the CS program.
            exercises.Add(new SecondExercise("Sum of two integers"));

            // 3. on the list for the CS program.
            exercises.Add(new ThirdExercise("Divide two numbers."));

        }

        /**
         * Run all the initialized exercises.
         **/
        private static void runAllExercises()
        {
            foreach (Exercise excercise in exercises)
            {
                // Run the exercise.
                excercise.runExercise();
            }
        }
    }
}