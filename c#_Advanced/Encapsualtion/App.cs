using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Encapsulation
{
    class app 
    {
        public static void Main()
        {

            Console.WriteLine("Welcome to Encapsulation concept !");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Person[] First = new Person[3];
            First[0] = new Person { name = "Ahmed Fathy", age = 23 };
            First[1] = new Person { name = "Fatma Fathy", age = 21 };
            First[2] = new Person { name = "Salma Fathy", age = 17 };
            for(int i = 0; i < First.Length; i++)
            {
            Console.WriteLine($" {First[i].name} {First[i].age}");
            }



        }
    }
    class Person
    {
        private string _name;
        private int _age;

         public string name {
            get{
                return _name;
            }
            set => _name = value ?? throw new ArgumentNullException();
         }
         public int age {
            get{ return _age; }
            set 
            {
                if (value < 0)
                throw new ArgumentException("Invalid age !!");
                _age = value;
            }
         }

    }
}