using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Dictionary;

/// <summary>
/// Represents the entry point for the Dictionary application.
/// </summary>
class Program
{
    /// <summary>
    /// Entry point for the program execution.
    /// </summary>
    /// <param name="args">An array of command-line arguments passed to the program.</param>
    static void Main(string[] args)
    {
        Console.WriteLine(FindFirstUnique("leetcode")); // prints 0
        Console.WriteLine(FindFirstUnique("loveleetcode")); // prints 2
        Console.WriteLine(FindFirstUnique("aabb")); // prints -1
    }

    /// <summary>
    /// Finds the index of the first unique character in a given string.
    /// </summary>
    /// <param name="s">The input string to search for the first unique character.</param>
    /// <returns>
    /// Returns the zero-based index of the first unique character in the string.
    /// Returns -1 if there are no unique characters in the string.
    /// </returns>
    static int FindFirstUnique(string s)
    {
        Dictionary<char, int> charCount = new Dictionary<char, int>();
        
        // Count occurrences of each character
        foreach(char c in s)
        {
            if(charCount.ContainsKey(c))
                charCount[c]++;
            else
                charCount[c] = 1;
        }
        
        // Find first character with count 1
        for(int i = 0; i < s.Length; i++)
        {
            if(charCount[s[i]] == 1)
                return i;
        }
        
        return -1;
    }
}

/// <summary>
/// Represents a collection of key/value pairs that are organized based on the key
/// and provide fast retrieval of the value associated with the key.
/// </summary>
/// <typeparam name="TKey">The type of keys in the dictionary.</typeparam>
/// <typeparam name="TValue">The type of values in the dictionary.</typeparam>
public class Dictionary<TKey, TValue>
{
    /// <summary>
    /// An internal dictionary instance used to store key-value pairs
    /// of type <typeparamref name="TKey"/> and <typeparamref name="TValue"/>.
    /// </summary>
    /// <remarks>
    /// This field is private and readonly, ensuring the dictionary cannot be replaced
    /// after initialization, and is utilized internally by the class to perform operations
    /// such as indexing, addition of items, and validation of keys.
    /// </remarks>
    private readonly System.Collections.Generic.Dictionary<TKey, TValue> dictionary = new();

    /// <summary>
    /// Provides indexer behavior to access or modify the value associated with the specified key in the dictionary.
    /// </summary>
    /// <param name="key">The key of the element to get or set in the dictionary.</param>
    /// <returns>
    /// The value associated with the specified key.
    /// If the key does not exist in the dictionary, accessing this property will throw a KeyNotFoundException.
    /// </returns>
    /// <exception cref="KeyNotFoundException">
    /// Thrown when attempting to get a value for a key that does not exist in the dictionary.
    /// </exception>
    /// <remarks>
    /// The indexer allows you to use the syntax <c>dictionary[key]</c> to get or set values.
    /// If the key exists, the value is updated; otherwise, a new key-value pair is added to the dictionary when setting a value.
    /// </remarks>
    public TValue this[TKey key] 
    { 
        get => dictionary[key];
        set => dictionary[key] = value; 
    }

    /// <summary>
    /// Adds the specified key and value to the dictionary.
    /// </summary>
    /// <param name="key">The key of the element to add.</param>
    /// <param name="value">The value of the element to add.</param>
    /// <exception cref="System.ArgumentNullException">Thrown when the key is null.</exception>
    /// <exception cref="System.ArgumentException">Thrown when an element with the same key already exists in the dictionary.</exception>
    public void Add(TKey key, TValue value)
    {
        dictionary.Add(key, value);
    }

    /// <summary>
    /// Determines whether the dictionary contains the specified key.
    /// </summary>
    /// <param name="key">The key to locate in the dictionary.</param>
    /// <returns>True if the dictionary contains an element with the specified key; otherwise, false.</returns>
    public bool ContainsKey(TKey key)
    {
        return dictionary.ContainsKey(key);
    }
}