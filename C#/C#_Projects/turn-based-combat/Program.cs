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
            #region Starting of Defination of the chars 
            Console.WriteLine("Welcome to Turn Based Combat!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.Clear();
        Charcter player = new Charcter("Hero", 100, 10);
        Charcter Monster = new Charcter("Monster", 50, 5);
        #endregion end if the defination


    #region Start the battle !! 
        while(player.IsAlive() && Monster.IsAlive())
        {
            #region Player Attack
            Console.WriteLine("Player Turn !! ");
            System.Threading.Thread.Sleep(500);
            player.take_attack(Monster);
            Display_Status(player,Monster);
            if (!Monster.IsAlive())
            {
                Console.WriteLine($"{Monster.name} has been defeated , You Win !! ");
                break;
            }
            #endregion end player attack

            #region Monster Attack
            Console.WriteLine("Monster Turn !! ");
            System.Threading.Thread.Sleep(500);
            Monster.take_attack(player);
            Display_Status(player,Monster);
            if (!player.IsAlive())
            {
                Console.WriteLine($"{player.name} has been defeated , You Lose !! ");
                break;
            }
            #endregion end Monter attack

#endregion end of the battle !!
        }

        }
        static void Display_Status(Charcter player ,Charcter Monster)
        {
            Console.WriteLine(" Status Reloadig ....");
            System.Threading.Thread.Sleep(500);
            Console.WriteLine("the health of the Hero is : " + player.health);
            Console.WriteLine("the health of the Moster is : " + Monster.health);
        }
    }
    class Charcter 
    {
        public string name; 
        public int health;
        public int attack;
        
        public Charcter(string name , int health , int attack)
        {
            this.name = name;
            this.health = health;
            this.attack = attack;
        }
        public Charcter()
        {
            this.name = "Player";
            this.health = 100;
            this.attack = 10;
            Console.WriteLine("Your name is " + this.name + " and you have " + this.health + " health and " + this.attack + " attack.");
        }
        public void take_attack (Charcter target)
        {
            target.health -= this.attack;
            Console.WriteLine(this.name + " attacked " + target.name + " for " + this.attack + " damage!");
            Console.WriteLine(target.name + " now has " + target.health + " health.");
        }
        public bool IsAlive()
        {
            if (this.health > 0)
       return true;
         else
            return false;
        
        }
        

    }
}
