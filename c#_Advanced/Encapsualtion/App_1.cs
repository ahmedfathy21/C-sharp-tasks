using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation1
{
    class app 
    {
        public static void Main()
        {
            Console.WriteLine("Welcome to the Encapsulation and Manipulation the data from the user ! ");
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
            Person[] people = new Person[3];
            for(int i = 0; i < people.Length;i++)
            {
                Console.WriteLine($" Enter the info of the {i + 1}");
                Console.WriteLine("Enter the Name :");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the Age :");
        
                int age = Convert.ToInt32(Console.ReadLine());
                people[i] = new Person{Name = name , Age = age};

            }
            Person oldest_person = people[0];
            for (int i = 0;i <people.Length;i++)
            {
                if(oldest_person.Age < people[i].Age)
                {
                    oldest_person = people[i];

                }
            }
            Console.WriteLine($"The oldest person is {oldest_person.Name} and his age is {oldest_person.Age}");



        }
    }
     class Person
    {
        private string _name;
        private int _age;

         public string Name {
            get{
                return _name;
            }
            set => _name = value ?? throw new ArgumentNullException();
         }
         public int Age {
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


