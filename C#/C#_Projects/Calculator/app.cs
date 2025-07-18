using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class App 
    {
        public static void Main(){
            Console.WriteLine ("Welcome to the Calculator App");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine ("Enter the first number");
            double num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine ("Enter the operator : +, -, *, /, %");
            string op = Console.ReadLine();
            Console.WriteLine ("Enter the second number");
            double num2 = Convert.ToInt32(Console.ReadLine());
            double result = calculator(num1, num2, op);
            Console.WriteLine("Calculating...");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Console.WriteLine("The result is: " + result);
            Console.WriteLine("Thank you for using the Calculator App !! ");
            
        }
        static double  calculator(double num1, double num2, string op){
            double result = 0;
            switch (op)
            {
                case "+":
                    return result = num1 + num2;
                case "-":lshdfkjhajfhaojhf
                    return result = num1 - num2;
                    case "*":
                    return result = num1 * num2;
                case "/":
                    return result = num1 / num2;
                case "%":
                    return result = num1 % num2;    
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }         
            return result; 
        }
    }


}