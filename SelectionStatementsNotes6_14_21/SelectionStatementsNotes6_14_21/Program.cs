using System;

namespace SelectionStatementsNotes6_14_21
{
    class Program
    {
        public static void GuessingGame(int randomNumber)
        {
            bool rightGuess = false;
            while (rightGuess == false)
            
            Console.WriteLine("Guess a number");
            var guess = int.Parse(Console.ReadLine());
            if(guess > randomNumber)
            {
            Console.WriteLine("Too high.");
            }
            else if(guess < randomNumber)
            {
            Console.WriteLine("Too low.");
            }
            else
            {
            Console.WriteLine($"Congrats! You found {randomNumber}!");
            rightGuess = true;
            }
        }

        static void Main(string[] args)
        {
            var random = new Random();
            bool correctInput;
            int randomNumber;
            Console.WriteLine("Hello! Try to play the guessing game!");
            do
            {
                Console.Clear();
                correctInput = true;
                Console.WriteLine("How hard do you want this game to be? \n" +
                    "Hard \n" +
                    "Medium \n" +
                    "Easy");
                Console.Write(">");
                var difficulty = Console.ReadLine();
                if (difficulty.ToLower() == "hard")
                {
                    randomNumber = random.Next(1, 10000);
                    GuessingGame(randomNumber);
                }
                else if (difficulty.ToLower() == "medium")
                {
                    randomNumber = random.Next(1, 1000);
                    GuessingGame(randomNumber);
                }
                else if (difficulty.ToLower() == "easy")
                {
                    randomNumber = random.Next(1, 100);
                    GuessingGame(randomNumber);
                }
                else
                {
                Console.WriteLine("Input not accepted");
                correctInput = false;
                }
            } while (correctInput == false);

        }
    }
}


namespace Loop17
{
    class MainClass
    {
        public static string UserInput(string question)
        {
            bool correctInput;
            Console.WriteLine(question);

            var input = Console.ReadLine();

            while (input == " " || input == "")
            {
                Console.WriteLine("I'm sorry");
                input = Console.ReadLine();
            }
            while (correctInput == false)
            {
                Console.WriteLine("please try again");
                input = Console.ReadLine();
            }
            return input;
        }

        public static void Main(string[] args)
        {
            UserInput("What is your name?");
            bool playAgain = false;
            do
            {
                playAgain = false;
                Console.WriteLine("Welcome to my game");
                Console.WriteLine("GameRunning");
                Console.WriteLine("Game over. Would you like to play again? \n" +
                    "y/n");
                if (Console.ReadLine() == "y")
                {
                    playAgain = true;
                }
            } while (playAgain == true);

            for(int i = 0; i < 10; i++)
            {
                add += i;
            }
            Console.WriteLine(add);



            {
                Console.WriteLine("What is your favorite color?");
                if(Console.ReadLine().ToLower() == "green")
                {
                    Console.WriteLine("That's right!");
                }
                else
                {
                    Console.WriteLine("Try again");
                }

                string dogOrCat = "cdcdcdcdcdcdcd";
                int dogAmount = 0;
                int catAmount = 0;
                foreach(var animal in dogOrCat)
                {
                    if(animal == 'c')
                    {
                        catAmount++;
                    }
                    else if(animal == 'd')
                    {
                        dogAmount++;
                    }
                }

                Console.WriteLine($"there are {dogAmount} of dogs and {catAmount} of cats");


            }
            public static void(string[] args)
            {
                var ourCandyBag = new string[] { "snickers", "reeses", "milky-way", "candy-corn"};
                foreach(var pieceOfCandy in ourCandyBag)
                {
                if (pieceOfCandy == "candy-corn");
                }
                else
                {
                    Console.WriteLine($"a {pieceOfCandy}! Awesome!");
                }
        }
    }
}