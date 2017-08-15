using System;
using System.Collections.Generic;
using System.Text;

namespace CSExcercise.excercises.basic
{
    class SixthBasicExercise : Exercise
    {

        /**
         * SixthBasicExercise Constructor.
         **/
        public SixthBasicExercise(string title) : base(title)
        {
        }

        /**
         * Write a C# Sharp program to print the output of multiplication of three numbers which will be entered by the user.
         **/
        public override void DoExercise()
        {

            Console.WriteLine("Write integer into variable x");
            int x = int.Parse(Console.ReadLine());

            Console.WriteLine("Write integer into variable y");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("Write integer into variable z");
            int z = int.Parse(Console.ReadLine());

            // Multiply them all.
            MultiplyThreeNumbers(x, y, z);
            
        }

        /**
         * 
         **/
        private void MultiplyThreeNumbers(int x, int y, int z)
        {
            Console.WriteLine($"Result: { x } * { y } * {z} = {x * y * z}");
        }
    }
}
