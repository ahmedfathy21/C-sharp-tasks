using System;
using System.Collections;

namespace Generic_Collections;


class Program
{
    static void Main(string[] args)
    {
        #region create the list

        List<int> list = new List<int>();
        
        Console.WriteLine($"capacity = {list.Capacity}  count = {list.Count}");

        #endregion
        #region add elements

        list.Add(12);
        Console.WriteLine($"capacity = {list.Capacity}  count = {list.Count}");
        list.AddRange(new List<int> { 1, 2, 3, 4 });
        Console.WriteLine($"capacity = {list.Capacity}  count = {list.Count}");
        foreach(var item in list)
            Console.Write($"    {item}");
        list.TrimExcess();
        Console.WriteLine($"\ncapacity = {list.Capacity}  count = {list.Count}");

        #endregion

        #region LinkedListCore

        LinkedList<int> linkedlist = new LinkedList<int>();
        linkedlist.AddFirst(12);
        linkedlist.AddLast(13);
        linkedlist.AddBefore(linkedlist.First, 11);
        linkedlist.AddAfter(linkedlist.First, 14);
        foreach(int item in linkedlist)
            Console.Write($"    {item}");
        

        #endregion        
    }
}