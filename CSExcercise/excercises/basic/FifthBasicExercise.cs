using System;

namespace CSExcercise.excercises.basic
{
    class FifthBasicExercise : Exercise
    {
        /**
         * FifthBasicExercise Constructor.
         **/
        public FifthBasicExercise(string title) : base(title)
        {
        }

        /**
         * Write a C# Sharp program to swap two numbers.
         **/
        public override void doExercise()
        {

            // Message to the user.
            Console.WriteLine("Please enter two integers one at a time..");

            // Get user input.
            int userFirstNumber  = int.Parse(Console.ReadLine());
            int userSecondNumber = int.Parse(Console.ReadLine());

            swapNumber(userFirstNumber, userSecondNumber);
            
        }

        /**
         * Swap two integers.
         **/
        private void swapNumber(int x, int y)
        {

            Console.WriteLine($"Numbers to swap: x = { x } AND y = { y }.");

            // Save the first integr.
            int savedNumber = x;

            // Change x to y.
            x = y;

            // Change y to former x.
            y = savedNumber;

            Console.WriteLine($"Swapped: x = { x } AND y = { y }");
            
        }
    }
}
