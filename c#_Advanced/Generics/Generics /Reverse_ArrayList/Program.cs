using System;
using System.Collections;

/// <summary>
/// Contains methods for performing operations on collections.
/// </summary>
class Program
{
    /// <summary>
    /// Reverses the order of elements in the given ArrayList.
    /// </summary>
    /// <param name="list">The ArrayList to be reversed.</param>
    public static void ReverseArrayList(ArrayList list)
    {
        int left = 0;
        int right = list.Count - 1;

        while (left < right)
        {
            object temp = list[left];
            list[left] = list[right];
            list[right] = temp;
            
            left++;
            right--;
        }
    }

    /// <summary>
    /// Prints all the elements of the provided ArrayList to the console, separated by spaces.
    /// </summary>
    /// <param name="list">The ArrayList whose elements are to be printed.</param>
    static void PrintArrayList(ArrayList list)
    {
        foreach (var item in list)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    /// <summary>
    /// The entry point of the application where the program execution begins.
    /// </summary>
    /// <param name="args">An array of strings containing command-line arguments.</param>
    static void Main(string[] args)
    {
        // Test with numbers
        ArrayList numbers = new ArrayList { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original Number List:");
        PrintArrayList(numbers);
        
        ReverseArrayList(numbers);
        Console.WriteLine("Reversed Number List:");
        PrintArrayList(numbers);

        // Test with mixed types
        ArrayList mixed = new ArrayList { 1, "hello", 3.14, true, 'A' };
        Console.WriteLine("\nOriginal Mixed List:");
        PrintArrayList(mixed);
        
        ReverseArrayList(mixed);
        Console.WriteLine("Reversed Mixed List:");
        PrintArrayList(mixed);
    }
}