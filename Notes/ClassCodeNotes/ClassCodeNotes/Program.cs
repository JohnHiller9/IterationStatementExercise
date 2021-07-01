using System;

namespace ClassCodeNotes
{
    class Program
    {
        static void Main(string[] args)
        // What statement (Boolean) ----- 
        {
            bool condition = true;
            if (condition)
            {
                Console.WriteLine("The variable is set to true.");
            }
            else
            {
                Console.WriteLine("The variable is set to false.");
            }


            // Example 1 / Else-If Statement -----
            #region
            Console.WriteLine("Hello, what is your grade");
            var grade = int.Parse(Console.ReadLine());
            if(grade > 95)
            {
                Console.WriteLine("A+");
            }
            if(grade > 90)
            {
                Console.WriteLine("A");
            }
            if(grade = 90)
            {
                Console.WriteLine("A-");
            }
            if(grade > 85)
            {
                Console.WriteLine("B+");
            }
            if(grade > 80)
            {
                Console.WriteLine("B");
            }
            if(grade = 80)
            {
                Console.WriteLine("B-");
            }
            if(grade > 75)
            {
                Console.WriteLine("C+");
            }
            if(grade > 70)
            {
                Console.WriteLine("C");
            }
            if (grade = 70)
            {
                Console.WriteLine("C-");
            }
            if(grade > 65)
            {
                Console.WriteLine("D+");
            }
            if(grade > 60)
            {
                Console.WriteLine("D");
            }
            if(grade = 60)
            {
                Console.WriteLine("D-");
            }
            if(grade > 55)
            {
                Console.WriteLine("F+");
            }
            if(grade > 50)
            {
                Console.WriteLine("F");
            }
            if(grade = 50)
            {
                Console.WriteLine("F-");
            }
            if (grade < 50)
            {
                Console.WriteLine("Fail");
            }
            #endregion


            // Example 2 / Switch Selection Statement -----
            #region
            Console.WriteLine("Opening bag");
            Console.WriteLine("What item do you want from your bag?");
            string item = Console.ReadLine();
            switch (item.ToLower())
            {
                case "food":
                case "apple":
                case "bread":
                case "meat":
                    Console.WriteLine("I see you are hungry.");
                    break;
                case "waepon":
                case "sword":
                case "bow":
                case "spear":
                    Console.WriteLine("Must be enemies near by");
                    break;
                case "book":
                    Console.WriteLine("Must be readin' time.");
                    break;
                default:
                    Console.WriteLine("What is that?");
                    break;
                    #endregion

      
        }
    }
}
// 6,21,21 - Encapsulation Notes -----
static void Main(string[] args)
{
    var playerOne.FindHealth();
    var playerOne.GainLife();

        Console.WriteLine(playerOne.Health);
        playerOne.GainLife();
        Console.WriteLine(playerOne.Health);
}