namespace Animals;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Eagle L = new Eagle();
        Animals E =  L;

        if (E is Falcon)
        {
            Console.WriteLine("Falcon");
            
        }
        else
        {
            Console.WriteLine("not falcon");
        }
    }
}

class Animals
{
    void moving()
    {
        Console.WriteLine("Moving Animals");
    }
}

class Eagle : Animals

{
    void flying()
    {
        Console.WriteLine("Flying Animals");
    }


}

class Falcon : Animals
    {
        void Falcon_Flying()
        {
            Console.WriteLine("Flying Fal con");
        }
    }
