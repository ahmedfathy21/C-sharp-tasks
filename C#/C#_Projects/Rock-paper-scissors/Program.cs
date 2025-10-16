// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turn_based_combat
{
    class Program
    {
        static void Main()
        {
            #region Start the game
            Console.WriteLine("Welcome to Rock-paper-scissors game !!");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            #endregion


            #region Defination of the chars
            Charcter player = new Charcter("player1",0,' ');
            Charcter player2 = new Charcter("player2",0,' ');
            #endregion

            #region Start the game
                Display_status(player,player2);  
                while(player.score < 3 && player2.score < 3)
                {

                Start_game_player_1(player);
                Start_game_player_2(player2);

                if (player.choice == player2.choice)
                {
                    Console.WriteLine("It's a tie !!");
                }
                else if (player.choice == 'r' && player2.choice == 's' || player.choice == 'p' && player2.choice == 'r' || player.choice == 's' && player2.choice == 'p')
                {
                    Console.WriteLine("Player 1 wins !!");
                    player.score++;
                    if (check_winner(player,player2))
                    {
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Player 2 wins !!");
                    player2.score++;
                     if (check_winner(player,player2))
                    {
                        break;
                    }
                }
                Display_status(player,player2);                
                }


        #endregion
        }
        static void Display_status(Charcter player ,Charcter player2)
        {
            Console.WriteLine("Status Reloading ....");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine($"player 1 :{player.name} , Score :{player.score} , Choice :{player.choice}");
            Console.WriteLine($"player 2 :{player2.name} , Score :{player2.score} , Choice :{player2.choice}");

        }
        static void Start_game_player_1(Charcter player)
        {
            Console.WriteLine("Please enter 'r' for rock , 'p' for paper , 's' for scissors");
            Console.WriteLine("Player 1 turn !!");
            player.choice = Console.ReadLine()[0];
        }
          static void Start_game_player_2(Charcter player)
        {
            Console.WriteLine("Please enter 'r' for rock , 'p' for paper , 's' for scissors");
            Console.WriteLine("Player 2 turn !!");
            player.choice = Console.ReadLine()[0];
        }
        static bool check_winner(Charcter player ,Charcter player2)
        {
            if (player.score == 3)
            {
                Console.WriteLine("Player 1 wins the game !!");
                return true;
            }
            else if (player2.score == 3)
            {
                Console.WriteLine("Player 2 wins the game !!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    class Charcter
    {
        public string name;
        public int score;
        public char choice;
        public Charcter(string name,int score,char choice)
        {
            this.name = name;
            this.score = score;
            this.choice = choice;
        }


    }
}