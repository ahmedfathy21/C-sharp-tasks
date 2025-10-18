using System;
namespace Animals;

class Program
{
    static void Main(string[] args)
    {
        Animals names = new Animals()
        {
            [0] = "Lion",
            [1] = "Tiger",
            [2] = "Elephant"
        };
        Console.WriteLine(names[0]);
        Console.WriteLine(names[1]);
        Console.WriteLine(names[2]);    
    }
}


