//6,21,21 ----- Encapsulation Notes -----
#region
using System;
namespace ClassCodeNotes
{
    public class EmptyClass
    {
        public EmptyClass()
        {
        }

        private int health = 10;
        public bool FoundHealth { get; set; };

        public int Health
        {
            get
            {
                return health;
            }
        }

        public void LoseLife()
        {
            health -= 1;
        }
        public void GainLife()
        {
            health += 1;
        }

        public void FindHealth()
        {
            var random = new Random();
            Console.WriteLine("Guess a number from 1-5.");
            if (int.Parse(Console.ReadLine()) == random.Next(5))
            {
                FoundHealth = true;
            }
        }
    }
}
#endregion