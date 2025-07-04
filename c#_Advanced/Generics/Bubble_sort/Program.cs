using Is_As;

namespace Bubble_sort;

class Program
{
    static void Main(string[] args)
    {

        student[] students =
            {
                new student("John", 20, "cs"),
                new student("Jane", 23, "phy"),
                new student("Jake", 25, "math"),
                new student("Jill", 18, "cardio"),
                new student("Jake", 28, "cash"),

            };
        Helper<student>.Bouble_sort(students);
        foreach (var student in students)
        {
            Console.WriteLine(student);
        }
    }

    
}