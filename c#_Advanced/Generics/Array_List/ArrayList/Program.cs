using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList;


public class FixedSizeList<T>
{
    public T[] Items { get; }
    public int Count { get; private set; }
    public int Capacity { get; }


    public FixedSizeList(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be greater than zero.");
        
        this.Capacity = capacity;
        Items = new T[capacity];
        Count = 0;
    }

    public void Add(T item)
    {
        if (Count >= Capacity)
            throw new InvalidOperationException("List has reached its maximum capacity.");
        
        Items[Count] = item;
        Count++;
    }

    public T Check_Index(int index)
    {
        if (index < 0 || index >= Count)
            throw new ArgumentOutOfRangeException(nameof(index), "Index is out of range.");

        Console.WriteLine("The index is: " + index + " \n The Value in the index is " +Items[index] );
        
        return Items[index];
    }
}

class Application
{
    static void Main(string[] args)
    {
        var list = new FixedSizeList<int>(3);
        
        list.Add(1);
        list.Add(2);
        list.Add(3);
        
        list.Check_Index(0); // Outputs: 1
        list.Check_Index(1); // Outputs: 2
        list.Check_Index(2); // Outputs: 3
        
    }
}
