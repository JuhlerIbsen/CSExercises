using CSExcercise.excercises.basic;
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
            // Initialize the basic exercises 1 - 20.
            initializeBasicExercises();

            // Run all the initialized exercises.
            runAllExercises();

            // Show user message on how to stop application.
            Console.WriteLine("Press enter to end the application...");
            
            // Pause the application.
            Console.ReadLine();
        }

        /**
        * http://www.w3resource.com/csharp-exercises/basic/
        * These are some of the exercises I'm told to do by my school.
        * Need to do exercise 1 - 20.
        * 
        **/
        private static void initializeBasicExercises()
        {
            exercises.Add(new FirstBasicExercise("PrintName"));
            exercises.Add(new SecondBasicExercise("Sum of two integers"));
            exercises.Add(new ThirdBasicExercise("Divide two numbers."));
            exercises.Add(new FourthBasicExercise("Different operators."));
            exercises.Add(new FifthBasicExercise("Swap numbers"));
            exercises.Add(new SixthBasicExercise("Multiply three numbers"));
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