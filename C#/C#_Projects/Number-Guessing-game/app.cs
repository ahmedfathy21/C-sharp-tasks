using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Number_Guessing_game
{
    class App
    {
        public static void Main()
        {
            while(true)
            {
            Console.WriteLine("Welcome to the Number Guessing Game App");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Random random = new Random();
            int Generated_Number = random.Next(1, 101); // generates a random number between 1 and 100
            int attempts = 3;
            int Guessed_Number = 0;
            Console.WriteLine("You have 3 attempts to guess the number between 1 and 100");
            while (attempts > 0)
            {
                Console.WriteLine("Enter your guess: ");
                Guessed_Number = Convert.ToInt32(Console.ReadLine());
                if (Guessed_Number == Generated_Number)
                {
                    Console.WriteLine("Congratulations, you have guessed the number correctly");
                    break;
                }
                else
                {
                    Console.WriteLine("Sorry, you have guessed the number incorrectly");
                    attempts--;
                    Console.WriteLine("You have " + attempts + " attempts left");
                }
            }
            Console.WriteLine("The number was: " + Generated_Number);
            Console.WriteLine("Thank you for playing the Number Guessing Game App !! ");
            Console.WriteLine("Press 'R' to restart the game or any other key to exit");
            if (Console.ReadLine().ToUpper() != "R")
            {
                break;
            }
            Console.Clear();

        }
        }
    }
}
