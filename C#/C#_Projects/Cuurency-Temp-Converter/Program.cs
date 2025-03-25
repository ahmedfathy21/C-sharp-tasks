// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuurency_Temp_Converter
{
    class Application
    {
         public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Currency and Temperature Converter");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("Press 1 for Currency Converter");
            Console.WriteLine("Press 2 for Temperature Converter");
            Console.WriteLine("Press 3 for Exit");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    CurrencyConverter();
                    break;
                case 2:
                    TemperatureConverter();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }

        }
         static void CurrencyConverter()
         {
                Console.WriteLine("Welcome to Currency Converter");
                System.Threading.Thread.Sleep(1000);
                Console.Clear();
                Console.WriteLine("Press 1 for $ to pound ");
                Console.WriteLine("Press 2 for pound to $");
                Console.WriteLine("Press 3 for Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
    
                switch (choice)
                {
                    case 1:
                        dollar_to_pound();
                        break;
                    case 2:
                        pound_to_dollar();
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
         } 
            static void TemperatureConverter()
            {
                    Console.WriteLine("Welcome to Temperature Converter");
                    System.Threading.Thread.Sleep(1000);
                    Console.Clear();
                    Console.WriteLine("Press 1 for Celsius to Fahrenheit ");
                    Console.WriteLine("Press 2 for Fahrenheit to Celsius");
                    Console.WriteLine("Press 3 for Exit");
                    int choice = Convert.ToInt32(Console.ReadLine());
        
                    switch (choice)
                    {
                        case 1:
                            Celsius_to_Fahrenheit();
                            break;
                        case 2:
                            Fahrenheit_to_Celsius();
                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice");
                            break;
                    }
            }
            static void dollar_to_pound()
            {
                Console.WriteLine("Enter the amount in $");
                double dollar = Convert.ToDouble(Console.ReadLine());
                double pound = dollar * 0.72;
                Console.WriteLine("Amount in pound is: " + pound);
            }
            static void pound_to_dollar()
            {
                Console.WriteLine("Enter the amount in pound");
                double pound = Convert.ToDouble(Console.ReadLine());
                double dollar = pound * 1.39;
                Console.WriteLine("Amount in $ is: " + dollar);
            }
            static void Celsius_to_Fahrenheit()
            {
                Console.WriteLine("Enter the temperature in Celsius");
                double celsius = Convert.ToDouble(Console.ReadLine());
                double fahrenheit = (celsius * 9/5) + 32;
                Console.WriteLine("Temperature in Fahrenheit is: " + fahrenheit);
            }
            static void Fahrenheit_to_Celsius()
            {
                Console.WriteLine("Enter the temperature in Fahrenheit");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                double celsius = (fahrenheit - 32) * 5/9;
                Console.WriteLine("Temperature in Celsius is: " + celsius);
            }
    }


}