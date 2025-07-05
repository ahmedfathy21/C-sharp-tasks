namespace Bubble_sort;

public class StudentNameComparer :  IComparer<student>

{
    public int Compare(student? x, student? y)
    {
        // x is null   
        //x.name is null
        
        // x < y =< -ve 
        // x == y  == 0
        return x?.name?.CompareTo(y?.name) ?? -1;
    }
}