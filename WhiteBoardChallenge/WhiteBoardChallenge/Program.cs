using System;

namespace WhiteBoardChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz();
        }
        public static void FizzBuzz()
        { 
            // Write a short program that prints each number from 1 to 100 on a new line.
            for (int i = 1; i <= 100; i++)
            {
                // For numbers which are multiples of both 3 and 5, print "FizzBuzz" instead of the number.
                if (i % 3 == 0 && 1 % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                // For each multiple of 3, print "Fizz" instead of the number. 
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                // For each multiple of 5, print "Buzz" instead of the number. 
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
