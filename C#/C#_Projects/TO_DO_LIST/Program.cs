// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TO_DO_LIST
{
    class Application
    {
        static List<string> todoList = new List<string>();

        public static void Main()
        {

            Console.WriteLine("Welcome to the To-Do List Application!");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            while(true)
            {

            Console.WriteLine("========== To do List Application ==========");
            Console.WriteLine("Please select an option:");
            Console.WriteLine("1. View tasks");
            Console.WriteLine("2. Add a task");
            Console.WriteLine("3. Delete a task");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Please enter the number of the option you would like to select:");
            string option = Console.ReadLine();
        switch (option)
        {
            case "1":
                view_tasks();
                        break;
            case "2":
               add_task();
                break;
            case "3":
            remove_task();
                break;
                    case "4":
                        {
                            Environment.Exit(0);
                        }
                break;
            default:
                Console.WriteLine("Invalid option");
                break;
        }

            }

        }
        static void view_tasks()
        {
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            if(todoList.Count == 0)
            {
                Console.WriteLine("You have no tasks to do!");
            }
            else
            {
                Console.WriteLine("Your tasks are:");
                for(int i = 0; i < todoList.Count; i++)
                {
                    Console.WriteLine($" ' ' {todoList[i]}");
                    
                }
            }   
            
        }
        static void add_task()
        {
            Console.WriteLine("Please enter the task you would like to add:");
            string task = Console.ReadLine();
            todoList.Add(task);
            Console.WriteLine("Task added successfully!");
        }
        static void remove_task()
        {
            Console.WriteLine("Please enter the task you would like to remove:");
            string task = Console.ReadLine();
            if(todoList.Contains(task))
            {
                todoList.Remove(task);
                Console.WriteLine("Task removed successfully!");
            }
            else
            {
                Console.WriteLine("Task not found!");
            }
        }
        
        
    }
}