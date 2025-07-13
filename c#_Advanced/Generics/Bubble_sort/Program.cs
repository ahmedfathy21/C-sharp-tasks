using Is_As;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bubble_sort;

class Program
{
    static void Main(string[] args)
    {

        student[] students =
            {
                new student("Ahmed", 20, "cs"),
                new student("zee", 23, "phy"),
                new student("Fatma", 25, "math"),
                new student("Salma", 18, "cardio"),
                new student("Fathy", 28, "cash"),

            };
        Helper<student>.bubble_sort(students, new StudentNameComparer());
       var result =  Helper<student>.Linear_Search(students ,  new student("Fatma", 25, "math"), EqualityComparer<student>.Default);
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }

        Console.WriteLine($"The index of the student is {result}");
    LinkedList<int> Linkedlist = new LinkedList<int>();
LinkedListNode<int> node = Linkedlist.AddFirst(10);
Linkedlist.AddBefore(node, 20);
Linkedlist.AddAfter(node, 30);
foreach (int item in Linkedlist)
    Console.WriteLine($"{item}  ");
    

    }

    
}



