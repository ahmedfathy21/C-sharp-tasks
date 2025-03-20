using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dice_game
{
    class App
    {
        public static void Main()
        {
            while(true)
            {

            Console.WriteLine("Welcome to the Dice Game App");
            System.Threading.Thread.Sleep(1000);
            #region Dice Game
            Console.WriteLine("Press any key to roll the dice");
            Console.ReadKey();
            Console.Clear();
            Random random = new Random();
            int dice1 = random.Next(1, 7); // generates a random number between 1 and 6
            int dice2 = random.Next(1, 7);
            Console.WriteLine("Checking if you got the same number on both dice...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("The first dice is: " + dice1);
            Console.WriteLine("The second dice is: " + dice2);  
            if (dice1 == dice2)
            {
                Console.WriteLine("Congratulations, you have won the game");
            }
            else
            {
                Console.WriteLine("Sorry, you have lost the game");
            }
            Console.WriteLine("Thank you for playing the Dice Game App !! ");
            Console.WriteLine ("Press any key to start again");
            Console.ReadKey();
            Console.Clear();

            #endregion

            }
    
    }
}
}