using System;

namespace SelectionsStatementExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Try to guess my favorite number.");

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);

            var random = new Random();
            var number = random.Next(1, upperLimit);
            
            var guess = int.Parse(Console.ReadLine());
            //my section
            #region
            
            var reply= Console.ReadLine();

            if (guess > 9)
            {
                Console.WriteLine("Nuh-uh. (HINT: You're too high)");
            }
        
            if (guess < 9)
            {
                Console.WriteLine("Nope. (HINT: You're too low");
            }

            if (guess < 0)
            {
                Console.WriteLine("Eh, nevermind.");
            }

            else
            {
                Console.WriteLine("BINGO!!! How did you know?");
            }

               
            #endregion
        }
    }
}

