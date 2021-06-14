using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Explicit typing -
            string variableName = "Hello";
            //Inferred typing -
            var varName = "Hello";


            //----------Exercise 1----------
            //Create 2 variables a and b, with a = 17 and b = 4.
            var a = 17;
            var b = 4;
            //Create variables for addition, subtraction, and multiplication.
            var plus = a + b;
            var minus = a - b;
            var times = a * b;
            //Create variable named quotient that stores the division of a and b.
            //Create another variable named remainder that stores the remainder using the % operator.
            var quotient = a / b;
            var remainder = a % b;
            //Write out results using Console.WriteLine.
            Console.WriteLine($"{a} + {b} = {plus}");
            Console.WriteLine($"{a} - {b} = {minus}");
            Console.WriteLine($"{a} * {b} = {times}");
            Console.WriteLine($"{a} / {b} = {quotient} remainder {remainder}");


            //----------Exercise 2----------
            //Create a method named circleArea that will calculate the area of a circle based on its radius.
            var r = 20;
            var pi = Math.PI;
            var circleArea = pi * (r * r);
            Console.WriteLine($"The area of a circle with radius {r} is {circleArea}");
        }
    }
}
