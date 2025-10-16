namespace Get_Hash;

class Program
{
    static void Main(string[] args)
    {
        string name = "John";
        string name2 = "John";
        Console.WriteLine(name.Equals(name2));
        Console.WriteLine(name.GetHashCode());
        Console.WriteLine(name2.GetHashCode());

    }
}